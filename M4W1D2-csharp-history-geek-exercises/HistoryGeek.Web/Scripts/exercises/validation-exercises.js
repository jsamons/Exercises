/// <reference path="../jquery-3.1.1.js" />
/// <reference path="../jquery.validate.js" />

$(document).ready(function () {

    $("#register > form").validate({
        rules: {
            EmailAddress: {
                required: true,
                email: true
            },
            Password: {
                required: true,         //requires password field
                minlength: 8,           //requires at least 8 characters
                strongpassword: true    //uses custom validator for strong password
            },
            ConfirmPassword: {
                equalTo: "#Password"
            }
        },
        messages: {
            EmailAddress: {
                required: "You must provide an email address",
                email: "This is not a valid email address"
            },
            password: {
                required: "You must provide a password",
                minlength: "Password can't be less than 8 characters",
                strongpassword: "Password must be stronger"
            },
            verifyPassword: {
                equalTo: "Must match password"
            }
        }
    });

    $("#login > form").validate({
        rules: {
            EmailAddress: {
                required: true,
                email: true,
            },
            Password: {
                required: true,         //requires password field
                minlength: 8,           //requires at least 8 characters
                strongpassword: true    //uses custom validator for strong password
            }
        },
        messages: {
            EmailAddress: {
                required: "You must provide an email address",
                email: "This is not a valid email address"
            },
            password: {
                required: "You must provide a password",
                minlength: "Password can't be less than 8 characters",
                strongpassword: "Password must be stronger"
            }
        }
    });

    $("#checkout").validate({
        rules: {
            BillingAddress1: {
                required: true,
            },
            BillingCity: {
                required: true,
            },
            BillingState: {
                required: true,
            },
            BillingPostalCode: {
                required: true,
            },
            ShippingAddress1: {
                required: true,
            },
            ShippingCity: {
                required: true,
            },
            ShippingState: {
                required: true,
            },
            ShippingPostalCode: {
                required:true,
            },
            NameOnCard: {
                required:true,
            },
            CreditCardNumber: {
                required: true,
            },
            ExpirationDate: {
                required: true,
            }
        },
        messages: {
            BillingAddress1: {
                required: "You must enter a billing address",
            },
            BillingCity: {
                required: "You must enter a billing city",
            },
            BillingState: {
                required: "You must enter a billing state",
            },
            BillingPostalCode: {
                required: "You must enter a billing postal code",
                length
            },
            ShippingAddress1: {
                required: "You must enter a shipping address",
            },
            ShippingCity: {
                required: "You must enter a shipping city",
            },
            ShippingState: {
                required: "You must enter a shipping state",
            },
            ShippingPostalCode: {
                required: "You must enter a shipping postal code",
            },
            NameOnCard: {
                required: "You must enter a name for the card",
            },
            CreditCardNumber: {
                required: "You must enter a credit card number",
            },
            ExpirationDate: {
                required: "You must enter an expiration date",
            }
        },
        errorContainer: "#errorSummary",
        errorLabelContainer: "#errorSummary ul",
        wrapper: "li",    
    });
});


