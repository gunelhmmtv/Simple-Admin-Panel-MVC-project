$(document).ready(function () {
    LoadProduct();



});


function LoadProduct() {

    $("#product-datatable").dataTable({
        autoWidth: false,
        pageLength: 5,
        lengthMenu: [[5], [10], [15]],
        ajax: {
            url: "/Adminarea/Product/GetProduct",
            dataSrc: ""
        },
        columns: [
            { data: 'id' },
            { data: 'productName' },
            { data: 'price' },
            { data: 'stockCount' },
            {
                data: null,
                render: function (data, type, row) {
                    console.log(row.id);
                    return '<button id="edit-product"  class="btn btn-outline-success" data-id="'+ row.id + '">Edit</button>';
                }

            },
            {
                data: null,
                render: function (data, type, row) {
                    console.log(row.id);
                    return '<button id="delete-product"  class="btn btn-outline-danger" data-id="' + row.id + '">Delete</button>';
                }

            },

        ]
    })

    $("#product-datatable > tbody").on("click", "button.btn-outline-success", function () {
        
        let id = $(this).data("id");

        window.location.href = `/adminarea/product/addproduct/${id}`
    })

    $("#product-datatable > tbody").on("click", "button.btn-outline-danger", function () {
        let id = $(this).data("id");

        Swal.fire({
            title: "Do you want to remove the product?",
            showDenyButton: true,
            showCancelButton: true,
            confirmButtonText: "Delete",
            denyButtonText: `Don't Delete`
        }).then((result) => {
            if (result.isConfirmed) {
                $.ajax({
                    type: "GET",
                    url: `/Adminarea/Product/RemoveProduct/${id}`,
                    dataType: "json",
                    success: function (response) {
                        window.location.reload();
                    }
                })
            } else if (result.isDenied) {
                Swal.fire("Changes are not saved", "", "info");
            }
        });


    })


}
