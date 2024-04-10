using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ConnectionString                         0001866B1C70 ModelClassType SQLiteConnectionString SQLiteConnectionString SQLiteConnectionString Pointer
    public partial class SQLiteAsyncConnection : DataModel
    {
        public SQLiteConnectionString?                  ConnectionString                        { get; set; }

        public static SQLiteAsyncConnection? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SQLiteAsyncConnection() { Pointer= p0 };

            value.ConnectionString                          = GetObject<SQLiteConnectionString>(new IntPtr(p + 0x010), ReversePrism.DataModels.SQLiteConnectionString.FromPointer); // 02466B38EC38 0x10 ConnectionString            ( 0001866B1C70 ModelClassType SQLiteConnectionString SQLiteConnectionString SQLiteConnectionString Pointer )

            return value;
        }
    }
}
