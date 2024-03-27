using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 ContentType                              string IL2CPP_TYPE_STRING
    // 008 Authorization                            string IL2CPP_TYPE_STRING
    // 010 ApplicationPlatform                      000186674040 ModelPrimitiveType string string string String
    // 018 ApplicationVersion                       000186674040 ModelPrimitiveType string string string String
    // 020 UnityVersion                             000186674040 ModelPrimitiveType string string string String
    // 028 DeviceTime                               000186674040 ModelPrimitiveType string string string String
    // 030 DeviceName                               000186674040 ModelPrimitiveType string string string String
    // 038 OsName                                   000186674040 ModelPrimitiveType string string string String
    // 040 OsVersion                                000186674040 ModelPrimitiveType string string string String
    // 048 PlatformUserId                           000186674040 ModelPrimitiveType string string string String
    // 050 ApplicationUserId                        000186674040 ModelPrimitiveType string string string String
    // 058 ApplicationUserLanguage                  000186674040 ModelPrimitiveType string string string String
    // 060 ApplicationUserCountry                   000186674040 ModelPrimitiveType string string string String
    // 068 Encryption                               000186674040 ModelPrimitiveType string string string String
    // 070 ServerToken                              000186674040 ModelPrimitiveType string string string String
    // 078 VersionHash                              000186674040 ModelPrimitiveType string string string String
    // 080 EncryptionCompress                       000186674040 ModelPrimitiveType string string string String
    // 088 EncryptionMode                           000186674040 ModelPrimitiveType string string string String
    public partial class WebHeader
    {
        public string                                   ApplicationPlatform                     { get; set; }
        public string                                   ApplicationVersion                      { get; set; }
        public string                                   UnityVersion                            { get; set; }
        public string                                   DeviceTime                              { get; set; }
        public string                                   DeviceName                              { get; set; }
        public string                                   OsName                                  { get; set; }
        public string                                   OsVersion                               { get; set; }
        public string                                   PlatformUserId                          { get; set; }
        public string                                   ApplicationUserId                       { get; set; }
        public string                                   ApplicationUserLanguage                 { get; set; }
        public string                                   ApplicationUserCountry                  { get; set; }
        public string                                   Encryption                              { get; set; }
        public string                                   ServerToken                             { get; set; }
        public string                                   VersionHash                             { get; set; }
        public string                                   EncryptionCompress                      { get; set; }
        public string                                   EncryptionMode                          { get; set; }

        public static WebHeader? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WebHeader();

            value.ApplicationPlatform                       = GetString(new IntPtr(p + 0x010)); // 0270DB6B2A00 0x10 ApplicationPlatform         ( 000186674040 ModelPrimitiveType string string string String )
            value.ApplicationVersion                        = GetString(new IntPtr(p + 0x018)); // 0270DB6B2A20 0x18 ApplicationVersion          ( 000186674040 ModelPrimitiveType string string string String )
            value.UnityVersion                              = GetString(new IntPtr(p + 0x020)); // 0270DB6B2A40 0x20 UnityVersion                ( 000186674040 ModelPrimitiveType string string string String )
            value.DeviceTime                                = GetString(new IntPtr(p + 0x028)); // 0270DB6B2A60 0x28 DeviceTime                  ( 000186674040 ModelPrimitiveType string string string String )
            value.DeviceName                                = GetString(new IntPtr(p + 0x030)); // 0270DB6B2A80 0x30 DeviceName                  ( 000186674040 ModelPrimitiveType string string string String )
            value.OsName                                    = GetString(new IntPtr(p + 0x038)); // 0270DB6B2AA0 0x38 OsName                      ( 000186674040 ModelPrimitiveType string string string String )
            value.OsVersion                                 = GetString(new IntPtr(p + 0x040)); // 0270DB6B2AC0 0x40 OsVersion                   ( 000186674040 ModelPrimitiveType string string string String )
            value.PlatformUserId                            = GetString(new IntPtr(p + 0x048)); // 0270DB6B2AE0 0x48 PlatformUserId              ( 000186674040 ModelPrimitiveType string string string String )
            value.ApplicationUserId                         = GetString(new IntPtr(p + 0x050)); // 0270DB6B2B00 0x50 ApplicationUserId           ( 000186674040 ModelPrimitiveType string string string String )
            value.ApplicationUserLanguage                   = GetString(new IntPtr(p + 0x058)); // 0270DB6B2B20 0x58 ApplicationUserLanguage     ( 000186674040 ModelPrimitiveType string string string String )
            value.ApplicationUserCountry                    = GetString(new IntPtr(p + 0x060)); // 0270DB6B2B40 0x60 ApplicationUserCountry      ( 000186674040 ModelPrimitiveType string string string String )
            value.Encryption                                = GetString(new IntPtr(p + 0x068)); // 0270DB6B2B60 0x68 Encryption                  ( 000186674040 ModelPrimitiveType string string string String )
            value.ServerToken                               = GetString(new IntPtr(p + 0x070)); // 0270DB6B2B80 0x70 ServerToken                 ( 000186674040 ModelPrimitiveType string string string String )
            value.VersionHash                               = GetString(new IntPtr(p + 0x078)); // 0270DB6B2BA0 0x78 VersionHash                 ( 000186674040 ModelPrimitiveType string string string String )
            value.EncryptionCompress                        = GetString(new IntPtr(p + 0x080)); // 0270DB6B2BC0 0x80 EncryptionCompress          ( 000186674040 ModelPrimitiveType string string string String )
            value.EncryptionMode                            = GetString(new IntPtr(p + 0x088)); // 0270DB6B2BE0 0x88 EncryptionMode              ( 000186674040 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
