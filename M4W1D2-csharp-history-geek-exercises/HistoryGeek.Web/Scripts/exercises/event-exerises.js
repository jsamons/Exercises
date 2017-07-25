/// <reference path="../jquery-3.1.1.js" />

$(document).ready(function () {

    var subtotalString = $("#subtotal>span").text(); 
    var subtotal = parseFloat(subtotalString.substr(1));
    $("#grandtotal > span").text("$" + subtotal.toFixed(2));

    var checkBox = $("#SameShipping");
    checkBox.on("click", function (event) {
        if (checkBox.is(":checked")) {
            $("#ShippingAddress1").val($("#BillingAddress1").val());
            $("#ShippingAddress2").val($("#BillingAddress2").val());
            $("#ShippingCity").val($("#BillingCity").val());
            $("#ShippingState").val($("#BillingState").val());
            $("#ShippingPostalCode").val($("#BillingPostalCode").val());
        }
        else {
            $("#ShippingAddress1").val($(null).val());
            $("#ShippingAddress2").val($(null).val());
            $("#ShippingCity").val($(null).val());
            $("#ShippingState").val($(null).val());
            $("#ShippingPostalCode").val($(null).val());
        }
    });

    var count = 0;

    $("input[name=ShippingType]:radio").change(function () {
        var shippingCostString = $("input[name=ShippingType]:checked").attr("data-cost");       
        $("#shipping > span").html(shippingCostString);
        var shippingCost = parseFloat(shippingCostString.substr(1));
        var taxCostString = $("#tax > span").text();
        var taxCost = parseFloat(taxCostString.substr(1));

        if(isNaN(taxCost)) {           
            var grandTotal = subtotal + shippingCost;
            $("#grandtotal > span").text("$" + grandTotal.toFixed(2));
        }
        else {
            var grandTotal = subtotal + shippingCost + taxCost;
            $("#grandtotal > span").text("$" + grandTotal.toFixed(2));
        }
        
    });  


});




