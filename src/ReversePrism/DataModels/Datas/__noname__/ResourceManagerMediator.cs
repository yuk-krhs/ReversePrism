using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Rm                                       ModelClassType ResourceManager ResourceManager ResourceManager Pointer
    public partial class ResourceManagerMediator : DataModel
    {
        public ResourceManager?                         Rm                                      { get; set; }

        public static ResourceManagerMediator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ResourceManagerMediator() { Pointer= p0 };

            value.Rm                                        = GetObject<ResourceManager>(new IntPtr(p + 0x010), ReversePrism.DataModels.ResourceManager.FromPointer); // 0x10 Rm                          ( ModelClassType ResourceManager ResourceManager ResourceManager Pointer )

            return value;
        }
    }
}
