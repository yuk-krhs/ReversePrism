using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Mediator                                 0001866D7A00 ModelClassType ResourceManagerMediator ResourceManagerMediator ResourceManagerMediator Pointer
    public partial class FileBasedResourceGroveler
    {
        public ResourceManagerMediator?                 Mediator                                { get; set; }

        public static FileBasedResourceGroveler? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FileBasedResourceGroveler();

            value.Mediator                                  = GetObject<ResourceManagerMediator>(new IntPtr(p + 0x010), ReversePrism.DataModels.ResourceManagerMediator.FromPointer); // 0270D6CC8FA8 0x10 Mediator                    ( 0001866D7A00 ModelClassType ResourceManagerMediator ResourceManagerMediator ResourceManagerMediator Pointer )

            return value;
        }
    }
}
