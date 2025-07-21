using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 DefaultCopyBufferLength                  int IL2CPP_TYPE_I4
    // 000 DefaultDownloadBufferLength              int IL2CPP_TYPE_I4
    // 000 DefaultUploadFileContentType             string IL2CPP_TYPE_STRING
    // 000 UploadFileContentType                    string IL2CPP_TYPE_STRING
    // 000 UploadValuesContentType                  string IL2CPP_TYPE_STRING
    // 028 BaseAddress                              ModelClassType Uri Uri Uri Pointer
    // 030 Credentials                              ModelClassType ICredentials ICredentials ICredentials Pointer
    // 038 Headers                                  ModelClassType WebHeaderCollection WebHeaderCollection WebHeaderCollection Pointer
    // 040 RequestParameters                        ModelClassType NameValueCollection NameValueCollection NameValueCollection Pointer
    // 048 WebResponse                              ModelClassType WebResponse WebResponse WebResponse Pointer
    // 050 WebRequest                               ModelClassType WebRequest WebRequest WebRequest Pointer
    // 058 Encoding                                 ModelClassType Encoding Encoding Encoding Pointer
    // 060 Method                                   ModelPrimitiveType string string string String
    // 068 ContentLength                            ModelPrimitiveType long long long Int64
    // 070 InitWebClientAsync                       ModelPrimitiveType bool bool bool Bool
    // 071 Canceled                                 ModelPrimitiveType bool bool bool Bool
    // 078 Progress                                 ModelClassType ProgressData ProgressData ProgressData Pointer
    // 080 Proxy                                    ModelClassType IWebProxy IWebProxy IWebProxy Pointer
    // 088 ProxySet                                 ModelPrimitiveType bool bool bool Bool
    // 08C CallNesting                              ModelPrimitiveType int int int Int32
    // 090 AsyncOp                                  ModelClassType AsyncOperation AsyncOperation AsyncOperation Pointer
    // 098 DownloadDataOperationCompleted           ModelClassType SendOrPostCallback SendOrPostCallback SendOrPostCallback Pointer
    // 0A0 OpenReadOperationCompleted               ModelClassType SendOrPostCallback SendOrPostCallback SendOrPostCallback Pointer
    // 0A8 OpenWriteOperationCompleted              ModelClassType SendOrPostCallback SendOrPostCallback SendOrPostCallback Pointer
    // 0B0 DownloadStringOperationCompleted         ModelClassType SendOrPostCallback SendOrPostCallback SendOrPostCallback Pointer
    // 0B8 DownloadFileOperationCompleted           ModelClassType SendOrPostCallback SendOrPostCallback SendOrPostCallback Pointer
    // 0C0 UploadStringOperationCompleted           ModelClassType SendOrPostCallback SendOrPostCallback SendOrPostCallback Pointer
    // 0C8 UploadDataOperationCompleted             ModelClassType SendOrPostCallback SendOrPostCallback SendOrPostCallback Pointer
    // 0D0 UploadFileOperationCompleted             ModelClassType SendOrPostCallback SendOrPostCallback SendOrPostCallback Pointer
    // 0D8 UploadValuesOperationCompleted           ModelClassType SendOrPostCallback SendOrPostCallback SendOrPostCallback Pointer
    // 0E0 ReportDownloadProgressChanged            ModelClassType SendOrPostCallback SendOrPostCallback SendOrPostCallback Pointer
    // 0E8 ReportUploadProgressChanged              ModelClassType SendOrPostCallback SendOrPostCallback SendOrPostCallback Pointer
    // 0F0 DownloadStringCompleted                  ModelClassType DownloadStringCompletedEventHandler DownloadStringCompletedEventHandler DownloadStringCompletedEventHandler Pointer
    // 0F8 DownloadDataCompleted                    ModelClassType DownloadDataCompletedEventHandler DownloadDataCompletedEventHandler DownloadDataCompletedEventHandler Pointer
    // 100 DownloadFileCompleted                    ModelClassType AsyncCompletedEventHandler AsyncCompletedEventHandler AsyncCompletedEventHandler Pointer
    // 108 UploadStringCompleted                    ModelClassType UploadStringCompletedEventHandler UploadStringCompletedEventHandler UploadStringCompletedEventHandler Pointer
    // 110 UploadDataCompleted                      ModelClassType UploadDataCompletedEventHandler UploadDataCompletedEventHandler UploadDataCompletedEventHandler Pointer
    // 118 UploadFileCompleted                      ModelClassType UploadFileCompletedEventHandler UploadFileCompletedEventHandler UploadFileCompletedEventHandler Pointer
    // 120 UploadValuesCompleted                    ModelClassType UploadValuesCompletedEventHandler UploadValuesCompletedEventHandler UploadValuesCompletedEventHandler Pointer
    // 128 OpenReadCompleted                        ModelClassType OpenReadCompletedEventHandler OpenReadCompletedEventHandler OpenReadCompletedEventHandler Pointer
    // 130 OpenWriteCompleted                       ModelClassType OpenWriteCompletedEventHandler OpenWriteCompletedEventHandler OpenWriteCompletedEventHandler Pointer
    // 138 DownloadProgressChanged                  ModelClassType DownloadProgressChangedEventHandler DownloadProgressChangedEventHandler DownloadProgressChangedEventHandler Pointer
    // 140 UploadProgressChanged                    ModelClassType UploadProgressChangedEventHandler UploadProgressChangedEventHandler UploadProgressChangedEventHandler Pointer
    // 148 CachePolicy                              ModelClassType RequestCachePolicy RequestCachePolicy RequestCachePolicy Pointer
    // 000 s_parseContentTypeSeparators             char[] IL2CPP_TYPE_SZARRAY
    // 008 s_knownEncodings                         Encoding[] IL2CPP_TYPE_SZARRAY
    // 150 AllowReadStreamBuffering                 ModelPrimitiveType bool bool bool Bool
    // 151 AllowWriteStreamBuffering                ModelPrimitiveType bool bool bool Bool
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
        public bool                                     AllowReadStreamBuffering                { get; set; }
        public bool                                     AllowWriteStreamBuffering               { get; set; }

        public static WebClient? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WebClient() { Pointer= p0 };

            value.BaseAddress                               = GetObject<Uri>(new IntPtr(p + 0x028), ReversePrism.DataModels.Uri.FromPointer); // 0x28 BaseAddress                 ( ModelClassType Uri Uri Uri Pointer )
            value.Credentials                               = GetObject<ICredentials>(new IntPtr(p + 0x030), ReversePrism.DataModels.ICredentials.FromPointer); // 0x30 Credentials                 ( ModelClassType ICredentials ICredentials ICredentials Pointer )
            value.Headers                                   = GetObject<WebHeaderCollection>(new IntPtr(p + 0x038), ReversePrism.DataModels.WebHeaderCollection.FromPointer); // 0x38 Headers                     ( ModelClassType WebHeaderCollection WebHeaderCollection WebHeaderCollection Pointer )
            value.RequestParameters                         = GetObject<NameValueCollection>(new IntPtr(p + 0x040), ReversePrism.DataModels.NameValueCollection.FromPointer); // 0x40 RequestParameters           ( ModelClassType NameValueCollection NameValueCollection NameValueCollection Pointer )
            value.WebResponse                               = GetObject<WebResponse>(new IntPtr(p + 0x048), ReversePrism.DataModels.WebResponse.FromPointer); // 0x48 WebResponse                 ( ModelClassType WebResponse WebResponse WebResponse Pointer )
            value.WebRequest                                = GetObject<WebRequest>(new IntPtr(p + 0x050), ReversePrism.DataModels.WebRequest.FromPointer); // 0x50 WebRequest                  ( ModelClassType WebRequest WebRequest WebRequest Pointer )
            value.Encoding                                  = GetObject<Encoding>(new IntPtr(p + 0x058), ReversePrism.DataModels.Encoding.FromPointer); // 0x58 Encoding                    ( ModelClassType Encoding Encoding Encoding Pointer )
            value.Method                                    = GetString(new IntPtr(p + 0x060)); // 0x60 Method                      ( ModelPrimitiveType string string string String )
            value.ContentLength                             = GetInt64(new IntPtr(p + 0x068)); // 0x68 ContentLength               ( ModelPrimitiveType long long long Int64 )
            value.InitWebClientAsync                        = GetBool(new IntPtr(p + 0x070)); // 0x70 InitWebClientAsync          ( ModelPrimitiveType bool bool bool Bool )
            value.Canceled                                  = GetBool(new IntPtr(p + 0x071)); // 0x71 Canceled                    ( ModelPrimitiveType bool bool bool Bool )
            value.Progress                                  = GetObject<ProgressData>(new IntPtr(p + 0x078), ReversePrism.DataModels.ProgressData.FromPointer); // 0x78 Progress                    ( ModelClassType ProgressData ProgressData ProgressData Pointer )
            value.Proxy                                     = GetObject<IWebProxy>(new IntPtr(p + 0x080), ReversePrism.DataModels.IWebProxy.FromPointer); // 0x80 Proxy                       ( ModelClassType IWebProxy IWebProxy IWebProxy Pointer )
            value.ProxySet                                  = GetBool(new IntPtr(p + 0x088)); // 0x88 ProxySet                    ( ModelPrimitiveType bool bool bool Bool )
            value.CallNesting                               = GetInt32(new IntPtr(p + 0x08C)); // 0x8C CallNesting                 ( ModelPrimitiveType int int int Int32 )
            value.AsyncOp                                   = GetObject<AsyncOperation>(new IntPtr(p + 0x090), ReversePrism.DataModels.AsyncOperation.FromPointer); // 0x90 AsyncOp                     ( ModelClassType AsyncOperation AsyncOperation AsyncOperation Pointer )
            value.DownloadDataOperationCompleted            = GetObject<SendOrPostCallback>(new IntPtr(p + 0x098), ReversePrism.DataModels.SendOrPostCallback.FromPointer); // 0x98 DownloadDataOperationCompleted ( ModelClassType SendOrPostCallback SendOrPostCallback SendOrPostCallback Pointer )
            value.OpenReadOperationCompleted                = GetObject<SendOrPostCallback>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.SendOrPostCallback.FromPointer); // 0xA0 OpenReadOperationCompleted  ( ModelClassType SendOrPostCallback SendOrPostCallback SendOrPostCallback Pointer )
            value.OpenWriteOperationCompleted               = GetObject<SendOrPostCallback>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.SendOrPostCallback.FromPointer); // 0xA8 OpenWriteOperationCompleted ( ModelClassType SendOrPostCallback SendOrPostCallback SendOrPostCallback Pointer )
            value.DownloadStringOperationCompleted          = GetObject<SendOrPostCallback>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.SendOrPostCallback.FromPointer); // 0xB0 DownloadStringOperationCompleted ( ModelClassType SendOrPostCallback SendOrPostCallback SendOrPostCallback Pointer )
            value.DownloadFileOperationCompleted            = GetObject<SendOrPostCallback>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.SendOrPostCallback.FromPointer); // 0xB8 DownloadFileOperationCompleted ( ModelClassType SendOrPostCallback SendOrPostCallback SendOrPostCallback Pointer )
            value.UploadStringOperationCompleted            = GetObject<SendOrPostCallback>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.SendOrPostCallback.FromPointer); // 0xC0 UploadStringOperationCompleted ( ModelClassType SendOrPostCallback SendOrPostCallback SendOrPostCallback Pointer )
            value.UploadDataOperationCompleted              = GetObject<SendOrPostCallback>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.SendOrPostCallback.FromPointer); // 0xC8 UploadDataOperationCompleted ( ModelClassType SendOrPostCallback SendOrPostCallback SendOrPostCallback Pointer )
            value.UploadFileOperationCompleted              = GetObject<SendOrPostCallback>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.SendOrPostCallback.FromPointer); // 0xD0 UploadFileOperationCompleted ( ModelClassType SendOrPostCallback SendOrPostCallback SendOrPostCallback Pointer )
            value.UploadValuesOperationCompleted            = GetObject<SendOrPostCallback>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.SendOrPostCallback.FromPointer); // 0xD8 UploadValuesOperationCompleted ( ModelClassType SendOrPostCallback SendOrPostCallback SendOrPostCallback Pointer )
            value.ReportDownloadProgressChanged             = GetObject<SendOrPostCallback>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.SendOrPostCallback.FromPointer); // 0xE0 ReportDownloadProgressChanged ( ModelClassType SendOrPostCallback SendOrPostCallback SendOrPostCallback Pointer )
            value.ReportUploadProgressChanged               = GetObject<SendOrPostCallback>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.SendOrPostCallback.FromPointer); // 0xE8 ReportUploadProgressChanged ( ModelClassType SendOrPostCallback SendOrPostCallback SendOrPostCallback Pointer )
            value.DownloadStringCompleted                   = GetObject<DownloadStringCompletedEventHandler>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.DownloadStringCompletedEventHandler.FromPointer); // 0xF0 DownloadStringCompleted     ( ModelClassType DownloadStringCompletedEventHandler DownloadStringCompletedEventHandler DownloadStringCompletedEventHandler Pointer )
            value.DownloadDataCompleted                     = GetObject<DownloadDataCompletedEventHandler>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.DownloadDataCompletedEventHandler.FromPointer); // 0xF8 DownloadDataCompleted       ( ModelClassType DownloadDataCompletedEventHandler DownloadDataCompletedEventHandler DownloadDataCompletedEventHandler Pointer )
            value.DownloadFileCompleted                     = GetObject<AsyncCompletedEventHandler>(new IntPtr(p + 0x100), ReversePrism.DataModels.AsyncCompletedEventHandler.FromPointer); // 0x100 DownloadFileCompleted       ( ModelClassType AsyncCompletedEventHandler AsyncCompletedEventHandler AsyncCompletedEventHandler Pointer )
            value.UploadStringCompleted                     = GetObject<UploadStringCompletedEventHandler>(new IntPtr(p + 0x108), ReversePrism.DataModels.UploadStringCompletedEventHandler.FromPointer); // 0x108 UploadStringCompleted       ( ModelClassType UploadStringCompletedEventHandler UploadStringCompletedEventHandler UploadStringCompletedEventHandler Pointer )
            value.UploadDataCompleted                       = GetObject<UploadDataCompletedEventHandler>(new IntPtr(p + 0x110), ReversePrism.DataModels.UploadDataCompletedEventHandler.FromPointer); // 0x110 UploadDataCompleted         ( ModelClassType UploadDataCompletedEventHandler UploadDataCompletedEventHandler UploadDataCompletedEventHandler Pointer )
            value.UploadFileCompleted                       = GetObject<UploadFileCompletedEventHandler>(new IntPtr(p + 0x118), ReversePrism.DataModels.UploadFileCompletedEventHandler.FromPointer); // 0x118 UploadFileCompleted         ( ModelClassType UploadFileCompletedEventHandler UploadFileCompletedEventHandler UploadFileCompletedEventHandler Pointer )
            value.UploadValuesCompleted                     = GetObject<UploadValuesCompletedEventHandler>(new IntPtr(p + 0x120), ReversePrism.DataModels.UploadValuesCompletedEventHandler.FromPointer); // 0x120 UploadValuesCompleted       ( ModelClassType UploadValuesCompletedEventHandler UploadValuesCompletedEventHandler UploadValuesCompletedEventHandler Pointer )
            value.OpenReadCompleted                         = GetObject<OpenReadCompletedEventHandler>(new IntPtr(p + 0x128), ReversePrism.DataModels.OpenReadCompletedEventHandler.FromPointer); // 0x128 OpenReadCompleted           ( ModelClassType OpenReadCompletedEventHandler OpenReadCompletedEventHandler OpenReadCompletedEventHandler Pointer )
            value.OpenWriteCompleted                        = GetObject<OpenWriteCompletedEventHandler>(new IntPtr(p + 0x130), ReversePrism.DataModels.OpenWriteCompletedEventHandler.FromPointer); // 0x130 OpenWriteCompleted          ( ModelClassType OpenWriteCompletedEventHandler OpenWriteCompletedEventHandler OpenWriteCompletedEventHandler Pointer )
            value.DownloadProgressChanged                   = GetObject<DownloadProgressChangedEventHandler>(new IntPtr(p + 0x138), ReversePrism.DataModels.DownloadProgressChangedEventHandler.FromPointer); // 0x138 DownloadProgressChanged     ( ModelClassType DownloadProgressChangedEventHandler DownloadProgressChangedEventHandler DownloadProgressChangedEventHandler Pointer )
            value.UploadProgressChanged                     = GetObject<UploadProgressChangedEventHandler>(new IntPtr(p + 0x140), ReversePrism.DataModels.UploadProgressChangedEventHandler.FromPointer); // 0x140 UploadProgressChanged       ( ModelClassType UploadProgressChangedEventHandler UploadProgressChangedEventHandler UploadProgressChangedEventHandler Pointer )
            value.CachePolicy                               = GetObject<RequestCachePolicy>(new IntPtr(p + 0x148), ReversePrism.DataModels.RequestCachePolicy.FromPointer); // 0x148 CachePolicy                 ( ModelClassType RequestCachePolicy RequestCachePolicy RequestCachePolicy Pointer )
            value.AllowReadStreamBuffering                  = GetBool(new IntPtr(p + 0x150)); // 0x150 AllowReadStreamBuffering    ( ModelPrimitiveType bool bool bool Bool )
            value.AllowWriteStreamBuffering                 = GetBool(new IntPtr(p + 0x151)); // 0x151 AllowWriteStreamBuffering   ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
