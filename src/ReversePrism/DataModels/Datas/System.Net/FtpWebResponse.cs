using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ResponseStream                           ModelClassType Stream Stream Stream Pointer
    // 028 ContentLength                            ModelPrimitiveType long long long Int64
    // 030 ResponseUri                              ModelClassType Uri Uri Uri Pointer
    // 038 StatusCode                               ModelEnumType FtpStatusCode FtpStatusCode FtpStatusCode Int32
    // 040 StatusLine                               ModelPrimitiveType string string string String
    // 048 FtpRequestHeaders                        ModelClassType WebHeaderCollection WebHeaderCollection WebHeaderCollection Pointer
    // 050 LastModified                             ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 058 BannerMessage                            ModelPrimitiveType string string string String
    // 060 WelcomeMessage                           ModelPrimitiveType string string string String
    // 068 ExitMessage                              ModelPrimitiveType string string string String
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

            value.ResponseStream                            = GetObject<Stream>(new IntPtr(p + 0x020), ReversePrism.DataModels.Stream.FromPointer); // 0x20 ResponseStream              ( ModelClassType Stream Stream Stream Pointer )
            value.ContentLength                             = GetInt64(new IntPtr(p + 0x028)); // 0x28 ContentLength               ( ModelPrimitiveType long long long Int64 )
            value.ResponseUri                               = GetObject<Uri>(new IntPtr(p + 0x030), ReversePrism.DataModels.Uri.FromPointer); // 0x30 ResponseUri                 ( ModelClassType Uri Uri Uri Pointer )
            value.StatusCode                                = (FtpStatusCode)GetInt32(new IntPtr(p + 0x038)); // 0x38 StatusCode                  ( ModelEnumType FtpStatusCode FtpStatusCode FtpStatusCode Int32 )
            value.StatusLine                                = GetString(new IntPtr(p + 0x040)); // 0x40 StatusLine                  ( ModelPrimitiveType string string string String )
            value.FtpRequestHeaders                         = GetObject<WebHeaderCollection>(new IntPtr(p + 0x048), ReversePrism.DataModels.WebHeaderCollection.FromPointer); // 0x48 FtpRequestHeaders           ( ModelClassType WebHeaderCollection WebHeaderCollection WebHeaderCollection Pointer )
            value.LastModified                              = GetDateTime(new IntPtr(p + 0x050)); // 0x50 LastModified                ( ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.BannerMessage                             = GetString(new IntPtr(p + 0x058)); // 0x58 BannerMessage               ( ModelPrimitiveType string string string String )
            value.WelcomeMessage                            = GetString(new IntPtr(p + 0x060)); // 0x60 WelcomeMessage              ( ModelPrimitiveType string string string String )
            value.ExitMessage                               = GetString(new IntPtr(p + 0x068)); // 0x68 ExitMessage                 ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
