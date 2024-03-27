using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     000186671910 ModelPrimitiveType string string string String
    // 018 Type                                     000186584BA0 ModelEnumType StaticAccessorType StaticAccessorType StaticAccessorType Int32
    public partial class StaticAccessorAttribute
    {
        public string                                   Name                                    { get; set; }
        public StaticAccessorType                       Type                                    { get; set; }

        public static StaticAccessorAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StaticAccessorAttribute();

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 027006979918 0x10 Name                        ( 000186671910 ModelPrimitiveType string string string String )
            value.Type                                      = (StaticAccessorType)GetInt32(new IntPtr(p + 0x018)); // 027006979938 0x18 Type                        ( 000186584BA0 ModelEnumType StaticAccessorType StaticAccessorType StaticAccessorType Int32 )

            return value;
        }
    }
}
