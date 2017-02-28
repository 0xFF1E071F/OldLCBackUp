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
<?php
	include ('weekday.php');
	// get connection
	require_once 'conn.php'; 
?>


<table>
	<tr>
		<td >
			<fieldset style="min-width: 600px;">
				<legend>Calendar</legend>
				<!--reload the date inside table-->
				<?php //include('reload.php'); ?>
					<table class="calender">
						<!--load the recent meet day change-->
						<tr>
							<?php
							// show every one the meet day has been changed
								$get_old="select * from defday where isnew = 0";
								$get_new="select * from defday where isnew = 1";
								$old_day = mysqli_query($conn,$get_old); 
								$new_day = mysqli_query($conn,$get_new); 
								if(mysqli_num_rows($old_day)==1 &&mysqli_num_rows($new_day)==1)
								{
									$old= mysqli_fetch_array($old_day); 
									$new= mysqli_fetch_array($new_day);
									echo '<span class="messageForDate">';
									$today=strtotime("today");
									// if not the same meet day and 
									// also we are not after that changed date
									if ($new['weekday']!=$old['weekday']&&$today<$new['date'])
									{
										echo "Starting on ".date('M-d-Y',$new['date']).", meetings are now on ".weekday($new['weekday'])." of the week";
										echo " instead of ".weekday($old['weekday']);
										echo ".";
									}
									
									echo "</span>";
								}
							?>
						</tr>
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
								if($daterow['date']>=strtotime("today"))
								//if($daterow['date']>=strtotime("today-1day"))
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
								
								//select names from database userinfo
								$sql_uinfo = "SELECT id,f_name,l_name,uid from uinfo ORDER BY f_name;";
								$result_uinfo = mysqli_query($conn,$sql_uinfo);
								
								//WSB: problem -- we don't know if there's anyone to print after this until we print it
								//so we have to count non-checked-out members BEFORE entering this loop.
								//Problem:  mysqli_fetch_array destroys the array
								//Solution: ...?
								
								//Convert query result to an array
								$rows = mysqli_fetch_all ($result_uinfo, MYSQLI_ASSOC);
								
								//Now extract all the names that aren't checked out, put 'em in $stillComing
								// We must initialize $stillComing each time or we'll get last date's
								// entries
								$stillComing = [];
								foreach ($rows as $row)
									if (! in_array ($row['uid'],$uid_checkout_array))
										$stillComing[] = $row;

								//Finally, print each element of $stillComing.  Put commas after
								// all but last entry.
								for ($i = 0; $i < count($stillComing); ++$i)
								{
									$row = $stillComing[$i];
									echo $row['f_name'];
									if ($row['l_name'] != '') echo " ".$row['l_name'];
									
									if ($i < count($stillComing)-1)
										echo ", ";
								}								
							?>
							</td>
						</tr>
						<?php
						}
						//mysqli_close($conn);
					?>
				</table>
			</fieldset>
		</td>
	</tr>
</table>
