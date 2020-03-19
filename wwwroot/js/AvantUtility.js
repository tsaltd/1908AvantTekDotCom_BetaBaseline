$(document).ready(function () {
    "use strict";
    $('#DevButton').click(function () {
        $('#collapseExample01').collapse('toggle');
        $('#collapseExample02').collapse('hide');
        $('#collapseExample03').collapse('hide');
    });
    $('#InfoButton').click(function () {
        $('#collapseExample02').collapse('toggle');
        $('#collapseExample01').collapse('hide');
        $('#collapseExample03').collapse('hide');
        
    });
    $('#CloudButton').click(function () {
        $('#collapseExample03').collapse('toggle');
        $('#collapseExample02').collapse('hide');
        $('#collapseExample01').collapse('hide');
    });
}); 
