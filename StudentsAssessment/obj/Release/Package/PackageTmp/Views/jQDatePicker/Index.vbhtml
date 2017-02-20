﻿
@Code
    Layout = Nothing
End Code


<!DOCTYPE html>
<html>
<head>
    <meta http-equiv="Content-Type" content="text/html;charset=utf-8">
    <title>jQuery Datepicker</title>
    @*<link href="css/jquery.datepick.css" rel="stylesheet">
    <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>
    <script src="js/jquery.plugin.min.js"></script>
    <script src="js/jquery.datepick.js"></script>*@
    <link href="~/Content/jQuery_datepicker/css/jquery.datepick.css" rel="stylesheet" />
    <script src="~/Scripts/jquery-1.12.4.min.js"></script>
    <script src="~/Content/jQuery_datepicker/js/jquery.plugin.min.js"></script>
    <script src="~/Content/jQuery_datepicker/js/jquery.datepick.js"></script>

    <script>
$(function() {
	$('#popupDatepicker').datepick();
	$('#inlineDatepicker').datepick({onSelect: showDate});
});

function showDate(date) {
	alert('The date chosen is ' + date);
}
    </script>
</head>
<body>
    <h1>jQuery Datepicker</h1>
    <p>
        This page demonstrates the very basics of the
        <a href="http://keith-wood.name/datepick.html">jQuery Datepicker plugin</a>.
        It contains the minimum requirements for using the plugin and
        can be used as the basis for your own experimentation.
    </p>
    <p>For more detail see the <a href="http://keith-wood.name/datepickRef.html">documentation reference</a> page.</p>
    <p>A popup datepicker <input type="text" id="popupDatepicker"></p>
    <p>Or inline</p>
    <div id="inlineDatepicker"></div>
    <dl>
        <dt>Github</dt>
        <dd><a href="https://github.com/kbwood/datepick">https://github.com/kbwood/datepick</a></dd>
        <dt>Bower</dt>
        <dd>kbw-datepick</dd>
    </dl>
</body>
</html>

