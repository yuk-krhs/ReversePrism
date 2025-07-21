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
    // 018 UserId                                   ModelPrimitiveType string string string String
    // 000 SecretFieldNumber                        int IL2CPP_TYPE_I4
    // 020 Secret                                   ModelPrimitiveType string string string String
    // 000 DeviceNameFieldNumber                    int IL2CPP_TYPE_I4
    // 028 DeviceName                               ModelPrimitiveType string string string String
    // 000 OsNameFieldNumber                        int IL2CPP_TYPE_I4
    // 030 OsName                                   ModelPrimitiveType string string string String
    // 000 OsVersionFieldNumber                     int IL2CPP_TYPE_I4
    // 038 OsVersion                                ModelPrimitiveType string string string String
    // 000 AdIdFieldNumber                          int IL2CPP_TYPE_I4
    // 040 AdId                                     ModelPrimitiveType string string string String
    // 000 SpaceFieldNumber                         int IL2CPP_TYPE_I4
    // 048 Space                                    ModelPrimitiveType long long long Int64
    // 000 ViewerIdFieldNumber                      int IL2CPP_TYPE_I4
    // 050 ViewerId                                 ModelPrimitiveType long long long Int64
    // 000 ViewerIdSignatureFieldNumber             int IL2CPP_TYPE_I4
    // 058 ViewerIdSignature                        ModelPrimitiveType string string string String
    public partial class LoginArgs : DataModel
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
            var value   = new LoginArgs() { Pointer= p0 };

            value.UserId                                    = GetString(new IntPtr(p + 0x018)); // 0x18 UserId                      ( ModelPrimitiveType string string string String )
            value.Secret                                    = GetString(new IntPtr(p + 0x020)); // 0x20 Secret                      ( ModelPrimitiveType string string string String )
            value.DeviceName                                = GetString(new IntPtr(p + 0x028)); // 0x28 DeviceName                  ( ModelPrimitiveType string string string String )
            value.OsName                                    = GetString(new IntPtr(p + 0x030)); // 0x30 OsName                      ( ModelPrimitiveType string string string String )
            value.OsVersion                                 = GetString(new IntPtr(p + 0x038)); // 0x38 OsVersion                   ( ModelPrimitiveType string string string String )
            value.AdId                                      = GetString(new IntPtr(p + 0x040)); // 0x40 AdId                        ( ModelPrimitiveType string string string String )
            value.Space                                     = GetInt64(new IntPtr(p + 0x048)); // 0x48 Space                       ( ModelPrimitiveType long long long Int64 )
            value.ViewerId                                  = GetInt64(new IntPtr(p + 0x050)); // 0x50 ViewerId                    ( ModelPrimitiveType long long long Int64 )
            value.ViewerIdSignature                         = GetString(new IntPtr(p + 0x058)); // 0x58 ViewerIdSignature           ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
