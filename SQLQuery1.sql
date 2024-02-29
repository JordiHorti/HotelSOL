CREATE TABLE user_table(
	user_id INT NOT NULL IDENTITY(1,1),
	username VARCHAR(20),
	password VARCHAR(30),
	user_role INT,
	PRIMARY KEY (user_id)
);