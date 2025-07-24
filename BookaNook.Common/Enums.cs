namespace BookaNook.Common
{
    public enum DatabaseOperations
    {
        Failed = 0,
        SavedSuccessfully = 1,
        UnexpectedError = 2
    }

    public enum DatabaseErrorType
    {
        None = 0,
        System = 1,
        User = 2
    }
}
