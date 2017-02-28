<?php
function Login()
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
     
    $username = trim($_POST['$username']);
    $password = trim($_POST['$password']);
     
    if(/*!CheckLoginInDB($username,$password)*/$username!="username" && $password != "password")
    {
    	echo "wrong password";
        return false;
    }
    else {
    	echo "loged in";
   	 return true;   
    }
    //session_start();
  
   // $_SESSION[GetLoginSessionVar()] = $username;
     
    return true;
}

function CheckLoginInDB($username,$password)
{
    if(!DBLogin())
    {
        HandleError("Database login failed!");
        return false;
    }         
    $username = SanitizeForSQL($username);
    $pwdmd5 = md5($password);
    $qry = "Select name, email from tablename ".
        " where username='$username' and password='$pwdmd5' ".
        " and confirmcode='y'";
     
    $result = mysql_query($qry,connection);
     
    if(!$result || mysql_num_rows($result) <= 0)
    {
        HandleError("Error logging in. ".
            "The username or password does not match");
        return false;
    }
    return true;
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
		Login();
		
?>

</body>

</html>
