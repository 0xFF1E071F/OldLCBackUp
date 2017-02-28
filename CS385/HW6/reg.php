<?php
	function register($username,$password,$repw)		// print result and send to db
	{
		echo "welcome, $username, you become user.</br>";
		echo "userName: ", $_POST['$username'],"<br/>";
		echo "passWord: ", $_POST['$password'], "<br/>"; 
		echo "re-PW:   ",  $_POST['$repw'],"<br/>";

	}
	
	function check()	//check register information correct
	{
		if(empty($_POST['$username']))
   		{
       		echo "UserName is empty!";
       		return false;
    	}
     
   		if(empty($_POST['$password']))
    	{
       		echo "Password is empty!";
       		return false;
    	}
		if( $_POST['$password']!=$_POST['$repw'])
		{
			echo "Please type in same password twice!";	
			return false;
		}	 
		return true;
	}
	
	function regActoin($username,$password,$repw)	//give reaction
	{

		if (check()==true)
			register($username,$password,$repw);			

	}
?>
<S!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">

<head>
<meta content="text/html; charset=utf-8" http-equiv="Content-Type" />
<title>Untitled 1</title>
</head>

<body>
<?php
		regActoin($_POST['$username'],$_POST['$password'],$_POST['$repw']);
?>


</body>

</html>

