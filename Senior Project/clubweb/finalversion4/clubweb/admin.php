<!-- 
--------------------------------------------
			  admin.php
				Yu Fu
			  2015-10-3
--------------------------------------------
This php show the page for admin user 
they can modify date: add/delete
also, superadmin can modify admin user.
-->
<div>
	<?php
		//connect to database
		require_once 'conn.php';
	
		// check if this user is a superadmin
		$sql = "SELECT superadmin FROM users WHERE id='$_COOKIE[user_id]'";
		$get_currentuser = mysqli_query($conn,$sql) or die("Error: ".mysqli_error($conn));
		$get_superadmin=mysqli_fetch_array($get_currentuser);
	?>
</div>


<?php
include ('deleteDate.php');
include ('addDate.php');

if ($get_superadmin['superadmin']==1)
{
	//this is superadmin to setup admin users
?>
	<p><a href="adminusers.php">-Change Users-</a>
	<!--Change weekday-->
	<p><a href="changeDefDay.php">-Change the Default Meeting Day-</a>
	<p><a href="changeelsepw.php">-Reset PW-</a>
<?php	
}
?>
<!--register a new user-->
<p><a href="registration.php">-Register A New User-</a>
<p><a href="checkelsepage.php">-Check Out/IN Users-</a>
