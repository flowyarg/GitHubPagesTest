namespace GitHubPagesTest.Services.Contract
{
    public interface IFirebaseDbService
    {
        Task WriteCount(string data);

        Task<string> ReadCounts();
    }
}
