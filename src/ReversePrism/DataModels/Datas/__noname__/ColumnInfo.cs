using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     ModelPrimitiveType string string string String
    // 018 Notnull                                  ModelPrimitiveType int int int Int32
    public partial class ColumnInfo : DataModel
    {
        public string                                   Name                                    { get; set; }
        public int                                      Notnull                                 { get; set; }

        public static ColumnInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ColumnInfo() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0x10 Name                        ( ModelPrimitiveType string string string String )
            value.Notnull                                   = GetInt32(new IntPtr(p + 0x018)); // 0x18 Notnull                     ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
