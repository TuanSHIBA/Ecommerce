$(document).ready(function () {
    $(function () {
        function loadHeaderCart() {
            $('#miniCart').load("/AjaxContent/HeaderCart");
            $('#numberCart').load("/AjaxContent/NumberCart");
        }

        $(".add-to-cart").click(function () {
            var productid = $("#ProductID").val();
            var soluong = $("#txtsoLuong").val();
            $.ajax({
                url: "/api/cart/add",
                type: "POST",
                datatype: "json",
                async: true,
                data: {
                    productID: productid,
                    amount: soluong
                },
                success: function (response) {                
                    loadHeaderCart();
                    window.location.reload();
         
                },
                error: function (error) {
                    alert("There was an error");
                }
            });
        })
    })   
});
