// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.


$(document).ready(function () {
    $('.category_item').click(function () {
        var category = $(this).attr('id');


        if (category == 'all') {
            $('.art_item').css('display', 'none');
            setTimeout(function () {
                $('.art_item').css('display', '');
            }, 300);

        } else {
            $('.art_item').css('display', 'none');
            setTimeout(function () {
                $('.' + category).css('display', '');
            }, 300);

        }
    });


});




