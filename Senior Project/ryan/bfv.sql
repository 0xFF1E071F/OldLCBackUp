--
-- Selected TOC Entries:
--
-- \connect - osirisdba

drop database if exists bfv;
create database bfv;
use             bfv;

--
-- TOC Entry ID 2 (OID 16558)
--
-- Name: auths Type: TABLE Owner: osirisdba
--
drop table if exists auths;

CREATE TABLE auths (
	serau text,
	au text,
	fn text,
	role character(1),
	rid integer,
	aorder integer
);

--
-- TOC Entry ID 3 (OID 16563)
--
-- Name: ref Type: TABLE Owner: osirisdba
--

drop table if exists ref;
CREATE TABLE ref (
	rid integer,
	ti text,
	date text,
	jn text,
	jnfk text,
	vo text,
	pg text,
	pub text,
	type character(2),
	edvo text,
	trans text,
	tt text,
	ts text,
	ed text
);

--
-- TOC Entry ID 4 (OID 16568)
--
-- Name: subj Type: TABLE Owner: osirisdba
--
drop table if exists subj;
CREATE TABLE subj (
	su text,
	rid integer
);

--
-- TOC Entry ID 5 (OID 16573)
--
-- Name: tax Type: TABLE Owner: osirisdba
--

drop table if exists tax;
CREATE TABLE tax (
	taxon text,
	rid integer
);

--
-- TOC Entry ID 6 (OID 16578)
--
-- Name: jnfull Type: TABLE Owner: osirisdba
--

drop table if exists jnfull;
CREATE TABLE jnfull (
	jnfk text,
	fulljname text,
	ppub text,
	pub text
);

--
-- TOC Entry ID 7 (OID 1144892)
--
-- Name: tref Type: TABLE Owner: osirisdba
--

drop table if exists tref;
CREATE TABLE tref (
	rid integer,
	type character(2) NOT NULL,
	date text,
	ti text,
	jn text,
	vo text,
	pg text,
	pub text,
	trans text,
	tt text,
	ts text,
	jnfk text,
	ed text,
	edvo text
);

--
-- TOC Entry ID 8 (OID 1153543)
--
-- Name: tauth Type: TABLE Owner: osirisdba
--

drop table if exists tauth;
CREATE TABLE tauth (
	rid integer,
	serau text,
	au text,
	fn text,
	aorder integer,
	role character(1)
);

--
-- TOC Entry ID 9 (OID 1153548)
--
-- Name: tsubj Type: TABLE Owner: osirisdba
--
drop table if exists tsubj;
CREATE TABLE tsubj (
	rid integer NOT NULL,
	su text
);

--
-- TOC Entry ID 10 (OID 1153553)
--
-- Name: ttax Type: TABLE Owner: osirisdba
--
drop table if exists ttax;
CREATE TABLE ttax (
	rid integer NOT NULL,
	taxon varchar(255)
);

--
-- TOC Entry ID 11 (OID 3663394)
--
-- Name: refbak Type: TABLE Owner: osirisdba
--
drop table if exists refbak;
CREATE TABLE refbak (
	rid integer,
	ti text,
	date text,
	jn text,
	jnfk text,
	vo text,
	pg text,
	pub text,
	type character(2),
	edvo text,
	trans text,
	tt text,
	ts text,
	ed text
);

--
-- TOC Entry ID 12 (OID 3784043)
--
-- Name: authsbak Type: TABLE Owner: osirisdba
--
drop table if exists authsbak;
CREATE TABLE authsbak (
	serau text,
	au text,
	fn text,
	role character(1),
	rid integer,
	aorder integer
);

--
-- TOC Entry ID 13 (OID 3929356)
--
-- Name: subjbak Type: TABLE Owner: osirisdba
--
drop table if exists subjbak;
CREATE TABLE subjbak (
	su text,
	rid integer
);

--
-- TOC Entry ID 14 (OID 4193725)
--
-- Name: taxbak Type: TABLE Owner: osirisdba
--
drop table if exists taxbak;
CREATE TABLE taxbak (
	taxon text,
	rid integer
);
