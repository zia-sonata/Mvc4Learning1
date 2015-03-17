$(function () {

    $("#btnOrder").click(function () {

        var txt = "";

        $("input:checkbox:checked").each(function () {

            txt = txt + $(this).val() + " ";

        });
        $("#order").val("You ordered a coffee with: " + txt);

    });

    $(".btn-minimize").click(function () {
        $(".slide").slideToggle();
    });
});


