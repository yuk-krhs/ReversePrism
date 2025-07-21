using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Data                                     ModelEnumType NativeArrayDispose NativeArrayDispose NativeArrayDispose Int32
    public partial class NativeArrayDisposeJob : DataModel
    {
        public NativeArrayDispose                       Data                                    { get; set; }

        public static NativeArrayDisposeJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NativeArrayDisposeJob() { Pointer= p0 };

            value.Data                                      = (NativeArrayDispose)GetInt32(new IntPtr(p + 0x010)); // 0x10 Data                        ( ModelEnumType NativeArrayDispose NativeArrayDispose NativeArrayDispose Int32 )

            return value;
        }
    }
}
