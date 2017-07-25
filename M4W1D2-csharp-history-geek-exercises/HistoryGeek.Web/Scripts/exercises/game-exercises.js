$(document).ready(function () {

    var row = 0;
    var column = 0;
    var lastrow = parseInt($("tr").last().attr("id").substr(4));

    function getCellId(row, column) {
        return "#row_" + row + "_column_" + column;
    };

    $("#btnRestart").click(function () {
        var location = getCellId(row, column);
        $(location).removeClass("ship");
        $("#row_0_column_0").addClass("ship");
        row = 0;
        column = 0;
        
    });

    $("body").on("keydown", function (event) {
        var code = event.keyCode;

        switch (event.keyCode) {

            case 38://up arrow

                if (row !== 0) {
                    var initialCell = getCellId(row, column);
                    row -= 1;
                    var cellId = getCellId(row, column);
                    if ($(cellId).hasClass("iceberg")) {
                        alert("Titanic part 2!!!");
                        $(initialCell).removeClass("ship");
                        $("#row_0_column_0").addClass("ship");
                        row = 0;
                        column = 0;
                    }
                    else if ($(cellId).hasClass("pirate")) {
                        alert("Arg, de pirates gotcha!!!");
                        $(initialCell).removeClass("ship");
                        $("#row_0_column_0").addClass("ship");
                        row = 0;
                        column = 0;
                    }
                    else {
                        $(initialCell).removeClass("ship");
                        $(cellId).addClass("ship");
                    }
                }
                break;

            case 37: //left arrow

                if (column !== 0) {

                    var initialCell = getCellId(row, column);
                    column -= 1;
                    var cellId = getCellId(row, column);
                    if ($(cellId).hasClass("iceberg")) {
                        alert("Titanic part 2!!!");
                        $(initialCell).removeClass("ship");
                        $("#row_0_column_0").addClass("ship");
                        row = 0;
                        column = 0;
                    }
                    else if ($(cellId).hasClass("pirate")) {
                        alert("Arg, de pirates gotcha!!!");
                        $(initialCell).removeClass("ship");
                        $("#row_0_column_0").addClass("ship");
                        row = 0;
                        column = 0;
                    }
                    else {
                        $(initialCell).removeClass("ship");
                        $(cellId).addClass("ship");
                    }
                }
                break;

            case 39://right arrow
                if (column !== lastrow) {
                    var initialCell = getCellId(row, column);
                    column += 1;
                    var cellId = getCellId(row, column);
                    if ($(cellId).hasClass("treasure"))
                    {
                        alert("You found the treasure! Congrats!")
                        $(initialCell).removeClass("ship");
                        $("#row_0_column_0").addClass("ship");
                        row = 0;
                        column = 0;
                    }
                    else if ($(cellId).hasClass("iceberg")) {
                        alert("Titanic part 2!!!");
                        $(initialCell).removeClass("ship");
                        $("#row_0_column_0").addClass("ship");
                        row = 0;
                        column = 0;
                    }
                    else if ($(cellId).hasClass("pirate")) {
                        alert("Arg, de pirates gotcha!!!");
                        $(initialCell).removeClass("ship");
                        $("#row_0_column_0").addClass("ship");
                        row = 0;
                        column = 0;
                    }
                    else {
                        $(initialCell).removeClass("ship");
                        $(cellId).addClass("ship");
                    }
                }

                break;

            case 40:// down arrow

                if (row !== lastrow) {
                    var initialCell = getCellId(row, column);
                    row += 1;
                    var cellId = getCellId(row, column);
                    if ($(cellId).hasClass("treasure")) {
                        alert("You found the treasure! Congrats!")
                        $(initialCell).removeClass("ship");
                        $("#row_0_column_0").addClass("ship");
                        row = 0;
                        column = 0;
                    }
                    else if ($(cellId).hasClass("iceberg")) {
                        alert("Titanic part 2!!!");
                        $(initialCell).removeClass("ship");
                        $("#row_0_column_0").addClass("ship");
                        row = 0;
                        column = 0;
                    }
                    else if ($(cellId).hasClass("pirate")) {
                        alert("Arg, de pirates gotcha!!!");
                        $(initialCell).removeClass("ship");
                        $("#row_0_column_0").addClass("ship");
                        row = 0;
                        column = 0;
                    }
                    else {
                        $(initialCell).removeClass("ship");
                        $(cellId).addClass("ship");
                    }
                }
                break;

        }
    });
});