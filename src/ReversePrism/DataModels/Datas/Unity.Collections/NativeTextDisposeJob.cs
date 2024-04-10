using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Data                                     000186693E40 ModelEnumType NativeTextDispose NativeTextDispose NativeTextDispose Int32
    public partial class NativeTextDisposeJob : DataModel
    {
        public NativeTextDispose                        Data                                    { get; set; }

        public static NativeTextDisposeJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NativeTextDisposeJob() { Pointer= p0 };

            value.Data                                      = (NativeTextDispose)GetInt32(new IntPtr(p + 0x010)); // 0246608B7730 0x10 Data                        ( 000186693E40 ModelEnumType NativeTextDispose NativeTextDispose NativeTextDispose Int32 )

            return value;
        }
    }
}
