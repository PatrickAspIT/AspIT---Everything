using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIZ
{
    public class ClassBIZ
    {

        ClassBox ReposBox;
        ClassMaterial ReposMaterial;

        public ClassBIZ() 
        { 
            ReposBox = new ClassBox();
            ReposMaterial = new ClassMaterial();
        }
    }
}
