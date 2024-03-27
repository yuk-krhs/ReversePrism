using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 Proto                                    000186611140 ModelClassType MethodDescriptorProto MethodDescriptorProto MethodDescriptorProto Pointer
    // 030 Service                                  000186737DA0 ModelClassType ServiceDescriptor ServiceDescriptor ServiceDescriptor Pointer
    // 038 InputType                                000186606920 ModelClassType MessageDescriptor MessageDescriptor MessageDescriptor Pointer
    // 040 OutputType                               000186606920 ModelClassType MessageDescriptor MessageDescriptor MessageDescriptor Pointer
    public partial class MethodDescriptor
    {
        public MethodDescriptorProto?                   Proto                                   { get; set; }
        public ServiceDescriptor?                       Service                                 { get; set; }
        public MessageDescriptor?                       InputType                               { get; set; }
        public MessageDescriptor?                       OutputType                              { get; set; }

        public static MethodDescriptor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MethodDescriptor();

            value.Proto                                     = GetObject<MethodDescriptorProto>(new IntPtr(p + 0x028), ReversePrism.DataModels.MethodDescriptorProto.FromPointer); // 0270D0D48C00 0x28 Proto                       ( 000186611140 ModelClassType MethodDescriptorProto MethodDescriptorProto MethodDescriptorProto Pointer )
            value.Service                                   = GetObject<ServiceDescriptor>(new IntPtr(p + 0x030), ReversePrism.DataModels.ServiceDescriptor.FromPointer); // 0270D0D48C20 0x30 Service                     ( 000186737DA0 ModelClassType ServiceDescriptor ServiceDescriptor ServiceDescriptor Pointer )
            value.InputType                                 = GetObject<MessageDescriptor>(new IntPtr(p + 0x038), ReversePrism.DataModels.MessageDescriptor.FromPointer); // 0270D0D48C40 0x38 InputType                   ( 000186606920 ModelClassType MessageDescriptor MessageDescriptor MessageDescriptor Pointer )
            value.OutputType                                = GetObject<MessageDescriptor>(new IntPtr(p + 0x040), ReversePrism.DataModels.MessageDescriptor.FromPointer); // 0270D0D48C60 0x40 OutputType                  ( 000186606920 ModelClassType MessageDescriptor MessageDescriptor MessageDescriptor Pointer )

            return value;
        }
    }
}
