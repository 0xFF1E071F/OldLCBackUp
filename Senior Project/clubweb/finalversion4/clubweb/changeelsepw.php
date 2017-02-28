<!-- 
--------------------------------------------
		     changeelsepw.php
				Yu Fu
			  2015-11-18
--------------------------------------------
change Other user's password page 
-->
<html>
<head>
<meta content="en-us" http-equiv="Content-Language" />
<meta content="text/html; charset=utf-8" http-equiv="Content-Type" />
<link rel="stylesheet" type="text/css" href="style.css" />
<script language=JavaScript>
function InputCheck(changepw)
{
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
<title>Charlottesville Warriors Circle</title>
</head>

<body>
	<?php include ('header.html'); ?>
	<?php include ('line.html'); ?>
<fieldset>
<legend>User Password Change</legend>
<form name="changepw" method="post" action="updatepw.php" onSubmit="return InputCheck(this)">
<table align="left">
	<tr >
	<div align="left">Select A User:
		<select name="selectUser" align="left">
		<?php
		require_once 'conn.php';
		//get all users
		$sql = "SELECT * from users join uinfo where users.id=uinfo.uid ORDER BY f_name";
		$getUsers = mysqli_query($conn,$sql);
		while($userRow = mysqli_fetch_array($getUsers)) 
		{
		?>
				<option value=<?php echo $userRow['id'];?>>
					<?php 
					echo $userRow['f_name'];
					if ($userRow['l_name']!= "")
						echo  " ".$userRow['l_name'];
					?>
				</option>
		<?php
		}
		?>
		</select>
	</div>
	</tr>
	<tr> 
	</br>
		<div align="left">Type in your new password:</div>
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
	<?php include ('line.html'); ?>
	<?php include ('footer.php'); ?>
</body>

</html>