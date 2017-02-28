<?php 
/*
	Yu FU
	cs385
	2014
T	his is loged php, use to check if user loged or not */
//if loged show user name 
if(isset($_COOKIE['username'])){ 
	echo 'You are loged as '.$_COOKIE['username'].'<br/>'; 
	//click “Log Out”，direct to logOut.php page and cookie off 
	echo '<a href="logOut.php"> Log Out('.$_COOKIE['username'].')</a>'; 
	} 
?>