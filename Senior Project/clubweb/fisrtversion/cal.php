<!--
--------------------------------------------
			   cal.php
				Yu Fu
			  2015-10-3
--------------------------------------------
This php creates calender frame
-->

<script language="javascript" type="text/javascript" src="jquery\jquery.js"></script>
<script language="javascript" type="text/javascript" src="jquery\myJS.js">
setTimeout('myrefresh()',60000);
</script>

<body>
<table>
	<tr>
		<td >
			<fieldset style="width:600px;">
				<legend>Calender</legend>
					<table class="calender">
						<tr >
							<td class="datetitle">date</td>
							<td class="contitle">CON</td>
							<td class="buttitle">Button</td>
							<td class="nametitle">Name who will come</td>
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
								$currentdateid = $daterow['id'];
								echo date('M-d-Y', $daterow['date']);
								$sql_uid = "SELECT userId from checkouts where dateId='$currentdateid'";
								$result_uid = mysqli_query($conn,$sql_uid);
							?>
							</td>
						
							<!--check out -->
							<td class="con">
							<?php
								$uid_array = array();
								while($row_uid = mysqli_fetch_array($result_uid)) 
								{
									array_push($uid_array, $row_uid['userId']);
								}
								echo $uid_count=count($uid_array);
							?>
							</td>
						
							<!--button-->
							<td class="but">
								<?php 
								//if date older than today, not checkout button
								if($daterow['date']>=strtotime("today-1day"))
								{
								?>
								<button type="button" onclick="clickFunction(this,<?php echo $myid;?>)" class="btn" id="<?php echo $currentdateid; ?>" value="notset">	
									<script type='text/javascript'>
										if ($("#"+<?php echo $currentdateid;?>).val()== "notset")
										{
											<?php
											if(!in_array($myid,$uid_array))
											{
											?>				
												$("button").val("co");
											<?php
											}
											else if (in_array($myid,$uid_array))
											{
											?>
												$("button").val("ci");
											<?php
											}
											?>
										}
										
										if($("#"+<?php echo $currentdateid;?>).val()=="co")
											document.write("CheckOut");
										else if($("#"+<?php echo $currentdateid;?>).val()=="ci")
											document.write("CheckIn");	
									</script>
								</button>	
								<?php 
								}
								?>
							</td>
							
							<!--name list-->
							<td class="name" >
							<?php
								$sql_uinfo = "SELECT f_name,l_name,uid from uinfo";
								$result_uinfo = mysqli_query($conn,$sql_uinfo);
								while($row_uid = mysqli_fetch_array($result_uinfo)) 
								{
									if (!in_array($row_uid['uid'],$uid_array) && $row_uid['uid']!=1)
										echo $row_uid['f_name']." ".$row_uid['l_name'].",";
								}
							?>
							</td>

						</tr>
						<?php
						}
						mysqli_close($conn);
					?>
				</table>
			</fieldset>
		</td>
	</tr>
</table>

