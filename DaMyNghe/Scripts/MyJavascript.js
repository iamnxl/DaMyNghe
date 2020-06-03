$.ajax({
    type: "POST",
    contentType: false,
    url: "test",
    data: "{}",
    dataType: 'text',
    success: function (str) {
        var Result = JSON.parse(str);
        console.log(Result);
        var data = [];
        for (var i in Result) {
            data.push({ date: new Date(Result[i].Date), value: Result[i].Value });
        }

        DreawChart(data);
    },
    error: function (Result) {
        alert("Error");
    }
});