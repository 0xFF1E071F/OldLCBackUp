<!-- 
--------------------------------------------
			   body.php
				Yu Fu
			  2015-10-3
--------------------------------------------
This php create body of website
-->
<div>
<table style="width: 100%">
	<tr>
	<?php	
	if(isset($_COOKIE['user_id']))	//if login
	{	?>
	
		<td style="width: 60%">
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
