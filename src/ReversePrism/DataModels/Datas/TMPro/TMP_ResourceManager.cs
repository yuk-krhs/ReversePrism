using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_instance                               TMP_ResourceManager IL2CPP_TYPE_CLASS
    // 008 s_TextSettings                           TMP_Settings IL2CPP_TYPE_CLASS
    // 010 S_FontAssetReferences                    000185D11D28 ModelClassListType List`1<TMP_FontAsset> List`1<TMP_FontAsset> List<TMP_FontAsset> Pointer
    // 018 s_FontAssetReferenceLookup               Dictionary`2<int, TMP_FontAsset> IL2CPP_TYPE_GENERICINST
    public partial class TMP_ResourceManager
    {
        public List<TMP_FontAsset>?                     S_FontAssetReferences                   { get; set; }

        public static TMP_ResourceManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TMP_ResourceManager();

            value.S_FontAssetReferences                     = GetObjectList<TMP_FontAsset>(new IntPtr(p + 0x010), ReversePrism.DataModels.TMP_FontAsset.FromPointer); // 0270DA6530F0 0x10 S_FontAssetReferences       ( 000185D11D28 ModelClassListType List`1<TMP_FontAsset> List`1<TMP_FontAsset> List<TMP_FontAsset> Pointer )

            return value;
        }
    }
}
