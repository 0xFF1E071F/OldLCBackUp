<!-- 
--------------------------------------------
			  user.php
				Yu Fu
			  2015-10-3
--------------------------------------------
This is the user page after login
It shows the user's name 
and if user is admin
it will show the admin page
-->

<body style="height: 200px">

<table style="width: 100%; height: 150px">
	
	

	<tr>
		
		<td style="width: 100%;height:100px">
		<fieldset>
		<legend>User Center:</legend>
		<?php
			//Connect to database
			// check user name from db
			// print welcome text
			// set logout button
			require_once 'conn.php'; 
			$dbc = mysqli_connect(DB_HOST,DB_USER,DB_PASSWORD,DB_NAME); 
			$currentuid=$_COOKIE['user_id'];
			$query = "SELECT f_name,l_name FROM uinfo WHERE '$currentuid' = uid"; 
			//check username and password
			$data = mysqli_query($dbc,$query); 
			$row = mysqli_fetch_array($data); 
			echo "Welcome back, " . $row['f_name']/*." ".$row['l_name']*/." !";		
		?>
		<br />
		<input type="button" onclick="window.location.href='logout.php';" value="Log out" class="right" />
		</fieldset>
		</td>
	</tr>
	
	<tr>
		<td style="width: 100%; height:100px">
		<?php
			// if this is a admin user
			// will show the admin table
			$sql_admin = "SELECT admin FROM users WHERE '$currentuid' = id"; 
			$result_admin = mysqli_query($dbc,$sql_admin); 
			$row_admin = mysqli_fetch_array($result_admin);	
			
			if ($row_admin['admin'] ==1)
			{
				include "admin.php";
			}
		?>
		</td>

	</tr>
	<tr style="height: 30%">
		
	</tr>
	
</table>

</body>


