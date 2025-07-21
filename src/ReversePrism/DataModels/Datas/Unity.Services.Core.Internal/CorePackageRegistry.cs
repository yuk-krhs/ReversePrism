using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 <Instance>k__BackingField                CorePackageRegistry IL2CPP_TYPE_CLASS
    // 010 Registry                                 ModelClassType IPackageRegistry IPackageRegistry IPackageRegistry Pointer
    public partial class CorePackageRegistry : DataModel
    {
        public IPackageRegistry?                        Registry                                { get; set; }

        public static CorePackageRegistry? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CorePackageRegistry() { Pointer= p0 };

            value.Registry                                  = GetObject<IPackageRegistry>(new IntPtr(p + 0x010), ReversePrism.DataModels.IPackageRegistry.FromPointer); // 0x10 Registry                    ( ModelClassType IPackageRegistry IPackageRegistry IPackageRegistry Pointer )

            return value;
        }
    }
}
