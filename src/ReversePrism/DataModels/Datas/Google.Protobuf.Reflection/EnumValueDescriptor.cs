using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 Proto                                    ModelClassType EnumValueDescriptorProto EnumValueDescriptorProto EnumValueDescriptorProto Pointer
    // 030 EnumDescriptor                           ModelClassType EnumDescriptor EnumDescriptor EnumDescriptor Pointer
    public partial class EnumValueDescriptor : DataModel
    {
        public EnumValueDescriptorProto?                Proto                                   { get; set; }
        public EnumDescriptor?                          EnumDescriptor                          { get; set; }

        public static EnumValueDescriptor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EnumValueDescriptor() { Pointer= p0 };

            value.Proto                                     = GetObject<EnumValueDescriptorProto>(new IntPtr(p + 0x028), ReversePrism.DataModels.EnumValueDescriptorProto.FromPointer); // 0x28 Proto                       ( ModelClassType EnumValueDescriptorProto EnumValueDescriptorProto EnumValueDescriptorProto Pointer )
            value.EnumDescriptor                            = GetObject<EnumDescriptor>(new IntPtr(p + 0x030), ReversePrism.DataModels.EnumDescriptor.FromPointer); // 0x30 EnumDescriptor              ( ModelClassType EnumDescriptor EnumDescriptor EnumDescriptor Pointer )

            return value;
        }
    }
}
