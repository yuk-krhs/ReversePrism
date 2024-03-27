using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_StreamData                             0001866A33A0 ModelEnumType UnsafeStream UnsafeStream UnsafeStream Int32
    public partial class NativeStreamDispose
    {
        public UnsafeStream                             M_StreamData                            { get; set; }

        public static NativeStreamDispose? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NativeStreamDispose();

            value.M_StreamData                              = (UnsafeStream)GetInt32(new IntPtr(p + 0x010)); // 0270D086EA48 0x10 M_StreamData                ( 0001866A33A0 ModelEnumType UnsafeStream UnsafeStream UnsafeStream Int32 )

            return value;
        }
    }
}
