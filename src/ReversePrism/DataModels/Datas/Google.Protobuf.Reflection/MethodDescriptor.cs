using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 Service                                  ModelClassType ServiceDescriptor ServiceDescriptor ServiceDescriptor Pointer
    // 030 InputType                                ModelClassType MessageDescriptor MessageDescriptor MessageDescriptor Pointer
    // 038 OutputType                               ModelClassType MessageDescriptor MessageDescriptor MessageDescriptor Pointer
    // 040 Proto                                    ModelClassType MethodDescriptorProto MethodDescriptorProto MethodDescriptorProto Pointer
    public partial class MethodDescriptor : DataModel
    {
        public ServiceDescriptor?                       Service                                 { get; set; }
        public MessageDescriptor?                       InputType                               { get; set; }
        public MessageDescriptor?                       OutputType                              { get; set; }
        public MethodDescriptorProto?                   Proto                                   { get; set; }

        public static MethodDescriptor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MethodDescriptor() { Pointer= p0 };

            value.Service                                   = GetObject<ServiceDescriptor>(new IntPtr(p + 0x028), ReversePrism.DataModels.ServiceDescriptor.FromPointer); // 0x28 Service                     ( ModelClassType ServiceDescriptor ServiceDescriptor ServiceDescriptor Pointer )
            value.InputType                                 = GetObject<MessageDescriptor>(new IntPtr(p + 0x030), ReversePrism.DataModels.MessageDescriptor.FromPointer); // 0x30 InputType                   ( ModelClassType MessageDescriptor MessageDescriptor MessageDescriptor Pointer )
            value.OutputType                                = GetObject<MessageDescriptor>(new IntPtr(p + 0x038), ReversePrism.DataModels.MessageDescriptor.FromPointer); // 0x38 OutputType                  ( ModelClassType MessageDescriptor MessageDescriptor MessageDescriptor Pointer )
            value.Proto                                     = GetObject<MethodDescriptorProto>(new IntPtr(p + 0x040), ReversePrism.DataModels.MethodDescriptorProto.FromPointer); // 0x40 Proto                       ( ModelClassType MethodDescriptorProto MethodDescriptorProto MethodDescriptorProto Pointer )

            return value;
        }
    }
}
