document.addEventListener('DOMContentLoaded', () => {
  // Used to change images in the gallerySection based on the button pressed
  const galleryImages = document.querySelectorAll('.gallery-image img.size-large');
  const buttons = document.querySelectorAll('.gallery-btn');

  // Arrays of src images for each button
  const galleriesSrc  = [
        [ // 'All images' button - 1,2,3,4,5,6,7,8,9
            'wp-content/uploads/sites/5/01-small.jpg',
            'wp-content/uploads/sites/5/02-small.jpg',
            'wp-content/uploads/sites/5/03-small.jpg',
            'wp-content/uploads/sites/5/04-small.jpg',
            'wp-content/uploads/sites/5/05-small.jpg',
            'wp-content/uploads/sites/5/06-small.jpg',
            'wp-content/uploads/sites/5/07-small.jpg',
            'wp-content/uploads/sites/5/08-small.jpg',
            'wp-content/uploads/sites/5/09-small.jpg'
        ],
        [ // 'Lawn care' button - 1,2,4,6,8,9,10,11,12
            'wp-content/uploads/sites/5/01-small.jpg',
            'wp-content/uploads/sites/5/02-small.jpg',
            'wp-content/uploads/sites/5/04-small.jpg',
            'wp-content/uploads/sites/5/06-small.jpg',
            'wp-content/uploads/sites/5/08-small.jpg',
            'wp-content/uploads/sites/5/09-small.jpg',
            'wp-content/uploads/sites/5/10-small.jpg',
            'wp-content/uploads/sites/5/11-small.jpg',
            'wp-content/uploads/sites/5/12-small.jpg'
        ],
        [ // 'landscape gardener' button - 1,2,3,5,6,7,9,10,11
            'wp-content/uploads/sites/5/01-small.jpg',
            'wp-content/uploads/sites/5/02-small.jpg',
            'wp-content/uploads/sites/5/03-small.jpg',
            'wp-content/uploads/sites/5/05-small.jpg',
            'wp-content/uploads/sites/5/06-small.jpg',
            'wp-content/uploads/sites/5/07-small.jpg',
            'wp-content/uploads/sites/5/09-small.jpg',
            'wp-content/uploads/sites/5/10-small.jpg',
            'wp-content/uploads/sites/5/11-small.jpg'
        ],
        [ // 'Planting' button - 1,2,3,5,6,7,8,9,11
            'wp-content/uploads/sites/5/01-small.jpg',
            'wp-content/uploads/sites/5/02-small.jpg',
            'wp-content/uploads/sites/5/03-small.jpg',
            'wp-content/uploads/sites/5/05-small.jpg',
            'wp-content/uploads/sites/5/06-small.jpg',
            'wp-content/uploads/sites/5/07-small.jpg',
            'wp-content/uploads/sites/5/08-small.jpg',
            'wp-content/uploads/sites/5/09-small.jpg',
            'wp-content/uploads/sites/5/11-small.jpg'
        ]
    ];

    // Arrays of srcset images for each button
    const galleriesSrcset = [
        [ // 'All images' button - 1,2,3,4,5,6,7,8,9
            'wp-content/uploads/sites/5/01-small.jpg 500w, wp-content/uploads/sites/5/01-small-300x200.jpg 300w',
            'wp-content/uploads/sites/5/02-small.jpg 500w, wp-content/uploads/sites/5/02-small-300x200.jpg 300w',
            'wp-content/uploads/sites/5/03-small.jpg 500w, wp-content/uploads/sites/5/03-small-300x200.jpg 300w',
            'wp-content/uploads/sites/5/04-small.jpg 500w, wp-content/uploads/sites/5/04-small-300x200.jpg 300w',
            'wp-content/uploads/sites/5/05-small.jpg 500w, wp-content/uploads/sites/5/05-small-300x200.jpg 300w',
            'wp-content/uploads/sites/5/06-small.jpg 500w, wp-content/uploads/sites/5/06-small-300x200.jpg 300w',
            'wp-content/uploads/sites/5/07-small.jpg 500w, wp-content/uploads/sites/5/07-small-300x200.jpg 300w',
            'wp-content/uploads/sites/5/08-small.jpg 500w, wp-content/uploads/sites/5/08-small-300x200.jpg 300w',
            'wp-content/uploads/sites/5/09-small.jpg 500w, wp-content/uploads/sites/5/09-small-300x200.jpg 300w'
        ],
        [ // 'Lawn care' button - 1,2,4,6,8,9,10,11,12
            'wp-content/uploads/sites/5/01-small.jpg 500w, wp-content/uploads/sites/5/01-small-300x200.jpg 300w',
            'wp-content/uploads/sites/5/02-small.jpg 500w, wp-content/uploads/sites/5/02-small-300x200.jpg 300w',
            'wp-content/uploads/sites/5/04-small.jpg 500w, wp-content/uploads/sites/5/04-small-300x200.jpg 300w',
            'wp-content/uploads/sites/5/06-small.jpg 500w, wp-content/uploads/sites/5/06-small-300x200.jpg 300w',
            'wp-content/uploads/sites/5/08-small.jpg 500w, wp-content/uploads/sites/5/08-small-300x200.jpg 300w',
            'wp-content/uploads/sites/5/09-small.jpg 500w, wp-content/uploads/sites/5/09-small-300x200.jpg 300w',
            'wp-content/uploads/sites/5/10-small.jpg 500w, wp-content/uploads/sites/5/10-small-300x200.jpg 300w',
            'wp-content/uploads/sites/5/11-small.jpg 500w, wp-content/uploads/sites/5/11-small-300x200.jpg 300w',
            'wp-content/uploads/sites/5/12-small.jpg 500w, wp-content/uploads/sites/5/12-small-300x200.jpg 300w'
        ],
        [ // 'landscape gardener' button - 1,2,3,5,6,7,9,10,11
            'wp-content/uploads/sites/5/01-small.jpg 500w, wp-content/uploads/sites/5/01-small-300x200.jpg 300w',
            'wp-content/uploads/sites/5/02-small.jpg 500w, wp-content/uploads/sites/5/02-small-300x200.jpg 300w',
            'wp-content/uploads/sites/5/03-small.jpg 500w, wp-content/uploads/sites/5/03-small-300x200.jpg 300w',
            'wp-content/uploads/sites/5/05-small.jpg 500w, wp-content/uploads/sites/5/05-small-300x200.jpg 300w',
            'wp-content/uploads/sites/5/06-small.jpg 500w, wp-content/uploads/sites/5/06-small-300x200.jpg 300w',
            'wp-content/uploads/sites/5/07-small.jpg 500w, wp-content/uploads/sites/5/07-small-300x200.jpg 300w',
            'wp-content/uploads/sites/5/09-small.jpg 500w, wp-content/uploads/sites/5/09-small-300x200.jpg 300w',
            'wp-content/uploads/sites/5/10-small.jpg 500w, wp-content/uploads/sites/5/10-small-300x200.jpg 300w',
            'wp-content/uploads/sites/5/11-small.jpg 500w, wp-content/uploads/sites/5/11-small-300x200.jpg 300w'
        ],
        [ // 'Planting' button - 1,2,3,5,6,7,8,9,11
            'wp-content/uploads/sites/5/01-small.jpg 500w, wp-content/uploads/sites/5/01-small-300x200.jpg 300w',
            'wp-content/uploads/sites/5/02-small.jpg 500w, wp-content/uploads/sites/5/02-small-300x200.jpg 300w',
            'wp-content/uploads/sites/5/03-small.jpg 500w, wp-content/uploads/sites/5/03-small-300x200.jpg 300w',
            'wp-content/uploads/sites/5/05-small.jpg 500w, wp-content/uploads/sites/5/05-small-300x200.jpg 300w',
            'wp-content/uploads/sites/5/06-small.jpg 500w, wp-content/uploads/sites/5/06-small-300x200.jpg 300w',
            'wp-content/uploads/sites/5/07-small.jpg 500w, wp-content/uploads/sites/5/07-small-300x200.jpg 300w',
            'wp-content/uploads/sites/5/08-small.jpg 500w, wp-content/uploads/sites/5/08-small-300x200.jpg 300w',
            'wp-content/uploads/sites/5/09-small.jpg 500w, wp-content/uploads/sites/5/09-small-300x200.jpg 300w',
            'wp-content/uploads/sites/5/11-small.jpg 500w, wp-content/uploads/sites/5/11-small-300x200.jpg 300w'
        ]
    ];

  // Function to update the gallery images
  const updateGallery = (index) => {
    //console.log(`updateGallery Index: ${index}`);
    galleryImages.forEach((img, i) => {
        if (galleriesSrc[index][i] && galleriesSrcset[index][i]) { // Ensure both src and srcset are available
            img.src = galleriesSrc[index][i];
            img.srcset = galleriesSrcset[index][i];
            //console.log(`src: ${img.src}, srcset: ${img.srcset}`);
        } else {
            console.warn(`No image or srcset available for index ${i} in gallery ${index}`);
        }
    });
 };

  // Event listener for buttons
  buttons.forEach((button, index) => {
    button.addEventListener('click', () => {
        // Remove galleryActive class from all buttons
        buttons.forEach(btn => btn.classList.remove('galleryActive'));
        // Add galleryActive class to clicked button
        button.classList.add('galleryActive');
        //console.log(`Gallery:`, galleryImages);
        // Update the gallery
        updateGallery(index);
    });
 });

  // Initialize the first gallery
  updateGallery(0);
});