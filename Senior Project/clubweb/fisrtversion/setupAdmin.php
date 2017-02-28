<form name="update_admin" method="post"  action="updateAdmin.php">
<label for="users">Set a User to admin:</label>
<?php
while($userrow = mysqli_fetch_array($get_uinfo)) 
{
?>		
<table>
	<tr>
		<td>
			<?php
			$sql_admin = "SELECT admin FROM users WHERE id='$userrow[uid]'";
			$get_admin = mysqli_query($conn,$sql_admin) or die("Error: ".mysqli_error($conn));
			$row = mysqli_fetch_array($get_admin);
			?>
			<input type="checkbox" name="adminUser[]" value=<?php echo $userrow['uid']?> 
			<?php
				if($row['admin']=="1")
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