using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_Instance                               TMP_FontAssetUtilities IL2CPP_TYPE_CLASS
    // 008 k_SearchedAssets                         HashSet`1<int> IL2CPP_TYPE_GENERICINST
    // 010 K_IsFontEngineInitialized                ModelPrimitiveType bool bool bool Bool
    public partial class TMP_FontAssetUtilities : DataModel
    {
        public bool                                     K_IsFontEngineInitialized               { get; set; }

        public static TMP_FontAssetUtilities? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TMP_FontAssetUtilities() { Pointer= p0 };

            value.K_IsFontEngineInitialized                 = GetBool(new IntPtr(p + 0x010)); // 0x10 K_IsFontEngineInitialized   ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
