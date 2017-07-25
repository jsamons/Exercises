/// <reference path="../jquery-3.1.1.js" />
//Locate all <div> elements and add the 'president' class.
function presentialDivs() {
    $("#btnPresident").click(function () {
        alert("Clicked the first button");
        $("div").addClass("president");
    })
}

//Locate George Washington and add the 'founding-father' class
function georgeWashington() {
    $("#btnFoundingFather").click(function () {
        alert("Clicked second button");
        $("#george-washington").addClass("founding-father");
    })
}

//Locate all Republican presidents and add the 'red' class.
function republicanPresidents() {
    $("#btnRepublicans").click(function () {
        alert("Clicked third button");
        $(".Republican").addClass("red");
    })

}

//Locate all Democrat presidents and add the 'blue' class.
function democratPresidents() {
    $("#btnDemocrats").click(function () {
        alert("Clicked another button");
        $(".Democratic").addClass("blue");
    })
}

//Locate all Federalist presidents and add the 'gold' class.
function otherPresidents() {
    $("#btnOther").click(function () {
        alert("And another");
        $("div").not(".Democratic").not(".Republican").addClass("gold");
    })
}

//Locate all presidents named 'James' and add the 'james' class.
function presidentsNamedJames() {
    $("#btnJames").click(function (){
        alert("Good button pushing");
        $("[id^='james']").addClass("james");
    })
}

//Locate each president serving at the beginning of each century and add the 'beginningOfCentury' class.
function turnOfTheCenturyPresidents() {
    $("#btnBeginningOfCentury").click(function () {
        alert("got it");
        $("h2").next("div").addClass("beginningOfCentury");
    })
}

//Locate each president serving at the end of the century and add the 'endOfCentury' class.
function endOfTheCenturyPresidents() {
    $("#btnEndOfCentury").click(function () {
        alert("got it");
        $("h2").prev("div").addClass("endOfCentury");
    }) 

}

//Locate all presidents serving in the 1900s who appear on currency and add the 'appearOnCurrency' class.
function currencyPresidents() {
    $("#btnAppearOnCurrency").click(function () {
        alert("Last One");
        $("h2").eq(2).nextUntil("h2").filter(".currency").addClass("appearOnCurrency");
    })

}