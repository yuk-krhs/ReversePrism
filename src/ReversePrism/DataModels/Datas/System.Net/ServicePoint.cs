using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Uri                                      ModelClassType Uri Uri Uri Pointer
    // 018 LastDnsResolve                           ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 020 ProtocolVersion                          ModelClassType Version Version Version Pointer
    // 028 Host                                     ModelClassType IPHostEntry IPHostEntry IPHostEntry Pointer
    // 030 UsesProxy                                ModelPrimitiveType bool bool bool Bool
    // 031 SendContinue                             ModelPrimitiveType bool bool bool Bool
    // 032 UseConnect                               ModelPrimitiveType bool bool bool Bool
    // 038 hostE                                    <object> IL2CPP_TYPE_OBJECT
    // 040 UseNagle                                 ModelPrimitiveType bool bool bool Bool
    // 048 EndPointCallback                         ModelClassType BindIPEndPoint BindIPEndPoint BindIPEndPoint Pointer
    // 050 Tcp_keepalive                            ModelPrimitiveType bool bool bool Bool
    // 054 Tcp_keepalive_time                       ModelPrimitiveType int int int Int32
    // 058 Tcp_keepalive_interval                   ModelPrimitiveType int int int Int32
    // 05C Disposed                                 ModelPrimitiveType bool bool bool Bool
    // 060 ConnectionLeaseTimeout                   ModelPrimitiveType int int int Int32
    // 064 ReceiveBufferSize                        ModelPrimitiveType int int int Int32
    // 068 Key                                      ModelClassType SPKey SPKey SPKey Pointer
    // 070 Scheduler                                ModelClassType ServicePointScheduler ServicePointScheduler ServicePointScheduler Pointer
    // 078 ConnectionLimit                          ModelPrimitiveType int int int Int32
    // 07C MaxIdleTime                              ModelPrimitiveType int int int Int32
    // 080 m_ServerCertificateOrBytes               <object> IL2CPP_TYPE_OBJECT
    // 088 m_ClientCertificateOrBytes               <object> IL2CPP_TYPE_OBJECT
    public partial class ServicePoint : DataModel
    {
        public Uri?                                     Uri                                     { get; set; }
        public DateTime                                 LastDnsResolve                          { get; set; }
        public Version?                                 ProtocolVersion                         { get; set; }
        public IPHostEntry?                             Host                                    { get; set; }
        public bool                                     UsesProxy                               { get; set; }
        public bool                                     SendContinue                            { get; set; }
        public bool                                     UseConnect                              { get; set; }
        public bool                                     UseNagle                                { get; set; }
        public BindIPEndPoint?                          EndPointCallback                        { get; set; }
        public bool                                     Tcp_keepalive                           { get; set; }
        public int                                      Tcp_keepalive_time                      { get; set; }
        public int                                      Tcp_keepalive_interval                  { get; set; }
        public bool                                     Disposed                                { get; set; }
        public int                                      ConnectionLeaseTimeout                  { get; set; }
        public int                                      ReceiveBufferSize                       { get; set; }
        public SPKey?                                   Key                                     { get; set; }
        public ServicePointScheduler?                   Scheduler                               { get; set; }
        public int                                      ConnectionLimit                         { get; set; }
        public int                                      MaxIdleTime                             { get; set; }

        public static ServicePoint? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ServicePoint() { Pointer= p0 };

            value.Uri                                       = GetObject<Uri>(new IntPtr(p + 0x010), ReversePrism.DataModels.Uri.FromPointer); // 0x10 Uri                         ( ModelClassType Uri Uri Uri Pointer )
            value.LastDnsResolve                            = GetDateTime(new IntPtr(p + 0x018)); // 0x18 LastDnsResolve              ( ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.ProtocolVersion                           = GetObject<Version>(new IntPtr(p + 0x020), ReversePrism.DataModels.Version.FromPointer); // 0x20 ProtocolVersion             ( ModelClassType Version Version Version Pointer )
            value.Host                                      = GetObject<IPHostEntry>(new IntPtr(p + 0x028), ReversePrism.DataModels.IPHostEntry.FromPointer); // 0x28 Host                        ( ModelClassType IPHostEntry IPHostEntry IPHostEntry Pointer )
            value.UsesProxy                                 = GetBool(new IntPtr(p + 0x030)); // 0x30 UsesProxy                   ( ModelPrimitiveType bool bool bool Bool )
            value.SendContinue                              = GetBool(new IntPtr(p + 0x031)); // 0x31 SendContinue                ( ModelPrimitiveType bool bool bool Bool )
            value.UseConnect                                = GetBool(new IntPtr(p + 0x032)); // 0x32 UseConnect                  ( ModelPrimitiveType bool bool bool Bool )
            value.UseNagle                                  = GetBool(new IntPtr(p + 0x040)); // 0x40 UseNagle                    ( ModelPrimitiveType bool bool bool Bool )
            value.EndPointCallback                          = GetObject<BindIPEndPoint>(new IntPtr(p + 0x048), ReversePrism.DataModels.BindIPEndPoint.FromPointer); // 0x48 EndPointCallback            ( ModelClassType BindIPEndPoint BindIPEndPoint BindIPEndPoint Pointer )
            value.Tcp_keepalive                             = GetBool(new IntPtr(p + 0x050)); // 0x50 Tcp_keepalive               ( ModelPrimitiveType bool bool bool Bool )
            value.Tcp_keepalive_time                        = GetInt32(new IntPtr(p + 0x054)); // 0x54 Tcp_keepalive_time          ( ModelPrimitiveType int int int Int32 )
            value.Tcp_keepalive_interval                    = GetInt32(new IntPtr(p + 0x058)); // 0x58 Tcp_keepalive_interval      ( ModelPrimitiveType int int int Int32 )
            value.Disposed                                  = GetBool(new IntPtr(p + 0x05C)); // 0x5C Disposed                    ( ModelPrimitiveType bool bool bool Bool )
            value.ConnectionLeaseTimeout                    = GetInt32(new IntPtr(p + 0x060)); // 0x60 ConnectionLeaseTimeout      ( ModelPrimitiveType int int int Int32 )
            value.ReceiveBufferSize                         = GetInt32(new IntPtr(p + 0x064)); // 0x64 ReceiveBufferSize           ( ModelPrimitiveType int int int Int32 )
            value.Key                                       = GetObject<SPKey>(new IntPtr(p + 0x068), ReversePrism.DataModels.SPKey.FromPointer); // 0x68 Key                         ( ModelClassType SPKey SPKey SPKey Pointer )
            value.Scheduler                                 = GetObject<ServicePointScheduler>(new IntPtr(p + 0x070), ReversePrism.DataModels.ServicePointScheduler.FromPointer); // 0x70 Scheduler                   ( ModelClassType ServicePointScheduler ServicePointScheduler ServicePointScheduler Pointer )
            value.ConnectionLimit                           = GetInt32(new IntPtr(p + 0x078)); // 0x78 ConnectionLimit             ( ModelPrimitiveType int int int Int32 )
            value.MaxIdleTime                               = GetInt32(new IntPtr(p + 0x07C)); // 0x7C MaxIdleTime                 ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
