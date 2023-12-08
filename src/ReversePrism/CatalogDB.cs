using System.Text;
using SQLite;

namespace ReversePrism
{
    // H7PEUQDOOSJB74LVHV5TYF265M => F434229D6B4CF190E10BE549E6BEED325E7DBFB4CBA9CC065BD436ED31538CA8
    // SF3BSQN4IYRIB3V46UFDCYWPGA => FEA5267A55E86F6AD49EFA251E5A91535891B11FD3DFA2931CF85343C57C8619
    // HOKLGQ5YPWHDGFOCTFPELLKAIU => F9AC2EB91A6AE009BE31F981B83F4399288841F2363A68D7AFE9CE3482AEE9EF
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
