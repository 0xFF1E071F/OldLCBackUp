<!-- 
--------------------------------------------
			setupuser.php
				Yu Fu
			  2015-11-14
--------------------------------------------
this page 
include two part
1. setup admin users
2. delete users from our db
-->

<?php
echo "<table>";
echo "<tr>";
echo "<td>";
echo "</td>";
echo "<td>";
//show the result of delete user from db
echo '<center><span class="messageFromURLArgument">';
if (isset($_GET['result']))
{
	switch ($_GET['result'])
	{
		case "delete": 		echo "User deleted!"; 								break;
		case "notdelete":	echo "User not deleted."; 							break;
	}
}
echo "</span></center>";

echo "</td>";
echo "</tr>";
echo "<tr>";
echo "<td width='50%'>";
//set up admin user
include 'setupAdmin.php';

echo "</td>";
echo "<td width='50%'>";
//delete  user from db
include 'deleteusers.php'; 

echo "</td>";
echo "<td>";

echo "<input type='button' onclick=window.location.href='index.php' value='Back to Index' class='left' >";

echo "</td>";
echo "</tr>";
echo "</table>";
?>