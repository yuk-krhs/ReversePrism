using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 defaultPrefix                            string IL2CPP_TYPE_STRING
    // 008 keyViewerId                              string IL2CPP_TYPE_STRING
    // 010 KeyOnetimeToken                          0001866738F0 ModelPrimitiveType string string string String
    // 018 KeyOpenId                                0001866738F0 ModelPrimitiveType string string string String
    // 020 KeyAccessToken                           0001866738F0 ModelPrimitiveType string string string String
    // 010 ViewerId                                 000186671910 ModelPrimitiveType string string string String
    // 018 AccessToken                              000186671910 ModelPrimitiveType string string string String
    // 020 OpenId                                   000186671910 ModelPrimitiveType string string string String
    // 028 OnetimeToken                             000186671910 ModelPrimitiveType string string string String
    public partial class DmmGamesInitializeArgsModel
    {
        public string                                   KeyOnetimeToken                         { get; set; }
        public string                                   KeyOpenId                               { get; set; }
        public string                                   KeyAccessToken                          { get; set; }
        public string                                   ViewerId                                { get; set; }
        public string                                   AccessToken                             { get; set; }
        public string                                   OpenId                                  { get; set; }
        public string                                   OnetimeToken                            { get; set; }

        public static DmmGamesInitializeArgsModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DmmGamesInitializeArgsModel();

            value.KeyOnetimeToken                           = GetString(new IntPtr(p + 0x010)); // 027003C77350 0x10 KeyOnetimeToken             ( 0001866738F0 ModelPrimitiveType string string string String )
            value.KeyOpenId                                 = GetString(new IntPtr(p + 0x018)); // 027003C77370 0x18 KeyOpenId                   ( 0001866738F0 ModelPrimitiveType string string string String )
            value.KeyAccessToken                            = GetString(new IntPtr(p + 0x020)); // 027003C77390 0x20 KeyAccessToken              ( 0001866738F0 ModelPrimitiveType string string string String )
            value.ViewerId                                  = GetString(new IntPtr(p + 0x010)); // 027003C773B0 0x10 ViewerId                    ( 000186671910 ModelPrimitiveType string string string String )
            value.AccessToken                               = GetString(new IntPtr(p + 0x018)); // 027003C773D0 0x18 AccessToken                 ( 000186671910 ModelPrimitiveType string string string String )
            value.OpenId                                    = GetString(new IntPtr(p + 0x020)); // 027003C773F0 0x20 OpenId                      ( 000186671910 ModelPrimitiveType string string string String )
            value.OnetimeToken                              = GetString(new IntPtr(p + 0x028)); // 027003C77410 0x28 OnetimeToken                ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
