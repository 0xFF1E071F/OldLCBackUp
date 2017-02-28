<!-- 
--------------------------------------------
		     changepw.php
				Yu Fu
			  2015-11-18
--------------------------------------------
change password page 
-->
<script language=JavaScript>
function InputCheck(changepw)
{
  if (changepw.oldpw.value == "" )
  {
    alert("Old password can not be empty!");
    changepw.username.focus();
    return (false);
  }
  if (changepw.password.value == "")
  {
    alert("Must have password!");
    changepw.password.focus();
    return (false);
  }
  if (changepw.repass.value != changepw.password.value)
  {
    alert("Input the same password twice!");
    changepw.repass.focus();
    return (false);
  }
}
</script>
<?php 
	
	function printMessageFromURLArgument ()
	{
		echo '<center><span class="messageFromURLArgument">';
			
		if (isset($_GET['result']))
		{
				//First: admin actions related to scheduling meetings
			switch ($_GET['result'])
			{
			case "dbfail": 			echo "DATABASE connection is not correct!"; 							break;
			case "oldfail": 		echo "Old password is not correct!"; 							break;
			case "repw":			echo "Input the same password twice!"; 						break;
			}
		}
		echo "</span></center>";
	}
?>
<fieldset>
<legend>User Password Change</legend>
<form name="changepw" method="post" action="updatepw.php" onSubmit="return InputCheck(this)">
<table align="left">
	<tr>
		<?php printMessageFromURLArgument(); ?>
	</tr>
	<tr>
		<?php
			$user=$_COOKIE['user_id'];
			$query = "SELECT ui.f_name,ui.l_name,u.username FROM uinfo ui join users u on u.id = ui.uid WHERE '$user' = ui.uid"; 
			//check username and password
			$data = mysqli_query($conn,$query); 
			$row = mysqli_fetch_array($data); 
			echo "User: " . $row['username'].".<br>";
			echo "You need type in your old password and new password to make changes.<br>";	
		?>
	</tr>
	<tr>  
		<td style="width:20%">
			<label for="oldpw" class="label">Old Password:  </label>
		</td>
		<td style="width:30%">
			<input id="oldpw" name="oldpw" type="text" class="input"/>
		</td>
		<td style="width:40%">
			
		</td>
	</tr> 
	<tr> 
		<p>Type in your new password:</p>
	</tr> 
	<tr> 
		<td>
			<label for="password" class="label">Password:  </label>
		</td>
		<td>
			<input id="password" name="password" type="password" class="input">
		</td>
		<td>
		
		</td>
	</tr> 
	
	<tr>  
		<td>
	<label for="repw" class="label">Re-Password:</label>
		</td>
		<td>
			<input id="repw" name="repw" type="password" class="input">
		</td>
		<td>
			<span>(* Type in the same password again)</span>
		</td>
	</tr> 
	<tr>  
		<td>
			<input type="submit" name="submit" value="Submit" class="left">
		</td>
		<td>
			<input type="button" onclick="window.location.href='index.php';" value="Cancel" class="left" >
		</td>
	</tr> 
</table>
</form>
</fieldset>
