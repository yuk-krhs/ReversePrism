using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetAssetVersionReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 AssetUrlFieldNumber                      int IL2CPP_TYPE_I4
    // 018 AssetUrl                                 000186671910 ModelPrimitiveType string string string String
    // 000 AssetIndexNameFieldNumber                int IL2CPP_TYPE_I4
    // 020 AssetIndexName                           000186671910 ModelPrimitiveType string string string String
    // 000 AssetVersionFieldNumber                  int IL2CPP_TYPE_I4
    // 028 AssetVersion                             000186671910 ModelPrimitiveType string string string String
    public partial class GetAssetVersionReply
    {
        public string                                   AssetUrl                                { get; set; }
        public string                                   AssetIndexName                          { get; set; }
        public string                                   AssetVersion                            { get; set; }

        public static GetAssetVersionReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetAssetVersionReply();

            value.AssetUrl                                  = GetString(new IntPtr(p + 0x018)); // 0270D0B1F980 0x18 AssetUrl                    ( 000186671910 ModelPrimitiveType string string string String )
            value.AssetIndexName                            = GetString(new IntPtr(p + 0x020)); // 0270D0B1F9C0 0x20 AssetIndexName              ( 000186671910 ModelPrimitiveType string string string String )
            value.AssetVersion                              = GetString(new IntPtr(p + 0x028)); // 0270D0B1FA00 0x28 AssetVersion                ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
