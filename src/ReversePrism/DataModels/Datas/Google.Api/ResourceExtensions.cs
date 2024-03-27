using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 ResourceReference                        Extension`2<FieldOptions, ResourceReference> IL2CPP_TYPE_GENERICINST
    // 008 ResourceDefinition                       RepeatedExtension`2<FileOptions, ResourceDescriptor> IL2CPP_TYPE_GENERICINST
    // 010 Resource                                 Extension`2<MessageOptions, ResourceDescriptor> IL2CPP_TYPE_GENERICINST
    public partial class ResourceExtensions
    {

        public static ResourceExtensions? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ResourceExtensions();


            return value;
        }
    }
}
