using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_DecalEntityManager                     ModelClassType DecalEntityManager DecalEntityManager DecalEntityManager Pointer
    // 018 M_ReferenceCounter                       ModelPrimitiveType int int int Int32
    public partial class SharedDecalEntityManager : DataModel
    {
        public DecalEntityManager?                      M_DecalEntityManager                    { get; set; }
        public int                                      M_ReferenceCounter                      { get; set; }

        public static SharedDecalEntityManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SharedDecalEntityManager() { Pointer= p0 };

            value.M_DecalEntityManager                      = GetObject<DecalEntityManager>(new IntPtr(p + 0x010), ReversePrism.DataModels.DecalEntityManager.FromPointer); // 0x10 M_DecalEntityManager        ( ModelClassType DecalEntityManager DecalEntityManager DecalEntityManager Pointer )
            value.M_ReferenceCounter                        = GetInt32(new IntPtr(p + 0x018)); // 0x18 M_ReferenceCounter          ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
