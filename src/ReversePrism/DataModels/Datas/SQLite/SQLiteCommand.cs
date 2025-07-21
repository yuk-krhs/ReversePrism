using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Conn                                     ModelClassType SQLiteConnection SQLiteConnection SQLiteConnection Pointer
    // 018 Bindings                                 ModelClassListType List`1<Binding> List`1<Binding> List<Binding> Pointer
    // 020 CommandText                              ModelPrimitiveType string string string String
    // 000 NegativePointer                          <int> IL2CPP_TYPE_I
    public partial class SQLiteCommand : DataModel
    {
        public SQLiteConnection?                        Conn                                    { get; set; }
        public List<Binding>?                           Bindings                                { get; set; }
        public string                                   CommandText                             { get; set; }

        public static SQLiteCommand? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SQLiteCommand() { Pointer= p0 };

            value.Conn                                      = GetObject<SQLiteConnection>(new IntPtr(p + 0x010), ReversePrism.DataModels.SQLiteConnection.FromPointer); // 0x10 Conn                        ( ModelClassType SQLiteConnection SQLiteConnection SQLiteConnection Pointer )
            value.Bindings                                  = GetObjectList<Binding>(new IntPtr(p + 0x018), ReversePrism.DataModels.Binding.FromPointer); // 0x18 Bindings                    ( ModelClassListType List`1<Binding> List`1<Binding> List<Binding> Pointer )
            value.CommandText                               = GetString(new IntPtr(p + 0x020)); // 0x20 CommandText                 ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
