namespace GitHubPagesTest.Services.Contract
{
    public interface ILocalStorageService
    {
        Task<string> GetFromLocalStorage(string key);

        Task SetLocalStorage(string key, string value);
    }
}
