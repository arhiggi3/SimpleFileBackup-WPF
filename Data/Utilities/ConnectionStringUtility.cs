using Microsoft.Data.Sqlite;

namespace Data.Utilities
{
    public static class ConnectionStringUtility
    {
        const string DbName = "profileData.db";
        const string CoName = ".simple";
        const string ProjectName = "SimpleBackUp";
        public static string BuildConnectionString()
        {
            var builder = new SqliteConnectionStringBuilder
            {
                DataSource = GetDataSource()
            };
            return builder.ToString();
        }

        static string GetDataSource()
        {
            var userDataFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            var appDataFolder = Path.Combine(userDataFolderPath, CoName, ProjectName);
            Directory.CreateDirectory(appDataFolder);
            var dbPath = Path.Combine(appDataFolder, DbName);
            return dbPath;
        }
    }
}
