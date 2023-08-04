

namespace MauiSqLiteConnection.Utilities
{
    public static class PathDB
    {
        public static string GetPath(string nameDB) {
            string pathDbSqlite = string.Empty;

            pathDbSqlite = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            pathDbSqlite = Path.Combine(pathDbSqlite, nameDB);

            return pathDbSqlite;

        }
    }
}
