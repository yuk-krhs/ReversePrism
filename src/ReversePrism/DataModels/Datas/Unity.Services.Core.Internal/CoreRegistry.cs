using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 <Instance>k__BackingField                CoreRegistry IL2CPP_TYPE_CLASS
    // 010 PackageRegistry                          0001865D12C0 ModelClassType IPackageRegistry IPackageRegistry IPackageRegistry Pointer
    // 018 ComponentRegistry                        000186736420 ModelClassType IComponentRegistry IComponentRegistry IComponentRegistry Pointer
    public partial class CoreRegistry : DataModel
    {
        public IPackageRegistry?                        PackageRegistry                         { get; set; }
        public IComponentRegistry?                      ComponentRegistry                       { get; set; }

        public static CoreRegistry? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CoreRegistry() { Pointer= p0 };

            value.PackageRegistry                           = GetObject<IPackageRegistry>(new IntPtr(p + 0x010), ReversePrism.DataModels.IPackageRegistry.FromPointer); // 0246608BDFB8 0x10 PackageRegistry             ( 0001865D12C0 ModelClassType IPackageRegistry IPackageRegistry IPackageRegistry Pointer )
            value.ComponentRegistry                         = GetObject<IComponentRegistry>(new IntPtr(p + 0x018), ReversePrism.DataModels.IComponentRegistry.FromPointer); // 0246608BDFD8 0x18 ComponentRegistry           ( 000186736420 ModelClassType IComponentRegistry IComponentRegistry IComponentRegistry Pointer )

            return value;
        }
    }
}
