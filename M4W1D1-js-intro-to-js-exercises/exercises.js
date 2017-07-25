function sumDouble(x, y) {
    var result = 0;
    if (x === y) {
        result = (x + y) * 2;
    }
    else {
        result = x + y;
    }
    return result;
}

function hasTeen(x, y, z)
{
    var teen = false;
    var thisArray = [x, y, z];
    var arrayLength = thisArray.length;
    for (var i = 0; i < arrayLength; i++)
    {
        if (thisArray[i] >= 13 && thisArray[i] <= 19)
        {
            teen = true;
            break;
        }
    }
    return teen;
}

function lastDigit(x, y)
{
    var sameLastDigit = false;
    if (x % 10 === y % 10)
    {
        sameLastDigit = true;
    }
    return sameLastDigit;
}

function seeColor(str)
{
    var red = str.startsWith("red");
    var blue = str.startsWith("blue");
    var color = "";
   
    if (red === true)
    {
        color = "red";
    }
    else if (blue === true)
    {
        color = "blue";
    }
    return color;
}

function middleThree(str)
{
    var string = "";
    var start = (str.length-1)/2;
    for (var i = start-1; i < start + 2; i++)
    {
        string += str[i];
    }
    return string;
}

function frontAgain(str)
{
    var result = false;
    var string = str[0] + str[1];
    var stringEnd = str[str.length - 2] + str[str.length - 1];
    if (string === stringEnd)
    {
        result = true;
    }
    return result;
}

function alarmClock(weekday, vacation)
{
    var days = ["Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"];
    var string = "";
    if (vacation)
    {
        if(weekday === 0 || weekday === 6)
        {
            string = days[weekday] + " off";
        }
        else
        {
            string = days[weekday] + " 10:00";
        }
        
    }
    else if(weekday===0 || weekday === 6)
    {
        string = days[weekday] + " 10:00";
    }
    else {
        string = days[weekday] + " 7:00";
    }
    return string;
}

function makeMiddle(array)
{
    var newArray = [];
    if (array.length % 2 === 0 && array.length!=0)
    {
        var start = (array.length / 2) - 1;
        newArray.push(array[start]);
        newArray.push(array[start + 1]);
    }
    return newArray;
}

function oddOnly(array)
{
    var newArray = [];
    for (var i = 0; i < array.length; i++)
    {
        if (array[i] % 2 != 0)
        {
            newArray.push(array[i]);
        }
    }
    return newArray;
}

function weave(array, array2)
{
    var newArray = [];
    if (array.length >= array2.length)
    {
        while(array2.length>0)
        {
            newArray.push(array.shift());
            newArray.push(array2.shift());
        }
        while (array.length > 0)
        {
            newArray.push(array.shift());
        }

    }
    else
    {
        while (array.length > 0) {
            newArray.push(array.shift());
            newArray.push(array2.shift());
        }
        while (array2.length > 0) {
            newArray.push(array2.shift());
        }
    }
    return newArray;
}

function cigarParty(cigars, weekend)
{
    var goodParty = false;
    if (weekend)
    {
        if (cigars >= 40)
        {
            goodParty = true;
        }
    }
    else
    {
        if (cigars >= 40 && cigars <= 60)
        {
            goodParty = true;
        }
    }
    return goodParty;
}

function stringSplosion(string)
{
    var newString = "";
    for (var i = 0; i < string.length; i++)
    {
        for (var x = 0; x <= i; x++)
        {
            newString += string[x];
        }
    }
    return newString;
}

function fizzBuzz(num)
{
    var result;
    if (num % 3 === 0 && num % 5===0)
    {
        result = "FizzBuzz";
    }
    else if (num % 3 === 0)
    {
        result = "Fizz";
    }
    else if (num % 5 === 0)
    {
        result = "Buzz";
    }
    else
    {
        result = num;
    }
    return result;
}

function countValues(array)
{
    var newObject = {};
    newObject[array[i]];
    for (var i = 0; i < array.length; i++)
    {
        var count=0;
        for (var x = 0; x < array.length; x++)
        {
            if (array[i] === array[x])
            {
                count += 1;
            }           
        }       
        newObject[array[i]] = count;
    }
    return newObject;
}

function reverseArray(array)
{
    var newArray = [];
    while(array.length>0)
    {
        newArray.push(array.pop());
    }
    return newArray;
}

function blackJack(number1, number2) {
    var answer = 0;
    if (number1 <= 21) {
        answer = number1;
        if (number2 <= 21 && number2 > number1) {
            answer = number2;
        }
    }
    else if (number2 <= 21) {
        answer = number2;
    }
    return answer;

    function countValues(input) {
        var count = {};
        for (var i = 0; i < input.length; i++) {
            if (isNaN(count[input[i]])) {
                count[input[i]] = 0;
            }
            count[input[i]] += 1;
        }
        return count;
    }
}