using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Data                                     000186688F60 ModelEnumType NativeHashMapDispose NativeHashMapDispose NativeHashMapDispose Int32
    public partial class NativeHashMapDisposeJob
    {
        public NativeHashMapDispose                     Data                                    { get; set; }

        public static NativeHashMapDisposeJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NativeHashMapDisposeJob();

            value.Data                                      = (NativeHashMapDispose)GetInt32(new IntPtr(p + 0x010)); // 027003567618 0x10 Data                        ( 000186688F60 ModelEnumType NativeHashMapDispose NativeHashMapDispose NativeHashMapDispose Int32 )

            return value;
        }
    }
}
