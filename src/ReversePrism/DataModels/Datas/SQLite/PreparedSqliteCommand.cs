using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Initialized                              ModelPrimitiveType bool bool bool Bool
    // 018 Connection                               ModelClassType SQLiteConnection SQLiteConnection SQLiteConnection Pointer
    // 020 CommandText                              ModelPrimitiveType string string string String
    // 028 Statement                                <int> IL2CPP_TYPE_I
    // 000 NullStatement                            <int> IL2CPP_TYPE_I
    public partial class PreparedSqliteCommand : DataModel
    {
        public bool                                     Initialized                             { get; set; }
        public SQLiteConnection?                        Connection                              { get; set; }
        public string                                   CommandText                             { get; set; }

        public static PreparedSqliteCommand? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PreparedSqliteCommand() { Pointer= p0 };

            value.Initialized                               = GetBool(new IntPtr(p + 0x010)); // 0x10 Initialized                 ( ModelPrimitiveType bool bool bool Bool )
            value.Connection                                = GetObject<SQLiteConnection>(new IntPtr(p + 0x018), ReversePrism.DataModels.SQLiteConnection.FromPointer); // 0x18 Connection                  ( ModelClassType SQLiteConnection SQLiteConnection SQLiteConnection Pointer )
            value.CommandText                               = GetString(new IntPtr(p + 0x020)); // 0x20 CommandText                 ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
