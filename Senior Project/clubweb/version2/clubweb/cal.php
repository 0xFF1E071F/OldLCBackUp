<!--
--------------------------------------------
			   cal.php
				Yu Fu
			  2015-10-31
--------------------------------------------
This php creates calender frame
show all dates
give number of checkout user each day
give check out/in button for user
show users who is coming each day
-->


<table>
	<tr>
		<td >
			<fieldset style="min-width: 600px;">
				<legend>Calendar</legend>
				<!--reload the date inside table-->
				<?php include('reload.php'); ?>
					<table class="calender">
						<tr >
							<td class="datetitle">Dates</td>
							<td class="buttitle">Number<br>checked<br>out</td>
							<td class="contitle"></td>
							<td class="nametitle">Who's coming?</td>
						<!--date-->
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
						?>
						<tr>
							<td class="date">
							<?php
								// print dates from database
								$currentdateid = $daterow['id'];
								echo date('M-d-Y', $daterow['date']);
								$sql_uid = "SELECT userId from checkouts where dateId='$currentdateid'";
								$result_uid = mysqli_query($conn,$sql_uid);
							?>
							</td>
											
							<!--check out Number -->
							<td class="con">
							<?php
								//print how many user checked out this day
								$uid_checkout_array = array();
								while($row_uid = mysqli_fetch_array($result_uid)) 
								{
									array_push($uid_checkout_array, $row_uid['userId']);
								}
								echo $uid_count=count($uid_checkout_array);
							?>
							</td>

							<!--button-->
							<td class="but">
								<?php 
								//if date older than today, no checkout button
								if($daterow['date']>=strtotime("today-1day"))
								{
								?>

								<?php
								// set button action as
								// give checkuser.php 
								// user id, date id
								$acion_url="window.location.href='checkuser.php?id=".$myid."&dateid=".$currentdateid."'";
								?>	
								
								<input type="button" onclick =<?php echo $acion_url; ?> id = <?php echo $currentdateid;?> value ="notset">
								<!--i use js to control the text on button -->
								<script type="text/javascript">
								// set the defaul("notset") to co/ci 
								// denpend on if i can find user id in database
								if ($("#"+<?php echo $currentdateid;?>).val()== "notset")
								{
									<?php
									// if user is not in checkout list
									if(!in_array($myid,$uid_checkout_array))
									{
									//print button is check out
									?>	
										document.getElementById(<?php echo $currentdateid;?>).value="Check\nOut";
									
									<?php
									}
									// if user is in checkout list
									else if (in_array($myid,$uid_checkout_array))
									{
									//print button is check in
									?>
										document.getElementById(<?php echo $currentdateid;?>).value="Check\nIn";
									<?php
									}
									?>
								}
								
								// get update of dateid and ci/co from updatedates.php 
								// and reset the text on button
								<?php											
								if (isset($_GET['status']) && isset($_GET['dateid']))
								{
									if ($_GET['status']=="co")
									{
								?>
									document.getElementById(<?php echo $_GET['dateid'];?>).value="Check\nOut";
								<?php
									}
									else if ($_GET['status']=="ci")
									{
								?>
									document.getElementById(<?php echo $_GET['dateid'];?>).value="Check\nIn";
								<?php		
									}
								}

								unset($_GET['dateid']);
								?>
								</script>
							</input> 
							<?php 
							}
							?>
								
							</td>
							
							<!--name list-->
							<td class="name" >
							<?php
								//select name from database userinfo
								$sql_uinfo = "SELECT id,f_name,l_name,uid from uinfo";
								$result_uinfo = mysqli_query($conn,$sql_uinfo);
								// get last row from uinfo
								$sql_uLastID="SELECT id FROM uinfo ORDER BY id DESC LIMIT 1;";
								$result_uLastID = mysqli_query($conn,$sql_uLastID);
								$row_uLastID=mysqli_fetch_array($result_uLastID);

								while($row_uid = mysqli_fetch_array($result_uinfo)) 
								{	
									//old
									// do not print the superadmin with username 'admin' by default 
									// and its id is 1
									//new
									// i replace to check if it is a admin by id=1 to f_name = admin
									// adv: id=1 can be not admin 
									if (!in_array($row_uid['uid'],$uid_checkout_array) && $row_uid['f_name']!="admin")
									{
										echo $row_uid['f_name']." ".$row_uid['l_name'];
										if ($row_uid['id']!=$row_uLastID['id'] )
											echo ",";
									}
								}
							?>
							</td>
						</tr>
						<?php
						}
						//mysqli_close($conn);
					?>
				</table>
				<?php
				//show result of users' action
					if (isset($_GET['status']))
					{
						if ($_GET['status']=="ci")
							echo "You have checked out successful!";
						if ($_GET['status']=="co")
							echo "You have checked in successful!";
					}
					unset($_GET['status']);
				?>
			</fieldset>
		</td>
	</tr>
</table>
