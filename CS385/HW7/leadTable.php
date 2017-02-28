<?php /* 
	Yu Fu
	cs395
	2014
	This is leadtable php 
	whihc shows tags and user center( login and logout)*/?>
<table id="leadTable">
<tr>			
	<th id="TagsTable"> 
		<fieldset>		
		<p>
			<?php  include 'tags.php';?>
		</p>
		</fieldset> 
		<p>
			<?php
			if(isset($_COOKIE['user_id']))
			{?>
			<form method = "post" action="postNew.php" onSubmit="return InputCheck(this)"> 
				<input type="submit" value="Post New" name="submit"/> 
				
			</form>
			<?php }?>
		</p>
					</th>	 
					<th id="userTable"> 
						<!--use $_COOKIE['user_id'] to decide if user loged--> 
						<?php 
						if(empty($_COOKIE['user_id']))
						{ 
							include 'login.php';
						} 
						else
						{
							include 'loged.php'; 
						?>
							<br /><form> 
						<?php
						}
						?> 
					</th> 
				</tr> 
		 </table > 