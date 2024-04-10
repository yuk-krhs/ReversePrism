using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Uri                                      0001866A4C30 ModelClassType Uri Uri Uri Pointer
    // 018 LastDnsResolve                           0001865B9010 ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 020 ProtocolVersion                          0001866B0CC0 ModelClassType Version Version Version Pointer
    // 028 Host                                     0001865CE8D0 ModelClassType IPHostEntry IPHostEntry IPHostEntry Pointer
    // 030 UsesProxy                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 031 SendContinue                             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 032 UseConnect                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 038 hostE                                    <object> IL2CPP_TYPE_OBJECT
    // 040 UseNagle                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 048 EndPointCallback                         00018675C880 ModelClassType BindIPEndPoint BindIPEndPoint BindIPEndPoint Pointer
    // 050 Tcp_keepalive                            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 054 Tcp_keepalive_time                       0001865F2AF0 ModelPrimitiveType int int int Int32
    // 058 Tcp_keepalive_interval                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 05C Disposed                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 060 ConnectionLeaseTimeout                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 064 ReceiveBufferSize                        0001865F2AF0 ModelPrimitiveType int int int Int32
    // 068 Key                                      0001867624A0 ModelClassType SPKey SPKey SPKey Pointer
    // 070 Scheduler                                000186739A40 ModelClassType ServicePointScheduler ServicePointScheduler ServicePointScheduler Pointer
    // 078 ConnectionLimit                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 07C MaxIdleTime                              0001865F2AF0 ModelPrimitiveType int int int Int32
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

            value.Uri                                       = GetObject<Uri>(new IntPtr(p + 0x010), ReversePrism.DataModels.Uri.FromPointer); // 024667A8B400 0x10 Uri                         ( 0001866A4C30 ModelClassType Uri Uri Uri Pointer )
            value.LastDnsResolve                            = GetDateTime(new IntPtr(p + 0x018)); // 024667A8B420 0x18 LastDnsResolve              ( 0001865B9010 ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.ProtocolVersion                           = GetObject<Version>(new IntPtr(p + 0x020), ReversePrism.DataModels.Version.FromPointer); // 024667A8B440 0x20 ProtocolVersion             ( 0001866B0CC0 ModelClassType Version Version Version Pointer )
            value.Host                                      = GetObject<IPHostEntry>(new IntPtr(p + 0x028), ReversePrism.DataModels.IPHostEntry.FromPointer); // 024667A8B460 0x28 Host                        ( 0001865CE8D0 ModelClassType IPHostEntry IPHostEntry IPHostEntry Pointer )
            value.UsesProxy                                 = GetBool(new IntPtr(p + 0x030)); // 024667A8B480 0x30 UsesProxy                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.SendContinue                              = GetBool(new IntPtr(p + 0x031)); // 024667A8B4A0 0x31 SendContinue                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.UseConnect                                = GetBool(new IntPtr(p + 0x032)); // 024667A8B4C0 0x32 UseConnect                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.UseNagle                                  = GetBool(new IntPtr(p + 0x040)); // 024667A8B500 0x40 UseNagle                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.EndPointCallback                          = GetObject<BindIPEndPoint>(new IntPtr(p + 0x048), ReversePrism.DataModels.BindIPEndPoint.FromPointer); // 024667A8B520 0x48 EndPointCallback            ( 00018675C880 ModelClassType BindIPEndPoint BindIPEndPoint BindIPEndPoint Pointer )
            value.Tcp_keepalive                             = GetBool(new IntPtr(p + 0x050)); // 024667A8B540 0x50 Tcp_keepalive               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Tcp_keepalive_time                        = GetInt32(new IntPtr(p + 0x054)); // 024667A8B560 0x54 Tcp_keepalive_time          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Tcp_keepalive_interval                    = GetInt32(new IntPtr(p + 0x058)); // 024667A8B580 0x58 Tcp_keepalive_interval      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Disposed                                  = GetBool(new IntPtr(p + 0x05C)); // 024667A8B5A0 0x5C Disposed                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ConnectionLeaseTimeout                    = GetInt32(new IntPtr(p + 0x060)); // 024667A8B5C0 0x60 ConnectionLeaseTimeout      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ReceiveBufferSize                         = GetInt32(new IntPtr(p + 0x064)); // 024667A8B5E0 0x64 ReceiveBufferSize           ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Key                                       = GetObject<SPKey>(new IntPtr(p + 0x068), ReversePrism.DataModels.SPKey.FromPointer); // 024667A8B600 0x68 Key                         ( 0001867624A0 ModelClassType SPKey SPKey SPKey Pointer )
            value.Scheduler                                 = GetObject<ServicePointScheduler>(new IntPtr(p + 0x070), ReversePrism.DataModels.ServicePointScheduler.FromPointer); // 024667A8B620 0x70 Scheduler                   ( 000186739A40 ModelClassType ServicePointScheduler ServicePointScheduler ServicePointScheduler Pointer )
            value.ConnectionLimit                           = GetInt32(new IntPtr(p + 0x078)); // 024667A8B640 0x78 ConnectionLimit             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MaxIdleTime                               = GetInt32(new IntPtr(p + 0x07C)); // 024667A8B660 0x7C MaxIdleTime                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
