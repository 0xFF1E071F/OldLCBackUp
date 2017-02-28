<?php /* 
	Yu Fu
	CS385
	2014
	register.php
	which is user register page
*/?>
<link href="style.css" rel="stylesheet" type="text/css">
<div class="contentAreas">
		<fieldset>
		<legend>Register</legend>
		<form name="RegForm" method="post" action="reg.php" onSubmit="return InputCheck(this)" >
			<p>
				<label for="username" class="label">Username:</label>
				<input id="username" name="username" type="text" class="input" />
				<span>*,3-15long,a-z,0-9,_)</span>
			<p>
				<label for="password" class="label">password:</label>
				<input id="password" name="password" type="password" class="input" />
				<span>(*>6)</span>
			<p>
				<label for="repw" class="label">PW_again</label>
				<input id="repw" name="repw" type="password" class="input" />
			<p/>
				<input type="submit" name="Register" value="Submit" class="left" />
				<input type="submit" name="Cancel" value="Cancel" class="left" />
			</form>
			</fieldset>
</div>
