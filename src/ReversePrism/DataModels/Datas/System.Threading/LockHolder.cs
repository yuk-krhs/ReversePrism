using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Lock                                     0001865A91B0 ModelClassType Lock Lock Lock Pointer
    public partial class LockHolder
    {
        public Lock?                                    Lock                                    { get; set; }

        public static LockHolder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LockHolder();

            value.Lock                                      = GetObject<Lock>(new IntPtr(p + 0x010), ReversePrism.DataModels.Lock.FromPointer); // 0270D6AC7CC0 0x10 Lock                        ( 0001865A91B0 ModelClassType Lock Lock Lock Pointer )

            return value;
        }
    }
}
