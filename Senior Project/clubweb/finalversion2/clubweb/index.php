<!-- 
--------------------------------------------
			checkuser.php
				Yu Fu
			  2015-10-3
--------------------------------------------
This php create index page
-->
<?php   include 	"login.php"; ?>
<?php   require_once "conn.php"; ?>
<?php 	if (isset($_POST['submit'])) login ($conn); ?>	<!-- if this is a login attempt, process it -->
<?php date_default_timezone_set('America/New_York');?>  <!-- set time zone -->
<html>
<head>
<meta content="en-us" http-equiv="Content-Language" />
<meta content="text/html; charset=utf-8" http-equiv="Content-Type" />
<link rel="stylesheet" type="text/css" href="style.css"></link>
<script language="javascript" type="text/javascript" src="jquery/jquery.js"></script>
<script language=JavaScript>

$('input[type="checkbox"]').on('change', function() {
	$('input[name="' + this.name + '"]').not(this).prop('checked', false);
});
	

</script>
<title>Charlottesville Warriors Circle</title>

<?php	require_once 'conn.php'; 	/* Establish connection to database */ ?>

</head>
<body>
	<?php include ('header.html');?>
	<?php include ('body.php');?>
	<?php include ('footer.php');?>
</body>

</html>
