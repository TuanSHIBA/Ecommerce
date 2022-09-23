$(document).ready(function () {
    $("#cateId").change(function () {
      //  var cateid = $(this).children(":selected").attr("value");
        var cateid = $("#cateId").val();
        $.ajax({
            url: "/admin/adminproducts/Filter",
            type: "GET",
            datatype: "json",
            data: {
                CateId: cateid
            },
            async:true,
            success: function (result)
            {
                if (result.status == "Success")
                {                
                    window.location.href = result.redirectUrl;
                }
            },
            error: function (xhr) {
                alert('error');
            }
        });
    });

    $("#keyword").keyup(function ()
    {
        var word = $("#keyword").val();
        $.ajax({
            url: "/admin/Search/FindProduct/",
            datatype: "json",
            type:"POST",
            data: { keyword: word },
            async: true,
            success: function (results) {
                if (results.status == "Success") {
                    console.log(results.model);
                }
           
                $("#records_table").html("");
                $("#records_table").html(results);
            },
            error: function (ehr) {
                alert('error');

            }
        });
    })
});
