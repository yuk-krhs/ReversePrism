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
    public partial class WebConnectionTunnel : DataModel
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
            var value   = new WebConnectionTunnel() { Pointer= p0 };

            value.Request                                   = GetObject<HttpWebRequest>(new IntPtr(p + 0x010), ReversePrism.DataModels.HttpWebRequest.FromPointer); // 02466799C860 0x10 Request                     ( 0001866E5D00 ModelClassType HttpWebRequest HttpWebRequest HttpWebRequest Pointer )
            value.ConnectUri                                = GetObject<Uri>(new IntPtr(p + 0x018), ReversePrism.DataModels.Uri.FromPointer); // 02466799C880 0x18 ConnectUri                  ( 0001866A4C30 ModelClassType Uri Uri Uri Pointer )
            value.ConnectRequest                            = GetObject<HttpWebRequest>(new IntPtr(p + 0x020), ReversePrism.DataModels.HttpWebRequest.FromPointer); // 02466799C8A0 0x20 ConnectRequest              ( 0001866E5800 ModelClassType HttpWebRequest HttpWebRequest HttpWebRequest Pointer )
            value.NtlmAuthState                             = (NtlmAuthState)GetInt32(new IntPtr(p + 0x028)); // 02466799C8C0 0x28 NtlmAuthState               ( 00018670A4F0 ModelEnumType NtlmAuthState NtlmAuthState NtlmAuthState Int32 )
            value.Success                                   = GetBool(new IntPtr(p + 0x02C)); // 02466799C8E0 0x2C Success                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.CloseConnection                           = GetBool(new IntPtr(p + 0x02D)); // 02466799C900 0x2D CloseConnection             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.StatusCode                                = GetInt32(new IntPtr(p + 0x030)); // 02466799C920 0x30 StatusCode                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.StatusDescription                         = GetString(new IntPtr(p + 0x038)); // 02466799C940 0x38 StatusDescription           ( 000186671910 ModelPrimitiveType string string string String )
            value.Challenge                                 = GetStringList(new IntPtr(p + 0x040)); // 02466799C960 0x40 Challenge                   ( 000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.Headers                                   = GetObject<WebHeaderCollection>(new IntPtr(p + 0x048), ReversePrism.DataModels.WebHeaderCollection.FromPointer); // 02466799C980 0x48 Headers                     ( 00018654B520 ModelClassType WebHeaderCollection WebHeaderCollection WebHeaderCollection Pointer )
            value.ProxyVersion                              = GetObject<Version>(new IntPtr(p + 0x050), ReversePrism.DataModels.Version.FromPointer); // 02466799C9A0 0x50 ProxyVersion                ( 0001866B0CC0 ModelClassType Version Version Version Pointer )
            value.Data                                      = GetSByteList(new IntPtr(p + 0x058)); // 02466799C9C0 0x58 Data                        ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )

            return value;
        }
    }
}
