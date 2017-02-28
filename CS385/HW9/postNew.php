<?php /* 
	Yu FU
	cs385
	2014
	postsNew.php 
	which user can fill in information and posts*/?>
<S!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">

<head>
	<link href="style.css" rel="stylesheet" type="text/css">
	<title>Post New</title>
</head>
<body>
<div class="contentAreas">
		<fieldset>
		<legend>POST NEW</legend>
		<form name="postForm" method="post" action="post.php" onSubmit="return InputCheck(this)" >
			<p>
				<label for="tilte" class="label">Title:</label>
				<input id="title" name="title" type="text" class="input" />
			<p>
				<label for="content" class="label">Content:</label><br/>
				<textarea name="content" id="text_comment_area" Onkeyup="surplus_num(200);" 
					onKeyPress="surplus_num(200);" onKeyDown="surplus_num(200);" 
					onpropertychange="if(value.length>200) value=value.substr(0,200)" 
					maxlength="200" resize= "none"
					></textarea>
			<p><label for="tag" class="label">Tag:</label>
				<input id="tag" name="tag" type="text" class="input" />

			<p/>
				<input type="submit" name="post" value="Post" class="middle" />
		</form>
		</fieldset>
	</div>
</body>

</html>
