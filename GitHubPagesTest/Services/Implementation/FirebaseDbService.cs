using Firebase.Database;
using Firebase.Database.Query;
using GitHubPagesTest.Services.Contract;

namespace GitHubPagesTest.Services.Implementation
{
    public class FirebaseDbService : IFirebaseDbService
    {
        private const string DATABASE_BASE_URL = "https://mongodb-f5343-default-rtdb.europe-west1.firebasedatabase.app/";
        private const string COUNTERS_CHILD_RESOURCE_NAME = "counters";

        private readonly FirebaseClient _client;
        private readonly ChildQuery _countersQuery;
        private bool disposedValue;

        public FirebaseDbService()
        {
            _client = new FirebaseClient(DATABASE_BASE_URL);
            _countersQuery = _client.Child(COUNTERS_CHILD_RESOURCE_NAME);
        }


        public async Task WriteCount(string data)
        {
            await _countersQuery.PutAsync(data);
        }

        public async Task<string> ReadCounts()
        {
            var result = await _countersQuery.OnceSingleAsync<string>();
            return result ?? string.Empty;
        }
    }
}
