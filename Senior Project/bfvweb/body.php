<!--
====================================================================
					    body.php
					  Nov 21.2015
					     Yu Fu
====================================================================
This is body of searh table
includes all search blanks
-->
<?php
echo"
	<table align='center'>
		<form action='resultPage.php' target='_blank' method='post'>
		<tr>
			<td colspan='6'>
			<p>Simple Search:</p>
			</td>
		</tr>
		";
		
//last name
echo "	
		<tr>
			<td colspan='1'>
				Last Name:
			</td>
			<td colspan='5'>
				<select name='lnop'>
					<option value='='>Same</option>
					<option value='!='>Not Same</option>
					<option value='like'>Like</option>
					<option value='not like'>Not Like</option>
				</select> 
				<input type='text' name='ln' size='30'>				
			</td>
		</tr>";
//subject
echo "	
		<tr>
			<td colspan='1'>
				Subject:
			</td>
			<td colspan='5'>
				<select name='sjop'>
					<option value='='>Same</option>
					<option value='notsame'>Not Same</option>
					<option value='like'>Like</option>
					<option value='not like'>Not Like</option>
				</select> 

				<input type='text' name='subj' size='30'>
		
			</td>
		</tr>";
//journal
echo "	
		<tr>
			<td colspan='1'>
				journal:
			</td>
			<td colspan='3'>
				<select name='jnop'>
					<option value='='>Same</option>
					<option value='!='>Not Same</option>
					<option value='like'>Like</option>
					<option value='not like'>Not Like</option>
				</select> 

				<input type='text' name='jn' size='30'>
			</td>
			<td colspan='1'>
				Year:
			</td>
			<td colspan='1'>  
				<select name='yrop'>
					<option value='='>Is</option>
					<option value='<'>Before</option>
					<option value='>'>After</option>
				</select> 
				<input type='text' name='year' size='2'>
			</td>
		</tr>";
//taxon
echo "	
		<tr>
			<td colspan='1'>
				Taxon:
			</td>
			<td colspan='5'>
				<select name='taxop'>
					<option value='='>Same</option>
					<option value='!='>Not Same</option>
					<option value='like'>Like</option>
					<option value='not like'>Not Like</option>
				</select> 

				<input type='text' name='taxon' size='30'>

			</td>
		</tr>";
//publisher
echo "	
		<tr>
			<td colspan='1'>
				Publisher:
			</td>
			<td colspan='5'>
				<select name='pubop'>
					<option value='='>Same</option>
					<option value='!='>Not Same</option>
					<option value='like'>Like</option>
					<option value='not like'>Not Like</option>
				</select> 
				<input type='text' name='pub' size='30'>		
			</td>
		</tr>";
//Advanced Query
echo "	
		<tr>
			<td colspan='1'>
				Advanced Query: 		
			</td>
			<td colspan='5'>
				<input type='text' name='query' size='80'>	
		
			</td>
		</tr>";
// button
echo "
		<tr>
			<td colspan='4'>
				To submit the query, hit return or press:
			</td>
			<td colspan='2'>
				<input type='submit' value='Search'>
			</td>
		</tr>
		</form>
	</table>
		";
?>