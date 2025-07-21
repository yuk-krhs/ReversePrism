using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Data                                     ModelEnumType NativeHashMapDispose NativeHashMapDispose NativeHashMapDispose Int32
    public partial class NativeHashMapDisposeJob : DataModel
    {
        public NativeHashMapDispose                     Data                                    { get; set; }

        public static NativeHashMapDisposeJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NativeHashMapDisposeJob() { Pointer= p0 };

            value.Data                                      = (NativeHashMapDispose)GetInt32(new IntPtr(p + 0x010)); // 0x10 Data                        ( ModelEnumType NativeHashMapDispose NativeHashMapDispose NativeHashMapDispose Int32 )

            return value;
        }
    }
}
