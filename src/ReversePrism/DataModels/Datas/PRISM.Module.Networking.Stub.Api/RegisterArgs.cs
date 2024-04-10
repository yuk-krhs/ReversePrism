using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<RegisterArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 CountryFieldNumber                       int IL2CPP_TYPE_I4
    // 018 Country                                  000186671910 ModelPrimitiveType string string string String
    // 000 PlatformFieldNumber                      int IL2CPP_TYPE_I4
    // 020 Platform                                 000186671910 ModelPrimitiveType string string string String
    // 000 PlatformUserIdFieldNumber                int IL2CPP_TYPE_I4
    // 028 PlatformUserId                           000186671910 ModelPrimitiveType string string string String
    // 000 DeviceNameFieldNumber                    int IL2CPP_TYPE_I4
    // 030 DeviceName                               000186671910 ModelPrimitiveType string string string String
    // 000 AdIdFieldNumber                          int IL2CPP_TYPE_I4
    // 038 AdId                                     000186671910 ModelPrimitiveType string string string String
    // 000 ViewerIdFieldNumber                      int IL2CPP_TYPE_I4
    // 040 ViewerId                                 0001865F7700 ModelPrimitiveType long long long Int64
    // 000 ViewerIdSignatureFieldNumber             int IL2CPP_TYPE_I4
    // 048 ViewerIdSignature                        000186671910 ModelPrimitiveType string string string String
    public partial class RegisterArgs : DataModel
    {
        public string                                   Country                                 { get; set; }
        public string                                   Platform                                { get; set; }
        public string                                   PlatformUserId                          { get; set; }
        public string                                   DeviceName                              { get; set; }
        public string                                   AdId                                    { get; set; }
        public long                                     ViewerId                                { get; set; }
        public string                                   ViewerIdSignature                       { get; set; }

        public static RegisterArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RegisterArgs() { Pointer= p0 };

            value.Country                                   = GetString(new IntPtr(p + 0x018)); // 024660B5DCE8 0x18 Country                     ( 000186671910 ModelPrimitiveType string string string String )
            value.Platform                                  = GetString(new IntPtr(p + 0x020)); // 024660B5DD28 0x20 Platform                    ( 000186671910 ModelPrimitiveType string string string String )
            value.PlatformUserId                            = GetString(new IntPtr(p + 0x028)); // 024660B5DD68 0x28 PlatformUserId              ( 000186671910 ModelPrimitiveType string string string String )
            value.DeviceName                                = GetString(new IntPtr(p + 0x030)); // 024660B5DDA8 0x30 DeviceName                  ( 000186671910 ModelPrimitiveType string string string String )
            value.AdId                                      = GetString(new IntPtr(p + 0x038)); // 024660B5DDE8 0x38 AdId                        ( 000186671910 ModelPrimitiveType string string string String )
            value.ViewerId                                  = GetInt64(new IntPtr(p + 0x040)); // 024660B5DE28 0x40 ViewerId                    ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.ViewerIdSignature                         = GetString(new IntPtr(p + 0x048)); // 024660B5DE68 0x48 ViewerIdSignature           ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
