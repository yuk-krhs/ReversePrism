using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Container                                0001866A33A0 ModelEnumType UnsafeStream UnsafeStream UnsafeStream Int32
    public partial class DisposeJob
    {
        public UnsafeStream                             Container                               { get; set; }

        public static DisposeJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DisposeJob();

            value.Container                                 = (UnsafeStream)GetInt32(new IntPtr(p + 0x010)); // 0270D0873618 0x10 Container                   ( 0001866A33A0 ModelEnumType UnsafeStream UnsafeStream UnsafeStream Int32 )

            return value;
        }
    }
}
