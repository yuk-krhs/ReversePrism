using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Conn                                     0001866B0DF0 ModelClassType SQLiteConnection SQLiteConnection SQLiteConnection Pointer
    // 018 InternalResources                        000185CE24E8 ModelClassListType List`1<IDisposable> List`1<IDisposable> List<IDisposable> Pointer
    public partial class SQLiteDB
    {
        public SQLiteConnection?                        Conn                                    { get; set; }
        public List<IDisposable>?                       InternalResources                       { get; set; }

        public static SQLiteDB? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SQLiteDB();

            value.Conn                                      = GetObject<SQLiteConnection>(new IntPtr(p + 0x010), ReversePrism.DataModels.SQLiteConnection.FromPointer); // 027003D031F8 0x10 Conn                        ( 0001866B0DF0 ModelClassType SQLiteConnection SQLiteConnection SQLiteConnection Pointer )
            value.InternalResources                         = GetObjectList<IDisposable>(new IntPtr(p + 0x018), ReversePrism.DataModels.IDisposable.FromPointer); // 027003D03218 0x18 InternalResources           ( 000185CE24E8 ModelClassListType List`1<IDisposable> List`1<IDisposable> List<IDisposable> Pointer )

            return value;
        }
    }
}
