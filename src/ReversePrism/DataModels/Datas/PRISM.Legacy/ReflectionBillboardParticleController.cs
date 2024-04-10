using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 SharedMaterialList                       List`1<ValueTuple`2<Material, int>> IL2CPP_TYPE_GENERICINST
    // 020 MaterialList                             000185CF20E8 ModelClassListType List`1<Material> List`1<Material> List<Material> Pointer
    public partial class ReflectionBillboardParticleController : DataModel
    {
        public List<Material>?                          MaterialList                            { get; set; }

        public static ReflectionBillboardParticleController? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ReflectionBillboardParticleController() { Pointer= p0 };

            value.MaterialList                              = GetObjectList<Material>(new IntPtr(p + 0x020), ReversePrism.DataModels.Material.FromPointer); // 024665E6EC58 0x20 MaterialList                ( 000185CF20E8 ModelClassListType List`1<Material> List`1<Material> List<Material> Pointer )

            return value;
        }
    }
}
