// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// Handle missing product images by replacing with a default placeholder
function handleMissingProductImage(img) {
    img.onerror = function() {
        this.src = '/uploads/images/default-product.jpg';
        this.onerror = null; // Prevent infinite loop if default image is also missing
    };
    return true;
}

// Apply missing image handler to all product images
document.addEventListener('DOMContentLoaded', function() {
    // Find all images with product image class or in product containers
    const productImages = document.querySelectorAll('img[src^="/uploads/images/"]');
    productImages.forEach(img => {
        handleMissingProductImage(img);
    });
});
