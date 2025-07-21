using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Request                                  ModelClassType HttpWebRequest HttpWebRequest HttpWebRequest Pointer
    // 018 ConnectUri                               ModelClassType Uri Uri Uri Pointer
    // 020 ConnectRequest                           ModelClassType HttpWebRequest HttpWebRequest HttpWebRequest Pointer
    // 028 NtlmAuthState                            ModelEnumType NtlmAuthState NtlmAuthState NtlmAuthState Int32
    // 02C Success                                  ModelPrimitiveType bool bool bool Bool
    // 02D CloseConnection                          ModelPrimitiveType bool bool bool Bool
    // 030 StatusCode                               ModelPrimitiveType int int int Int32
    // 038 StatusDescription                        ModelPrimitiveType string string string String
    // 040 Challenge                                ModelPrimitiveListType string[] string[] List<string> Pointer
    // 048 Headers                                  ModelClassType WebHeaderCollection WebHeaderCollection WebHeaderCollection Pointer
    // 050 ProxyVersion                             ModelClassType Version Version Version Pointer
    // 058 Data                                     ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
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

            value.Request                                   = GetObject<HttpWebRequest>(new IntPtr(p + 0x010), ReversePrism.DataModels.HttpWebRequest.FromPointer); // 0x10 Request                     ( ModelClassType HttpWebRequest HttpWebRequest HttpWebRequest Pointer )
            value.ConnectUri                                = GetObject<Uri>(new IntPtr(p + 0x018), ReversePrism.DataModels.Uri.FromPointer); // 0x18 ConnectUri                  ( ModelClassType Uri Uri Uri Pointer )
            value.ConnectRequest                            = GetObject<HttpWebRequest>(new IntPtr(p + 0x020), ReversePrism.DataModels.HttpWebRequest.FromPointer); // 0x20 ConnectRequest              ( ModelClassType HttpWebRequest HttpWebRequest HttpWebRequest Pointer )
            value.NtlmAuthState                             = (NtlmAuthState)GetInt32(new IntPtr(p + 0x028)); // 0x28 NtlmAuthState               ( ModelEnumType NtlmAuthState NtlmAuthState NtlmAuthState Int32 )
            value.Success                                   = GetBool(new IntPtr(p + 0x02C)); // 0x2C Success                     ( ModelPrimitiveType bool bool bool Bool )
            value.CloseConnection                           = GetBool(new IntPtr(p + 0x02D)); // 0x2D CloseConnection             ( ModelPrimitiveType bool bool bool Bool )
            value.StatusCode                                = GetInt32(new IntPtr(p + 0x030)); // 0x30 StatusCode                  ( ModelPrimitiveType int int int Int32 )
            value.StatusDescription                         = GetString(new IntPtr(p + 0x038)); // 0x38 StatusDescription           ( ModelPrimitiveType string string string String )
            value.Challenge                                 = GetStringList(new IntPtr(p + 0x040)); // 0x40 Challenge                   ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.Headers                                   = GetObject<WebHeaderCollection>(new IntPtr(p + 0x048), ReversePrism.DataModels.WebHeaderCollection.FromPointer); // 0x48 Headers                     ( ModelClassType WebHeaderCollection WebHeaderCollection WebHeaderCollection Pointer )
            value.ProxyVersion                              = GetObject<Version>(new IntPtr(p + 0x050), ReversePrism.DataModels.Version.FromPointer); // 0x50 ProxyVersion                ( ModelClassType Version Version Version Pointer )
            value.Data                                      = GetSByteList(new IntPtr(p + 0x058)); // 0x58 Data                        ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )

            return value;
        }
    }
}
