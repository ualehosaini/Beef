-- Migration Script

BEGIN TRANSACTION

ALTER TABLE [Demo].[Person]
  ADD EyeColorCode NVARCHAR(50) NULL
	
COMMIT TRANSACTION