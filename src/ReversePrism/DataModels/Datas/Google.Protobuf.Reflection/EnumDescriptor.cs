using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 Proto                                    00018673A770 ModelClassType EnumDescriptorProto EnumDescriptorProto EnumDescriptorProto Pointer
    // 030 ContainingType                           000186606DB0 ModelClassType MessageDescriptor MessageDescriptor MessageDescriptor Pointer
    // 038 values                                   IList`1<EnumValueDescriptor> IL2CPP_TYPE_GENERICINST
    // 040 ClrType                                  0001866936B0 ModelClassType Type Type Type Pointer
    public partial class EnumDescriptor
    {
        public EnumDescriptorProto?                     Proto                                   { get; set; }
        public MessageDescriptor?                       ContainingType                          { get; set; }
        public Type?                                    ClrType                                 { get; set; }

        public static EnumDescriptor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EnumDescriptor();

            value.Proto                                     = GetObject<EnumDescriptorProto>(new IntPtr(p + 0x028), ReversePrism.DataModels.EnumDescriptorProto.FromPointer); // 0270D0CED728 0x28 Proto                       ( 00018673A770 ModelClassType EnumDescriptorProto EnumDescriptorProto EnumDescriptorProto Pointer )
            value.ContainingType                            = GetObject<MessageDescriptor>(new IntPtr(p + 0x030), ReversePrism.DataModels.MessageDescriptor.FromPointer); // 0270D0CED748 0x30 ContainingType              ( 000186606DB0 ModelClassType MessageDescriptor MessageDescriptor MessageDescriptor Pointer )
            value.ClrType                                   = GetObject<Type>(new IntPtr(p + 0x040), ReversePrism.DataModels.Type.FromPointer); // 0270D0CED788 0x40 ClrType                     ( 0001866936B0 ModelClassType Type Type Type Pointer )

            return value;
        }
    }
}
