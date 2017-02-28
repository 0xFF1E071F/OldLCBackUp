<?php
	/*
	--------------------------------------------
				checkelse page.php
					Yu Fu
				  2015-12-1
	--------------------------------------------
	This php create page of checkout/in other users
	
	*/
echo "<html>
<head>
<meta content='en-us' http-equiv='Content-Language' />
<meta content='text/html'; charset='utf-8' http-equiv='Content-Type' />
<link rel='stylesheet' type='text/css' href='style.css' />
<script language='javascript' type='text/javascript' src='jquery/jquery.js'></script>


<title>Charlottesville Warriors Circle</title>
</head>
<body>";
include ('header.html');
include ('line.html'); 
echo "<h1>Check Other users:</h1>";
	function printMessageFromURLArgument ()
	{
		echo '<center><span class="messageFromURLArgument">';
			
		//Now: user actions related to checking in or out
		if (isset($_GET['status']))
		{
			if ($_GET['status']=="ci") echo "Check out successfully!";
			if ($_GET['status']=="co") echo "Check in successfully!";
			//unset($_GET['status']);
		}
	}
?>
<input type="button" onclick ="window.location.href='index.php'" value ="Back to Index">
<?php include "weekday.php";
printMessageFromURLArgument ();
date_default_timezone_set('America/New_York');  //<!-- set time zone -->
?>

<table>
	<tr>
		<td class="datetitle">Dates</td>
		<td class="nametitle">Who's coming?</td>
	
	</tr>
<?php
	// get connection
	require_once 'conn.php'; 

	//get dates from database
	$sql = "SELECT * from dates ORDER BY date";	
	$myid=$_COOKIE['user_id'];
	$result = mysqli_query($conn,$sql);
	while($daterow = mysqli_fetch_array($result)) 
	{
		if ($daterow['date']>=strtotime("today"))
		{
		?>
		<tr>
			<td class="date">
			<?php
				// print dates from database
				$currentdateid = $daterow['id'];
				echo date('M-d-Y', $daterow['date']);
				echo " (".getWeek($daterow['date']).")";
				$check_out_users_sql = "SELECT userId from checkouts where dateId='$currentdateid'";
				//$all_users_sql="select ";
				$result_uid = mysqli_query($conn,$check_out_users_sql);
			?>
			</td>										
			<!--name list-->
			<td class="name">
			<?php
			//select names from database userinfo
			$sql_uinfo = "SELECT id,f_name,l_name,uid from uinfo ORDER BY f_name;";
			$result_uinfo = mysqli_query($conn,$sql_uinfo);
			
			$uid_checkout_array = array();
			while($row_uid = mysqli_fetch_array($result_uid)) 
			{
				array_push($uid_checkout_array, $row_uid['userId']);
			}
			//Convert query result to an array
			$rows= array();
			while ($row = $result_uinfo->fetch_assoc()) 
				$rows[] = $row;
			
			//Now extract all the names that aren't checked out, put 'em in $stillComing
			// We must initialize $stillComing each time or we'll get last date's
			// entries
			$stillComing = array();
			foreach ($rows as $row)
				if (! in_array ($row['uid'],$uid_checkout_array))
					$stillComing[] = $row;

			//Finally, print each element of $stillComing.  Put commas after
			// all but last entry.
			echo "CheckOUT: </br>";
			for ($i = 0; $i < count($stillComing); ++$i)
			{
				$row = $stillComing[$i];
				echo $row['f_name'];
				if ($row['l_name'] != '') echo " ".$row['l_name'];
				$acion_url="window.location.href='checkelse.php?id=".$row['uid']."&dateid=".$currentdateid."'";
				?>
				<input type="button" onclick =<?php echo $acion_url; ?> id = <?php echo $currentdateid;?> value ="Check Out">
				<?php
				if ($i < count($stillComing)-1)
				{
					if (($i+1) %2==0)
					{
						echo "</br>";
					}
					else
						echo ", ";
				}

			}
			echo "</br> CheckIN: </br>";
			for ($i = 0; $i < count($uid_checkout_array); ++$i)
			{
			
				$uid_checkout_array[$i];
				$co_uinfo_sql = "SELECT f_name,l_name,uid from uinfo where uid='$uid_checkout_array[$i]'";

				$co_uinfo_result = mysqli_query($conn,$co_uinfo_sql);
				$row = mysqli_fetch_array($co_uinfo_result);
				echo $row['f_name'];
				if ($row['l_name'] != '') echo " ".$row['l_name'];
				$acion_url="window.location.href='checkelse.php?id=".$row['uid']."&dateid=".$currentdateid."'";
				?>		
				<input type="button" onclick =<?php echo $acion_url; ?> id = <?php echo $currentdateid;?> value ="Check In">
				<?php
				if ($i < count($uid_checkout_array)-1)
				{
					if (($i+1) %2==0)
					{
						echo "</br>";
					}
					else
						echo ", ";
				}
			}			
			?>
			</td>
		</tr>	
	<?php
		}
	}
	?>
</table>
<?php
include ('line.html'); 
include ('footer.php');
echo"</body>
	</html>";
?>