using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_Instance                               MaterialReferenceManager IL2CPP_TYPE_CLASS
    // 010 m_FontMaterialReferenceLookup            Dictionary`2<int, Material> IL2CPP_TYPE_GENERICINST
    // 018 m_FontAssetReferenceLookup               Dictionary`2<int, FontAsset> IL2CPP_TYPE_GENERICINST
    // 020 m_SpriteAssetReferenceLookup             Dictionary`2<int, SpriteAsset> IL2CPP_TYPE_GENERICINST
    // 028 m_ColorGradientReferenceLookup           Dictionary`2<int, TextColorGradient> IL2CPP_TYPE_GENERICINST
    public partial class MaterialReferenceManager : DataModel
    {

        public static MaterialReferenceManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MaterialReferenceManager() { Pointer= p0 };


            return value;
        }
    }
}
