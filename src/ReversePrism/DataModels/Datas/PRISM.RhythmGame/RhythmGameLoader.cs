using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 InnerLoader                              ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
    public partial class RhythmGameLoader : DataModel
    {
        public IResourceLoader?                         InnerLoader                             { get; set; }

        public static RhythmGameLoader? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RhythmGameLoader() { Pointer= p0 };

            value.InnerLoader                               = GetObject<IResourceLoader>(new IntPtr(p + 0x010), ReversePrism.DataModels.IResourceLoader.FromPointer); // 0x10 InnerLoader                 ( ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )

            return value;
        }
    }
}
