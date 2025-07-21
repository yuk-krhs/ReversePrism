using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 RawLoader                                ModelClassType IRawResourceLoader IRawResourceLoader IRawResourceLoader Pointer
    public partial class ResourceLoaderFactory : DataModel
    {
        public IRawResourceLoader?                      RawLoader                               { get; set; }

        public static ResourceLoaderFactory? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ResourceLoaderFactory() { Pointer= p0 };

            value.RawLoader                                 = GetObject<IRawResourceLoader>(new IntPtr(p + 0x010), ReversePrism.DataModels.IRawResourceLoader.FromPointer); // 0x10 RawLoader                   ( ModelClassType IRawResourceLoader IRawResourceLoader IRawResourceLoader Pointer )

            return value;
        }
    }
}
