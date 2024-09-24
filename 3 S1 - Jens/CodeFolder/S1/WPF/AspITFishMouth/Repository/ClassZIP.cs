using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ClassZIP
    {
        public ClassZIP()
        {
            
        }

        public string CompressString(string inString)
        {
            var res = "";

            Encoding enc1252 = Encoding.GetEncoding("Windows-1252");
            byte[] asciiBytes = enc1252.GetBytes(inString);

            using (MemoryStream memoryStream = new MemoryStream())
            {
                using (var gZipStream = new GZipStream(memoryStream, CompressionMode.Compress, true))
                {
                    gZipStream.Write(asciiBytes, 0, asciiBytes.Length);
                }
                memoryStream.Position = 0;

                var compressedData = new byte[memoryStream.Length];
                memoryStream.Read(compressedData, 0, compressedData.Length);

                var gZipBuffer = new byte[compressedData.Length + 4];
                Buffer.BlockCopy(compressedData, 0, gZipBuffer, 4, compressedData.Length);
                Buffer.BlockCopy(BitConverter.GetBytes(asciiBytes.Length), 0, gZipBuffer, 0, 4);
                res = Convert.ToBase64String(gZipBuffer);
            }
            return res;
        }

        public string DecompressString(string inString)
        {
            string res = "";

            byte[] gZipBuffer = Convert.FromBase64String(inString);
            using (var memoryStream = new MemoryStream())
            {
                int dataLength = BitConverter.ToInt32(gZipBuffer, 0);
                memoryStream.Write(gZipBuffer, 4, gZipBuffer.Length - 4);

                var buffer = new byte[dataLength];
                memoryStream.Position = 0;
                using (var gZipStream = new GZipStream(memoryStream, CompressionMode.Decompress))
                {
                    gZipStream.Read(buffer, 0, buffer.Length);
                }
                res = Encoding.UTF7.GetString(buffer);
            }
            return res;
        }
    }
}
