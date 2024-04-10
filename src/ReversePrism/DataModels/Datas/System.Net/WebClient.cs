using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 BaseAddress                              0001866A4270 ModelClassType Uri Uri Uri Pointer
    // 030 Credentials                              000186745960 ModelClassType ICredentials ICredentials ICredentials Pointer
    // 038 Headers                                  00018654B520 ModelClassType WebHeaderCollection WebHeaderCollection WebHeaderCollection Pointer
    // 040 RequestParameters                        00018667CA00 ModelClassType NameValueCollection NameValueCollection NameValueCollection Pointer
    // 048 WebResponse                              000186550A80 ModelClassType WebResponse WebResponse WebResponse Pointer
    // 050 WebRequest                               00018654DAA0 ModelClassType WebRequest WebRequest WebRequest Pointer
    // 058 Encoding                                 00018672D9E0 ModelClassType Encoding Encoding Encoding Pointer
    // 060 Method                                   000186671910 ModelPrimitiveType string string string String
    // 068 ContentLength                            0001865F7700 ModelPrimitiveType long long long Int64
    // 070 InitWebClientAsync                       000186594D10 ModelPrimitiveType bool bool bool Bool
    // 071 Canceled                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 078 Progress                                 000186708730 ModelClassType ProgressData ProgressData ProgressData Pointer
    // 080 Proxy                                    00018669AB30 ModelClassType IWebProxy IWebProxy IWebProxy Pointer
    // 088 ProxySet                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 08C CallNesting                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 090 AsyncOp                                  0001866FA070 ModelClassType AsyncOperation AsyncOperation AsyncOperation Pointer
    // 098 DownloadDataOperationCompleted           000186724C20 ModelClassType SendOrPostCallback SendOrPostCallback SendOrPostCallback Pointer
    // 0A0 OpenReadOperationCompleted               000186724C20 ModelClassType SendOrPostCallback SendOrPostCallback SendOrPostCallback Pointer
    // 0A8 OpenWriteOperationCompleted              000186724C20 ModelClassType SendOrPostCallback SendOrPostCallback SendOrPostCallback Pointer
    // 0B0 DownloadStringOperationCompleted         000186724C20 ModelClassType SendOrPostCallback SendOrPostCallback SendOrPostCallback Pointer
    // 0B8 DownloadFileOperationCompleted           000186724C20 ModelClassType SendOrPostCallback SendOrPostCallback SendOrPostCallback Pointer
    // 0C0 UploadStringOperationCompleted           000186724C20 ModelClassType SendOrPostCallback SendOrPostCallback SendOrPostCallback Pointer
    // 0C8 UploadDataOperationCompleted             000186724C20 ModelClassType SendOrPostCallback SendOrPostCallback SendOrPostCallback Pointer
    // 0D0 UploadFileOperationCompleted             000186724C20 ModelClassType SendOrPostCallback SendOrPostCallback SendOrPostCallback Pointer
    // 0D8 UploadValuesOperationCompleted           000186724C20 ModelClassType SendOrPostCallback SendOrPostCallback SendOrPostCallback Pointer
    // 0E0 ReportDownloadProgressChanged            000186724C20 ModelClassType SendOrPostCallback SendOrPostCallback SendOrPostCallback Pointer
    // 0E8 ReportUploadProgressChanged              000186724C20 ModelClassType SendOrPostCallback SendOrPostCallback SendOrPostCallback Pointer
    // 0F0 DownloadStringCompleted                  0001866F2E70 ModelClassType DownloadStringCompletedEventHandler DownloadStringCompletedEventHandler DownloadStringCompletedEventHandler Pointer
    // 0F8 DownloadDataCompleted                    0001866F0260 ModelClassType DownloadDataCompletedEventHandler DownloadDataCompletedEventHandler DownloadDataCompletedEventHandler Pointer
    // 100 DownloadFileCompleted                    0001866F0D10 ModelClassType AsyncCompletedEventHandler AsyncCompletedEventHandler AsyncCompletedEventHandler Pointer
    // 108 UploadStringCompleted                    0001867450D0 ModelClassType UploadStringCompletedEventHandler UploadStringCompletedEventHandler UploadStringCompletedEventHandler Pointer
    // 110 UploadDataCompleted                      000186742F40 ModelClassType UploadDataCompletedEventHandler UploadDataCompletedEventHandler UploadDataCompletedEventHandler Pointer
    // 118 UploadFileCompleted                      0001867436C0 ModelClassType UploadFileCompletedEventHandler UploadFileCompletedEventHandler UploadFileCompletedEventHandler Pointer
    // 120 UploadValuesCompleted                    000186745A80 ModelClassType UploadValuesCompletedEventHandler UploadValuesCompletedEventHandler UploadValuesCompletedEventHandler Pointer
    // 128 OpenReadCompleted                        0001866E19D0 ModelClassType OpenReadCompletedEventHandler OpenReadCompletedEventHandler OpenReadCompletedEventHandler Pointer
    // 130 OpenWriteCompleted                       0001866E3020 ModelClassType OpenWriteCompletedEventHandler OpenWriteCompletedEventHandler OpenWriteCompletedEventHandler Pointer
    // 138 DownloadProgressChanged                  0001866F26C0 ModelClassType DownloadProgressChangedEventHandler DownloadProgressChangedEventHandler DownloadProgressChangedEventHandler Pointer
    // 140 UploadProgressChanged                    0001867449E0 ModelClassType UploadProgressChangedEventHandler UploadProgressChangedEventHandler UploadProgressChangedEventHandler Pointer
    // 148 CachePolicy                              0001866657A0 ModelClassType RequestCachePolicy RequestCachePolicy RequestCachePolicy Pointer
    // 000 s_parseContentTypeSeparators             char[] IL2CPP_TYPE_SZARRAY
    // 008 s_knownEncodings                         Encoding[] IL2CPP_TYPE_SZARRAY
    public partial class WebClient : DataModel
    {
        public Uri?                                     BaseAddress                             { get; set; }
        public ICredentials?                            Credentials                             { get; set; }
        public WebHeaderCollection?                     Headers                                 { get; set; }
        public NameValueCollection?                     RequestParameters                       { get; set; }
        public WebResponse?                             WebResponse                             { get; set; }
        public WebRequest?                              WebRequest                              { get; set; }
        public Encoding?                                Encoding                                { get; set; }
        public string                                   Method                                  { get; set; }
        public long                                     ContentLength                           { get; set; }
        public bool                                     InitWebClientAsync                      { get; set; }
        public bool                                     Canceled                                { get; set; }
        public ProgressData?                            Progress                                { get; set; }
        public IWebProxy?                               Proxy                                   { get; set; }
        public bool                                     ProxySet                                { get; set; }
        public int                                      CallNesting                             { get; set; }
        public AsyncOperation?                          AsyncOp                                 { get; set; }
        public SendOrPostCallback?                      DownloadDataOperationCompleted          { get; set; }
        public SendOrPostCallback?                      OpenReadOperationCompleted              { get; set; }
        public SendOrPostCallback?                      OpenWriteOperationCompleted             { get; set; }
        public SendOrPostCallback?                      DownloadStringOperationCompleted        { get; set; }
        public SendOrPostCallback?                      DownloadFileOperationCompleted          { get; set; }
        public SendOrPostCallback?                      UploadStringOperationCompleted          { get; set; }
        public SendOrPostCallback?                      UploadDataOperationCompleted            { get; set; }
        public SendOrPostCallback?                      UploadFileOperationCompleted            { get; set; }
        public SendOrPostCallback?                      UploadValuesOperationCompleted          { get; set; }
        public SendOrPostCallback?                      ReportDownloadProgressChanged           { get; set; }
        public SendOrPostCallback?                      ReportUploadProgressChanged             { get; set; }
        public DownloadStringCompletedEventHandler?     DownloadStringCompleted                 { get; set; }
        public DownloadDataCompletedEventHandler?       DownloadDataCompleted                   { get; set; }
        public AsyncCompletedEventHandler?              DownloadFileCompleted                   { get; set; }
        public UploadStringCompletedEventHandler?       UploadStringCompleted                   { get; set; }
        public UploadDataCompletedEventHandler?         UploadDataCompleted                     { get; set; }
        public UploadFileCompletedEventHandler?         UploadFileCompleted                     { get; set; }
        public UploadValuesCompletedEventHandler?       UploadValuesCompleted                   { get; set; }
        public OpenReadCompletedEventHandler?           OpenReadCompleted                       { get; set; }
        public OpenWriteCompletedEventHandler?          OpenWriteCompleted                      { get; set; }
        public DownloadProgressChangedEventHandler?     DownloadProgressChanged                 { get; set; }
        public UploadProgressChangedEventHandler?       UploadProgressChanged                   { get; set; }
        public RequestCachePolicy?                      CachePolicy                             { get; set; }

        public static WebClient? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WebClient() { Pointer= p0 };

            value.BaseAddress                               = GetObject<Uri>(new IntPtr(p + 0x028), ReversePrism.DataModels.Uri.FromPointer); // 024664F8DD08 0x28 BaseAddress                 ( 0001866A4270 ModelClassType Uri Uri Uri Pointer )
            value.Credentials                               = GetObject<ICredentials>(new IntPtr(p + 0x030), ReversePrism.DataModels.ICredentials.FromPointer); // 024664F8DD28 0x30 Credentials                 ( 000186745960 ModelClassType ICredentials ICredentials ICredentials Pointer )
            value.Headers                                   = GetObject<WebHeaderCollection>(new IntPtr(p + 0x038), ReversePrism.DataModels.WebHeaderCollection.FromPointer); // 024664F8DD48 0x38 Headers                     ( 00018654B520 ModelClassType WebHeaderCollection WebHeaderCollection WebHeaderCollection Pointer )
            value.RequestParameters                         = GetObject<NameValueCollection>(new IntPtr(p + 0x040), ReversePrism.DataModels.NameValueCollection.FromPointer); // 024664F8DD68 0x40 RequestParameters           ( 00018667CA00 ModelClassType NameValueCollection NameValueCollection NameValueCollection Pointer )
            value.WebResponse                               = GetObject<WebResponse>(new IntPtr(p + 0x048), ReversePrism.DataModels.WebResponse.FromPointer); // 024664F8DD88 0x48 WebResponse                 ( 000186550A80 ModelClassType WebResponse WebResponse WebResponse Pointer )
            value.WebRequest                                = GetObject<WebRequest>(new IntPtr(p + 0x050), ReversePrism.DataModels.WebRequest.FromPointer); // 024664F8DDA8 0x50 WebRequest                  ( 00018654DAA0 ModelClassType WebRequest WebRequest WebRequest Pointer )
            value.Encoding                                  = GetObject<Encoding>(new IntPtr(p + 0x058), ReversePrism.DataModels.Encoding.FromPointer); // 024664F8DDC8 0x58 Encoding                    ( 00018672D9E0 ModelClassType Encoding Encoding Encoding Pointer )
            value.Method                                    = GetString(new IntPtr(p + 0x060)); // 024664F8DDE8 0x60 Method                      ( 000186671910 ModelPrimitiveType string string string String )
            value.ContentLength                             = GetInt64(new IntPtr(p + 0x068)); // 024664F8DE08 0x68 ContentLength               ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.InitWebClientAsync                        = GetBool(new IntPtr(p + 0x070)); // 024664F8DE28 0x70 InitWebClientAsync          ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Canceled                                  = GetBool(new IntPtr(p + 0x071)); // 024664F8DE48 0x71 Canceled                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Progress                                  = GetObject<ProgressData>(new IntPtr(p + 0x078), ReversePrism.DataModels.ProgressData.FromPointer); // 024664F8DE68 0x78 Progress                    ( 000186708730 ModelClassType ProgressData ProgressData ProgressData Pointer )
            value.Proxy                                     = GetObject<IWebProxy>(new IntPtr(p + 0x080), ReversePrism.DataModels.IWebProxy.FromPointer); // 024664F8DE88 0x80 Proxy                       ( 00018669AB30 ModelClassType IWebProxy IWebProxy IWebProxy Pointer )
            value.ProxySet                                  = GetBool(new IntPtr(p + 0x088)); // 024664F8DEA8 0x88 ProxySet                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.CallNesting                               = GetInt32(new IntPtr(p + 0x08C)); // 024664F8DEC8 0x8C CallNesting                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.AsyncOp                                   = GetObject<AsyncOperation>(new IntPtr(p + 0x090), ReversePrism.DataModels.AsyncOperation.FromPointer); // 024664F8DEE8 0x90 AsyncOp                     ( 0001866FA070 ModelClassType AsyncOperation AsyncOperation AsyncOperation Pointer )
            value.DownloadDataOperationCompleted            = GetObject<SendOrPostCallback>(new IntPtr(p + 0x098), ReversePrism.DataModels.SendOrPostCallback.FromPointer); // 024664F8DF08 0x98 DownloadDataOperationCompleted ( 000186724C20 ModelClassType SendOrPostCallback SendOrPostCallback SendOrPostCallback Pointer )
            value.OpenReadOperationCompleted                = GetObject<SendOrPostCallback>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.SendOrPostCallback.FromPointer); // 024664F8DF28 0xA0 OpenReadOperationCompleted  ( 000186724C20 ModelClassType SendOrPostCallback SendOrPostCallback SendOrPostCallback Pointer )
            value.OpenWriteOperationCompleted               = GetObject<SendOrPostCallback>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.SendOrPostCallback.FromPointer); // 024664F8DF48 0xA8 OpenWriteOperationCompleted ( 000186724C20 ModelClassType SendOrPostCallback SendOrPostCallback SendOrPostCallback Pointer )
            value.DownloadStringOperationCompleted          = GetObject<SendOrPostCallback>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.SendOrPostCallback.FromPointer); // 024664F8DF68 0xB0 DownloadStringOperationCompleted ( 000186724C20 ModelClassType SendOrPostCallback SendOrPostCallback SendOrPostCallback Pointer )
            value.DownloadFileOperationCompleted            = GetObject<SendOrPostCallback>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.SendOrPostCallback.FromPointer); // 024664F8DF88 0xB8 DownloadFileOperationCompleted ( 000186724C20 ModelClassType SendOrPostCallback SendOrPostCallback SendOrPostCallback Pointer )
            value.UploadStringOperationCompleted            = GetObject<SendOrPostCallback>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.SendOrPostCallback.FromPointer); // 024664F8DFA8 0xC0 UploadStringOperationCompleted ( 000186724C20 ModelClassType SendOrPostCallback SendOrPostCallback SendOrPostCallback Pointer )
            value.UploadDataOperationCompleted              = GetObject<SendOrPostCallback>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.SendOrPostCallback.FromPointer); // 024664F8DFC8 0xC8 UploadDataOperationCompleted ( 000186724C20 ModelClassType SendOrPostCallback SendOrPostCallback SendOrPostCallback Pointer )
            value.UploadFileOperationCompleted              = GetObject<SendOrPostCallback>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.SendOrPostCallback.FromPointer); // 024664F8DFE8 0xD0 UploadFileOperationCompleted ( 000186724C20 ModelClassType SendOrPostCallback SendOrPostCallback SendOrPostCallback Pointer )
            value.UploadValuesOperationCompleted            = GetObject<SendOrPostCallback>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.SendOrPostCallback.FromPointer); // 024664F8E008 0xD8 UploadValuesOperationCompleted ( 000186724C20 ModelClassType SendOrPostCallback SendOrPostCallback SendOrPostCallback Pointer )
            value.ReportDownloadProgressChanged             = GetObject<SendOrPostCallback>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.SendOrPostCallback.FromPointer); // 024664F8E028 0xE0 ReportDownloadProgressChanged ( 000186724C20 ModelClassType SendOrPostCallback SendOrPostCallback SendOrPostCallback Pointer )
            value.ReportUploadProgressChanged               = GetObject<SendOrPostCallback>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.SendOrPostCallback.FromPointer); // 024664F8E048 0xE8 ReportUploadProgressChanged ( 000186724C20 ModelClassType SendOrPostCallback SendOrPostCallback SendOrPostCallback Pointer )
            value.DownloadStringCompleted                   = GetObject<DownloadStringCompletedEventHandler>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.DownloadStringCompletedEventHandler.FromPointer); // 024664F8E068 0xF0 DownloadStringCompleted     ( 0001866F2E70 ModelClassType DownloadStringCompletedEventHandler DownloadStringCompletedEventHandler DownloadStringCompletedEventHandler Pointer )
            value.DownloadDataCompleted                     = GetObject<DownloadDataCompletedEventHandler>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.DownloadDataCompletedEventHandler.FromPointer); // 024664F8E088 0xF8 DownloadDataCompleted       ( 0001866F0260 ModelClassType DownloadDataCompletedEventHandler DownloadDataCompletedEventHandler DownloadDataCompletedEventHandler Pointer )
            value.DownloadFileCompleted                     = GetObject<AsyncCompletedEventHandler>(new IntPtr(p + 0x100), ReversePrism.DataModels.AsyncCompletedEventHandler.FromPointer); // 024664F8E0A8 0x100 DownloadFileCompleted       ( 0001866F0D10 ModelClassType AsyncCompletedEventHandler AsyncCompletedEventHandler AsyncCompletedEventHandler Pointer )
            value.UploadStringCompleted                     = GetObject<UploadStringCompletedEventHandler>(new IntPtr(p + 0x108), ReversePrism.DataModels.UploadStringCompletedEventHandler.FromPointer); // 024664F8E0C8 0x108 UploadStringCompleted       ( 0001867450D0 ModelClassType UploadStringCompletedEventHandler UploadStringCompletedEventHandler UploadStringCompletedEventHandler Pointer )
            value.UploadDataCompleted                       = GetObject<UploadDataCompletedEventHandler>(new IntPtr(p + 0x110), ReversePrism.DataModels.UploadDataCompletedEventHandler.FromPointer); // 024664F8E0E8 0x110 UploadDataCompleted         ( 000186742F40 ModelClassType UploadDataCompletedEventHandler UploadDataCompletedEventHandler UploadDataCompletedEventHandler Pointer )
            value.UploadFileCompleted                       = GetObject<UploadFileCompletedEventHandler>(new IntPtr(p + 0x118), ReversePrism.DataModels.UploadFileCompletedEventHandler.FromPointer); // 024664F8E108 0x118 UploadFileCompleted         ( 0001867436C0 ModelClassType UploadFileCompletedEventHandler UploadFileCompletedEventHandler UploadFileCompletedEventHandler Pointer )
            value.UploadValuesCompleted                     = GetObject<UploadValuesCompletedEventHandler>(new IntPtr(p + 0x120), ReversePrism.DataModels.UploadValuesCompletedEventHandler.FromPointer); // 024664F8E128 0x120 UploadValuesCompleted       ( 000186745A80 ModelClassType UploadValuesCompletedEventHandler UploadValuesCompletedEventHandler UploadValuesCompletedEventHandler Pointer )
            value.OpenReadCompleted                         = GetObject<OpenReadCompletedEventHandler>(new IntPtr(p + 0x128), ReversePrism.DataModels.OpenReadCompletedEventHandler.FromPointer); // 024664F8E148 0x128 OpenReadCompleted           ( 0001866E19D0 ModelClassType OpenReadCompletedEventHandler OpenReadCompletedEventHandler OpenReadCompletedEventHandler Pointer )
            value.OpenWriteCompleted                        = GetObject<OpenWriteCompletedEventHandler>(new IntPtr(p + 0x130), ReversePrism.DataModels.OpenWriteCompletedEventHandler.FromPointer); // 024664F8E168 0x130 OpenWriteCompleted          ( 0001866E3020 ModelClassType OpenWriteCompletedEventHandler OpenWriteCompletedEventHandler OpenWriteCompletedEventHandler Pointer )
            value.DownloadProgressChanged                   = GetObject<DownloadProgressChangedEventHandler>(new IntPtr(p + 0x138), ReversePrism.DataModels.DownloadProgressChangedEventHandler.FromPointer); // 024664F8E188 0x138 DownloadProgressChanged     ( 0001866F26C0 ModelClassType DownloadProgressChangedEventHandler DownloadProgressChangedEventHandler DownloadProgressChangedEventHandler Pointer )
            value.UploadProgressChanged                     = GetObject<UploadProgressChangedEventHandler>(new IntPtr(p + 0x140), ReversePrism.DataModels.UploadProgressChangedEventHandler.FromPointer); // 024664F8E1A8 0x140 UploadProgressChanged       ( 0001867449E0 ModelClassType UploadProgressChangedEventHandler UploadProgressChangedEventHandler UploadProgressChangedEventHandler Pointer )
            value.CachePolicy                               = GetObject<RequestCachePolicy>(new IntPtr(p + 0x148), ReversePrism.DataModels.RequestCachePolicy.FromPointer); // 024664F8E1C8 0x148 CachePolicy                 ( 0001866657A0 ModelClassType RequestCachePolicy RequestCachePolicy RequestCachePolicy Pointer )

            return value;
        }
    }
}
