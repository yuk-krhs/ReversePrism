using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 Proto                                    ModelClassType EnumDescriptorProto EnumDescriptorProto EnumDescriptorProto Pointer
    // 030 ClrType                                  ModelClassType Type Type Type Pointer
    // 038 ContainingType                           ModelClassType MessageDescriptor MessageDescriptor MessageDescriptor Pointer
    // 040 <Values>k__BackingField                  IList`1<EnumValueDescriptor> IL2CPP_TYPE_GENERICINST
    public partial class EnumDescriptor : DataModel
    {
        public EnumDescriptorProto?                     Proto                                   { get; set; }
        public Type?                                    ClrType                                 { get; set; }
        public MessageDescriptor?                       ContainingType                          { get; set; }

        public static EnumDescriptor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EnumDescriptor() { Pointer= p0 };

            value.Proto                                     = GetObject<EnumDescriptorProto>(new IntPtr(p + 0x028), ReversePrism.DataModels.EnumDescriptorProto.FromPointer); // 0x28 Proto                       ( ModelClassType EnumDescriptorProto EnumDescriptorProto EnumDescriptorProto Pointer )
            value.ClrType                                   = GetObject<Type>(new IntPtr(p + 0x030), ReversePrism.DataModels.Type.FromPointer); // 0x30 ClrType                     ( ModelClassType Type Type Type Pointer )
            value.ContainingType                            = GetObject<MessageDescriptor>(new IntPtr(p + 0x038), ReversePrism.DataModels.MessageDescriptor.FromPointer); // 0x38 ContainingType              ( ModelClassType MessageDescriptor MessageDescriptor MessageDescriptor Pointer )

            return value;
        }
    }
}
