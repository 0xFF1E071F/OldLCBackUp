<table id="leadTable"  style="height: 100px">
				<tr>			
					<th id="TagsTable"> 
						<fieldset>
		<legend>Tags</legend>
		<form name="TagsForm" method="post" action="tag.php" onSubmit="return InputCheck(this)" >
		<p>
			<input type="checkbox" name="Animal" value="Animal">Animal
			<input type="checkbox" name="IT" value="IT">IT
			<input type="checkbox" name="Comic" value="Comic">Comic
			<input type="checkbox" name="Car" value="Car">Car
		</p>
		<p>
				<input type="submit" name="Refresh" value="Refresh" class="right" />
		</p>

		</form>
		</fieldset> 
					</th>	 
					<th id="userTable"> 
						<fieldset>
						<legend>Login</legend>
						<form name="loginForm" method="post" action="login.php" onSubmit="return InputCheck(this)" >
							
								<label for="username" class="label">Username:</label>
								<input id="username" name="$username" type="text" class="input" />
							
								<label for="password" class="label">password:</label>
								<input id="password" name="$password" type="password" class="input" /><br>
								<input type="submit" name="submit" value="Submit" class="right" />
								</form>
								<form METHOD="LINK" ACTION="regPage.php">
								<INPUT TYPE="submit" VALUE="Register">
								</form>					
		
						</fieldset>
					</th> 
				</tr> 
		 </table > 