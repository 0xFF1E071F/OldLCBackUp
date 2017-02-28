<?php /*
--------------------------------------------
			Registration.php
				Yu Fu
			  2015-10-3
--------------------------------------------
This php create Registration page
*/ ?>

<?php   require_once "conn.php"; ?>

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
	echo '<center><span class="messageFromURLArgument">';
	if (isset($_GET['result']))
	{
		switch ($_GET['result'])
		{
			case "userex": 		echo "User alreayd exist! Please try a different username."; break;
			case "empty":		echo "you must fill in all * blank."; 						 break;
			case "repw":		echo "You should type in same password"; 					 break;
			case "un":			echo "username is not match our rule."; 					 break;

		}
	echo "</span></center>";
	}
	?>
	
	<?php include ('reg.html'); ?>
	<?php include ('line.html'); ?>
	<?php include ('footer.php'); ?>
</body>

</html>
