using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Mediator                                 0001866D7A00 ModelClassType ResourceManagerMediator ResourceManagerMediator ResourceManagerMediator Pointer
    public partial class ManifestBasedResourceGroveler : DataModel
    {
        public ResourceManagerMediator?                 Mediator                                { get; set; }

        public static ManifestBasedResourceGroveler? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ManifestBasedResourceGroveler() { Pointer= p0 };

            value.Mediator                                  = GetObject<ResourceManagerMediator>(new IntPtr(p + 0x010), ReversePrism.DataModels.ResourceManagerMediator.FromPointer); // 024666D2F988 0x10 Mediator                    ( 0001866D7A00 ModelClassType ResourceManagerMediator ResourceManagerMediator ResourceManagerMediator Pointer )

            return value;
        }
    }
}
