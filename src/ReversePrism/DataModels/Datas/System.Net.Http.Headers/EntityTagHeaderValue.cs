using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 any                                      EntityTagHeaderValue IL2CPP_TYPE_CLASS
    // 010 IsWeak                                   ModelPrimitiveType bool bool bool Bool
    // 018 Tag                                      ModelPrimitiveType string string string String
    public partial class EntityTagHeaderValue : DataModel
    {
        public bool                                     IsWeak                                  { get; set; }
        public string                                   Tag                                     { get; set; }

        public static EntityTagHeaderValue? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EntityTagHeaderValue() { Pointer= p0 };

            value.IsWeak                                    = GetBool(new IntPtr(p + 0x010)); // 0x10 IsWeak                      ( ModelPrimitiveType bool bool bool Bool )
            value.Tag                                       = GetString(new IntPtr(p + 0x018)); // 0x18 Tag                         ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
