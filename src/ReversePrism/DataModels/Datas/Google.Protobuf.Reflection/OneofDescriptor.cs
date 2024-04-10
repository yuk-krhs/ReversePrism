using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 Proto                                    0001866DFF30 ModelClassType OneofDescriptorProto OneofDescriptorProto OneofDescriptorProto Pointer
    // 030 ContainingType                           000186606920 ModelClassType MessageDescriptor MessageDescriptor MessageDescriptor Pointer
    // 038 fields                                   IList`1<FieldDescriptor> IL2CPP_TYPE_GENERICINST
    // 040 Accessor                                 0001866DF2A0 ModelClassType OneofAccessor OneofAccessor OneofAccessor Pointer
    // 048 IsSynthetic                              0001865965D0 ModelPrimitiveType bool bool bool Bool
    public partial class OneofDescriptor : DataModel
    {
        public OneofDescriptorProto?                    Proto                                   { get; set; }
        public MessageDescriptor?                       ContainingType                          { get; set; }
        public OneofAccessor?                           Accessor                                { get; set; }
        public bool                                     IsSynthetic                             { get; set; }

        public static OneofDescriptor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OneofDescriptor() { Pointer= p0 };

            value.Proto                                     = GetObject<OneofDescriptorProto>(new IntPtr(p + 0x028), ReversePrism.DataModels.OneofDescriptorProto.FromPointer); // 024660D0E570 0x28 Proto                       ( 0001866DFF30 ModelClassType OneofDescriptorProto OneofDescriptorProto OneofDescriptorProto Pointer )
            value.ContainingType                            = GetObject<MessageDescriptor>(new IntPtr(p + 0x030), ReversePrism.DataModels.MessageDescriptor.FromPointer); // 024660D0E590 0x30 ContainingType              ( 000186606920 ModelClassType MessageDescriptor MessageDescriptor MessageDescriptor Pointer )
            value.Accessor                                  = GetObject<OneofAccessor>(new IntPtr(p + 0x040), ReversePrism.DataModels.OneofAccessor.FromPointer); // 024660D0E5D0 0x40 Accessor                    ( 0001866DF2A0 ModelClassType OneofAccessor OneofAccessor OneofAccessor Pointer )
            value.IsSynthetic                               = GetBool(new IntPtr(p + 0x048)); // 024660D0E5F0 0x48 IsSynthetic                 ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
