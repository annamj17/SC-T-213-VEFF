// Write your JavaScript code.

$("#ajax-btn").click(function() {

    $.get("Home/GetText", function(data, status) {
        $("#ajax-str").text(data);
        console.log(status);
    })
    .fail(function(err) {
        alert("fail!");
        console.log(err);
    });
});

$("#secret-btn").on('click', function () {
    $.get("Home/GetSecretStudent", function (data, status) {
        var markup = "<tr><td>" + data.name + "</td><td>" + data.age + "</td></tr>";
        $("#studentList").append(markup);
        $('#secret-btn').prop('disabled', true);
        
    })
    .fail(function (err) {
         alert("fail!");
        console.log(err);
    });
});

$("#concert-btn").click(function () {
    $.get("http://apis.is/concerts", function (data, status) {
            var table = 
                "<tr>" +
                "<th>Event Name: </th>" +
                "<th>Place: </th>" +
                "<th>Date: </th>" +
                "</tr>";
                $("#tbody").append(table);
                for (var i = 0; i < data.results.length; i++) {
                    var markup = "<tr><td>" + data.results[i].eventDateName + "</td>" +
                    "<td>" + data.results[i].eventHallName + "</td>" +
                    "<td>" + data.results[i].dateOfShow + "</td></tr>";
                    $("#tbody").append(markup);
                    
                }
    })
    .fail(function (err) {
        alert("fail!");
        console.log(err);
    });

    $('#concert-btn').prop('disabled', true);
});

$("#student-input").submit(function (e) {
    e.preventDefault();
    var name = $("#get-stud-name").val();
    var age = $("#get-stud-age").val();
    var data = 
    {
        name: name,
        age: age
    }
    $.post("Home/Add", data, function (data, status) {
        var markup = "<tr><td>" + data.name + "</td><td>" + data.age + "</td></tr>";
        $("#student-list").append(markup);
    });
});