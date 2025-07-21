using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 ContainingType                           ModelClassType MessageDescriptor MessageDescriptor MessageDescriptor Pointer
    // 030 fields                                   IList`1<FieldDescriptor> IL2CPP_TYPE_GENERICINST
    // 038 Accessor                                 ModelClassType OneofAccessor OneofAccessor OneofAccessor Pointer
    // 040 Proto                                    ModelClassType OneofDescriptorProto OneofDescriptorProto OneofDescriptorProto Pointer
    // 048 IsSynthetic                              ModelPrimitiveType bool bool bool Bool
    public partial class OneofDescriptor : DataModel
    {
        public MessageDescriptor?                       ContainingType                          { get; set; }
        public OneofAccessor?                           Accessor                                { get; set; }
        public OneofDescriptorProto?                    Proto                                   { get; set; }
        public bool                                     IsSynthetic                             { get; set; }

        public static OneofDescriptor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OneofDescriptor() { Pointer= p0 };

            value.ContainingType                            = GetObject<MessageDescriptor>(new IntPtr(p + 0x028), ReversePrism.DataModels.MessageDescriptor.FromPointer); // 0x28 ContainingType              ( ModelClassType MessageDescriptor MessageDescriptor MessageDescriptor Pointer )
            value.Accessor                                  = GetObject<OneofAccessor>(new IntPtr(p + 0x038), ReversePrism.DataModels.OneofAccessor.FromPointer); // 0x38 Accessor                    ( ModelClassType OneofAccessor OneofAccessor OneofAccessor Pointer )
            value.Proto                                     = GetObject<OneofDescriptorProto>(new IntPtr(p + 0x040), ReversePrism.DataModels.OneofDescriptorProto.FromPointer); // 0x40 Proto                       ( ModelClassType OneofDescriptorProto OneofDescriptorProto OneofDescriptorProto Pointer )
            value.IsSynthetic                               = GetBool(new IntPtr(p + 0x048)); // 0x48 IsSynthetic                 ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
