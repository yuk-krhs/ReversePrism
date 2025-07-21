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
    // 010 ApplicationPlatform                      ModelPrimitiveType string string string String
    // 018 ApplicationVersion                       ModelPrimitiveType string string string String
    // 020 UnityVersion                             ModelPrimitiveType string string string String
    // 028 DeviceTime                               ModelPrimitiveType string string string String
    // 030 DeviceName                               ModelPrimitiveType string string string String
    // 038 OsName                                   ModelPrimitiveType string string string String
    // 040 OsVersion                                ModelPrimitiveType string string string String
    // 048 PlatformUserId                           ModelPrimitiveType string string string String
    // 050 ApplicationUserId                        ModelPrimitiveType string string string String
    // 058 ApplicationUserLanguage                  ModelPrimitiveType string string string String
    // 060 ApplicationUserCountry                   ModelPrimitiveType string string string String
    // 068 Encryption                               ModelPrimitiveType string string string String
    // 070 ServerToken                              ModelPrimitiveType string string string String
    // 078 VersionHash                              ModelPrimitiveType string string string String
    // 080 EncryptionCompress                       ModelPrimitiveType string string string String
    // 088 EncryptionMode                           ModelPrimitiveType string string string String
    public partial class WebHeader : DataModel
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
            var value   = new WebHeader() { Pointer= p0 };

            value.ApplicationPlatform                       = GetString(new IntPtr(p + 0x010)); // 0x10 ApplicationPlatform         ( ModelPrimitiveType string string string String )
            value.ApplicationVersion                        = GetString(new IntPtr(p + 0x018)); // 0x18 ApplicationVersion          ( ModelPrimitiveType string string string String )
            value.UnityVersion                              = GetString(new IntPtr(p + 0x020)); // 0x20 UnityVersion                ( ModelPrimitiveType string string string String )
            value.DeviceTime                                = GetString(new IntPtr(p + 0x028)); // 0x28 DeviceTime                  ( ModelPrimitiveType string string string String )
            value.DeviceName                                = GetString(new IntPtr(p + 0x030)); // 0x30 DeviceName                  ( ModelPrimitiveType string string string String )
            value.OsName                                    = GetString(new IntPtr(p + 0x038)); // 0x38 OsName                      ( ModelPrimitiveType string string string String )
            value.OsVersion                                 = GetString(new IntPtr(p + 0x040)); // 0x40 OsVersion                   ( ModelPrimitiveType string string string String )
            value.PlatformUserId                            = GetString(new IntPtr(p + 0x048)); // 0x48 PlatformUserId              ( ModelPrimitiveType string string string String )
            value.ApplicationUserId                         = GetString(new IntPtr(p + 0x050)); // 0x50 ApplicationUserId           ( ModelPrimitiveType string string string String )
            value.ApplicationUserLanguage                   = GetString(new IntPtr(p + 0x058)); // 0x58 ApplicationUserLanguage     ( ModelPrimitiveType string string string String )
            value.ApplicationUserCountry                    = GetString(new IntPtr(p + 0x060)); // 0x60 ApplicationUserCountry      ( ModelPrimitiveType string string string String )
            value.Encryption                                = GetString(new IntPtr(p + 0x068)); // 0x68 Encryption                  ( ModelPrimitiveType string string string String )
            value.ServerToken                               = GetString(new IntPtr(p + 0x070)); // 0x70 ServerToken                 ( ModelPrimitiveType string string string String )
            value.VersionHash                               = GetString(new IntPtr(p + 0x078)); // 0x78 VersionHash                 ( ModelPrimitiveType string string string String )
            value.EncryptionCompress                        = GetString(new IntPtr(p + 0x080)); // 0x80 EncryptionCompress          ( ModelPrimitiveType string string string String )
            value.EncryptionMode                            = GetString(new IntPtr(p + 0x088)); // 0x88 EncryptionMode              ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
