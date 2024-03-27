using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 Proto                                    000186738240 ModelClassType ServiceDescriptorProto ServiceDescriptorProto ServiceDescriptorProto Pointer
    // 030 methods                                  IList`1<MethodDescriptor> IL2CPP_TYPE_GENERICINST
    public partial class ServiceDescriptor
    {
        public ServiceDescriptorProto?                  Proto                                   { get; set; }

        public static ServiceDescriptor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ServiceDescriptor();

            value.Proto                                     = GetObject<ServiceDescriptorProto>(new IntPtr(p + 0x028), ReversePrism.DataModels.ServiceDescriptorProto.FromPointer); // 0270D0CFA2A0 0x28 Proto                       ( 000186738240 ModelClassType ServiceDescriptorProto ServiceDescriptorProto ServiceDescriptorProto Pointer )

            return value;
        }
    }
}
