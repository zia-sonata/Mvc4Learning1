$(document).ready(function () {
    $('#adduser').click(function (e) {
        e.preventDefault();
        if ($("#addNewUserForm").valid()) { //if you use validation
            //reset unobtrusive validation summary, if it exists
            $("#addNewUserForm").find("[data-valmsg-summary=true]")
                         .removeClass("validation-summary-errors")
                          .addClass("validation-summary-valid")
                             .find("ul").empty();
            $.ajax({
                url: $("#addNewUserForm").attr('action'),
                type: $("#addNewUserForm").attr('method'),
                data: $("#addNewUserForm").serialize(),
                success: function (data) {
                    alert(data.Status);
                }
            });
        }
    });
});