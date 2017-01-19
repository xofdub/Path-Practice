CREATE TABLE Awards
(

	awardID INT IDENTITY (1,1) NOT NULL,
	awardType NVARCHAR(100) NOT NULL,
	awardLocation NVARCHAR (255),
	volunteerIDFK INT,
	jobIDFK INT,
	educationIDFK INT,
	proDevIDFK INT

)
