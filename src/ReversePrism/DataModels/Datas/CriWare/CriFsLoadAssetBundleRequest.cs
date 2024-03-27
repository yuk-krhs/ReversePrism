using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 Path                                     000186671910 ModelPrimitiveType string string string String
    // 048 AssetBundle                              0001866E34F0 ModelClassType AssetBundle AssetBundle AssetBundle Pointer
    // 050 LoadFileReq                              000186651D20 ModelClassType CriFsLoadFileRequest CriFsLoadFileRequest CriFsLoadFileRequest Pointer
    // 058 AssetBundleReq                           0001866E39D0 ModelClassType AssetBundleCreateRequest AssetBundleCreateRequest AssetBundleCreateRequest Pointer
    public partial class CriFsLoadAssetBundleRequest
    {
        public string                                   Path                                    { get; set; }
        public AssetBundle?                             AssetBundle                             { get; set; }
        public CriFsLoadFileRequest?                    LoadFileReq                             { get; set; }
        public AssetBundleCreateRequest?                AssetBundleReq                          { get; set; }

        public static CriFsLoadAssetBundleRequest? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CriFsLoadAssetBundleRequest();

            value.Path                                      = GetString(new IntPtr(p + 0x040)); // 0270DACB5E88 0x40 Path                        ( 000186671910 ModelPrimitiveType string string string String )
            value.AssetBundle                               = GetObject<AssetBundle>(new IntPtr(p + 0x048), ReversePrism.DataModels.AssetBundle.FromPointer); // 0270DACB5EA8 0x48 AssetBundle                 ( 0001866E34F0 ModelClassType AssetBundle AssetBundle AssetBundle Pointer )
            value.LoadFileReq                               = GetObject<CriFsLoadFileRequest>(new IntPtr(p + 0x050), ReversePrism.DataModels.CriFsLoadFileRequest.FromPointer); // 0270DACB5EC8 0x50 LoadFileReq                 ( 000186651D20 ModelClassType CriFsLoadFileRequest CriFsLoadFileRequest CriFsLoadFileRequest Pointer )
            value.AssetBundleReq                            = GetObject<AssetBundleCreateRequest>(new IntPtr(p + 0x058), ReversePrism.DataModels.AssetBundleCreateRequest.FromPointer); // 0270DACB5EE8 0x58 AssetBundleReq              ( 0001866E39D0 ModelClassType AssetBundleCreateRequest AssetBundleCreateRequest AssetBundleCreateRequest Pointer )

            return value;
        }
    }
}
