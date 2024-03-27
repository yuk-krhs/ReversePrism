using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<LoginArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 UserIdFieldNumber                        int IL2CPP_TYPE_I4
    // 018 UserId                                   000186671910 ModelPrimitiveType string string string String
    // 000 SecretFieldNumber                        int IL2CPP_TYPE_I4
    // 020 Secret                                   000186671910 ModelPrimitiveType string string string String
    // 000 DeviceNameFieldNumber                    int IL2CPP_TYPE_I4
    // 028 DeviceName                               000186671910 ModelPrimitiveType string string string String
    // 000 OsNameFieldNumber                        int IL2CPP_TYPE_I4
    // 030 OsName                                   000186671910 ModelPrimitiveType string string string String
    // 000 OsVersionFieldNumber                     int IL2CPP_TYPE_I4
    // 038 OsVersion                                000186671910 ModelPrimitiveType string string string String
    // 000 AdIdFieldNumber                          int IL2CPP_TYPE_I4
    // 040 AdId                                     000186671910 ModelPrimitiveType string string string String
    // 000 SpaceFieldNumber                         int IL2CPP_TYPE_I4
    // 048 Space                                    0001865F7700 ModelPrimitiveType long long long Int64
    // 000 ViewerIdFieldNumber                      int IL2CPP_TYPE_I4
    // 050 ViewerId                                 0001865F7700 ModelPrimitiveType long long long Int64
    // 000 ViewerIdSignatureFieldNumber             int IL2CPP_TYPE_I4
    // 058 ViewerIdSignature                        000186671910 ModelPrimitiveType string string string String
    public partial class LoginArgs
    {
        public string                                   UserId                                  { get; set; }
        public string                                   Secret                                  { get; set; }
        public string                                   DeviceName                              { get; set; }
        public string                                   OsName                                  { get; set; }
        public string                                   OsVersion                               { get; set; }
        public string                                   AdId                                    { get; set; }
        public long                                     Space                                   { get; set; }
        public long                                     ViewerId                                { get; set; }
        public string                                   ViewerIdSignature                       { get; set; }

        public static LoginArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LoginArgs();

            value.UserId                                    = GetString(new IntPtr(p + 0x018)); // 0270D0B6A550 0x18 UserId                      ( 000186671910 ModelPrimitiveType string string string String )
            value.Secret                                    = GetString(new IntPtr(p + 0x020)); // 0270D0B6A590 0x20 Secret                      ( 000186671910 ModelPrimitiveType string string string String )
            value.DeviceName                                = GetString(new IntPtr(p + 0x028)); // 0270D0B6A5D0 0x28 DeviceName                  ( 000186671910 ModelPrimitiveType string string string String )
            value.OsName                                    = GetString(new IntPtr(p + 0x030)); // 0270D0B6A610 0x30 OsName                      ( 000186671910 ModelPrimitiveType string string string String )
            value.OsVersion                                 = GetString(new IntPtr(p + 0x038)); // 0270D0B6A650 0x38 OsVersion                   ( 000186671910 ModelPrimitiveType string string string String )
            value.AdId                                      = GetString(new IntPtr(p + 0x040)); // 0270D0B6A690 0x40 AdId                        ( 000186671910 ModelPrimitiveType string string string String )
            value.Space                                     = GetInt64(new IntPtr(p + 0x048)); // 0270D0B6A6D0 0x48 Space                       ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.ViewerId                                  = GetInt64(new IntPtr(p + 0x050)); // 0270D0B6A710 0x50 ViewerId                    ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.ViewerIdSignature                         = GetString(new IntPtr(p + 0x058)); // 0270D0B6A750 0x58 ViewerIdSignature           ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
