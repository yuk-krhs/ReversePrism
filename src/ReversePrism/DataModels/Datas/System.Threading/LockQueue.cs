using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Rwlock                                   00018661FAD0 ModelClassType ReaderWriterLock ReaderWriterLock ReaderWriterLock Pointer
    // 018 LockCount                                0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class LockQueue
    {
        public ReaderWriterLock?                        Rwlock                                  { get; set; }
        public int                                      LockCount                               { get; set; }

        public static LockQueue? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LockQueue();

            value.Rwlock                                    = GetObject<ReaderWriterLock>(new IntPtr(p + 0x010), ReversePrism.DataModels.ReaderWriterLock.FromPointer); // 0270D6AEE290 0x10 Rwlock                      ( 00018661FAD0 ModelClassType ReaderWriterLock ReaderWriterLock ReaderWriterLock Pointer )
            value.LockCount                                 = GetInt32(new IntPtr(p + 0x018)); // 0270D6AEE2B0 0x18 LockCount                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
