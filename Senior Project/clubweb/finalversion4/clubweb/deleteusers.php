<!-- 
--------------------------------------------
			deleteusers.php
				Yu Fu
			  2015-11-14
--------------------------------------------
this page let admin can delete users
it will load every users(not superadmin from db)
and give a delete button
-->
<script language="javascript">
function delForm(id)
{
	alert=confirm("Do you really want to delete this user?")
	if(alert==true)
	{
		location.href="delete.php?id="+id
		//window.location.href='deleteuser.php?id='"<?php echo $userrow['uid'];?>"
	}
}
</script> 

<fieldset>
<legend>Delete User:</legend>
<form name="update_admin" method="post"  action="updateAdmin.php">
<table>
<tr>
<td>
<label for="users">Check user(s) to delete:</label>
</td>
</tr>
<?php
require_once 'conn.php';
// select all user without superadmin user
$sql = "SELECT i.f_name,i.l_name,u.admin,i.uid FROM uinfo i,users u WHERE u.id=i.uid AND u.superadmin!='1'"; 
$get_uinfo = mysqli_query($conn,$sql) or die("Error: ".mysqli_error($conn));
while($userrow = mysqli_fetch_array($get_uinfo)) 
{
?>		
	
	<tr>
		<td>
			<label>
			<?php
				echo $userrow['f_name']." ".$userrow['l_name']
			?>
			</label>
		</td>
		<td>
			<?php
				echo "<input type='button' onclick='delForm(".$userrow['uid'].");' value='Delete' class='left' >";
			?>
		</td>
	</tr>

<?php
}
?>
	
	<!--<tr>
	<td>
	<input type="submit" name="submit" id= "submit" value="Submit"/>
	
	</td>
	</tr>-->
</table>
</form>
</fieldset>