using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Container                                0001866A33A0 ModelEnumType UnsafeStream UnsafeStream UnsafeStream Int32
    // 030 List                                     IntPtr IL2CPP_TYPE_PTR
    public partial class ConstructJobList
    {
        public UnsafeStream                             Container                               { get; set; }

        public static ConstructJobList? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ConstructJobList();

            value.Container                                 = (UnsafeStream)GetInt32(new IntPtr(p + 0x010)); // 0270D0874128 0x10 Container                   ( 0001866A33A0 ModelEnumType UnsafeStream UnsafeStream UnsafeStream Int32 )

            return value;
        }
    }
}
