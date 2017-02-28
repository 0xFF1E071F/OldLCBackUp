<!-- 
--------------------------------------------
			  login.php
				Yu Fu
			  2015-10-3
--------------------------------------------
This php check username and passwork correct or not 
and set user cookies

-->
<?php
	include ('autoupdate.php');		//This gives us autoupdate(), which checks to see if dates in our db need updating

	function login ($conn)
	{
		//if sumbit login information, run this. 
		//$dbc = mysqli_connect(DB_HOST,DB_USER,DB_PASSWORD,DB_NAME); //WSB: do I need this?  isn't the one in conn.php enough?
		require_once 'conn.php';
		$user_username = mysqli_real_escape_string($conn,trim($_POST['username'])); 
		$user_password = mysqli_real_escape_string($conn,trim($_POST['password'])); 

		if(!empty($user_username)&&!empty($user_password))
		{ 
			//Mysql password use sha1 
			$query = "SELECT id, username,password FROM users WHERE username = '$user_username' AND "."password = sha1('$user_password')"; 
			//check username and password
			$data = mysqli_query($conn,$query); 
			
			//if exist username and password, set cookie and reload main
			if(mysqli_num_rows($data)==1)
			{ 
				$row = mysqli_fetch_array($data); 
				
				setcookie('user_id',$row['id'],time()+86400*365*10); 
				setcookie('username',$row['username'],time()+86400*365*10); 

    			autoupdate ($conn);		//see if we need to add/remove meeting dates based on what day it is -- WSB

				//Hey, whoa, why are we reloading now?  Because cookies aren't set until the next page load -- and we need them!  WSB
				// http://php.net/manual/en/function.setcookie.php
				
    			header("Location:index.php");
			}
			else
			{	// login un/pw error
				$result="error";
				$href="index.php?login=".$result;
				header("Location:".$href); 
				
			} 
		}
		else
		{	// login un/pw empty
			
			$result="empty";
			$href="index.php?login=".$result;
			header("Location:".$href); 
		}
	}
?>

