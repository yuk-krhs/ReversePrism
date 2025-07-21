using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_invokeActionDelegate                   Action`1<<object>> IL2CPP_TYPE_GENERICINST
    // 010 Value                                    ModelEnumType ValueTask ValueTask ValueTask Int32
    public partial class ValueTaskAwaiter : DataModel
    {
        public ValueTask                                Value                                   { get; set; }

        public static ValueTaskAwaiter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ValueTaskAwaiter() { Pointer= p0 };

            value.Value                                     = (ValueTask)GetInt32(new IntPtr(p + 0x010)); // 0x10 Value                       ( ModelEnumType ValueTask ValueTask ValueTask Int32 )

            return value;
        }
    }
}
