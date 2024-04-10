using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Tree                                     0001866C0090 ModelClassType DependencyTree DependencyTree DependencyTree Pointer
    // 018 Target                                   ICollection`1<int> IL2CPP_TYPE_GENERICINST
    // 020 m_PackageTypeHashExplorationHistory      Dictionary`2<int, ExplorationMark> IL2CPP_TYPE_GENERICINST
    public partial class DependencyTreeInitializeOrderSorter : DataModel
    {
        public DependencyTree?                          Tree                                    { get; set; }

        public static DependencyTreeInitializeOrderSorter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DependencyTreeInitializeOrderSorter() { Pointer= p0 };

            value.Tree                                      = GetObject<DependencyTree>(new IntPtr(p + 0x010), ReversePrism.DataModels.DependencyTree.FromPointer); // 02466BAFA880 0x10 Tree                        ( 0001866C0090 ModelClassType DependencyTree DependencyTree DependencyTree Pointer )

            return value;
        }
    }
}
