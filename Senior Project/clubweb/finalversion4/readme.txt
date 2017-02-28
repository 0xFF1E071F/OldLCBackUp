----2015-12-01----
Add checkouts other people for admin users.
	add checkuser.php AND checkuserelse.php
	
Add reset password for super admin users
	add changeelsepw.php
	upadte updatepw.php add functions to change different user's pw

----OLD----
Changes:
Changed the conn.php to my db password

make a "db-with-defday-date&defday-isNOTEmpty.sql" in other folder. (date and defday have insert values)
make a "db-with-defday-date&defday-iEmpty.sql" in other folder. (date and defday are empty tables)
Add a new table defDay(date,weekday,isNew(key)), there is only 2 rows which isnew =0 and isnew =1 save as old date and  new date
weekday is 0=sunday 1=monday 2=tu 3=wen and so on.

make changes for sql backup files add "ON UPDATE CASCADE ON DELETE CASCADE" for foreign key, then we can delete

admin.php add new linker to change changedafday.php (default meeting date).
admin.php add new linker to change adminusers.php which can set up admin users and delete users.
move set admin user to this new page 
add delete users in this page

move script function to different file
i find if i put all of them in index, not work
also make $_GET to different file, when js not working 
it will show the red error message on web page 

Add something at end of autoupdate.php
this will edit the autoupdate.txt when autoupdate.php update the db
This will tell us what is the recent update in autoupdate.txt
also the modify time of autoupdate.txt is a timer to relod.php

also modify $weekday depends on db's dafday table
if we have new weekday then $weekday = new weekday

also make a new php called updateOldDate.php
This is work for updating the dates in database
it will change the exist dates to new dates if we changed the meet day
it be included in autoupdate.php (can comment it)
im not sure if this works fine.

a new bug: if we have empty db with dates tables;
autoupdate.php will add dates into dates table;
if the add date is today then it wont be added


add change password page which allow user to change password after login
(how about forget pw?)
after changed suc, logout user

also autoupdate.php will only be actived when user trying to login 
if the user already loged in the db will not be update
i think it should be updated when user trying to load the body.php or index.php 