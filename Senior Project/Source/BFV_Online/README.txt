This contains a complete dump of the contents of the BFV database (bfv_dump20031024_0149-2.sql) as well as SQL for re-creating the tables.
In addition, the Web App Components folder contains Java source code for the applet that receives, interprets and responds to the user requests.

All files are actually plain text files (except the one PDF).

BFV_codes.pdf:

This was scanned from a document from the old BFV office and represents their internal codes for special characters, used by their publisher (I guess). The relevant information from this file appears in the source code file BfvCsHtml.java

SQL commands, PostgreSQL database, and data:

The database consists of the four tables:  auths, ref, subj, tax    There is a "jnfull" table that contains full journal names, but it is not complete and I haven't been using it. The other tables listed in the file are prefixed by "t" or suffixed with "bak" and represent temporary tables that I used when loading the data and are not referenced by the apps. You do not need them.

Web App components, Java source files:

The Web App is a Java servlet --- The Apache web server hands off HTTP POST requests to the Apache-Tomcat applet server for processing if the HTML form targets a registered servlet (in this case, one called "BFV_Services"). The main part of the servlet (and what is called initially) is BfvQuery.java. This parses the input line, constructs the SQL queries, sends the results out for formatting, and produces the HTML output that is returned in response to the request. 

The bfvServletLib folder contains a set of utilities used by BfvQuery --- class definitions, formatting details, etc. These become bundled into a library in the Web App (hence the name) but are nothing but miscellaneous small Java code snippets. Significantly, though, one can alter the way that the applet handles formatting of special characters through changing files here.

John Damuth
(805)-770-3870
damuth@lifesci.ucsb.edu

January 30, 2013
