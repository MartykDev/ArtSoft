CREATE PROCEDURE [dbo].[spDeleteEmployee]
(
   @employeeId UNIQUEIDENTIFIER
)
AS
BEGIN

    DELETE E
    FROM [dbo].[Employee] AS E
    WHERE E.[Id] = @employeeId

END