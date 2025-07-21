using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Tree                                     ModelClassType DependencyTree DependencyTree DependencyTree Pointer
    public partial class PackageRegistry : DataModel
    {
        public DependencyTree?                          Tree                                    { get; set; }

        public static PackageRegistry? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PackageRegistry() { Pointer= p0 };

            value.Tree                                      = GetObject<DependencyTree>(new IntPtr(p + 0x010), ReversePrism.DataModels.DependencyTree.FromPointer); // 0x10 Tree                        ( ModelClassType DependencyTree DependencyTree DependencyTree Pointer )

            return value;
        }
    }
}
