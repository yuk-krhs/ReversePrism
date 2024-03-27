using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ForegroundQueue                          000186719A00 ModelClassType ParallelDownloadHandlerQueue ParallelDownloadHandlerQueue ParallelDownloadHandlerQueue Pointer
    // 018 BackgroundQueue                          000186727A70 ModelClassType SequentialDownloadHandlerQueue SequentialDownloadHandlerQueue SequentialDownloadHandlerQueue Pointer
    // 020 Terminated                               000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class HybridDownloadHandlerQueue
    {
        public ParallelDownloadHandlerQueue?            ForegroundQueue                         { get; set; }
        public SequentialDownloadHandlerQueue?          BackgroundQueue                         { get; set; }
        public bool                                     Terminated                              { get; set; }

        public static HybridDownloadHandlerQueue? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HybridDownloadHandlerQueue();

            value.ForegroundQueue                           = GetObject<ParallelDownloadHandlerQueue>(new IntPtr(p + 0x010), ReversePrism.DataModels.ParallelDownloadHandlerQueue.FromPointer); // 027003E2F610 0x10 ForegroundQueue             ( 000186719A00 ModelClassType ParallelDownloadHandlerQueue ParallelDownloadHandlerQueue ParallelDownloadHandlerQueue Pointer )
            value.BackgroundQueue                           = GetObject<SequentialDownloadHandlerQueue>(new IntPtr(p + 0x018), ReversePrism.DataModels.SequentialDownloadHandlerQueue.FromPointer); // 027003E2F630 0x18 BackgroundQueue             ( 000186727A70 ModelClassType SequentialDownloadHandlerQueue SequentialDownloadHandlerQueue SequentialDownloadHandlerQueue Pointer )
            value.Terminated                                = GetBool(new IntPtr(p + 0x020)); // 027003E2F650 0x20 Terminated                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
