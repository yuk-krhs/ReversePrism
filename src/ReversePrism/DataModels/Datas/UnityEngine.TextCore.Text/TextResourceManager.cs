using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_FontAssetReferences                    Dictionary`2<int, FontAssetRef> IL2CPP_TYPE_GENERICINST
    // 008 s_FontAssetNameReferenceLookup           Dictionary`2<int, FontAsset> IL2CPP_TYPE_GENERICINST
    // 010 s_FontAssetFamilyNameAndStyleReferenceLookup Dictionary`2<long, FontAsset> IL2CPP_TYPE_GENERICINST
    // 018 S_FontAssetRemovalList                   ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer
    // 020 K_RegularStyleHashCode                   ModelPrimitiveType int int int Int32
    public partial class TextResourceManager : DataModel
    {
        public List<int>?                               S_FontAssetRemovalList                  { get; set; }
        public int                                      K_RegularStyleHashCode                  { get; set; }

        public static TextResourceManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TextResourceManager() { Pointer= p0 };

            value.S_FontAssetRemovalList                    = GetInt32List(new IntPtr(p + 0x018)); // 0x18 S_FontAssetRemovalList      ( ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer )
            value.K_RegularStyleHashCode                    = GetInt32(new IntPtr(p + 0x020)); // 0x20 K_RegularStyleHashCode      ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
