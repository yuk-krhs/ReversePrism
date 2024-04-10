using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TimeOfDay                                00018653A580 ModelEnumType TimeOfDay TimeOfDay TimeOfDay Int32
    // 014 Weather                                  00018653AFB0 ModelEnumType Weather Weather Weather Int32
    public partial class HomeBgmViewModel : DataModel
    {
        public TimeOfDay                                TimeOfDay                               { get; set; }
        public Weather                                  Weather                                 { get; set; }

        public static HomeBgmViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HomeBgmViewModel() { Pointer= p0 };

            value.TimeOfDay                                 = (TimeOfDay)GetInt32(new IntPtr(p + 0x010)); // 0245A5D43A98 0x10 TimeOfDay                   ( 00018653A580 ModelEnumType TimeOfDay TimeOfDay TimeOfDay Int32 )
            value.Weather                                   = (Weather)GetInt32(new IntPtr(p + 0x014)); // 0245A5D43AB8 0x14 Weather                     ( 00018653AFB0 ModelEnumType Weather Weather Weather Int32 )

            return value;
        }
    }
}
