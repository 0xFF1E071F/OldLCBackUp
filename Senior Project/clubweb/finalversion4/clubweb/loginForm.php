<!-- 
--------------------------------------------
			 loginForm.php
				Yu Fu and Will Briggs
			  2015-10-3, updates by Briggs 2015-11-13
--------------------------------------------
this is login form
-->
<?php 

	function loginForm ()
	{
echo <<<END
<script language=JavaScript>
function InputCheck(LoginForm)
{
  if (LoginForm.username.value == "" )
  {
    alert("Username can not be empty!");
    LoginForm.username.focus();
    return (false);
  }
  if (LoginForm.password.value == "")
  {
    alert("Must have password!");
    LoginForm.password.focus();
    return (false);
  }

}
</script>

<table class="login">
	<tr>
		<td >
			<fieldset>
			<legend>Login</legend>
				<form name="LoginForm" method="post" onSubmit="return InputCheck(this)" action="index.php" >
					<p>
						<label for="username" class="label">Username:</label>
						<input id="username" name="username" type="text" class="input" />
					</p>
					<p>
						<label for="password" class="label">Password:</label>
						<input id="password" name="password" type="password" class="input" />
					</p>
					<p>
						<input type="submit" name="submit" id= "submit" value=" Log in "/>
					</p>
					
				</form>
			</fieldset>
		</td>
	</tr>
</table>
END;

	}
?>