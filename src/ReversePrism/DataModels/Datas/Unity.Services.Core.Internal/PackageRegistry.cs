using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Tree                                     0001866BFBB0 ModelClassType DependencyTree DependencyTree DependencyTree Pointer
    public partial class PackageRegistry : DataModel
    {
        public DependencyTree?                          Tree                                    { get; set; }

        public static PackageRegistry? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PackageRegistry() { Pointer= p0 };

            value.Tree                                      = GetObject<DependencyTree>(new IntPtr(p + 0x010), ReversePrism.DataModels.DependencyTree.FromPointer); // 0245A3583C90 0x10 Tree                        ( 0001866BFBB0 ModelClassType DependencyTree DependencyTree DependencyTree Pointer )

            return value;
        }
    }
}
