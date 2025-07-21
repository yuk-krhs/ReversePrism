using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Data                                     ModelEnumType NativeBitArrayDispose NativeBitArrayDispose NativeBitArrayDispose Int32
    public partial class NativeBitArrayDisposeJob : DataModel
    {
        public NativeBitArrayDispose                    Data                                    { get; set; }

        public static NativeBitArrayDisposeJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NativeBitArrayDisposeJob() { Pointer= p0 };

            value.Data                                      = (NativeBitArrayDispose)GetInt32(new IntPtr(p + 0x010)); // 0x10 Data                        ( ModelEnumType NativeBitArrayDispose NativeBitArrayDispose NativeBitArrayDispose Int32 )

            return value;
        }
    }
}
