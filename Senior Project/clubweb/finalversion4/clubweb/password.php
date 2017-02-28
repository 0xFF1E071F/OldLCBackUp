<!-- 
--------------------------------------------
		     password.php
				Yu Fu
			  2015-11-18
--------------------------------------------
This php create the page of 
let user to change password after successful change
it will log user out 
also tell user pw changed
-->

<html>
<head>
<meta content="en-us" http-equiv="Content-Language" />
<meta content="text/html; charset=utf-8" http-equiv="Content-Type" />
<link rel="stylesheet" type="text/css" href="style.css" />
<script language="javascript" type="text/javascript" src="jquery/jquery.js"></script>


<title>Charlottesville Warriors Circle</title>
</head>
<?php require_once 'conn.php';?>
<body>
	<?php include ('header.html'); ?>
	<?php include ('line.html'); ?>

	<?php include ('changepw.php'); ?>

	<?php include ('line.html'); ?>
	<?php include ('footer.php'); ?>
</body>

</html>
