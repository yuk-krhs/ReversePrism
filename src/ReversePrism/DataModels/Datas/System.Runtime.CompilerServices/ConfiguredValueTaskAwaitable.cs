using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Value                                    00018676B380 ModelEnumType ValueTask ValueTask ValueTask Int32
    public partial class ConfiguredValueTaskAwaitable : DataModel
    {
        public ValueTask                                Value                                   { get; set; }

        public static ConfiguredValueTaskAwaitable? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ConfiguredValueTaskAwaitable() { Pointer= p0 };

            value.Value                                     = (ValueTask)GetInt32(new IntPtr(p + 0x010)); // 024666B56090 0x10 Value                       ( 00018676B380 ModelEnumType ValueTask ValueTask ValueTask Int32 )

            return value;
        }
    }
}
