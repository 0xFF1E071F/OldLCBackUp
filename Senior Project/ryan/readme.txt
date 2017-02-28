bfv.sql creates the database.  Load it first.  It works.

bfv-last.sql creates indices.  Load it last (I think).  It is NOT in MySQL syntax yet.

*.txt contains raw data for the tables.  (Except readme.txt, which is this file!)

The files need to have all the initial stuff, comments plus "Copy tablename from stdin;" removed; and the trailing .\ at the end of file removed.  I have done this for 3 files, which are in the cleanedUp folder.

You load the files in MySQL like this:

LOAD DATA LOCAL INFILE 'P:\\ryan\\tref.txt' into table tref;

I note that they seem to have trailing whitespace; this may cause us problems later on -- I am not sure.

Another potential problem is that there are warnings while loading.  You can see those warnings by typing SHOW WARNINGS; after a command that gives a warning.  I think you'll need to keep a log of what those warnings are, in case they turn out to be important.

So once all these files are cleaned, and loaded into your database, we'll need to create those indices in bfv-last.sql.  It looks like the syntax needs changing.  I got this to work for tax -- not

CREATE INDEX taxonx ON tax USING btree (taxon);

but

CREATE INDEX taxonx ON tax (taxonx (15)) using btree;

The 15 is because MySQL said "You're using a text field, so you have to tell me how many characters to consider."  I arbitrarily chose 15.

At that point, we may have a working database!



