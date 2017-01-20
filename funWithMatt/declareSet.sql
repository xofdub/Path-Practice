

DECLARE

	@ExerciseType NVARCHAR(40),
	@Reps INT,
	@ExcerciseDay DATE,
	@UserIDFK INT


	SET @ExerciseType='Bench Press'
	SET @Reps=10
	SET @ExcerciseDay=GETDATE
	SET @UserIDFK=1

INSERT Workouts

	ExerciseType,
	Reps,
	ExerciseDay,
	UserIDFK





VALUES

	@ExerciseType,
	@Reps,
	@ExerciseDay,
	@UserIDFK 


	