using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 Proto                                    ModelClassType ServiceDescriptorProto ServiceDescriptorProto ServiceDescriptorProto Pointer
    // 030 <Methods>k__BackingField                 IList`1<MethodDescriptor> IL2CPP_TYPE_GENERICINST
    public partial class ServiceDescriptor : DataModel
    {
        public ServiceDescriptorProto?                  Proto                                   { get; set; }

        public static ServiceDescriptor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ServiceDescriptor() { Pointer= p0 };

            value.Proto                                     = GetObject<ServiceDescriptorProto>(new IntPtr(p + 0x028), ReversePrism.DataModels.ServiceDescriptorProto.FromPointer); // 0x28 Proto                       ( ModelClassType ServiceDescriptorProto ServiceDescriptorProto ServiceDescriptorProto Pointer )

            return value;
        }
    }
}
