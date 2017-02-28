<!-- 
--------------------------------------------
			updateDates.php
				Yu Fu
			  2015-10-3
--------------------------------------------
update admin users in database	
-->


<?php
//connect to database
require_once 'conn.php'; 
// get connection
$conn = mysqli_connect(DB_HOST,DB_USER,DB_PASSWORD,DB_NAME);
// conn fail
if (!$conn){
	die("connection fail." . mysql_error());
}
$selected_date_id=$_POST['selectDate'];
$new_date=$_POST['date'];
$new_date_strtotime=strtotime($new_date);
echo $new_date_strtotime;
if($new_date!="" && $selected_date_id!="")
{
	//update old date to new date
	$sql = "UPDATE dates SET date='$new_date_strtotime' WHERE id='$selected_date_id' "; 
	$update_date = mysqli_query($conn,$sql) 
					or die("Error: ".mysqli_error($conn));
}

mysqli_close ($conn);
header('Location: index.php'); //back to index
?>