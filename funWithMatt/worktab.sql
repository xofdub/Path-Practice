CREATE TABLE Workouts
(
	WorkoutID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	ExerciseType NVARCHAR(40) NOT NULL,
	Reps INT NOT NULL,
	ExerciseDay DATE NOT NULL,
	UserIDFK INT

)
