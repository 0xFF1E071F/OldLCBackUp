<!-- 
--------------------------------------------
			Registration.php
				Yu Fu
			  2015-10-3
--------------------------------------------
This php create Registration page
-->

<html>
<head>
<meta content="en-us" http-equiv="Content-Language" />
<meta content="text/html; charset=utf-8" http-equiv="Content-Type" />
<link rel="stylesheet" type="text/css" href="style.css" />
<!-- forget to delete this. no this file
phpscript type="text/javascript" src="headerjs.js"></script>-->

<title>Charlottesville Warriors Circle</title>
</head>

<body>
	<?php include ('header.html'); ?>
	<?php include ('line.html'); ?>
	<?php
		if(isset($_GET['result']))
		{
			# not all case will be used
			# just in case when js not work
			switch ($_GET['result'])
			{
				case "un": 		echo "username is not vaild!"; 				break;
				case "repw":	echo "Please input same password agaim."; 	break;
				case "empty":	echo "Please fill in username/password."; 	break;
				case "userex":	echo "Username exist. Try a different one.";break;
			}
		}
	?>
	<?php include ('reg.html'); ?>
	<?php include ('line.html'); ?>
	<?php include ('footer.php'); ?>
</body>

</html>
