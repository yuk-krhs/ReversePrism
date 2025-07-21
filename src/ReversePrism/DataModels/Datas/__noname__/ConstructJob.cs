using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Container                                ModelEnumType UnsafeStream UnsafeStream UnsafeStream Int32
    // 030 Length                                   NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    public partial class ConstructJob : DataModel
    {
        public UnsafeStream                             Container                               { get; set; }

        public static ConstructJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ConstructJob() { Pointer= p0 };

            value.Container                                 = (UnsafeStream)GetInt32(new IntPtr(p + 0x010)); // 0x10 Container                   ( ModelEnumType UnsafeStream UnsafeStream UnsafeStream Int32 )

            return value;
        }
    }
}
