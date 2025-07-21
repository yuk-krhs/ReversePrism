using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 servicePoints                            ConcurrentDictionary`2<SPKey, ServicePoint> IL2CPP_TYPE_GENERICINST
    // 008 policy                                   ICertificatePolicy IL2CPP_TYPE_CLASS
    // 010 DefaultConnectionLimit                   ModelPrimitiveType int int int Int32
    // 014 MaxServicePointIdleTime                  ModelPrimitiveType int int int Int32
    // 018 MaxServicePoints                         ModelPrimitiveType int int int Int32
    // 01C DnsRefreshTimeout                        ModelPrimitiveType int int int Int32
    // 020 CheckCRL                                 ModelPrimitiveType bool bool bool Bool
    // 024 SecurityProtocol                         ModelEnumType SecurityProtocolType SecurityProtocolType SecurityProtocolType Int32
    // 028 ExpectContinue                           ModelPrimitiveType bool bool bool Bool
    // 029 UseNagle                                 ModelPrimitiveType bool bool bool Bool
    // 030 Server_cert_cb                           ModelClassType ServerCertValidationCallback ServerCertValidationCallback ServerCertValidationCallback Pointer
    // 038 Tcp_keepalive                            ModelPrimitiveType bool bool bool Bool
    // 03C Tcp_keepalive_time                       ModelPrimitiveType int int int Int32
    // 040 Tcp_keepalive_interval                   ModelPrimitiveType int int int Int32
    public partial class ServicePointManager : DataModel
    {
        public int                                      DefaultConnectionLimit                  { get; set; }
        public int                                      MaxServicePointIdleTime                 { get; set; }
        public int                                      MaxServicePoints                        { get; set; }
        public int                                      DnsRefreshTimeout                       { get; set; }
        public bool                                     CheckCRL                                { get; set; }
        public SecurityProtocolType                     SecurityProtocol                        { get; set; }
        public bool                                     ExpectContinue                          { get; set; }
        public bool                                     UseNagle                                { get; set; }
        public ServerCertValidationCallback?            Server_cert_cb                          { get; set; }
        public bool                                     Tcp_keepalive                           { get; set; }
        public int                                      Tcp_keepalive_time                      { get; set; }
        public int                                      Tcp_keepalive_interval                  { get; set; }

        public static ServicePointManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ServicePointManager() { Pointer= p0 };

            value.DefaultConnectionLimit                    = GetInt32(new IntPtr(p + 0x010)); // 0x10 DefaultConnectionLimit      ( ModelPrimitiveType int int int Int32 )
            value.MaxServicePointIdleTime                   = GetInt32(new IntPtr(p + 0x014)); // 0x14 MaxServicePointIdleTime     ( ModelPrimitiveType int int int Int32 )
            value.MaxServicePoints                          = GetInt32(new IntPtr(p + 0x018)); // 0x18 MaxServicePoints            ( ModelPrimitiveType int int int Int32 )
            value.DnsRefreshTimeout                         = GetInt32(new IntPtr(p + 0x01C)); // 0x1C DnsRefreshTimeout           ( ModelPrimitiveType int int int Int32 )
            value.CheckCRL                                  = GetBool(new IntPtr(p + 0x020)); // 0x20 CheckCRL                    ( ModelPrimitiveType bool bool bool Bool )
            value.SecurityProtocol                          = (SecurityProtocolType)GetInt32(new IntPtr(p + 0x024)); // 0x24 SecurityProtocol            ( ModelEnumType SecurityProtocolType SecurityProtocolType SecurityProtocolType Int32 )
            value.ExpectContinue                            = GetBool(new IntPtr(p + 0x028)); // 0x28 ExpectContinue              ( ModelPrimitiveType bool bool bool Bool )
            value.UseNagle                                  = GetBool(new IntPtr(p + 0x029)); // 0x29 UseNagle                    ( ModelPrimitiveType bool bool bool Bool )
            value.Server_cert_cb                            = GetObject<ServerCertValidationCallback>(new IntPtr(p + 0x030), ReversePrism.DataModels.ServerCertValidationCallback.FromPointer); // 0x30 Server_cert_cb              ( ModelClassType ServerCertValidationCallback ServerCertValidationCallback ServerCertValidationCallback Pointer )
            value.Tcp_keepalive                             = GetBool(new IntPtr(p + 0x038)); // 0x38 Tcp_keepalive               ( ModelPrimitiveType bool bool bool Bool )
            value.Tcp_keepalive_time                        = GetInt32(new IntPtr(p + 0x03C)); // 0x3C Tcp_keepalive_time          ( ModelPrimitiveType int int int Int32 )
            value.Tcp_keepalive_interval                    = GetInt32(new IntPtr(p + 0x040)); // 0x40 Tcp_keepalive_interval      ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
