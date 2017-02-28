<?php /* 
	Yu Fu
	CS385
	2014
	searchPage.php
	which is user to search posts
*/?>

<form name="searchForm" method="post" action="<?php echo $_SERVER['PHP_SELF'];?>" onSubmit="return InputCheck(this)" >
	<p>
		<label for="username" class="label">Search Title for posts:</label>
		<input id="searchKey" name="searchKey" type="text" class="input" />
	<p/>
		<input type="submit" name="Search" value="Search" class="left" />
</form>

