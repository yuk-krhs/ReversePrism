using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Usage                                    ModelClassType AttributeUsageAttribute AttributeUsageAttribute AttributeUsageAttribute Pointer
    // 018 InheritanceLevel                         ModelPrimitiveType int int int Int32
    public partial class AttributeInfo : DataModel
    {
        public AttributeUsageAttribute?                 Usage                                   { get; set; }
        public int                                      InheritanceLevel                        { get; set; }

        public static AttributeInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AttributeInfo() { Pointer= p0 };

            value.Usage                                     = GetObject<AttributeUsageAttribute>(new IntPtr(p + 0x010), ReversePrism.DataModels.AttributeUsageAttribute.FromPointer); // 0x10 Usage                       ( ModelClassType AttributeUsageAttribute AttributeUsageAttribute AttributeUsageAttribute Pointer )
            value.InheritanceLevel                          = GetInt32(new IntPtr(p + 0x018)); // 0x18 InheritanceLevel            ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
