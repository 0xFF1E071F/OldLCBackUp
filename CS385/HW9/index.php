<?php /* 
	Yu FU
	cs385
	2014
	This is index php */?>
<!DOCTYPE html>
<html>
<head>
	<link href="style.css" rel="stylesheet" type="text/css">
	<title>Collect ur Likes</title>
	</head>

<body>
	<div class="contentAreas">
		<?php include 'header.php';?>
		<?php include 'leadTable.php';?>
		
		<table id="middlePart">
	   		<tr>
	   			<td id="middleTable" valign="top">		
					<?php include 'midTable.php';?>
					</td>	   				
	   			<td id="right-sidebar" valign="top">
					<?php  include 'rightSide.php';?>
					</td>
				</tr>
			</table>
		<table id="footer">
			<?php  	include 'footer.php'?>
			</table>	
		</div>
</body>
</html>
