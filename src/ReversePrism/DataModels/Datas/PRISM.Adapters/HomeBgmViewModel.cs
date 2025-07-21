using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TimeOfDay                                ModelEnumType TimeOfDay TimeOfDay TimeOfDay Int32
    // 014 Weather                                  ModelEnumType Weather Weather Weather Int32
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

            value.TimeOfDay                                 = (TimeOfDay)GetInt32(new IntPtr(p + 0x010)); // 0x10 TimeOfDay                   ( ModelEnumType TimeOfDay TimeOfDay TimeOfDay Int32 )
            value.Weather                                   = (Weather)GetInt32(new IntPtr(p + 0x014)); // 0x14 Weather                     ( ModelEnumType Weather Weather Weather Int32 )

            return value;
        }
    }
}
