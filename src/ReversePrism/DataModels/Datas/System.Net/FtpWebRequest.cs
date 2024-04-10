using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 _syncObject                              <object> IL2CPP_TYPE_OBJECT
    // 040 AuthInfo                                 000186745960 ModelClassType ICredentials ICredentials ICredentials Pointer
    // 048 Uri                                      0001866A4C30 ModelClassType Uri Uri Uri Pointer
    // 050 MethodInfo                               0001865D0000 ModelClassType FtpMethodInfo FtpMethodInfo FtpMethodInfo Pointer
    // 058 RenameTo                                 000186671910 ModelPrimitiveType string string string String
    // 060 GetRequestStreamStarted                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 061 GetResponseStarted                       000186594D10 ModelPrimitiveType bool bool bool Bool
    // 068 StartTime                                0001865B9010 ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 070 Timeout                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 074 RemainingTimeout                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 078 ContentLength                            0001865F7700 ModelPrimitiveType long long long Int64
    // 080 ContentOffset                            0001865F7700 ModelPrimitiveType long long long Int64
    // 088 ClientCertificates                       0001865656A0 ModelClassType X509CertificateCollection X509CertificateCollection X509CertificateCollection Pointer
    // 090 Passive                                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 091 Binary                                   000186594D10 ModelPrimitiveType bool bool bool Bool
    // 098 ConnectionGroupName                      000186671910 ModelPrimitiveType string string string String
    // 0A0 Async                                    000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0A1 Aborted                                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0A2 TimedOut                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0A8 Exception                                0001865CA820 ModelClassType Exception Exception Exception Pointer
    // 0B0 TimerQueue                               000186612660 ModelClassType Queue Queue Queue Pointer
    // 0B8 TimerCallback                            000186611CC0 ModelClassType Callback Callback Callback Pointer
    // 0C0 EnableSsl                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0C8 Connection                               0001865CE9E0 ModelClassType FtpControlStream FtpControlStream FtpControlStream Pointer
    // 0D0 Stream                                   000186670270 ModelClassType Stream Stream Stream Pointer
    // 0D8 RequestStage                             0001866DB8F0 ModelEnumType RequestStage RequestStage RequestStage Int32
    // 0DC OnceFailed                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0E0 FtpRequestHeaders                        00018654B520 ModelClassType WebHeaderCollection WebHeaderCollection WebHeaderCollection Pointer
    // 0E8 FtpWebResponse                           0001865D1EB0 ModelClassType FtpWebResponse FtpWebResponse FtpWebResponse Pointer
    // 0F0 ReadWriteTimeout                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 0F8 WriteAsyncResult                         000186613E90 ModelClassType ContextAwareResult ContextAwareResult ContextAwareResult Pointer
    // 100 ReadAsyncResult                          00018650E3B0 ModelClassType LazyAsyncResult LazyAsyncResult LazyAsyncResult Pointer
    // 108 RequestCompleteAsyncResult               00018650E3B0 ModelClassType LazyAsyncResult LazyAsyncResult LazyAsyncResult Pointer
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

            value.AuthInfo                                  = GetObject<ICredentials>(new IntPtr(p + 0x040), ReversePrism.DataModels.ICredentials.FromPointer); // 024667A6A180 0x40 AuthInfo                    ( 000186745960 ModelClassType ICredentials ICredentials ICredentials Pointer )
            value.Uri                                       = GetObject<Uri>(new IntPtr(p + 0x048), ReversePrism.DataModels.Uri.FromPointer); // 024667A6A1A0 0x48 Uri                         ( 0001866A4C30 ModelClassType Uri Uri Uri Pointer )
            value.MethodInfo                                = GetObject<FtpMethodInfo>(new IntPtr(p + 0x050), ReversePrism.DataModels.FtpMethodInfo.FromPointer); // 024667A6A1C0 0x50 MethodInfo                  ( 0001865D0000 ModelClassType FtpMethodInfo FtpMethodInfo FtpMethodInfo Pointer )
            value.RenameTo                                  = GetString(new IntPtr(p + 0x058)); // 024667A6A1E0 0x58 RenameTo                    ( 000186671910 ModelPrimitiveType string string string String )
            value.GetRequestStreamStarted                   = GetBool(new IntPtr(p + 0x060)); // 024667A6A200 0x60 GetRequestStreamStarted     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.GetResponseStarted                        = GetBool(new IntPtr(p + 0x061)); // 024667A6A220 0x61 GetResponseStarted          ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.StartTime                                 = GetDateTime(new IntPtr(p + 0x068)); // 024667A6A240 0x68 StartTime                   ( 0001865B9010 ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.Timeout                                   = GetInt32(new IntPtr(p + 0x070)); // 024667A6A260 0x70 Timeout                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.RemainingTimeout                          = GetInt32(new IntPtr(p + 0x074)); // 024667A6A280 0x74 RemainingTimeout            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ContentLength                             = GetInt64(new IntPtr(p + 0x078)); // 024667A6A2A0 0x78 ContentLength               ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.ContentOffset                             = GetInt64(new IntPtr(p + 0x080)); // 024667A6A2C0 0x80 ContentOffset               ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.ClientCertificates                        = GetObject<X509CertificateCollection>(new IntPtr(p + 0x088), ReversePrism.DataModels.X509CertificateCollection.FromPointer); // 024667A6A2E0 0x88 ClientCertificates          ( 0001865656A0 ModelClassType X509CertificateCollection X509CertificateCollection X509CertificateCollection Pointer )
            value.Passive                                   = GetBool(new IntPtr(p + 0x090)); // 024667A6A300 0x90 Passive                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Binary                                    = GetBool(new IntPtr(p + 0x091)); // 024667A6A320 0x91 Binary                      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ConnectionGroupName                       = GetString(new IntPtr(p + 0x098)); // 024667A6A340 0x98 ConnectionGroupName         ( 000186671910 ModelPrimitiveType string string string String )
            value.Async                                     = GetBool(new IntPtr(p + 0x0A0)); // 024667A6A360 0xA0 Async                       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Aborted                                   = GetBool(new IntPtr(p + 0x0A1)); // 024667A6A380 0xA1 Aborted                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.TimedOut                                  = GetBool(new IntPtr(p + 0x0A2)); // 024667A6A3A0 0xA2 TimedOut                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Exception                                 = GetObject<Exception>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.Exception.FromPointer); // 024667A6A3C0 0xA8 Exception                   ( 0001865CA820 ModelClassType Exception Exception Exception Pointer )
            value.TimerQueue                                = GetObject<Queue>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.Queue.FromPointer); // 024667A6A3E0 0xB0 TimerQueue                  ( 000186612660 ModelClassType Queue Queue Queue Pointer )
            value.TimerCallback                             = GetObject<Callback>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.Callback.FromPointer); // 024667A6A400 0xB8 TimerCallback               ( 000186611CC0 ModelClassType Callback Callback Callback Pointer )
            value.EnableSsl                                 = GetBool(new IntPtr(p + 0x0C0)); // 024667A6A420 0xC0 EnableSsl                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Connection                                = GetObject<FtpControlStream>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.FtpControlStream.FromPointer); // 024667A6A440 0xC8 Connection                  ( 0001865CE9E0 ModelClassType FtpControlStream FtpControlStream FtpControlStream Pointer )
            value.Stream                                    = GetObject<Stream>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.Stream.FromPointer); // 024667A6A460 0xD0 Stream                      ( 000186670270 ModelClassType Stream Stream Stream Pointer )
            value.RequestStage                              = (RequestStage)GetInt32(new IntPtr(p + 0x0D8)); // 024667A6A480 0xD8 RequestStage                ( 0001866DB8F0 ModelEnumType RequestStage RequestStage RequestStage Int32 )
            value.OnceFailed                                = GetBool(new IntPtr(p + 0x0DC)); // 024667A6A4A0 0xDC OnceFailed                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.FtpRequestHeaders                         = GetObject<WebHeaderCollection>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.WebHeaderCollection.FromPointer); // 024667A6A4C0 0xE0 FtpRequestHeaders           ( 00018654B520 ModelClassType WebHeaderCollection WebHeaderCollection WebHeaderCollection Pointer )
            value.FtpWebResponse                            = GetObject<FtpWebResponse>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.FtpWebResponse.FromPointer); // 024667A6A4E0 0xE8 FtpWebResponse              ( 0001865D1EB0 ModelClassType FtpWebResponse FtpWebResponse FtpWebResponse Pointer )
            value.ReadWriteTimeout                          = GetInt32(new IntPtr(p + 0x0F0)); // 024667A6A500 0xF0 ReadWriteTimeout            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.WriteAsyncResult                          = GetObject<ContextAwareResult>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.ContextAwareResult.FromPointer); // 024667A6A520 0xF8 WriteAsyncResult            ( 000186613E90 ModelClassType ContextAwareResult ContextAwareResult ContextAwareResult Pointer )
            value.ReadAsyncResult                           = GetObject<LazyAsyncResult>(new IntPtr(p + 0x100), ReversePrism.DataModels.LazyAsyncResult.FromPointer); // 024667A6A540 0x100 ReadAsyncResult             ( 00018650E3B0 ModelClassType LazyAsyncResult LazyAsyncResult LazyAsyncResult Pointer )
            value.RequestCompleteAsyncResult                = GetObject<LazyAsyncResult>(new IntPtr(p + 0x108), ReversePrism.DataModels.LazyAsyncResult.FromPointer); // 024667A6A560 0x108 RequestCompleteAsyncResult  ( 00018650E3B0 ModelClassType LazyAsyncResult LazyAsyncResult LazyAsyncResult Pointer )

            return value;
        }
    }
}
