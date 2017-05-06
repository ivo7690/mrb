$('#formContact').validate();
$('#formContactPage').validate();
$('#formQuote').validate();

 $('#galleryPreview').cycle({
        fx: 'fade',
        timeout: 5000,
        speed: 2000,
        height: 'auto',
        containerResize: 1,
        slideResize: 1,
        fit: 0,
    });

//Active menu
var currentPage = window.location.pathname;
$('#main-menu .navbar-nav li a').each(function () {
    if ($(this).attr("href") == currentPage) {
        $(this).parent('li').addClass("active");
        if ($(this).parent().parent().parent().hasClass("dropdown"))
            $(this).parent().parent().parent().addClass("active");
    }

});

//$(window).load(function () {
//    $('#overlayLoad').fadeOut();

//});

//$('body').on({
//    'mousewheel': function (e) {
//        if (e.target.id == 'overlayLoad') {
//            e.preventDefault();
//            e.stopPropagation();
//        }
//    }
//});

$(document).ready(function () {
    $('.item-slide.activeSlide').css('transform', 'scale(1)');
    if (navigator.userAgent.match(/iPhone/i)) {
        $('.item-slide').each(function () {            
            $(this).css('backgroundSize', 'auto 480px');
            $(this).css('background-position-y', 'top');
        });
        $('.parallax').css('backgroundSize', 'auto 600px');
    }
});