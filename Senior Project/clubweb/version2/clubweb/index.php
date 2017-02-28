<!-- 
--------------------------------------------
			checkuser.php
				Yu Fu
			  2015-10-3
--------------------------------------------
This php create index page
-->
<html>
<head>
<meta content="en-us" http-equiv="Content-Language" />
<meta content="text/html; charset=utf-8" http-equiv="Content-Type" />
<link rel="stylesheet" type="text/css" href="style.css"></link>
<script language="javascript" type="text/javascript" src="jquery/jquery.js"></script>
<script language=JavaScript>
function InputCheck(LoginForm)
{
  if (LoginForm.username.value == "" )
  {
    alert("Username can not be empty!");
    LoginForm.username.focus();
    return (false);
  }
  if (LoginForm.password.value == "")
  {
    alert("Must have password!");
    LoginForm.password.focus();
    return (false);
  }

}

$('input[type="checkbox"]').on('change', function() {
	$('input[name="' + this.name + '"]').not(this).prop('checked', false);
});
	
function InputCheck(dateForm)
{
  if (dateForm.date.value == "")
  {
    alert("Please select a vaild date!");
    dateForm.date.focus();
    return (false);
  }
}

</script>
<title>Charlottesville Warriors Circle</title>
</head>
<body>
	<?php include ('auto.php');?>
	<?php include ('header.html');?>
	<?php include ('body.php');?>
	<?php include ('footer.php');?>
</body>

</html>
