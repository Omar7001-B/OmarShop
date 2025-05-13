// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// Handle missing product images by replacing with a default placeholder
function handleMissingProductImage(img) {
    img.onerror = function() {
        this.src = '/images/no-product-image.png';
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

// Toast notification helper function
function showToast(type, title, message) {
    // Create toast element
    const toast = $('<div class="toast" role="alert" aria-live="assertive" aria-atomic="true" data-bs-delay="4000">');
    
    // Create header based on type
    const headerClass = type === 'success' ? 'bg-success' : type === 'error' ? 'bg-danger' : 'bg-primary';
    const header = $('<div class="toast-header ' + headerClass + ' text-white">');
    header.append('<strong class="me-auto">' + title + '</strong>');
    header.append('<button type="button" class="btn-close btn-close-white" data-bs-dismiss="toast" aria-label="Close"></button>');
    
    // Create body
    const body = $('<div class="toast-body">').html(message);
    
    // Assemble toast
    toast.append(header).append(body);
    
    // Add to container
    $('#toastContainer').append(toast);
    
    // Initialize and show
    const bsToast = new bootstrap.Toast(toast.get(0));
    bsToast.show();
    
    // Remove from DOM when hidden
    toast.on('hidden.bs.toast', function() {
        $(this).remove();
    });
    
    return toast;
}
