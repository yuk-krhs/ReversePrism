using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Uwr                                      ModelClassType UnityWebRequest UnityWebRequest UnityWebRequest Pointer
    // 018 AssetBundle                              ModelClassType AssetBundle AssetBundle AssetBundle Pointer
    // 020 _responseHeaders                         Dictionary`2<string, string> IL2CPP_TYPE_GENERICINST
    public partial class WWW : DataModel
    {
        public UnityWebRequest?                         Uwr                                     { get; set; }
        public AssetBundle?                             AssetBundle                             { get; set; }

        public static WWW? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WWW() { Pointer= p0 };

            value.Uwr                                       = GetObject<UnityWebRequest>(new IntPtr(p + 0x010), ReversePrism.DataModels.UnityWebRequest.FromPointer); // 0x10 Uwr                         ( ModelClassType UnityWebRequest UnityWebRequest UnityWebRequest Pointer )
            value.AssetBundle                               = GetObject<AssetBundle>(new IntPtr(p + 0x018), ReversePrism.DataModels.AssetBundle.FromPointer); // 0x18 AssetBundle                 ( ModelClassType AssetBundle AssetBundle AssetBundle Pointer )

            return value;
        }
    }
}
