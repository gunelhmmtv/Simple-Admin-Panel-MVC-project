$(document).ready(function () {
    $("#add-product-button").click(AddNewProduct)
    LoadProduct();
})
function AddNewProduct() {
    var productName = $("#product-name").val();
    var price = $("#product-price").val();
    var stockCount = $("#stock-count").val();
    var Id = $("#product-id").val();

    const product = {
        id: Id,
        productName: productName,
        price: price,
        stockCount: stockCount
    };

    $.ajax({
        async: true,
        type: "POST",
        url: "/Adminarea/Product/AddProduct",
        dataType: "JSON",
        contentType: "application/json; charset=utf-8",
        data: JSON.stringify(product),
        success: function (response) {
            console.log(response);
            Swal.fire({
                position: "center",
                icon: "success",
                title: response.message,
                showConfirmButton: false,
                timer: 1500
            });
            window.location.href = "/adminarea/product/product";
        },
    });
}

