using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_GetRequestStreamCallback               WaitCallback IL2CPP_TYPE_CLASS
    // 008 s_GetResponseCallback                    WaitCallback IL2CPP_TYPE_CLASS
    // 038 M_connectionGroupName                    000186671910 ModelPrimitiveType string string string String
    // 040 M_contentLength                          0001865F7700 ModelPrimitiveType long long long Int64
    // 048 M_credentials                            000186745960 ModelClassType ICredentials ICredentials ICredentials Pointer
    // 050 M_fileAccess                             000186577D30 ModelEnumType FileAccess FileAccess FileAccess Int32
    // 058 M_headers                                00018654B520 ModelClassType WebHeaderCollection WebHeaderCollection WebHeaderCollection Pointer
    // 060 M_method                                 000186671910 ModelPrimitiveType string string string String
    // 068 M_preauthenticate                        000186594D10 ModelPrimitiveType bool bool bool Bool
    // 070 M_proxy                                  00018669AB30 ModelClassType IWebProxy IWebProxy IWebProxy Pointer
    // 078 M_readerEvent                            00018660A400 ModelClassType ManualResetEvent ManualResetEvent ManualResetEvent Pointer
    // 080 M_readPending                            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 088 M_response                               000186550A80 ModelClassType WebResponse WebResponse WebResponse Pointer
    // 090 M_stream                                 000186670270 ModelClassType Stream Stream Stream Pointer
    // 098 M_syncHint                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 09C M_timeout                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 0A0 M_uri                                    0001866A4270 ModelClassType Uri Uri Uri Pointer
    // 0A8 M_writePending                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0A9 M_writing                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0B0 M_WriteAResult                           00018650E3B0 ModelClassType LazyAsyncResult LazyAsyncResult LazyAsyncResult Pointer
    // 0B8 M_ReadAResult                            00018650E3B0 ModelClassType LazyAsyncResult LazyAsyncResult LazyAsyncResult Pointer
    // 0C0 M_Aborted                                0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class FileWebRequest : DataModel
    {
        public string                                   M_connectionGroupName                   { get; set; }
        public long                                     M_contentLength                         { get; set; }
        public ICredentials?                            M_credentials                           { get; set; }
        public FileAccess                               M_fileAccess                            { get; set; }
        public WebHeaderCollection?                     M_headers                               { get; set; }
        public string                                   M_method                                { get; set; }
        public bool                                     M_preauthenticate                       { get; set; }
        public IWebProxy?                               M_proxy                                 { get; set; }
        public ManualResetEvent?                        M_readerEvent                           { get; set; }
        public bool                                     M_readPending                           { get; set; }
        public WebResponse?                             M_response                              { get; set; }
        public Stream?                                  M_stream                                { get; set; }
        public bool                                     M_syncHint                              { get; set; }
        public int                                      M_timeout                               { get; set; }
        public Uri?                                     M_uri                                   { get; set; }
        public bool                                     M_writePending                          { get; set; }
        public bool                                     M_writing                               { get; set; }
        public LazyAsyncResult?                         M_WriteAResult                          { get; set; }
        public LazyAsyncResult?                         M_ReadAResult                           { get; set; }
        public int                                      M_Aborted                               { get; set; }

        public static FileWebRequest? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FileWebRequest() { Pointer= p0 };

            value.M_connectionGroupName                     = GetString(new IntPtr(p + 0x038)); // 024667AB02D8 0x38 M_connectionGroupName       ( 000186671910 ModelPrimitiveType string string string String )
            value.M_contentLength                           = GetInt64(new IntPtr(p + 0x040)); // 024667AB02F8 0x40 M_contentLength             ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.M_credentials                             = GetObject<ICredentials>(new IntPtr(p + 0x048), ReversePrism.DataModels.ICredentials.FromPointer); // 024667AB0318 0x48 M_credentials               ( 000186745960 ModelClassType ICredentials ICredentials ICredentials Pointer )
            value.M_fileAccess                              = (FileAccess)GetInt32(new IntPtr(p + 0x050)); // 024667AB0338 0x50 M_fileAccess                ( 000186577D30 ModelEnumType FileAccess FileAccess FileAccess Int32 )
            value.M_headers                                 = GetObject<WebHeaderCollection>(new IntPtr(p + 0x058), ReversePrism.DataModels.WebHeaderCollection.FromPointer); // 024667AB0358 0x58 M_headers                   ( 00018654B520 ModelClassType WebHeaderCollection WebHeaderCollection WebHeaderCollection Pointer )
            value.M_method                                  = GetString(new IntPtr(p + 0x060)); // 024667AB0378 0x60 M_method                    ( 000186671910 ModelPrimitiveType string string string String )
            value.M_preauthenticate                         = GetBool(new IntPtr(p + 0x068)); // 024667AB0398 0x68 M_preauthenticate           ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_proxy                                   = GetObject<IWebProxy>(new IntPtr(p + 0x070), ReversePrism.DataModels.IWebProxy.FromPointer); // 024667AB03B8 0x70 M_proxy                     ( 00018669AB30 ModelClassType IWebProxy IWebProxy IWebProxy Pointer )
            value.M_readerEvent                             = GetObject<ManualResetEvent>(new IntPtr(p + 0x078), ReversePrism.DataModels.ManualResetEvent.FromPointer); // 024667AB03D8 0x78 M_readerEvent               ( 00018660A400 ModelClassType ManualResetEvent ManualResetEvent ManualResetEvent Pointer )
            value.M_readPending                             = GetBool(new IntPtr(p + 0x080)); // 024667AB03F8 0x80 M_readPending               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_response                                = GetObject<WebResponse>(new IntPtr(p + 0x088), ReversePrism.DataModels.WebResponse.FromPointer); // 024667AB0418 0x88 M_response                  ( 000186550A80 ModelClassType WebResponse WebResponse WebResponse Pointer )
            value.M_stream                                  = GetObject<Stream>(new IntPtr(p + 0x090), ReversePrism.DataModels.Stream.FromPointer); // 024667AB0438 0x90 M_stream                    ( 000186670270 ModelClassType Stream Stream Stream Pointer )
            value.M_syncHint                                = GetBool(new IntPtr(p + 0x098)); // 024667AB0458 0x98 M_syncHint                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_timeout                                 = GetInt32(new IntPtr(p + 0x09C)); // 024667AB0478 0x9C M_timeout                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_uri                                     = GetObject<Uri>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.Uri.FromPointer); // 024667AB0498 0xA0 M_uri                       ( 0001866A4270 ModelClassType Uri Uri Uri Pointer )
            value.M_writePending                            = GetBool(new IntPtr(p + 0x0A8)); // 024667AB04B8 0xA8 M_writePending              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_writing                                 = GetBool(new IntPtr(p + 0x0A9)); // 024667AB04D8 0xA9 M_writing                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_WriteAResult                            = GetObject<LazyAsyncResult>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.LazyAsyncResult.FromPointer); // 024667AB04F8 0xB0 M_WriteAResult              ( 00018650E3B0 ModelClassType LazyAsyncResult LazyAsyncResult LazyAsyncResult Pointer )
            value.M_ReadAResult                             = GetObject<LazyAsyncResult>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.LazyAsyncResult.FromPointer); // 024667AB0518 0xB8 M_ReadAResult               ( 00018650E3B0 ModelClassType LazyAsyncResult LazyAsyncResult LazyAsyncResult Pointer )
            value.M_Aborted                                 = GetInt32(new IntPtr(p + 0x0C0)); // 024667AB0538 0xC0 M_Aborted                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
