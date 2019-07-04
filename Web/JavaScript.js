
$(document).ready(function (){

    $(".producto sombraBox").on("click", ".producto", function () {


        $(this).addClass("added").find(".far").removeClass("fa-plus-square").addClass("fa-check-square");
        if (timeoutHandle) {
            clearTimeout(timeoutHandle);
        }
    };      

    });