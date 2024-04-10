using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Container                                0001866A33A0 ModelEnumType UnsafeStream UnsafeStream UnsafeStream Int32
    public partial class DisposeJob : DataModel
    {
        public UnsafeStream                             Container                               { get; set; }

        public static DisposeJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DisposeJob() { Pointer= p0 };

            value.Container                                 = (UnsafeStream)GetInt32(new IntPtr(p + 0x010)); // 0246608BB5A8 0x10 Container                   ( 0001866A33A0 ModelEnumType UnsafeStream UnsafeStream UnsafeStream Int32 )

            return value;
        }
    }
}
