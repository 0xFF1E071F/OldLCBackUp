<!-- 
--------------------------------------------
			updateAdmin.php
				Yu Fu
			  2015-10-3
--------------------------------------------
update admin users in database	
-->
<?php
//connect to database
require_once 'conn.php'; 
// conn fail
if (!$conn){
	die("connection fail." . mysql_error());
}
$sql = "SELECT * FROM uinfo WHERE uid!='1'"; // select all user without admin
$get_uinfo = mysqli_query($conn,$sql) 
	or die("Error: ".mysqli_error($conn));
//reset all user to non-admin
while($userrow = mysqli_fetch_array($get_uinfo)) 
{
	$sql_admin = "UPDATE users SET admin=0 WHERE id='$userrow[uid]' AND superadmin!=1";
	$update_admin = mysqli_query($conn,$sql_admin) or die("Error: ".mysqli_error($conn));
}
$adminUser=$_POST["adminUser"];
$count_admin=count($adminUser);
//update setup admin
for($i=0;$i<$count_admin;$i++)
{
	$sql_setAdmin = "UPDATE users SET admin = 1 WHERE id='$adminUser[$i]'";
	$set_admin = mysqli_query($conn,$sql_setAdmin) or die("Error: ".mysqli_error($conn));
}
mysqli_close ($conn);
header('Location: index.php'); //back to index
?>