using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Registry                               0001865D1540 ModelClassType IPackageRegistry IPackageRegistry IPackageRegistry Pointer
    // 018 M_PackageHash                            0001865F4260 ModelPrimitiveType int int int Int32
    public partial class CoreRegistration : DataModel
    {
        public IPackageRegistry?                        M_Registry                              { get; set; }
        public int                                      M_PackageHash                           { get; set; }

        public static CoreRegistration? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CoreRegistration() { Pointer= p0 };

            value.M_Registry                                = GetObject<IPackageRegistry>(new IntPtr(p + 0x010), ReversePrism.DataModels.IPackageRegistry.FromPointer); // 02466BAFA010 0x10 M_Registry                  ( 0001865D1540 ModelClassType IPackageRegistry IPackageRegistry IPackageRegistry Pointer )
            value.M_PackageHash                             = GetInt32(new IntPtr(p + 0x018)); // 02466BAFA030 0x18 M_PackageHash               ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
