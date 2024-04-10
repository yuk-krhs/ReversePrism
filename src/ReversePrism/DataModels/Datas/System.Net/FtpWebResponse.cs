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
    public partial class FtpWebResponse : DataModel
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
            var value   = new FtpWebResponse() { Pointer= p0 };

            value.ResponseStream                            = GetObject<Stream>(new IntPtr(p + 0x020), ReversePrism.DataModels.Stream.FromPointer); // 024667A6E100 0x20 ResponseStream              ( 000186670490 ModelClassType Stream Stream Stream Pointer )
            value.ContentLength                             = GetInt64(new IntPtr(p + 0x028)); // 024667A6E120 0x28 ContentLength               ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.ResponseUri                               = GetObject<Uri>(new IntPtr(p + 0x030), ReversePrism.DataModels.Uri.FromPointer); // 024667A6E140 0x30 ResponseUri                 ( 0001866A4270 ModelClassType Uri Uri Uri Pointer )
            value.StatusCode                                = (FtpStatusCode)GetInt32(new IntPtr(p + 0x038)); // 024667A6E160 0x38 StatusCode                  ( 0001865D0BD0 ModelEnumType FtpStatusCode FtpStatusCode FtpStatusCode Int32 )
            value.StatusLine                                = GetString(new IntPtr(p + 0x040)); // 024667A6E180 0x40 StatusLine                  ( 000186671910 ModelPrimitiveType string string string String )
            value.FtpRequestHeaders                         = GetObject<WebHeaderCollection>(new IntPtr(p + 0x048), ReversePrism.DataModels.WebHeaderCollection.FromPointer); // 024667A6E1A0 0x48 FtpRequestHeaders           ( 00018654B520 ModelClassType WebHeaderCollection WebHeaderCollection WebHeaderCollection Pointer )
            value.LastModified                              = GetDateTime(new IntPtr(p + 0x050)); // 024667A6E1C0 0x50 LastModified                ( 0001865B9010 ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.BannerMessage                             = GetString(new IntPtr(p + 0x058)); // 024667A6E1E0 0x58 BannerMessage               ( 000186671910 ModelPrimitiveType string string string String )
            value.WelcomeMessage                            = GetString(new IntPtr(p + 0x060)); // 024667A6E200 0x60 WelcomeMessage              ( 000186671910 ModelPrimitiveType string string string String )
            value.ExitMessage                               = GetString(new IntPtr(p + 0x068)); // 024667A6E220 0x68 ExitMessage                 ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
