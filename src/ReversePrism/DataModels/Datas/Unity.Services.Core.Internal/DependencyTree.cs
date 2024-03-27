using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PackageTypeHashToInstance                Dictionary`2<int, IInitializablePackage> IL2CPP_TYPE_GENERICINST
    // 018 ComponentTypeHashToPackageTypeHash       Dictionary`2<int, int> IL2CPP_TYPE_GENERICINST
    // 020 PackageTypeHashToComponentTypeHashDependencies Dictionary`2<int, List`1<int>> IL2CPP_TYPE_GENERICINST
    // 028 ComponentTypeHashToInstance              Dictionary`2<int, IServiceComponent> IL2CPP_TYPE_GENERICINST
    public partial class DependencyTree
    {

        public static DependencyTree? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DependencyTree();


            return value;
        }
    }
}
