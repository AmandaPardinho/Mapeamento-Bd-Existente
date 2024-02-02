CREATE TABLE [actor] (
    [actor_id] int NOT NULL IDENTITY,
    [first_name] varchar(45) NULL,
    [last_name] varchar(45) NULL,
    [last_update] datetime2 NOT NULL,
    CONSTRAINT [PK_actor] PRIMARY KEY ([actor_id])
);
GO


