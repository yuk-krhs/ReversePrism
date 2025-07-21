using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Mediator                                 ModelClassType ResourceManagerMediator ResourceManagerMediator ResourceManagerMediator Pointer
    public partial class FileBasedResourceGroveler : DataModel
    {
        public ResourceManagerMediator?                 Mediator                                { get; set; }

        public static FileBasedResourceGroveler? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FileBasedResourceGroveler() { Pointer= p0 };

            value.Mediator                                  = GetObject<ResourceManagerMediator>(new IntPtr(p + 0x010), ReversePrism.DataModels.ResourceManagerMediator.FromPointer); // 0x10 Mediator                    ( ModelClassType ResourceManagerMediator ResourceManagerMediator ResourceManagerMediator Pointer )

            return value;
        }
    }
}
