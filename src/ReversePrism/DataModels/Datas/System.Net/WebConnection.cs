using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Ntlm_credentials                         00018669A8D0 ModelClassType NetworkCredential NetworkCredential NetworkCredential Pointer
    // 018 Ntlm_authenticated                       000186594D10 ModelPrimitiveType bool bool bool Bool
    // 019 Unsafe_sharing                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 020 NetworkStream                            000186670270 ModelClassType Stream Stream Stream Pointer
    // 028 Socket                                   0001865214F0 ModelClassType Socket Socket Socket Pointer
    // 030 MonoTlsStream                            00018664D800 ModelClassType MonoTlsStream MonoTlsStream MonoTlsStream Pointer
    // 038 Tunnel                                   000186549370 ModelClassType WebConnectionTunnel WebConnectionTunnel WebConnectionTunnel Pointer
    // 040 Disposed                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 048 ServicePoint                             000186739110 ModelClassType ServicePoint ServicePoint ServicePoint Pointer
    // 050 IdleSince                                0001865B9010 ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 058 CurrentOperation                         00018654C440 ModelClassType WebOperation WebOperation WebOperation Pointer
    public partial class WebConnection : DataModel
    {
        public NetworkCredential?                       Ntlm_credentials                        { get; set; }
        public bool                                     Ntlm_authenticated                      { get; set; }
        public bool                                     Unsafe_sharing                          { get; set; }
        public Stream?                                  NetworkStream                           { get; set; }
        public Socket?                                  Socket                                  { get; set; }
        public MonoTlsStream?                           MonoTlsStream                           { get; set; }
        public WebConnectionTunnel?                     Tunnel                                  { get; set; }
        public int                                      Disposed                                { get; set; }
        public ServicePoint?                            ServicePoint                            { get; set; }
        public DateTime                                 IdleSince                               { get; set; }
        public WebOperation?                            CurrentOperation                        { get; set; }

        public static WebConnection? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WebConnection() { Pointer= p0 };

            value.Ntlm_credentials                          = GetObject<NetworkCredential>(new IntPtr(p + 0x010), ReversePrism.DataModels.NetworkCredential.FromPointer); // 024667AFAB00 0x10 Ntlm_credentials            ( 00018669A8D0 ModelClassType NetworkCredential NetworkCredential NetworkCredential Pointer )
            value.Ntlm_authenticated                        = GetBool(new IntPtr(p + 0x018)); // 024667AFAB20 0x18 Ntlm_authenticated          ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Unsafe_sharing                            = GetBool(new IntPtr(p + 0x019)); // 024667AFAB40 0x19 Unsafe_sharing              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.NetworkStream                             = GetObject<Stream>(new IntPtr(p + 0x020), ReversePrism.DataModels.Stream.FromPointer); // 024667AFAB60 0x20 NetworkStream               ( 000186670270 ModelClassType Stream Stream Stream Pointer )
            value.Socket                                    = GetObject<Socket>(new IntPtr(p + 0x028), ReversePrism.DataModels.Socket.FromPointer); // 024667AFAB80 0x28 Socket                      ( 0001865214F0 ModelClassType Socket Socket Socket Pointer )
            value.MonoTlsStream                             = GetObject<MonoTlsStream>(new IntPtr(p + 0x030), ReversePrism.DataModels.MonoTlsStream.FromPointer); // 024667AFABA0 0x30 MonoTlsStream               ( 00018664D800 ModelClassType MonoTlsStream MonoTlsStream MonoTlsStream Pointer )
            value.Tunnel                                    = GetObject<WebConnectionTunnel>(new IntPtr(p + 0x038), ReversePrism.DataModels.WebConnectionTunnel.FromPointer); // 024667AFABC0 0x38 Tunnel                      ( 000186549370 ModelClassType WebConnectionTunnel WebConnectionTunnel WebConnectionTunnel Pointer )
            value.Disposed                                  = GetInt32(new IntPtr(p + 0x040)); // 024667AFABE0 0x40 Disposed                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ServicePoint                              = GetObject<ServicePoint>(new IntPtr(p + 0x048), ReversePrism.DataModels.ServicePoint.FromPointer); // 024667AFAC00 0x48 ServicePoint                ( 000186739110 ModelClassType ServicePoint ServicePoint ServicePoint Pointer )
            value.IdleSince                                 = GetDateTime(new IntPtr(p + 0x050)); // 024667AFAC20 0x50 IdleSince                   ( 0001865B9010 ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.CurrentOperation                          = GetObject<WebOperation>(new IntPtr(p + 0x058), ReversePrism.DataModels.WebOperation.FromPointer); // 024667AFAC40 0x58 CurrentOperation            ( 00018654C440 ModelClassType WebOperation WebOperation WebOperation Pointer )

            return value;
        }
    }
}
