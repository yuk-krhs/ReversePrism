using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 crlf                                     sbyte[] IL2CPP_TYPE_SZARRAY
    // 058 WriteBuffer                              0001865FB790 ModelClassType MemoryStream MemoryStream MemoryStream Pointer
    // 060 RequestWritten                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 061 AllowBuffering                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 062 SendChunked                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 068 PendingWrite                             000186547C40 ModelClassType WebCompletionSource WebCompletionSource WebCompletionSource Pointer
    // 070 TotalWritten                             0001865F7700 ModelPrimitiveType long long long Int64
    // 078 Headers                                  000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 080 HeadersSent                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 084 CompleteRequestWritten                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 088 ChunkTrailerWritten                      0001865F2AF0 ModelPrimitiveType int int int Int32
    // 090 InnerStream                              000186670BE0 ModelClassType Stream Stream Stream Pointer
    // 098 KeepAlive                                0001865965D0 ModelPrimitiveType bool bool bool Bool
    public partial class WebRequestStream
    {
        public MemoryStream?                            WriteBuffer                             { get; set; }
        public bool                                     RequestWritten                          { get; set; }
        public bool                                     AllowBuffering                          { get; set; }
        public bool                                     SendChunked                             { get; set; }
        public WebCompletionSource?                     PendingWrite                            { get; set; }
        public long                                     TotalWritten                            { get; set; }
        public List<sbyte>?                             Headers                                 { get; set; }
        public bool                                     HeadersSent                             { get; set; }
        public int                                      CompleteRequestWritten                  { get; set; }
        public int                                      ChunkTrailerWritten                     { get; set; }
        public Stream?                                  InnerStream                             { get; set; }
        public bool                                     KeepAlive                               { get; set; }

        public static WebRequestStream? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WebRequestStream();

            value.WriteBuffer                               = GetObject<MemoryStream>(new IntPtr(p + 0x058), ReversePrism.DataModels.MemoryStream.FromPointer); // 0270D7A73540 0x58 WriteBuffer                 ( 0001865FB790 ModelClassType MemoryStream MemoryStream MemoryStream Pointer )
            value.RequestWritten                            = GetBool(new IntPtr(p + 0x060)); // 0270D7A73560 0x60 RequestWritten              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.AllowBuffering                            = GetBool(new IntPtr(p + 0x061)); // 0270D7A73580 0x61 AllowBuffering              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.SendChunked                               = GetBool(new IntPtr(p + 0x062)); // 0270D7A735A0 0x62 SendChunked                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.PendingWrite                              = GetObject<WebCompletionSource>(new IntPtr(p + 0x068), ReversePrism.DataModels.WebCompletionSource.FromPointer); // 0270D7A735C0 0x68 PendingWrite                ( 000186547C40 ModelClassType WebCompletionSource WebCompletionSource WebCompletionSource Pointer )
            value.TotalWritten                              = GetInt64(new IntPtr(p + 0x070)); // 0270D7A735E0 0x70 TotalWritten                ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.Headers                                   = GetSByteList(new IntPtr(p + 0x078)); // 0270D7A73600 0x78 Headers                     ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.HeadersSent                               = GetBool(new IntPtr(p + 0x080)); // 0270D7A73620 0x80 HeadersSent                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.CompleteRequestWritten                    = GetInt32(new IntPtr(p + 0x084)); // 0270D7A73640 0x84 CompleteRequestWritten      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ChunkTrailerWritten                       = GetInt32(new IntPtr(p + 0x088)); // 0270D7A73660 0x88 ChunkTrailerWritten         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.InnerStream                               = GetObject<Stream>(new IntPtr(p + 0x090), ReversePrism.DataModels.Stream.FromPointer); // 0270D7A73680 0x90 InnerStream                 ( 000186670BE0 ModelClassType Stream Stream Stream Pointer )
            value.KeepAlive                                 = GetBool(new IntPtr(p + 0x098)); // 0270D7A736A0 0x98 KeepAlive                   ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
