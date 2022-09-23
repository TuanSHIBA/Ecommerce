$(document).ready(function () {
    $("#register").click(function () {
        let check = true;
        var newpass = $("#newPassword").val();
        var confirmpass = $("#ConfirmPassword").val();
        var currentPassword = $("#currentPassword").val();
        if (currentPassword == newpass)
        {
            $("#errorCurrentPassword").text("Mật Khẩu Mới Trùng Với Mật Khẩu Hiện Tại");
            check = false;
        }
        if (newpass != confirmpass)
        {
            $("#error").text("Mật Khẩu Mới Và Mật khẩu Nhập Lại Không Khớp");
            check = false;
        }    
        if (check)
        {
            $.ajax({
                url: "/account/changepassword",
                type: "POST",
                datatype: "json",
                data: {
                    PasswordNow: $("#currentPassword").val(),
                    Password: $("#newPassword").val(),
                    ConfirmPassword: $("#ConfirmPassword").val()
                },
                async: true,
                success: function (result) {
                    if (result.status == "Success") {
                        alert("Đổi Mật Khẩu Thành Công");
                        window.location.reload();
                    }
                },
                error: function (xhr) {
                    $("#errorpassword").text("Mật Khẩu Hiện Tại Không Đúng");
                    alert("Mật Khẩu Hiện Tại Không Đúng");
                }
            });
        }

    }
    );

}
)