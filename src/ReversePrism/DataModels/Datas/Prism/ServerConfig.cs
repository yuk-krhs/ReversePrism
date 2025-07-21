using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 instance                                 ServerConfig IL2CPP_TYPE_CLASS
    // 018 Host                                     ModelPrimitiveType string string string String
    // 020 GrpcPort                                 ModelPrimitiveType int int int Int32
    // 024 GrpcKeepAliveTimeMs                      ModelPrimitiveType int int int Int32
    // 028 GrpcKeepAliveTimeoutMs                   ModelPrimitiveType int int int Int32
    // 02C GrpcConnectTimeoutMs                     ModelPrimitiveType int int int Int32
    // 030 RequestTimeOutMs                         ModelPrimitiveType int int int Int32
    // 034 UseCredentials                           ModelPrimitiveType bool bool bool Bool
    // 035 UseEncryption                            ModelPrimitiveType bool bool bool Bool
    // 036 UseTrace                                 ModelPrimitiveType bool bool bool Bool
    // 038 Definitions                              ModelPrimitiveListType string[] string[] List<string> Pointer
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

            value.Host                                      = GetString(new IntPtr(p + 0x018)); // 0x18 Host                        ( ModelPrimitiveType string string string String )
            value.GrpcPort                                  = GetInt32(new IntPtr(p + 0x020)); // 0x20 GrpcPort                    ( ModelPrimitiveType int int int Int32 )
            value.GrpcKeepAliveTimeMs                       = GetInt32(new IntPtr(p + 0x024)); // 0x24 GrpcKeepAliveTimeMs         ( ModelPrimitiveType int int int Int32 )
            value.GrpcKeepAliveTimeoutMs                    = GetInt32(new IntPtr(p + 0x028)); // 0x28 GrpcKeepAliveTimeoutMs      ( ModelPrimitiveType int int int Int32 )
            value.GrpcConnectTimeoutMs                      = GetInt32(new IntPtr(p + 0x02C)); // 0x2C GrpcConnectTimeoutMs        ( ModelPrimitiveType int int int Int32 )
            value.RequestTimeOutMs                          = GetInt32(new IntPtr(p + 0x030)); // 0x30 RequestTimeOutMs            ( ModelPrimitiveType int int int Int32 )
            value.UseCredentials                            = GetBool(new IntPtr(p + 0x034)); // 0x34 UseCredentials              ( ModelPrimitiveType bool bool bool Bool )
            value.UseEncryption                             = GetBool(new IntPtr(p + 0x035)); // 0x35 UseEncryption               ( ModelPrimitiveType bool bool bool Bool )
            value.UseTrace                                  = GetBool(new IntPtr(p + 0x036)); // 0x36 UseTrace                    ( ModelPrimitiveType bool bool bool Bool )
            value.Definitions                               = GetStringList(new IntPtr(p + 0x038)); // 0x38 Definitions                 ( ModelPrimitiveListType string[] string[] List<string> Pointer )

            return value;
        }
    }
}
