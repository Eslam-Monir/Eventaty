--------------------------------------------------------
--  File created - Wednesday-April-26-2023   
--------------------------------------------------------
--------------------------------------------------------
--  DDL for Table CATEGORY
--------------------------------------------------------

  CREATE TABLE "CATEGORY" 
   (	"ID" NUMBER, 
	"NAME" VARCHAR2(20)
   ) ;
--------------------------------------------------------
--  DDL for Table COMMENTS
--------------------------------------------------------

  CREATE TABLE "COMMENTS" 
   (	"ID" NUMBER, 
	"TEXT" VARCHAR2(500), 
	"USER_ID" NUMBER, 
	"EVENT_ID" NUMBER
   ) ;
--------------------------------------------------------
--  DDL for Table EVENTS
--------------------------------------------------------

  CREATE TABLE "EVENTS" 
   (	"ID" NUMBER, 
	"NAME" VARCHAR2(50), 
	"DATES" VARCHAR2(20), 
	"TIMES" VARCHAR2(20), 
	"ATTENDEE_LIMIT" NUMBER, 
	"DESCRIPTION" VARCHAR2(20), 
	"CATEGORIES" VARCHAR2(20), 
	"LOCATION" NUMBER, 
	"STATUS" NUMBER
   ) ;
--------------------------------------------------------
--  DDL for Table EVENT_CATERGORY
--------------------------------------------------------

  CREATE TABLE "EVENT_CATERGORY" 
   (	"EVENT_ID" NUMBER, 
	"CAT_ID" NUMBER
   ) ;
--------------------------------------------------------
--  DDL for Table EVENT_SPONSERS
--------------------------------------------------------

  CREATE TABLE "EVENT_SPONSERS" 
   (	"EVENT_ID" NUMBER, 
	"SP_ID" NUMBER
   ) ;
--------------------------------------------------------
--  DDL for Table FAVORITE_CATEGORY
--------------------------------------------------------

  CREATE TABLE "FAVORITE_CATEGORY" 
   (	"CAT_ID" NUMBER, 
	"USER_ID" NUMBER
   ) ;
--------------------------------------------------------
--  DDL for Table PENDING_REQUEST
--------------------------------------------------------

  CREATE TABLE "PENDING_REQUEST" 
   (	"ID" NUMBER, 
	"USER_ID" NUMBER, 
	"EVENT_ID" NUMBER
   ) ;
--------------------------------------------------------
--  DDL for Table PLACE
--------------------------------------------------------

  CREATE TABLE "PLACE" 
   (	"ID" NUMBER, 
	"NAME" VARCHAR2(20), 
	"LOCATION" VARCHAR2(500), 
	"CAPACITY" NUMBER, 
	"AVAILABLE_TIME" VARCHAR2(20), 
	"STATUS" VARCHAR2(20)
   ) ;
--------------------------------------------------------
--  DDL for Table PLACEOWNER
--------------------------------------------------------

  CREATE TABLE "PLACEOWNER" 
   (	"ID" NUMBER, 
	"NAME" VARCHAR2(20)
   ) ;
--------------------------------------------------------
--  DDL for Table PLACEOWNER_PLACES
--------------------------------------------------------

  CREATE TABLE "PLACEOWNER_PLACES" 
   (	"PO_ID" NUMBER, 
	"PLACE_ID" NUMBER
   ) ;
--------------------------------------------------------
--  DDL for Table SPONSERS
--------------------------------------------------------

  CREATE TABLE "SPONSERS" 
   (	"ID" NUMBER, 
	"NAME" VARCHAR2(20), 
	"DESCRIPTION" VARCHAR2(500)
   ) ;
--------------------------------------------------------
--  DDL for Table USERS
--------------------------------------------------------

  CREATE TABLE "USERS" 
   (	"ID" NUMBER, 
	"NAME" VARCHAR2(20), 
	"PASSWORD" VARCHAR2(20), 
	"EMAIL" VARCHAR2(30)
   ) ;
--------------------------------------------------------
--  DDL for Table USER_CREATED_EVENTS
--------------------------------------------------------

  CREATE TABLE "USER_CREATED_EVENTS" 
   (	"USERID" NUMBER, 
	"EVENTID" NUMBER
   ) ;
--------------------------------------------------------
--  DDL for Table USER_ENROLLED_EVENTS
--------------------------------------------------------

  CREATE TABLE "USER_ENROLLED_EVENTS" 
   (	"USERID" NUMBER, 
	"EVENTID" NUMBER
   ) ;

---------------------------------------------------
--   DATA FOR TABLE USER_ENROLLED_EVENTS
--   FILTER = none used
---------------------------------------------------
REM INSERTING into USER_ENROLLED_EVENTS

---------------------------------------------------
--   END DATA FOR TABLE USER_ENROLLED_EVENTS
---------------------------------------------------

---------------------------------------------------
--   DATA FOR TABLE PLACEOWNER
--   FILTER = none used
---------------------------------------------------
REM INSERTING into PLACEOWNER

---------------------------------------------------
--   END DATA FOR TABLE PLACEOWNER
---------------------------------------------------

---------------------------------------------------
--   DATA FOR TABLE PENDING_REQUEST
--   FILTER = none used
---------------------------------------------------
REM INSERTING into PENDING_REQUEST

---------------------------------------------------
--   END DATA FOR TABLE PENDING_REQUEST
---------------------------------------------------

---------------------------------------------------
--   DATA FOR TABLE FAVORITE_CATEGORY
--   FILTER = none used
---------------------------------------------------
REM INSERTING into FAVORITE_CATEGORY

---------------------------------------------------
--   END DATA FOR TABLE FAVORITE_CATEGORY
---------------------------------------------------

---------------------------------------------------
--   DATA FOR TABLE PLACE
--   FILTER = none used
---------------------------------------------------
REM INSERTING into PLACE
Insert into PLACE (ID,NAME,LOCATION,CAPACITY,AVAILABLE_TIME,STATUS) values (2,'messi','october',20,'hm','ok');
Insert into PLACE (ID,NAME,LOCATION,CAPACITY,AVAILABLE_TIME,STATUS) values (3,'cr7','gzera',30,'hour','ok');

---------------------------------------------------
--   END DATA FOR TABLE PLACE
---------------------------------------------------

---------------------------------------------------
--   DATA FOR TABLE USER_CREATED_EVENTS
--   FILTER = none used
---------------------------------------------------
REM INSERTING into USER_CREATED_EVENTS

---------------------------------------------------
--   END DATA FOR TABLE USER_CREATED_EVENTS
---------------------------------------------------

---------------------------------------------------
--   DATA FOR TABLE COMMENTS
--   FILTER = none used
---------------------------------------------------
REM INSERTING into COMMENTS

---------------------------------------------------
--   END DATA FOR TABLE COMMENTS
---------------------------------------------------

---------------------------------------------------
--   DATA FOR TABLE CATEGORY
--   FILTER = none used
---------------------------------------------------
REM INSERTING into CATEGORY

---------------------------------------------------
--   END DATA FOR TABLE CATEGORY
---------------------------------------------------

---------------------------------------------------
--   DATA FOR TABLE EVENT_SPONSERS
--   FILTER = none used
---------------------------------------------------
REM INSERTING into EVENT_SPONSERS

---------------------------------------------------
--   END DATA FOR TABLE EVENT_SPONSERS
---------------------------------------------------

---------------------------------------------------
--   DATA FOR TABLE EVENT_CATERGORY
--   FILTER = none used
---------------------------------------------------
REM INSERTING into EVENT_CATERGORY

---------------------------------------------------
--   END DATA FOR TABLE EVENT_CATERGORY
---------------------------------------------------

---------------------------------------------------
--   DATA FOR TABLE USERS
--   FILTER = none used
---------------------------------------------------
REM INSERTING into USERS

---------------------------------------------------
--   END DATA FOR TABLE USERS
---------------------------------------------------

---------------------------------------------------
--   DATA FOR TABLE SPONSERS
--   FILTER = none used
---------------------------------------------------
REM INSERTING into SPONSERS

---------------------------------------------------
--   END DATA FOR TABLE SPONSERS
---------------------------------------------------

---------------------------------------------------
--   DATA FOR TABLE PLACEOWNER_PLACES
--   FILTER = none used
---------------------------------------------------
REM INSERTING into PLACEOWNER_PLACES

---------------------------------------------------
--   END DATA FOR TABLE PLACEOWNER_PLACES
---------------------------------------------------

---------------------------------------------------
--   DATA FOR TABLE EVENTS
--   FILTER = none used
---------------------------------------------------
REM INSERTING into EVENTS

---------------------------------------------------
--   END DATA FOR TABLE EVENTS
---------------------------------------------------
--------------------------------------------------------
--  Constraints for Table CATEGORY
--------------------------------------------------------

  ALTER TABLE "CATEGORY" ADD CONSTRAINT "CATEGORY_PK" PRIMARY KEY ("ID") ENABLE;
 
  ALTER TABLE "CATEGORY" MODIFY ("ID" NOT NULL ENABLE);
 
  ALTER TABLE "CATEGORY" MODIFY ("NAME" NOT NULL ENABLE);
--------------------------------------------------------
--  Constraints for Table COMMENTS
--------------------------------------------------------

  ALTER TABLE "COMMENTS" ADD CONSTRAINT "COMMENTS_PK" PRIMARY KEY ("ID") ENABLE;
 
  ALTER TABLE "COMMENTS" MODIFY ("ID" NOT NULL ENABLE);
--------------------------------------------------------
--  Constraints for Table EVENTS
--------------------------------------------------------

  ALTER TABLE "EVENTS" ADD CONSTRAINT "EVENTS_PK" PRIMARY KEY ("ID") ENABLE;
 
  ALTER TABLE "EVENTS" MODIFY ("ID" NOT NULL ENABLE);
 
  ALTER TABLE "EVENTS" MODIFY ("NAME" NOT NULL ENABLE);
 
  ALTER TABLE "EVENTS" MODIFY ("DATES" NOT NULL ENABLE);
 
  ALTER TABLE "EVENTS" MODIFY ("TIMES" NOT NULL ENABLE);
 
  ALTER TABLE "EVENTS" MODIFY ("STATUS" NOT NULL ENABLE);
--------------------------------------------------------
--  Constraints for Table EVENT_CATERGORY
--------------------------------------------------------

  ALTER TABLE "EVENT_CATERGORY" MODIFY ("EVENT_ID" NOT NULL ENABLE);
 
  ALTER TABLE "EVENT_CATERGORY" MODIFY ("CAT_ID" NOT NULL ENABLE);
--------------------------------------------------------
--  Constraints for Table EVENT_SPONSERS
--------------------------------------------------------

  ALTER TABLE "EVENT_SPONSERS" MODIFY ("EVENT_ID" NOT NULL ENABLE);
 
  ALTER TABLE "EVENT_SPONSERS" MODIFY ("SP_ID" NOT NULL ENABLE);
--------------------------------------------------------
--  Constraints for Table FAVORITE_CATEGORY
--------------------------------------------------------

  ALTER TABLE "FAVORITE_CATEGORY" MODIFY ("CAT_ID" NOT NULL ENABLE);
 
  ALTER TABLE "FAVORITE_CATEGORY" MODIFY ("USER_ID" NOT NULL ENABLE);

--------------------------------------------------------
--  Constraints for Table PLACE
--------------------------------------------------------

  ALTER TABLE "PLACE" ADD CONSTRAINT "PLACE_PK" PRIMARY KEY ("ID") ENABLE;
 
  ALTER TABLE "PLACE" MODIFY ("ID" NOT NULL ENABLE);
 
  ALTER TABLE "PLACE" MODIFY ("NAME" NOT NULL ENABLE);
 
  ALTER TABLE "PLACE" MODIFY ("LOCATION" NOT NULL ENABLE);
 
  ALTER TABLE "PLACE" MODIFY ("CAPACITY" NOT NULL ENABLE);
--------------------------------------------------------
--  Constraints for Table PLACEOWNER
--------------------------------------------------------

  ALTER TABLE "PLACEOWNER" ADD CONSTRAINT "PLACEOWNER_PK" PRIMARY KEY ("ID") ENABLE;
 
  ALTER TABLE "PLACEOWNER" MODIFY ("ID" NOT NULL ENABLE);
 
  ALTER TABLE "PLACEOWNER" MODIFY ("NAME" NOT NULL ENABLE);
--------------------------------------------------------
--  Constraints for Table PLACEOWNER_PLACES
--------------------------------------------------------

  ALTER TABLE "PLACEOWNER_PLACES" MODIFY ("PO_ID" NOT NULL ENABLE);
--------------------------------------------------------
--  Constraints for Table SPONSERS
--------------------------------------------------------

  ALTER TABLE "SPONSERS" ADD CONSTRAINT "SPONSERS_PK" PRIMARY KEY ("ID") ENABLE;
 
  ALTER TABLE "SPONSERS" MODIFY ("ID" NOT NULL ENABLE);
 
  ALTER TABLE "SPONSERS" MODIFY ("NAME" NOT NULL ENABLE);
 
  ALTER TABLE "SPONSERS" MODIFY ("DESCRIPTION" NOT NULL ENABLE);
--------------------------------------------------------
--  Constraints for Table USERS
--------------------------------------------------------

  ALTER TABLE "USERS" MODIFY ("ID" NOT NULL ENABLE);
 
  ALTER TABLE "USERS" MODIFY ("NAME" NOT NULL ENABLE);
 
  ALTER TABLE "USERS" MODIFY ("PASSWORD" NOT NULL ENABLE);
 
  ALTER TABLE "USERS" ADD CONSTRAINT "USERS_PK" PRIMARY KEY ("ID") ENABLE;


--------------------------------------------------------
--  DDL for Index CATEGORY_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "CATEGORY_PK" ON "CATEGORY" ("ID") 
  ;
--------------------------------------------------------
--  DDL for Index COMMENTS_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "COMMENTS_PK" ON "COMMENTS" ("ID") 
  ;
--------------------------------------------------------
--  DDL for Index EVENTS_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "EVENTS_PK" ON "EVENTS" ("ID") 
  ;
--------------------------------------------------------
--  DDL for Index PLACEOWNER_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "PLACEOWNER_PK" ON "PLACEOWNER" ("ID") 
  ;
--------------------------------------------------------
--  DDL for Index PLACE_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "PLACE_PK" ON "PLACE" ("ID") 
  ;
--------------------------------------------------------
--  DDL for Index SPONSERS_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "SPONSERS_PK" ON "SPONSERS" ("ID") 
  ;
--------------------------------------------------------
--  DDL for Index USERS_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "USERS_PK" ON "USERS" ("ID") 
  ;

--------------------------------------------------------
--  Ref Constraints for Table COMMENTS
--------------------------------------------------------

  ALTER TABLE "COMMENTS" ADD CONSTRAINT "COMMENTS_EVENTS_FK1" FOREIGN KEY ("EVENT_ID")
	  REFERENCES "EVENTS" ("ID") ON DELETE CASCADE ENABLE;
 
  ALTER TABLE "COMMENTS" ADD CONSTRAINT "COMMENTS_USERS_FK1" FOREIGN KEY ("USER_ID")
	  REFERENCES "USERS" ("ID") ON DELETE CASCADE ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table EVENTS
--------------------------------------------------------

  ALTER TABLE "EVENTS" ADD CONSTRAINT "EVENTS_PLACE_FK1" FOREIGN KEY ("LOCATION")
	  REFERENCES "PLACE" ("ID") ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table EVENT_CATERGORY
--------------------------------------------------------

  ALTER TABLE "EVENT_CATERGORY" ADD CONSTRAINT "EVENT_CATERGORY_EVENTS_FK1" FOREIGN KEY ("EVENT_ID")
	  REFERENCES "EVENTS" ("ID") ON DELETE CASCADE ENABLE;
 
  ALTER TABLE "EVENT_CATERGORY" ADD CONSTRAINT "EVENT_CATERGORY_USERS_FK1" FOREIGN KEY ("CAT_ID")
	  REFERENCES "CATEGORY" ("ID") ON DELETE CASCADE ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table EVENT_SPONSERS
--------------------------------------------------------

  ALTER TABLE "EVENT_SPONSERS" ADD CONSTRAINT "EVENT_SPONSERS_EVENTS_FK1" FOREIGN KEY ("EVENT_ID")
	  REFERENCES "EVENTS" ("ID") ON DELETE CASCADE ENABLE;
 
  ALTER TABLE "EVENT_SPONSERS" ADD CONSTRAINT "EVENT_SPONSERS_SPONSERS_FK1" FOREIGN KEY ("EVENT_ID")
	  REFERENCES "SPONSERS" ("ID") ON DELETE CASCADE ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table FAVORITE_CATEGORY
--------------------------------------------------------

  ALTER TABLE "FAVORITE_CATEGORY" ADD CONSTRAINT "FAVORITE_CATEGORY_CATEGOR_FK1" FOREIGN KEY ("CAT_ID")
	  REFERENCES "CATEGORY" ("ID") ON DELETE CASCADE ENABLE;
 
  ALTER TABLE "FAVORITE_CATEGORY" ADD CONSTRAINT "FAVORITE_CATEGORY_USERS_FK1" FOREIGN KEY ("CAT_ID")
	  REFERENCES "USERS" ("ID") ON DELETE CASCADE ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table PENDING_REQUEST
--------------------------------------------------------

  ALTER TABLE "PENDING_REQUEST" ADD CONSTRAINT "PENDING_REQUEST_EVENTS_FK1" FOREIGN KEY ("EVENT_ID")
	  REFERENCES "EVENTS" ("ID") ON DELETE CASCADE ENABLE;
 
  ALTER TABLE "PENDING_REQUEST" ADD CONSTRAINT "PENDING_REQUEST_USERS_FK1" FOREIGN KEY ("USER_ID")
	  REFERENCES "USERS" ("ID") ON DELETE CASCADE ENABLE;


--------------------------------------------------------
--  Ref Constraints for Table PLACEOWNER_PLACES
--------------------------------------------------------

  ALTER TABLE "PLACEOWNER_PLACES" ADD CONSTRAINT "PLACEOWNER_PLACES_PLACEOW_FK1" FOREIGN KEY ("PO_ID")
	  REFERENCES "PLACEOWNER" ("ID") ON DELETE CASCADE ENABLE;
 
  ALTER TABLE "PLACEOWNER_PLACES" ADD CONSTRAINT "PLACEOWNER_PLACES_PLACE_FK1" FOREIGN KEY ("PLACE_ID")
	  REFERENCES "PLACE" ("ID") ON DELETE CASCADE ENABLE;


--------------------------------------------------------
--  Ref Constraints for Table USER_CREATED_EVENTS
--------------------------------------------------------

  ALTER TABLE "USER_CREATED_EVENTS" ADD CONSTRAINT "USER_CREATED_USER_EVENTS_FK1" FOREIGN KEY ("EVENTID")
	  REFERENCES "EVENTS" ("ID") ENABLE;
 
  ALTER TABLE "USER_CREATED_EVENTS" ADD CONSTRAINT "USER_CREATED_USER_USERS_FK1" FOREIGN KEY ("USERID")
	  REFERENCES "USERS" ("ID") ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table USER_ENROLLED_EVENTS
--------------------------------------------------------

  ALTER TABLE "USER_ENROLLED_EVENTS" ADD CONSTRAINT "USER_ENROLLED_EVENTS_EVEN_FK1" FOREIGN KEY ("USERID")
	  REFERENCES "EVENTS" ("ID") ON DELETE CASCADE ENABLE;
 
  ALTER TABLE "USER_ENROLLED_EVENTS" ADD CONSTRAINT "USER_ENROLLED_EVENTS_USER_FK1" FOREIGN KEY ("USERID")
	  REFERENCES "USERS" ("ID") ON DELETE CASCADE ENABLE;
--------------------------------------------------------
--  DDL for Procedure ID_CHANGE
--------------------------------------------------------
set define off;

  CREATE OR REPLACE PROCEDURE "ID_CHANGE" 
  (old_id IN number,new_id IN number)
is
  begin 
  update emp set empno =new_id
  where empno=old_id;
END;

/

