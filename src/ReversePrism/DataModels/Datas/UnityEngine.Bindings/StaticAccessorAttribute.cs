using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     ModelPrimitiveType string string string String
    // 018 Type                                     ModelEnumType StaticAccessorType StaticAccessorType StaticAccessorType Int32
    public partial class StaticAccessorAttribute : DataModel
    {
        public string                                   Name                                    { get; set; }
        public StaticAccessorType                       Type                                    { get; set; }

        public static StaticAccessorAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StaticAccessorAttribute() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0x10 Name                        ( ModelPrimitiveType string string string String )
            value.Type                                      = (StaticAccessorType)GetInt32(new IntPtr(p + 0x018)); // 0x18 Type                        ( ModelEnumType StaticAccessorType StaticAccessorType StaticAccessorType Int32 )

            return value;
        }
    }
}
