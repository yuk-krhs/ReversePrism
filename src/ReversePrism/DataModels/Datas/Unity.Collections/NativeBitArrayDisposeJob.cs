using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Data                                     000186682020 ModelEnumType NativeBitArrayDispose NativeBitArrayDispose NativeBitArrayDispose Int32
    public partial class NativeBitArrayDisposeJob
    {
        public NativeBitArrayDispose                    Data                                    { get; set; }

        public static NativeBitArrayDisposeJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NativeBitArrayDisposeJob();

            value.Data                                      = (NativeBitArrayDispose)GetInt32(new IntPtr(p + 0x010)); // 027003566A70 0x10 Data                        ( 000186682020 ModelEnumType NativeBitArrayDispose NativeBitArrayDispose NativeBitArrayDispose Int32 )

            return value;
        }
    }
}
