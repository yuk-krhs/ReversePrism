using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 _entries                                 Dictionary`2<string, Entry> IL2CPP_TYPE_GENERICINST
    // 018 _entriesLock                             <object> IL2CPP_TYPE_OBJECT
    // 000 _shared                                  SQLiteConnectionPool IL2CPP_TYPE_CLASS
    public partial class SQLiteConnectionPool : DataModel
    {

        public static SQLiteConnectionPool? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SQLiteConnectionPool() { Pointer= p0 };


            return value;
        }
    }
}
