using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ResponseStream                           000186670490 ModelClassType Stream Stream Stream Pointer
    // 028 ContentLength                            0001865F7700 ModelPrimitiveType long long long Int64
    // 030 ResponseUri                              0001866A4270 ModelClassType Uri Uri Uri Pointer
    // 038 StatusCode                               0001865D0BD0 ModelEnumType FtpStatusCode FtpStatusCode FtpStatusCode Int32
    // 040 StatusLine                               000186671910 ModelPrimitiveType string string string String
    // 048 FtpRequestHeaders                        00018654B520 ModelClassType WebHeaderCollection WebHeaderCollection WebHeaderCollection Pointer
    // 050 LastModified                             0001865B9010 ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 058 BannerMessage                            000186671910 ModelPrimitiveType string string string String
    // 060 WelcomeMessage                           000186671910 ModelPrimitiveType string string string String
    // 068 ExitMessage                              000186671910 ModelPrimitiveType string string string String
    public partial class FtpWebResponse
    {
        public Stream?                                  ResponseStream                          { get; set; }
        public long                                     ContentLength                           { get; set; }
        public Uri?                                     ResponseUri                             { get; set; }
        public FtpStatusCode                            StatusCode                              { get; set; }
        public string                                   StatusLine                              { get; set; }
        public WebHeaderCollection?                     FtpRequestHeaders                       { get; set; }
        public DateTime                                 LastModified                            { get; set; }
        public string                                   BannerMessage                           { get; set; }
        public string                                   WelcomeMessage                          { get; set; }
        public string                                   ExitMessage                             { get; set; }

        public static FtpWebResponse? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FtpWebResponse();

            value.ResponseStream                            = GetObject<Stream>(new IntPtr(p + 0x020), ReversePrism.DataModels.Stream.FromPointer); // 0270D7A16100 0x20 ResponseStream              ( 000186670490 ModelClassType Stream Stream Stream Pointer )
            value.ContentLength                             = GetInt64(new IntPtr(p + 0x028)); // 0270D7A16120 0x28 ContentLength               ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.ResponseUri                               = GetObject<Uri>(new IntPtr(p + 0x030), ReversePrism.DataModels.Uri.FromPointer); // 0270D7A16140 0x30 ResponseUri                 ( 0001866A4270 ModelClassType Uri Uri Uri Pointer )
            value.StatusCode                                = (FtpStatusCode)GetInt32(new IntPtr(p + 0x038)); // 0270D7A16160 0x38 StatusCode                  ( 0001865D0BD0 ModelEnumType FtpStatusCode FtpStatusCode FtpStatusCode Int32 )
            value.StatusLine                                = GetString(new IntPtr(p + 0x040)); // 0270D7A16180 0x40 StatusLine                  ( 000186671910 ModelPrimitiveType string string string String )
            value.FtpRequestHeaders                         = GetObject<WebHeaderCollection>(new IntPtr(p + 0x048), ReversePrism.DataModels.WebHeaderCollection.FromPointer); // 0270D7A161A0 0x48 FtpRequestHeaders           ( 00018654B520 ModelClassType WebHeaderCollection WebHeaderCollection WebHeaderCollection Pointer )
            value.LastModified                              = GetDateTime(new IntPtr(p + 0x050)); // 0270D7A161C0 0x50 LastModified                ( 0001865B9010 ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.BannerMessage                             = GetString(new IntPtr(p + 0x058)); // 0270D7A161E0 0x58 BannerMessage               ( 000186671910 ModelPrimitiveType string string string String )
            value.WelcomeMessage                            = GetString(new IntPtr(p + 0x060)); // 0270D7A16200 0x60 WelcomeMessage              ( 000186671910 ModelPrimitiveType string string string String )
            value.ExitMessage                               = GetString(new IntPtr(p + 0x068)); // 0270D7A16220 0x68 ExitMessage                 ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
