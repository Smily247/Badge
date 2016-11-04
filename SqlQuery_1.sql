CREATE TABLE USERS (
User_ID varchar(7),
User_NAME varchar(30),
EMAIL varchar(30),
USER_TYPE varchar(3),
PRIMARY KEY (User_ID)
)

CREATE TABLE BadgeType(
BT_Name varchar(30),
BT_Descript varchar(300), /* may need to use a bigger # than 300*/
BT_ID int,
PRIMARY KEY(BT_ID)
)


CREATE TABLE BadgeGiveType(
BGT_Name varchar(30),
BGT_Descript varchar(300),/* may need to use a bigger # than 300*/
BGT_ID int,
PRIMARY KEY (BGT_ID)
)

CREATE TABLE BADGE( 
Badge_Image varchar(50), 
Badge_RetireDate varchar(9),
Badge_ActivateDate varchar(9),
Badge_ID int NOT NULL,
Badge_Name varchar(40),
Badge_Descript varchar(300),/* may need to use a bigger # than 300*/
Badge_Status varchar(10),
BadgeType int,
BadgeGiveType int,
PRIMARY KEY (Badge_ID),
FOREIGN KEY (BadgeType) REFERENCES BadgeType(BT_ID),
FOREIGN KEY (BadgeGiveType) REFERENCES BadgeGiveType(BGT_ID)
)
CREATE TABLE BadgeTransaction(
Sender varchar(7),
Reciever varchar(7),
Badge_ID int,
BTrans_Date varchar(9),
Badge_comment varchar(300),/* may need to use a bigger # than 300*/
FOREIGN KEY (Sender) REFERENCES Users(User_ID),
FOREIGN KEY (Reciever) REFERENCES Users(User_ID),
FOREIGN KEY (Badge_ID) REFERENCES Badge(Badge_ID)
)



