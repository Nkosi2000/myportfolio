$(document).ready(function () {
    $('.navbar-toggler').on('click', function () {
        $(this).toggleClass('collapsed');
        $('.navbar-collapse').toggleClass('show');
    });

    $('.navbar-close').on('click', function () {
        $('.navbar-toggler').addClass('collapsed');
        $('.navbar-collapse').removeClass('show');
    });
});
