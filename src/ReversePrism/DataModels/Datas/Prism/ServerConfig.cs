using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 instance                                 ServerConfig IL2CPP_TYPE_CLASS
    // 018 Host                                     000186671910 ModelPrimitiveType string string string String
    // 020 GrpcPort                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 024 GrpcKeepAliveTimeMs                      0001865F2AF0 ModelPrimitiveType int int int Int32
    // 028 GrpcKeepAliveTimeoutMs                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 02C GrpcConnectTimeoutMs                     0001865F36C0 ModelPrimitiveType int int int Int32
    // 030 RequestTimeOutMs                         0001865F36C0 ModelPrimitiveType int int int Int32
    // 034 UseCredentials                           000186595960 ModelPrimitiveType bool bool bool Bool
    // 035 UseEncryption                            000186595960 ModelPrimitiveType bool bool bool Bool
    // 036 UseTrace                                 000186595960 ModelPrimitiveType bool bool bool Bool
    // 038 Definitions                              000185B81990 ModelPrimitiveListType string[] string[] List<string> Pointer
    public partial class ServerConfig : DataModel
    {
        public string                                   Host                                    { get; set; }
        public int                                      GrpcPort                                { get; set; }
        public int                                      GrpcKeepAliveTimeMs                     { get; set; }
        public int                                      GrpcKeepAliveTimeoutMs                  { get; set; }
        public int                                      GrpcConnectTimeoutMs                    { get; set; }
        public int                                      RequestTimeOutMs                        { get; set; }
        public bool                                     UseCredentials                          { get; set; }
        public bool                                     UseEncryption                           { get; set; }
        public bool                                     UseTrace                                { get; set; }
        public List<string>?                            Definitions                             { get; set; }

        public static ServerConfig? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ServerConfig() { Pointer= p0 };

            value.Host                                      = GetString(new IntPtr(p + 0x018)); // 024660E1B4E0 0x18 Host                        ( 000186671910 ModelPrimitiveType string string string String )
            value.GrpcPort                                  = GetInt32(new IntPtr(p + 0x020)); // 024660E1B500 0x20 GrpcPort                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.GrpcKeepAliveTimeMs                       = GetInt32(new IntPtr(p + 0x024)); // 024660E1B520 0x24 GrpcKeepAliveTimeMs         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.GrpcKeepAliveTimeoutMs                    = GetInt32(new IntPtr(p + 0x028)); // 024660E1B540 0x28 GrpcKeepAliveTimeoutMs      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.GrpcConnectTimeoutMs                      = GetInt32(new IntPtr(p + 0x02C)); // 024660E1B560 0x2C GrpcConnectTimeoutMs        ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.RequestTimeOutMs                          = GetInt32(new IntPtr(p + 0x030)); // 024660E1B580 0x30 RequestTimeOutMs            ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.UseCredentials                            = GetBool(new IntPtr(p + 0x034)); // 024660E1B5A0 0x34 UseCredentials              ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.UseEncryption                             = GetBool(new IntPtr(p + 0x035)); // 024660E1B5C0 0x35 UseEncryption               ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.UseTrace                                  = GetBool(new IntPtr(p + 0x036)); // 024660E1B5E0 0x36 UseTrace                    ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.Definitions                               = GetStringList(new IntPtr(p + 0x038)); // 024660E1B600 0x38 Definitions                 ( 000185B81990 ModelPrimitiveListType string[] string[] List<string> Pointer )

            return value;
        }
    }
}
