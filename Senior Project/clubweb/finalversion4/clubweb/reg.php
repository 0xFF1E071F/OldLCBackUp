<!-- 
--------------------------------------------
			   reg.php
				Yu Fu
			  2015-10-3
--------------------------------------------
This php connect to database and add the user
-->

<?php

if(isset($_POST['cancel']))
{
	header("location:index.php");
}
else if (isset($_POST['submit']))
{	
	// i make username lower case
	// first name, last name with only first character is upper case
	$username = strtolower($_POST['username']);
	$password = $_POST['password'];
	$repw = $_POST['repw'];
	$email = $_POST['email'];
	$fname = ucfirst(strtolower($_POST['fname']));
	$lname = ucfirst(strtolower($_POST['lname']));
	//check register information
	if(!preg_match('/^[\w\x80-\xff]{3,15}$/', $username)){
		header('Location: registration.php?result=un');
		exit;
	}
	//if(strlen($password) < 6)
	//	exit('Your password is too short! You need 6+ characters.<a href="javascript:history.back(-1);">Return</a>');
	
	if($password!=$repw){
		header('Location: registration.php?result=repw');
		exit;
	}
	if ($username== "" || $password==""	|| $repw==""	)
	{
		header('Location: registration.php?result=empty');
		exit;
	}
	//include database file
	include('conn.php');
				
	//check if username exist
	$check_query = mysqli_query($conn,"select id from users where lower(username) ='$username' limit 1");
	if(mysqli_fetch_array($check_query)){
		header('Location: registration.php?result=userex');
		exit;
	}
	
	//insert database
	$password = sha1($password);
	$sql = "INSERT INTO users(username,password)VALUES('$username','$password')";
	
	if(mysqli_query($conn,$sql)){
		$last_user_id=mysqli_insert_id($conn);
		$sql = "INSERT INTO uinfo(f_name,l_name,email,uid)VALUES('$fname','$lname','$email','$last_user_id')";
		if (mysqli_query($conn,$sql))
		{	
			header('Location: index.php?result=regsuc'); exit;
			//It would be nice if we sent it something saying "registration successful!"
		}
		else
		{
			header('Location: index.php?result=regunsuc');
			exit;
		}
	} else {
		header('Location: index.php?result=regunsuc');
		exit;
	}
}

?>

