using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Request                                  0001866E5D00 ModelClassType HttpWebRequest HttpWebRequest HttpWebRequest Pointer
    // 018 ConnectUri                               0001866A4C30 ModelClassType Uri Uri Uri Pointer
    // 020 ConnectRequest                           0001866E5800 ModelClassType HttpWebRequest HttpWebRequest HttpWebRequest Pointer
    // 028 NtlmAuthState                            00018670A4F0 ModelEnumType NtlmAuthState NtlmAuthState NtlmAuthState Int32
    // 02C Success                                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 02D CloseConnection                          000186594D10 ModelPrimitiveType bool bool bool Bool
    // 030 StatusCode                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 038 StatusDescription                        000186671910 ModelPrimitiveType string string string String
    // 040 Challenge                                000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 048 Headers                                  00018654B520 ModelClassType WebHeaderCollection WebHeaderCollection WebHeaderCollection Pointer
    // 050 ProxyVersion                             0001866B0CC0 ModelClassType Version Version Version Pointer
    // 058 Data                                     000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    public partial class WebConnectionTunnel
    {
        public HttpWebRequest?                          Request                                 { get; set; }
        public Uri?                                     ConnectUri                              { get; set; }
        public HttpWebRequest?                          ConnectRequest                          { get; set; }
        public NtlmAuthState                            NtlmAuthState                           { get; set; }
        public bool                                     Success                                 { get; set; }
        public bool                                     CloseConnection                         { get; set; }
        public int                                      StatusCode                              { get; set; }
        public string                                   StatusDescription                       { get; set; }
        public List<string>?                            Challenge                               { get; set; }
        public WebHeaderCollection?                     Headers                                 { get; set; }
        public Version?                                 ProxyVersion                            { get; set; }
        public List<sbyte>?                             Data                                    { get; set; }

        public static WebConnectionTunnel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WebConnectionTunnel();

            value.Request                                   = GetObject<HttpWebRequest>(new IntPtr(p + 0x010), ReversePrism.DataModels.HttpWebRequest.FromPointer); // 0270D7934860 0x10 Request                     ( 0001866E5D00 ModelClassType HttpWebRequest HttpWebRequest HttpWebRequest Pointer )
            value.ConnectUri                                = GetObject<Uri>(new IntPtr(p + 0x018), ReversePrism.DataModels.Uri.FromPointer); // 0270D7934880 0x18 ConnectUri                  ( 0001866A4C30 ModelClassType Uri Uri Uri Pointer )
            value.ConnectRequest                            = GetObject<HttpWebRequest>(new IntPtr(p + 0x020), ReversePrism.DataModels.HttpWebRequest.FromPointer); // 0270D79348A0 0x20 ConnectRequest              ( 0001866E5800 ModelClassType HttpWebRequest HttpWebRequest HttpWebRequest Pointer )
            value.NtlmAuthState                             = (NtlmAuthState)GetInt32(new IntPtr(p + 0x028)); // 0270D79348C0 0x28 NtlmAuthState               ( 00018670A4F0 ModelEnumType NtlmAuthState NtlmAuthState NtlmAuthState Int32 )
            value.Success                                   = GetBool(new IntPtr(p + 0x02C)); // 0270D79348E0 0x2C Success                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.CloseConnection                           = GetBool(new IntPtr(p + 0x02D)); // 0270D7934900 0x2D CloseConnection             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.StatusCode                                = GetInt32(new IntPtr(p + 0x030)); // 0270D7934920 0x30 StatusCode                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.StatusDescription                         = GetString(new IntPtr(p + 0x038)); // 0270D7934940 0x38 StatusDescription           ( 000186671910 ModelPrimitiveType string string string String )
            value.Challenge                                 = GetStringList(new IntPtr(p + 0x040)); // 0270D7934960 0x40 Challenge                   ( 000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.Headers                                   = GetObject<WebHeaderCollection>(new IntPtr(p + 0x048), ReversePrism.DataModels.WebHeaderCollection.FromPointer); // 0270D7934980 0x48 Headers                     ( 00018654B520 ModelClassType WebHeaderCollection WebHeaderCollection WebHeaderCollection Pointer )
            value.ProxyVersion                              = GetObject<Version>(new IntPtr(p + 0x050), ReversePrism.DataModels.Version.FromPointer); // 0270D79349A0 0x50 ProxyVersion                ( 0001866B0CC0 ModelClassType Version Version Version Pointer )
            value.Data                                      = GetSByteList(new IntPtr(p + 0x058)); // 0270D79349C0 0x58 Data                        ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )

            return value;
        }
    }
}
