using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_timeControl                            000186671F80 ModelClassType ITimeControl ITimeControl ITimeControl Pointer
    // 018 M_started                                000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class TimeControlPlayable
    {
        public ITimeControl?                            M_timeControl                           { get; set; }
        public bool                                     M_started                               { get; set; }

        public static TimeControlPlayable? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TimeControlPlayable();

            value.M_timeControl                             = GetObject<ITimeControl>(new IntPtr(p + 0x010), ReversePrism.DataModels.ITimeControl.FromPointer); // 0270DB29E378 0x10 M_timeControl               ( 000186671F80 ModelClassType ITimeControl ITimeControl ITimeControl Pointer )
            value.M_started                                 = GetBool(new IntPtr(p + 0x018)); // 0270DB29E398 0x18 M_started                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
