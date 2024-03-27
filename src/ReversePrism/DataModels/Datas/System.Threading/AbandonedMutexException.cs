using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 MutexIndex                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 098 Mutex                                    000186677290 ModelClassType Mutex Mutex Mutex Pointer
    public partial class AbandonedMutexException
    {
        public int                                      MutexIndex                              { get; set; }
        public Mutex?                                   Mutex                                   { get; set; }

        public static AbandonedMutexException? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AbandonedMutexException();

            value.MutexIndex                                = GetInt32(new IntPtr(p + 0x090)); // 0270D6AC24D8 0x90 MutexIndex                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Mutex                                     = GetObject<Mutex>(new IntPtr(p + 0x098), ReversePrism.DataModels.Mutex.FromPointer); // 0270D6AC24F8 0x98 Mutex                       ( 000186677290 ModelClassType Mutex Mutex Mutex Pointer )

            return value;
        }
    }
}
