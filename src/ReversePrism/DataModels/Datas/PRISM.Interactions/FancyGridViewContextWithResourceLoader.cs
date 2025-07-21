using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 ResourceLoader                           ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
    public partial class FancyGridViewContextWithResourceLoader : DataModel
    {
        public IResourceLoader?                         ResourceLoader                          { get; set; }

        public static FancyGridViewContextWithResourceLoader? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FancyGridViewContextWithResourceLoader() { Pointer= p0 };

            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x040), ReversePrism.DataModels.IResourceLoader.FromPointer); // 0x40 ResourceLoader              ( ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )

            return value;
        }
    }
}
