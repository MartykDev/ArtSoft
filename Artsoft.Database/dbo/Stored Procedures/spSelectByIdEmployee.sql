CREATE PROCEDURE [dbo].[spSelectByIdEmployee]
(
   @employeeId UNIQUEIDENTIFIER
)
AS
BEGIN

    SELECT *
    FROM [dbo].[vEmployee] AS E
    WHERE E.[Id] = @employeeId

END