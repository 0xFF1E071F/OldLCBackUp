<S!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">

<head>
<meta content="text/html; charset=utf-8" http-equiv="Content-Type" />
<title>Untitled 1</title>
</head>

<body>
		
		<fieldset>
		<legend>Register</legend>
		<form name="RegForm" method="post" action="reg.php" onSubmit="return InputCheck(this)" >
			<p>
				<label for="username" class="label">Username:</label>
				<input id="username" name="$username" type="text" class="input" />
				<span>*,3-15long,a-z,0-9,_)</span>
			<p>
				<label for="password" class="label">password:</label>
				<input id="password" name="$password" type="password" class="input" />
				<span>(*>6)</span>
			<p>
				<label for="repass" class="label">PW_again</label>
				<input id="repass" name="$repw" type="password" class="input" />
			<p/>
				<input type="submit" name="submit1" value="Submit" class="left" />
				</form>
		</fieldset>
</body>

</html>
