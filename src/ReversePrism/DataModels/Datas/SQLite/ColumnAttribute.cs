using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     000186671910 ModelPrimitiveType string string string String
    public partial class ColumnAttribute
    {
        public string                                   Name                                    { get; set; }

        public static ColumnAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ColumnAttribute();

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 027003D98BB0 0x10 Name                        ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
