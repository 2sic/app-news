$(function() {
    $(".app-news-categories").click(function(e) {
        e.stopPropagation();
    });
    $(".app-news-item .btn.btn-primary").click(function(e) {
        e.stopPropagation();
    });
});