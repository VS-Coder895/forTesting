USE Car_Rental_DB;

exec sp_rename 'dbo.EnginTypes','EngineTypes'

exec sp_rename 'dbo.EngineTypes.EnginTypeID','EngineTypeID', 'COLUMN'


