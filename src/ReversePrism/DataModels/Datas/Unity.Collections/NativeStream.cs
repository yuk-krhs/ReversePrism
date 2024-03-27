using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Stream                                 0001866A3150 ModelEnumType UnsafeStream UnsafeStream UnsafeStream Int32
    public partial class NativeStream
    {
        public UnsafeStream                             M_Stream                                { get; set; }

        public static NativeStream? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NativeStream();

            value.M_Stream                                  = (UnsafeStream)GetInt32(new IntPtr(p + 0x010)); // 0270D086B7B8 0x10 M_Stream                    ( 0001866A3150 ModelEnumType UnsafeStream UnsafeStream UnsafeStream Int32 )

            return value;
        }
    }
}
