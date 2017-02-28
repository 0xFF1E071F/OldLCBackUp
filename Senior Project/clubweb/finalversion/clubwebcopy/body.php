<!-- 
--------------------------------------------
			   body.php
				Yu Fu
			  2015-10-3
--------------------------------------------
This php create body of website
-->
<?php 
	//After certain actions -- attempting to add or remove meeting dates as administrator, or attempting to check in or out --
	// we may want a message to the user saying that it did or didn't work.  This function does that.
	
	//Note that you can fake messages by typing in a URL argument -- but if Google can do this with its search terms,
	// we can do this with our error messages.  WSB 2015-11-12
	
	function printMessageFromURLArgument ()
	{
		echo '<center><span class="messageFromURLArgument">';
			
		if (isset($_GET['result']))
		{
			//First: admin actions related to scheduling meetings
			switch ($_GET['result'])
			{
				case "delete": 		echo "Date deleted!"; 								break;
				case "notdelete":	echo "Date not deleted."; 							break;
				case "exist":		echo "Date exists.  Please select a new date!"; 	break;
				case "add":			echo "Date added successfully."; 					break;
				case "regsuc":		echo "Registration successful!"; 					break;
				case "regunsuc":	echo "Registration unsuccessful!"; 					break;
				case "adsuc":		echo "Setup admin users successful!"; 				break;
			}
			unset($_GET['result']);	
			// i want to reset this, bcz i do not want any information show after user refresh
		}
			
		//Now: user actions related to checking in or out
		if (isset($_GET['status']))
		{
			if ($_GET['status']=="ci") echo "You have checked out successfully!";
			if ($_GET['status']=="co") echo "You have checked in successfully!";
			//unset($_GET['status']);
		}
			
		echo "</span></center>";
	}
?>

<div>
<table style="width: 100%">
	<tr>
	<?php	
	if(isset($_COOKIE['user_id']))	//if login
	{	?>
	

		<td style="width: 60%">
			<?php printMessageFromURLArgument (); ?> <!-- if there's a message print it -->
			<?php include "cal.php" ?>
		</td>
		
		<td style="width: 40%">
		<?php	
			include "user.php";
		?>
		</td>

	<?php 
	}
	else
	//if not login
	{
	?>
		<td style="width: 60%">
		
		</td>
		
		<td style="width: 40%">
		<?php
			include "login.html";
		?>
		</td>
	<?php	
	}
	?>
	</tr>
</table>
</div>
