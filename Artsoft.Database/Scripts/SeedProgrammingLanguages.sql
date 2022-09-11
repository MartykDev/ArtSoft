MERGE INTO [dbo].[ProgrammingLanguage] AS TARGET
USING (VALUES
	 (NEWID(), 'C#')
	,(NEWID(), 'Java Script')
	,(NEWID(), 'Python')
	,(NEWID(), 'Java')
	,(NEWID(), 'C++')
	,(NEWID(), 'F#')
	) AS SOURCE ([Id], [Name])
ON SOURCE.[Name] = TARGET.[Name]
WHEN NOT MATCHED THEN
	INSERT ([Id], [Name]) 
	VALUES (SOURCE.[Id], SOURCE.[Name])
WHEN MATCHED THEN
	UPDATE SET
		[Name] = SOURCE.[Name];