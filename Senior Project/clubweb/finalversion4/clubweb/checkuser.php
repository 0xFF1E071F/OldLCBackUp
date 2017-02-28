<?php
	/*
	--------------------------------------------
				checkuser.php
					Yu Fu
				  2015-10-3
	--------------------------------------------
	This php can checkout/ checkin user from database
	*/
	
	// get info	
	$userid=$_GET['id'];
	$dateid=$_GET['dateid'];
	//$value=$_POST['action'];
	// connect to database
	require_once 'conn.php'; 
	
	// checkin/checkout
	$sql;
	$status;
	
	//check if user is check in/out
	$find_check="SELECT * FROM checkouts WHERE dateId = $dateid AND userId = $userid"; 
	$result_check = mysqli_query($conn,$find_check);
	
	// do check in/out action 
	// depends on if 
	// i can find the name in database
	if(mysqli_num_rows($result_check)==0)
	{
		$sql = "INSERT INTO checkouts (dateId,userId) VALUES ($dateid,$userid)";
		$status="ci";
	}
	else if(mysqli_num_rows($result_check)==1)
	{
		$sql = "DELETE FROM checkouts WHERE dateId=$dateid AND userId=$userid;";
		$status="co";
	}
	//give user result as $_GET
	//Jump to index
	if (mysqli_query($conn,$sql))
	{
		$href="index.php?status=".$status."&dateid=".$dateid;
		header("Location:".$href); 
	}
?>