<?php 
	/* 
	Yu Fu
	cs385
	2014
	This is login which get user login action php */
	//get connection of databases;
	require_once 'connectvars.php'; 

	$error_msg = ""; 
	//check exist cookie£¬if no exist $_COOKIE['user_id'] run this 
	if(!isset($_COOKIE['user_id']))
	{ 
		if(isset($_POST['submit']))
		{//if sumbit login information, run this. 
			$dbc = mysqli_connect(DB_HOST,DB_USER,DB_PASSWORD,DB_NAME); 
			$user_username = mysqli_real_escape_string($dbc,trim($_POST['username'])); 
			$user_password = mysqli_real_escape_string($dbc,trim($_POST['password'])); 

			if(!empty($user_username)&&!empty($user_password))
			{ 
				//Mysql password use MD5 
				$query = "SELECT user_id, username FROM users WHERE username = '$user_username' AND "."password = MD5('$user_password')"; 
				//check username and password
				$data = mysqli_query($dbc,$query); 
				//if exist username and password, set cookie and reload main
				if(mysqli_num_rows($data)==1)
				{ 
					$row = mysqli_fetch_array($data); 
					setcookie('user_id',$row['user_id']); 
					setcookie('username',$row['username']); 
					$home_url = 'main.php'; 
					header('Location: '.$home_url); 
				}
				else
				{//if no exist information, show error msg
					$error_msg = 'Sorry, you must enter a valid username and password to log in.'; 
					exit('No exist user! <a href="regPage.php">Return to register Page.</a>');
				} 
			}
			else
			{ 
				$error_msg = 'Sorry, you must enter a valid username and password to log in.'; 
				
			} 
		} 
	}
	else{
	//if loged, jump to loged.php 
		$home_url = 'loged.php'; 
		header('Location: '.$home_url); 
	} 
	if(isset($_POST['register'])) // go to register page
	{				
		header('Location:regPage.php'); 
	}
?> 
<html> 
<head> 
<title>LogIn Page</title> 
</head> 
<body> 
<!--$_COOKIE['user_id']if loged then go to loged.php, if not loged show login.php--> 
<!-- $_SERVER['PHP_SELF']check self php --> 
<form method = "post" action="<?php echo $_SERVER['PHP_SELF'];?>"> 
<fieldset> 
	<legend>Log In</legend> 
	<label for="username">Username:</label> 
	<!-- if inputed username show it. --> 
	<input type="text" id="username" name="username" 
		value="<?php if(!empty($user_username)) echo $user_username; ?>" /> <br/> 
	<label for="password">Password:</label> 
	<input type="password" id="password" name="password"/> 
</fieldset> <br/> 
	<input type="submit" value="Log In" name="submit"/> 
	<input type="submit" value="Register" name="register"/> 
</form> 

</body> 
</html> 
