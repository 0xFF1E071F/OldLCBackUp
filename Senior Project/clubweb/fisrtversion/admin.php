<!-- 
--------------------------------------------
			  admin.php
				Yu Fu
			  2015-10-3
--------------------------------------------
This php show the page for admin user 
they can modify date,
also, superadmin can modify admin user.
-->
<script  language="javascript" type="text/javascript" >
	$('input[type="checkbox"]').on('change', function() {
		$('input[name="' + this.name + '"]').not(this).prop('checked', false);
	});
	
function InputCheck(dateForm)
{
  if (dateForm.date.value == "" || dateForm.selectDate.value=="")
  {
    alert("Please select a vaild date!");
    dateForm.username.focus();
    return (false);
  }
}
</script>

<div>
	<?php
		//connect to database
		require_once 'conn.php'; 
		//select db
		$currentUser=$_COOKIE['user_id'];
		mysqli_select_db($conn,DB_NAME);
		$sql = "SELECT superadmin FROM users WHERE id='$_COOKIE[user_id]'";
		$get_currentuser = mysqli_query($conn,$sql) or die("Error: ".mysqli_error($conn));
		$get_superadmin=mysqli_fetch_array($get_currentuser);
		
		if ($get_superadmin['superadmin']==1 && $currentUser==1)
		{
			$sql = "SELECT * FROM uinfo WHERE uid!='1'"; // select all user without admin
			$get_uinfo = mysqli_query($conn,$sql) or die("Error: ".mysqli_error($conn));
			
			//this is superadmin to setup admin users
			include "setupAdmin.php";
		}
	?>
</div>

<div>
	<form name="dateForm" method="post"  onSubmit="return InputCheck(this)" action="updateDates.php" >	
		<select name="selectDate">
		<?php
		//get all date

		$sql = "SELECT * from dates ORDER BY date";
		$getDate = mysqli_query($conn,$sql);
		$today=strtotime("today-1day");
		while($daterow = mysqli_fetch_array($getDate)) 
		{
			if($daterow['date'] > $today)
			{
		?>
				<option value=<?php echo $daterow['id'];?>>
					<?php echo date('M-d-Y', $daterow['date']);?>
				</option>
		<?php
			}
		}
		?>
		</select>
		
	
		<label for="date">date:</label>
		<p>
			<input id="date" name="date" type="date" class="input" /> 
		</p>
		<input type="submit" name="submit" id= "submit" value=" submit "/>
	</form>
</div>
<?php

mysqli_close($conn);

?>