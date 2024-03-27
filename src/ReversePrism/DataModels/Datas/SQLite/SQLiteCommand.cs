using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Conn                                     0001866B0B70 ModelClassType SQLiteConnection SQLiteConnection SQLiteConnection Pointer
    // 018 Bindings                                 000185D2AA78 ModelClassListType List`1<Binding> List`1<Binding> List<Binding> Pointer
    // 020 CommandText                              000186671910 ModelPrimitiveType string string string String
    // 000 NegativePointer                          <int> IL2CPP_TYPE_I
    public partial class SQLiteCommand
    {
        public SQLiteConnection?                        Conn                                    { get; set; }
        public List<Binding>?                           Bindings                                { get; set; }
        public string                                   CommandText                             { get; set; }

        public static SQLiteCommand? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SQLiteCommand();

            value.Conn                                      = GetObject<SQLiteConnection>(new IntPtr(p + 0x010), ReversePrism.DataModels.SQLiteConnection.FromPointer); // 027003D450A0 0x10 Conn                        ( 0001866B0B70 ModelClassType SQLiteConnection SQLiteConnection SQLiteConnection Pointer )
            value.Bindings                                  = GetObjectList<Binding>(new IntPtr(p + 0x018), ReversePrism.DataModels.Binding.FromPointer); // 027003D450C0 0x18 Bindings                    ( 000185D2AA78 ModelClassListType List`1<Binding> List`1<Binding> List<Binding> Pointer )
            value.CommandText                               = GetString(new IntPtr(p + 0x020)); // 027003D450E0 0x20 CommandText                 ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
