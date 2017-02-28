<!--
--------------------------------------------
			checkuser.php
				Yu Fu
			  2015-10-3
--------------------------------------------
This php can checkout/ checkin user from database
-->
<?php
	// get info	
	$userid=$_POST['id'];
	$dateid=$_POST['dateid'];
	$value=$_POST['action'];
	// connect to database
	require_once 'conn.php'; 
	// checkin/checkout
	$sql;
	//database depends on checkout or checkin
	if ($value =="co")
	{
			$query = "SELECT * FROM checkouts WHERE dateId = $dateid AND userId = $userid"; 
			//check username and password
			$data = mysqli_query($conn,$query); 
			//if exist username and password, set cookie and reload main
			if(mysqli_num_rows($data)==0)
				$sql = "INSERT INTO checkouts (dateId,userId) VALUES ($dateid,$userid)";
			else if(mysqli_num_rows($data)==1)
				$sql = "DELETE FROM checkouts WHERE dateId=$dateid AND userId=$userid;";
	}
	else if ($value =="ci")
	{
		$sql = "DELETE FROM checkouts WHERE dateId=$dateid AND userId=$userid;";
	}
	
	$result = mysqli_query($conn,$sql);
	mysqli_close($conn);
?>