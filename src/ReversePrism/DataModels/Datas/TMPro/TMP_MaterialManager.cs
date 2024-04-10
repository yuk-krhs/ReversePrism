using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 m_materialList                           List`1<MaskingMaterial> IL2CPP_TYPE_GENERICINST
    // 008 m_fallbackMaterials                      Dictionary`2<long, FallbackMaterial> IL2CPP_TYPE_GENERICINST
    // 010 m_fallbackMaterialLookup                 Dictionary`2<int, long> IL2CPP_TYPE_GENERICINST
    // 018 M_fallbackCleanupList                    000185D2D3D8 ModelClassListType List`1<FallbackMaterial> List`1<FallbackMaterial> List<FallbackMaterial> Pointer
    // 020 IsFallbackListDirty                      000186595C30 ModelPrimitiveType bool bool bool Bool
    public partial class TMP_MaterialManager : DataModel
    {
        public List<FallbackMaterial>?                  M_fallbackCleanupList                   { get; set; }
        public bool                                     IsFallbackListDirty                     { get; set; }

        public static TMP_MaterialManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TMP_MaterialManager() { Pointer= p0 };

            value.M_fallbackCleanupList                     = GetObjectList<FallbackMaterial>(new IntPtr(p + 0x018), ReversePrism.DataModels.FallbackMaterial.FromPointer); // 0245A4199930 0x18 M_fallbackCleanupList       ( 000185D2D3D8 ModelClassListType List`1<FallbackMaterial> List`1<FallbackMaterial> List<FallbackMaterial> Pointer )
            value.IsFallbackListDirty                       = GetBool(new IntPtr(p + 0x020)); // 0245A4199950 0x20 IsFallbackListDirty         ( 000186595C30 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
