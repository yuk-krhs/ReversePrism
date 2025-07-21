using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ForegroundQueue                          ModelClassType ParallelDownloadHandlerQueue ParallelDownloadHandlerQueue ParallelDownloadHandlerQueue Pointer
    // 018 BackgroundQueue                          ModelClassType SequentialDownloadHandlerQueue SequentialDownloadHandlerQueue SequentialDownloadHandlerQueue Pointer
    // 020 Terminated                               ModelPrimitiveType bool bool bool Bool
    public partial class HybridDownloadHandlerQueue : DataModel
    {
        public ParallelDownloadHandlerQueue?            ForegroundQueue                         { get; set; }
        public SequentialDownloadHandlerQueue?          BackgroundQueue                         { get; set; }
        public bool                                     Terminated                              { get; set; }

        public static HybridDownloadHandlerQueue? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HybridDownloadHandlerQueue() { Pointer= p0 };

            value.ForegroundQueue                           = GetObject<ParallelDownloadHandlerQueue>(new IntPtr(p + 0x010), ReversePrism.DataModels.ParallelDownloadHandlerQueue.FromPointer); // 0x10 ForegroundQueue             ( ModelClassType ParallelDownloadHandlerQueue ParallelDownloadHandlerQueue ParallelDownloadHandlerQueue Pointer )
            value.BackgroundQueue                           = GetObject<SequentialDownloadHandlerQueue>(new IntPtr(p + 0x018), ReversePrism.DataModels.SequentialDownloadHandlerQueue.FromPointer); // 0x18 BackgroundQueue             ( ModelClassType SequentialDownloadHandlerQueue SequentialDownloadHandlerQueue SequentialDownloadHandlerQueue Pointer )
            value.Terminated                                = GetBool(new IntPtr(p + 0x020)); // 0x20 Terminated                  ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
