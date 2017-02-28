<!--
--------------------------------------------
			 setupAdmin.php
				Yu Fu
			  2015-10-3
--------------------------------------------
This php connect to database
and gives the names of admin user with checked
and not admin users without checked
-->

<fieldset>
<legend>Admin User:</legend>
<form name="update_admin" method="post"  action="updateAdmin.php">
<label for="users">Set a User to admin:</label>
<?php
// select all user without superadmin user
$sql = "SELECT i.f_name,i.l_name,u.admin,i.uid FROM uinfo i,users u WHERE u.id=i.uid AND u.superadmin!='1'"; 
$get_uinfo = mysqli_query($conn,$sql) or die("Error: ".mysqli_error($conn));
while($userrow = mysqli_fetch_array($get_uinfo)) 
{
?>		
<table>
	<tr>
		<td>
			<input type="checkbox" name="adminUser[]" value=<?php echo $userrow['uid']?> 
			<?php
				if($userrow['admin']=="1")
				//print checked
					echo "checked";
				else
					//without checked
			?>
			>
			<label>
				<?php
				echo $userrow['f_name']." ".$userrow['l_name']
				?>
			</label>
		

		</td>
	</tr>

<?php
}
?>
</table>
	<input type="submit" name="submit" id= "submit" value="Submit"/>
</form>
</fieldset>