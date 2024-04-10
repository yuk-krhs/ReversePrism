using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 EnumDescriptor                           00018673A000 ModelClassType EnumDescriptor EnumDescriptor EnumDescriptor Pointer
    // 030 Proto                                    00018673D020 ModelClassType EnumValueDescriptorProto EnumValueDescriptorProto EnumValueDescriptorProto Pointer
    public partial class EnumValueDescriptor : DataModel
    {
        public EnumDescriptor?                          EnumDescriptor                          { get; set; }
        public EnumValueDescriptorProto?                Proto                                   { get; set; }

        public static EnumValueDescriptor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EnumValueDescriptor() { Pointer= p0 };

            value.EnumDescriptor                            = GetObject<EnumDescriptor>(new IntPtr(p + 0x028), ReversePrism.DataModels.EnumDescriptor.FromPointer); // 024660CD3010 0x28 EnumDescriptor              ( 00018673A000 ModelClassType EnumDescriptor EnumDescriptor EnumDescriptor Pointer )
            value.Proto                                     = GetObject<EnumValueDescriptorProto>(new IntPtr(p + 0x030), ReversePrism.DataModels.EnumValueDescriptorProto.FromPointer); // 024660CD3030 0x30 Proto                       ( 00018673D020 ModelClassType EnumValueDescriptorProto EnumValueDescriptorProto EnumValueDescriptorProto Pointer )

            return value;
        }
    }
}
