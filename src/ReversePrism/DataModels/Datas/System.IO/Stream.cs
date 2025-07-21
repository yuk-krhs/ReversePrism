using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Null                                     Stream IL2CPP_TYPE_CLASS
    // 018 ActiveReadWriteTask                      ModelClassType ReadWriteTask ReadWriteTask ReadWriteTask Pointer
    // 020 AsyncActiveSemaphore                     ModelClassType SemaphoreSlim SemaphoreSlim SemaphoreSlim Pointer
    public partial class Stream : DataModel
    {
        public ReadWriteTask?                           ActiveReadWriteTask                     { get; set; }
        public SemaphoreSlim?                           AsyncActiveSemaphore                    { get; set; }

        public static Stream? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Stream() { Pointer= p0 };

            value.ActiveReadWriteTask                       = GetObject<ReadWriteTask>(new IntPtr(p + 0x018), ReversePrism.DataModels.ReadWriteTask.FromPointer); // 0x18 ActiveReadWriteTask         ( ModelClassType ReadWriteTask ReadWriteTask ReadWriteTask Pointer )
            value.AsyncActiveSemaphore                      = GetObject<SemaphoreSlim>(new IntPtr(p + 0x020), ReversePrism.DataModels.SemaphoreSlim.FromPointer); // 0x20 AsyncActiveSemaphore        ( ModelClassType SemaphoreSlim SemaphoreSlim SemaphoreSlim Pointer )

            return value;
        }
    }
}
