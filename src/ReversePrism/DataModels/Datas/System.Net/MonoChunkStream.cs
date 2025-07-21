using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 Headers                                  ModelClassType WebHeaderCollection WebHeaderCollection WebHeaderCollection Pointer
    // 048 Decoder                                  ModelClassType MonoChunkParser MonoChunkParser MonoChunkParser Pointer
    public partial class MonoChunkStream : DataModel
    {
        public WebHeaderCollection?                     Headers                                 { get; set; }
        public MonoChunkParser?                         Decoder                                 { get; set; }

        public static MonoChunkStream? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MonoChunkStream() { Pointer= p0 };

            value.Headers                                   = GetObject<WebHeaderCollection>(new IntPtr(p + 0x040), ReversePrism.DataModels.WebHeaderCollection.FromPointer); // 0x40 Headers                     ( ModelClassType WebHeaderCollection WebHeaderCollection WebHeaderCollection Pointer )
            value.Decoder                                   = GetObject<MonoChunkParser>(new IntPtr(p + 0x048), ReversePrism.DataModels.MonoChunkParser.FromPointer); // 0x48 Decoder                     ( ModelClassType MonoChunkParser MonoChunkParser MonoChunkParser Pointer )

            return value;
        }
    }
}
