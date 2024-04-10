using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ColumnName                               000186671910 ModelPrimitiveType string string string String
    // 018 Ascending                                000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class Ordering : DataModel
    {
        public string                                   ColumnName                              { get; set; }
        public bool                                     Ascending                               { get; set; }

        public static Ordering? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Ordering() { Pointer= p0 };

            value.ColumnName                                = GetString(new IntPtr(p + 0x010)); // 02466B36FD30 0x10 ColumnName                  ( 000186671910 ModelPrimitiveType string string string String )
            value.Ascending                                 = GetBool(new IntPtr(p + 0x018)); // 02466B36FD50 0x18 Ascending                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
