MERGE INTO [dbo].[Department] AS TARGET
USING (VALUES
	 (NEWID(), 'Web', 1)
	,(NEWID(), 'Mobile', 2)
	,(NEWID(), 'Desktop', 3)
	,(NEWID(), 'Embedded', 4)
	) AS SOURCE ([Id], [Name], [Floor])
ON SOURCE.[Name] = TARGET.[Name]
WHEN NOT MATCHED THEN
	INSERT ([Id], [Name], [Floor]) 
	VALUES (SOURCE.[Id], SOURCE.[Name], SOURCE.[Floor])
WHEN MATCHED THEN
	UPDATE SET
		[Name] = SOURCE.[Name],
		[Floor] = SOURCE.[Floor];