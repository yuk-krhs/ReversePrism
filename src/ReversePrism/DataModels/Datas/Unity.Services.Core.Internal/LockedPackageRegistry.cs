using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 k_ErrorMessage                           string IL2CPP_TYPE_STRING
    // 010 Registry                                 0001865D1540 ModelClassType IPackageRegistry IPackageRegistry IPackageRegistry Pointer
    public partial class LockedPackageRegistry
    {
        public IPackageRegistry?                        Registry                                { get; set; }

        public static LockedPackageRegistry? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LockedPackageRegistry();

            value.Registry                                  = GetObject<IPackageRegistry>(new IntPtr(p + 0x010), ReversePrism.DataModels.IPackageRegistry.FromPointer); // 027003C4B230 0x10 Registry                    ( 0001865D1540 ModelClassType IPackageRegistry IPackageRegistry IPackageRegistry Pointer )

            return value;
        }
    }
}
