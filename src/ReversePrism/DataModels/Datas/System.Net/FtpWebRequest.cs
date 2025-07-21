using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 _syncObject                              <object> IL2CPP_TYPE_OBJECT
    // 040 AuthInfo                                 ModelClassType ICredentials ICredentials ICredentials Pointer
    // 048 Uri                                      ModelClassType Uri Uri Uri Pointer
    // 050 MethodInfo                               ModelClassType FtpMethodInfo FtpMethodInfo FtpMethodInfo Pointer
    // 058 RenameTo                                 ModelPrimitiveType string string string String
    // 060 GetRequestStreamStarted                  ModelPrimitiveType bool bool bool Bool
    // 061 GetResponseStarted                       ModelPrimitiveType bool bool bool Bool
    // 068 StartTime                                ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 070 Timeout                                  ModelPrimitiveType int int int Int32
    // 074 RemainingTimeout                         ModelPrimitiveType int int int Int32
    // 078 ContentLength                            ModelPrimitiveType long long long Int64
    // 080 ContentOffset                            ModelPrimitiveType long long long Int64
    // 088 ClientCertificates                       ModelClassType X509CertificateCollection X509CertificateCollection X509CertificateCollection Pointer
    // 090 Passive                                  ModelPrimitiveType bool bool bool Bool
    // 091 Binary                                   ModelPrimitiveType bool bool bool Bool
    // 098 ConnectionGroupName                      ModelPrimitiveType string string string String
    // 0A0 Async                                    ModelPrimitiveType bool bool bool Bool
    // 0A1 Aborted                                  ModelPrimitiveType bool bool bool Bool
    // 0A2 TimedOut                                 ModelPrimitiveType bool bool bool Bool
    // 0A8 Exception                                ModelClassType Exception Exception Exception Pointer
    // 0B0 TimerQueue                               ModelClassType Queue Queue Queue Pointer
    // 0B8 TimerCallback                            ModelClassType Callback Callback Callback Pointer
    // 0C0 EnableSsl                                ModelPrimitiveType bool bool bool Bool
    // 0C8 Connection                               ModelClassType FtpControlStream FtpControlStream FtpControlStream Pointer
    // 0D0 Stream                                   ModelClassType Stream Stream Stream Pointer
    // 0D8 RequestStage                             ModelEnumType RequestStage RequestStage RequestStage Int32
    // 0DC OnceFailed                               ModelPrimitiveType bool bool bool Bool
    // 0E0 FtpRequestHeaders                        ModelClassType WebHeaderCollection WebHeaderCollection WebHeaderCollection Pointer
    // 0E8 FtpWebResponse                           ModelClassType FtpWebResponse FtpWebResponse FtpWebResponse Pointer
    // 0F0 ReadWriteTimeout                         ModelPrimitiveType int int int Int32
    // 0F8 WriteAsyncResult                         ModelClassType ContextAwareResult ContextAwareResult ContextAwareResult Pointer
    // 100 ReadAsyncResult                          ModelClassType LazyAsyncResult LazyAsyncResult LazyAsyncResult Pointer
    // 108 RequestCompleteAsyncResult               ModelClassType LazyAsyncResult LazyAsyncResult LazyAsyncResult Pointer
    // 000 s_defaultFtpNetworkCredential            NetworkCredential IL2CPP_TYPE_CLASS
    // 008 s_DefaultTimerQueue                      Queue IL2CPP_TYPE_CLASS
    public partial class FtpWebRequest : DataModel
    {
        public ICredentials?                            AuthInfo                                { get; set; }
        public Uri?                                     Uri                                     { get; set; }
        public FtpMethodInfo?                           MethodInfo                              { get; set; }
        public string                                   RenameTo                                { get; set; }
        public bool                                     GetRequestStreamStarted                 { get; set; }
        public bool                                     GetResponseStarted                      { get; set; }
        public DateTime                                 StartTime                               { get; set; }
        public int                                      Timeout                                 { get; set; }
        public int                                      RemainingTimeout                        { get; set; }
        public long                                     ContentLength                           { get; set; }
        public long                                     ContentOffset                           { get; set; }
        public X509CertificateCollection?               ClientCertificates                      { get; set; }
        public bool                                     Passive                                 { get; set; }
        public bool                                     Binary                                  { get; set; }
        public string                                   ConnectionGroupName                     { get; set; }
        public bool                                     Async                                   { get; set; }
        public bool                                     Aborted                                 { get; set; }
        public bool                                     TimedOut                                { get; set; }
        public Exception?                               Exception                               { get; set; }
        public Queue?                                   TimerQueue                              { get; set; }
        public Callback?                                TimerCallback                           { get; set; }
        public bool                                     EnableSsl                               { get; set; }
        public FtpControlStream?                        Connection                              { get; set; }
        public Stream?                                  Stream                                  { get; set; }
        public RequestStage                             RequestStage                            { get; set; }
        public bool                                     OnceFailed                              { get; set; }
        public WebHeaderCollection?                     FtpRequestHeaders                       { get; set; }
        public FtpWebResponse?                          FtpWebResponse                          { get; set; }
        public int                                      ReadWriteTimeout                        { get; set; }
        public ContextAwareResult?                      WriteAsyncResult                        { get; set; }
        public LazyAsyncResult?                         ReadAsyncResult                         { get; set; }
        public LazyAsyncResult?                         RequestCompleteAsyncResult              { get; set; }

        public static FtpWebRequest? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FtpWebRequest() { Pointer= p0 };

            value.AuthInfo                                  = GetObject<ICredentials>(new IntPtr(p + 0x040), ReversePrism.DataModels.ICredentials.FromPointer); // 0x40 AuthInfo                    ( ModelClassType ICredentials ICredentials ICredentials Pointer )
            value.Uri                                       = GetObject<Uri>(new IntPtr(p + 0x048), ReversePrism.DataModels.Uri.FromPointer); // 0x48 Uri                         ( ModelClassType Uri Uri Uri Pointer )
            value.MethodInfo                                = GetObject<FtpMethodInfo>(new IntPtr(p + 0x050), ReversePrism.DataModels.FtpMethodInfo.FromPointer); // 0x50 MethodInfo                  ( ModelClassType FtpMethodInfo FtpMethodInfo FtpMethodInfo Pointer )
            value.RenameTo                                  = GetString(new IntPtr(p + 0x058)); // 0x58 RenameTo                    ( ModelPrimitiveType string string string String )
            value.GetRequestStreamStarted                   = GetBool(new IntPtr(p + 0x060)); // 0x60 GetRequestStreamStarted     ( ModelPrimitiveType bool bool bool Bool )
            value.GetResponseStarted                        = GetBool(new IntPtr(p + 0x061)); // 0x61 GetResponseStarted          ( ModelPrimitiveType bool bool bool Bool )
            value.StartTime                                 = GetDateTime(new IntPtr(p + 0x068)); // 0x68 StartTime                   ( ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.Timeout                                   = GetInt32(new IntPtr(p + 0x070)); // 0x70 Timeout                     ( ModelPrimitiveType int int int Int32 )
            value.RemainingTimeout                          = GetInt32(new IntPtr(p + 0x074)); // 0x74 RemainingTimeout            ( ModelPrimitiveType int int int Int32 )
            value.ContentLength                             = GetInt64(new IntPtr(p + 0x078)); // 0x78 ContentLength               ( ModelPrimitiveType long long long Int64 )
            value.ContentOffset                             = GetInt64(new IntPtr(p + 0x080)); // 0x80 ContentOffset               ( ModelPrimitiveType long long long Int64 )
            value.ClientCertificates                        = GetObject<X509CertificateCollection>(new IntPtr(p + 0x088), ReversePrism.DataModels.X509CertificateCollection.FromPointer); // 0x88 ClientCertificates          ( ModelClassType X509CertificateCollection X509CertificateCollection X509CertificateCollection Pointer )
            value.Passive                                   = GetBool(new IntPtr(p + 0x090)); // 0x90 Passive                     ( ModelPrimitiveType bool bool bool Bool )
            value.Binary                                    = GetBool(new IntPtr(p + 0x091)); // 0x91 Binary                      ( ModelPrimitiveType bool bool bool Bool )
            value.ConnectionGroupName                       = GetString(new IntPtr(p + 0x098)); // 0x98 ConnectionGroupName         ( ModelPrimitiveType string string string String )
            value.Async                                     = GetBool(new IntPtr(p + 0x0A0)); // 0xA0 Async                       ( ModelPrimitiveType bool bool bool Bool )
            value.Aborted                                   = GetBool(new IntPtr(p + 0x0A1)); // 0xA1 Aborted                     ( ModelPrimitiveType bool bool bool Bool )
            value.TimedOut                                  = GetBool(new IntPtr(p + 0x0A2)); // 0xA2 TimedOut                    ( ModelPrimitiveType bool bool bool Bool )
            value.Exception                                 = GetObject<Exception>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.Exception.FromPointer); // 0xA8 Exception                   ( ModelClassType Exception Exception Exception Pointer )
            value.TimerQueue                                = GetObject<Queue>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.Queue.FromPointer); // 0xB0 TimerQueue                  ( ModelClassType Queue Queue Queue Pointer )
            value.TimerCallback                             = GetObject<Callback>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.Callback.FromPointer); // 0xB8 TimerCallback               ( ModelClassType Callback Callback Callback Pointer )
            value.EnableSsl                                 = GetBool(new IntPtr(p + 0x0C0)); // 0xC0 EnableSsl                   ( ModelPrimitiveType bool bool bool Bool )
            value.Connection                                = GetObject<FtpControlStream>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.FtpControlStream.FromPointer); // 0xC8 Connection                  ( ModelClassType FtpControlStream FtpControlStream FtpControlStream Pointer )
            value.Stream                                    = GetObject<Stream>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.Stream.FromPointer); // 0xD0 Stream                      ( ModelClassType Stream Stream Stream Pointer )
            value.RequestStage                              = (RequestStage)GetInt32(new IntPtr(p + 0x0D8)); // 0xD8 RequestStage                ( ModelEnumType RequestStage RequestStage RequestStage Int32 )
            value.OnceFailed                                = GetBool(new IntPtr(p + 0x0DC)); // 0xDC OnceFailed                  ( ModelPrimitiveType bool bool bool Bool )
            value.FtpRequestHeaders                         = GetObject<WebHeaderCollection>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.WebHeaderCollection.FromPointer); // 0xE0 FtpRequestHeaders           ( ModelClassType WebHeaderCollection WebHeaderCollection WebHeaderCollection Pointer )
            value.FtpWebResponse                            = GetObject<FtpWebResponse>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.FtpWebResponse.FromPointer); // 0xE8 FtpWebResponse              ( ModelClassType FtpWebResponse FtpWebResponse FtpWebResponse Pointer )
            value.ReadWriteTimeout                          = GetInt32(new IntPtr(p + 0x0F0)); // 0xF0 ReadWriteTimeout            ( ModelPrimitiveType int int int Int32 )
            value.WriteAsyncResult                          = GetObject<ContextAwareResult>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.ContextAwareResult.FromPointer); // 0xF8 WriteAsyncResult            ( ModelClassType ContextAwareResult ContextAwareResult ContextAwareResult Pointer )
            value.ReadAsyncResult                           = GetObject<LazyAsyncResult>(new IntPtr(p + 0x100), ReversePrism.DataModels.LazyAsyncResult.FromPointer); // 0x100 ReadAsyncResult             ( ModelClassType LazyAsyncResult LazyAsyncResult LazyAsyncResult Pointer )
            value.RequestCompleteAsyncResult                = GetObject<LazyAsyncResult>(new IntPtr(p + 0x108), ReversePrism.DataModels.LazyAsyncResult.FromPointer); // 0x108 RequestCompleteAsyncResult  ( ModelClassType LazyAsyncResult LazyAsyncResult LazyAsyncResult Pointer )

            return value;
        }
    }
}
