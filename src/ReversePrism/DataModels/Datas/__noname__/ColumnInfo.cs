using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     000186671910 ModelPrimitiveType string string string String
    // 018 Notnull                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class ColumnInfo
    {
        public string                                   Name                                    { get; set; }
        public int                                      Notnull                                 { get; set; }

        public static ColumnInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ColumnInfo();

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 027003DAFED0 0x10 Name                        ( 000186671910 ModelPrimitiveType string string string String )
            value.Notnull                                   = GetInt32(new IntPtr(p + 0x018)); // 027003DAFEF0 0x18 Notnull                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
