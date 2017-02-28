<!-- 
--------------------------------------------
			 delete.php
				Yu Fu
			  2015-11-14
--------------------------------------------
this php connect db and delete user from db
then return result to user
-->
<?php
	
	if ($_GET['id'])
	{
		if ($_GET['id']!="")
		{
			require_once 'conn.php'; 
			//delete the user infor from db
			$uid=$_GET['id'];
			$delete="DELETE users, uinfo
			FROM users JOIN uinfo
			WHERE uinfo.uid=users.id
			AND users.id=$uid";
			if (mysqli_query($conn,$delete))
			{	
				// delete all checkouts
				$delete="DELETE FROM checkouts where userId=$uid";
				if(mysqli_query($conn,$delete))
				{
					$result = "delete";
				}
				
			}
			else
			{
				$result = "notdelete";
			}
			mysqli_close ($conn);
		}
	}
	$href="adminusers.php?result=".$result;
	header("Location:".$href); 
?>

	