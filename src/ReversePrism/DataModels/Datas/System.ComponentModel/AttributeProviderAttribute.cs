using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TypeName                                 ModelPrimitiveType string string string String
    // 018 PropertyName                             ModelPrimitiveType string string string String
    public partial class AttributeProviderAttribute : DataModel
    {
        public string                                   TypeName                                { get; set; }
        public string                                   PropertyName                            { get; set; }

        public static AttributeProviderAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AttributeProviderAttribute() { Pointer= p0 };

            value.TypeName                                  = GetString(new IntPtr(p + 0x010)); // 0x10 TypeName                    ( ModelPrimitiveType string string string String )
            value.PropertyName                              = GetString(new IntPtr(p + 0x018)); // 0x18 PropertyName                ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
