/// <reference path="../jquery-3.1.1.js" />
$(document).ready(function () {
    var initialGrandTotal;

    $("#BillingPostalCode").blur(function () {
        var subtotal = $("#subtotal>span").text().substr(1);
        var zipcode = $("#BillingPostalCode").val();
        var obj = { "billingZipCode": zipcode, "subtotal": subtotal };
        $.ajax({
            type: "GET",
            url: "/API/GetTax",
            data: obj,
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (response) {

                var taxString = $("#tax>span").text();                
                var taxCost = parseFloat(taxString.substr(1));
                $("#tax > span").html("$" + response.toString());
                var initialGrandTotalString = $("#grandtotal>span").text();
                initialGrandTotal = parseFloat(initialGrandTotalString.substr(1));

                if (isNaN(taxCost))
                {                  
                    var grandTotal = response + initialGrandTotal;
                    $("#grandtotal > span").text("$" + grandTotal.toFixed(2));
                }
                else {
                    var grandTotal = response + (initialGrandTotal - taxCost);
                    $("#grandtotal > span").html("$" + grandTotal.toFixed(2));
                }
                

            },
            error: function (response) {
                alert("Error: " + response.responseText);
            }
        });
    });
});