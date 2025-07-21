using System.Text;
using SQLite;

namespace ReversePrism
{
    public partial class CatalogDB : IDisposable
    {
        private bool                    disposed;
        private SQLiteConnection?       connection;

        public CatalogDB(string file, string keystr)
        {
            var key     = Enumerable.Range(0, keystr.Length/2).Select(i => Convert.ToByte(keystr.Substring(i*2, 2), 16)).ToArray();
            var options = new SQLiteConnectionString(file, SQLiteOpenFlags.ReadOnly, true, key: key);
            connection  = new SQLiteConnection(options);
        }

        public IEnumerable<CatalogA> SelectCatalogA()
        {
            var sql = "select * from A";
            var cmd = new SQLiteCommand(connection) { CommandText= sql };
            var list= cmd.ExecuteQuery<CatalogA>();

            return list;
        }

        public void Close()
        {
            if(null == connection)
                return;

            connection.Dispose();

            connection = null;
        }

        protected virtual void Dispose(bool disposing)
        {
            if(!disposed)
            {
                Close();

                disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
