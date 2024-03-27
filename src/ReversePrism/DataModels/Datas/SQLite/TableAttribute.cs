using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     000186671910 ModelPrimitiveType string string string String
    // 018 WithoutRowId                             000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class TableAttribute
    {
        public string                                   Name                                    { get; set; }
        public bool                                     WithoutRowId                            { get; set; }

        public static TableAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TableAttribute();

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 027003D78C98 0x10 Name                        ( 000186671910 ModelPrimitiveType string string string String )
            value.WithoutRowId                              = GetBool(new IntPtr(p + 0x018)); // 027003D78CB8 0x18 WithoutRowId                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
