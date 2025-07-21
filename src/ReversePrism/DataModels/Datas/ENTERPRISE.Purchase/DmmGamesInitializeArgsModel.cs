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
    // 010 KeyOnetimeToken                          ModelPrimitiveType string string string String
    // 018 KeyOpenId                                ModelPrimitiveType string string string String
    // 020 KeyAccessToken                           ModelPrimitiveType string string string String
    // 010 ViewerId                                 ModelPrimitiveType string string string String
    // 018 AccessToken                              ModelPrimitiveType string string string String
    // 020 OpenId                                   ModelPrimitiveType string string string String
    // 028 OnetimeToken                             ModelPrimitiveType string string string String
    public partial class DmmGamesInitializeArgsModel : DataModel
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
            var value   = new DmmGamesInitializeArgsModel() { Pointer= p0 };

            value.KeyOnetimeToken                           = GetString(new IntPtr(p + 0x010)); // 0x10 KeyOnetimeToken             ( ModelPrimitiveType string string string String )
            value.KeyOpenId                                 = GetString(new IntPtr(p + 0x018)); // 0x18 KeyOpenId                   ( ModelPrimitiveType string string string String )
            value.KeyAccessToken                            = GetString(new IntPtr(p + 0x020)); // 0x20 KeyAccessToken              ( ModelPrimitiveType string string string String )
            value.ViewerId                                  = GetString(new IntPtr(p + 0x010)); // 0x10 ViewerId                    ( ModelPrimitiveType string string string String )
            value.AccessToken                               = GetString(new IntPtr(p + 0x018)); // 0x18 AccessToken                 ( ModelPrimitiveType string string string String )
            value.OpenId                                    = GetString(new IntPtr(p + 0x020)); // 0x20 OpenId                      ( ModelPrimitiveType string string string String )
            value.OnetimeToken                              = GetString(new IntPtr(p + 0x028)); // 0x28 OnetimeToken                ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
