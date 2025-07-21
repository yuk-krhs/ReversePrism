using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 crlf                                     sbyte[] IL2CPP_TYPE_SZARRAY
    // 058 WriteBuffer                              ModelClassType MemoryStream MemoryStream MemoryStream Pointer
    // 060 RequestWritten                           ModelPrimitiveType bool bool bool Bool
    // 061 AllowBuffering                           ModelPrimitiveType bool bool bool Bool
    // 062 SendChunked                              ModelPrimitiveType bool bool bool Bool
    // 068 PendingWrite                             ModelClassType WebCompletionSource WebCompletionSource WebCompletionSource Pointer
    // 070 TotalWritten                             ModelPrimitiveType long long long Int64
    // 078 Headers                                  ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 080 HeadersSent                              ModelPrimitiveType bool bool bool Bool
    // 084 CompleteRequestWritten                   ModelPrimitiveType int int int Int32
    // 088 ChunkTrailerWritten                      ModelPrimitiveType int int int Int32
    // 090 InnerStream                              ModelClassType Stream Stream Stream Pointer
    // 098 KeepAlive                                ModelPrimitiveType bool bool bool Bool
    public partial class WebRequestStream : DataModel
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
            var value   = new WebRequestStream() { Pointer= p0 };

            value.WriteBuffer                               = GetObject<MemoryStream>(new IntPtr(p + 0x058), ReversePrism.DataModels.MemoryStream.FromPointer); // 0x58 WriteBuffer                 ( ModelClassType MemoryStream MemoryStream MemoryStream Pointer )
            value.RequestWritten                            = GetBool(new IntPtr(p + 0x060)); // 0x60 RequestWritten              ( ModelPrimitiveType bool bool bool Bool )
            value.AllowBuffering                            = GetBool(new IntPtr(p + 0x061)); // 0x61 AllowBuffering              ( ModelPrimitiveType bool bool bool Bool )
            value.SendChunked                               = GetBool(new IntPtr(p + 0x062)); // 0x62 SendChunked                 ( ModelPrimitiveType bool bool bool Bool )
            value.PendingWrite                              = GetObject<WebCompletionSource>(new IntPtr(p + 0x068), ReversePrism.DataModels.WebCompletionSource.FromPointer); // 0x68 PendingWrite                ( ModelClassType WebCompletionSource WebCompletionSource WebCompletionSource Pointer )
            value.TotalWritten                              = GetInt64(new IntPtr(p + 0x070)); // 0x70 TotalWritten                ( ModelPrimitiveType long long long Int64 )
            value.Headers                                   = GetSByteList(new IntPtr(p + 0x078)); // 0x78 Headers                     ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.HeadersSent                               = GetBool(new IntPtr(p + 0x080)); // 0x80 HeadersSent                 ( ModelPrimitiveType bool bool bool Bool )
            value.CompleteRequestWritten                    = GetInt32(new IntPtr(p + 0x084)); // 0x84 CompleteRequestWritten      ( ModelPrimitiveType int int int Int32 )
            value.ChunkTrailerWritten                       = GetInt32(new IntPtr(p + 0x088)); // 0x88 ChunkTrailerWritten         ( ModelPrimitiveType int int int Int32 )
            value.InnerStream                               = GetObject<Stream>(new IntPtr(p + 0x090), ReversePrism.DataModels.Stream.FromPointer); // 0x90 InnerStream                 ( ModelClassType Stream Stream Stream Pointer )
            value.KeepAlive                                 = GetBool(new IntPtr(p + 0x098)); // 0x98 KeepAlive                   ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
