using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Core                                     ModelClassType Model3dLoaderCore Model3dLoaderCore Model3dLoaderCore Pointer
    public partial class SimpleModel3dLoader : DataModel
    {
        public Model3dLoaderCore?                       Core                                    { get; set; }

        public static SimpleModel3dLoader? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SimpleModel3dLoader() { Pointer= p0 };

            value.Core                                      = GetObject<Model3dLoaderCore>(new IntPtr(p + 0x010), ReversePrism.DataModels.Model3dLoaderCore.FromPointer); // 0x10 Core                        ( ModelClassType Model3dLoaderCore Model3dLoaderCore Model3dLoaderCore Pointer )

            return value;
        }
    }
}
