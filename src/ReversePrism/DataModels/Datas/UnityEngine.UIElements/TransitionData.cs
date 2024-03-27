using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TransitionDelay                          000185D14658 ModelEnumListType List`1<TimeValue> List`1<TimeValue> List<TimeValue> Pointer
    // 018 TransitionDuration                       000185D14658 ModelEnumListType List`1<TimeValue> List`1<TimeValue> List<TimeValue> Pointer
    // 020 TransitionProperty                       000185D0E158 ModelEnumListType List`1<StylePropertyName> List`1<StylePropertyName> List<StylePropertyName> Pointer
    // 028 TransitionTimingFunction                 000185CD7CC8 ModelEnumListType List`1<EasingFunction> List`1<EasingFunction> List<EasingFunction> Pointer
    public partial class TransitionData
    {
        public List<TimeValue>?                         TransitionDelay                         { get; set; }
        public List<TimeValue>?                         TransitionDuration                      { get; set; }
        public List<StylePropertyName>?                 TransitionProperty                      { get; set; }
        public List<EasingFunction>?                    TransitionTimingFunction                { get; set; }

        public static TransitionData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TransitionData();

            value.TransitionDelay                           = GetEnumList<TimeValue>(new IntPtr(p + 0x010)); // 027003F23ED8 0x10 TransitionDelay             ( 000185D14658 ModelEnumListType List`1<TimeValue> List`1<TimeValue> List<TimeValue> Pointer )
            value.TransitionDuration                        = GetEnumList<TimeValue>(new IntPtr(p + 0x018)); // 027003F23EF8 0x18 TransitionDuration          ( 000185D14658 ModelEnumListType List`1<TimeValue> List`1<TimeValue> List<TimeValue> Pointer )
            value.TransitionProperty                        = GetEnumList<StylePropertyName>(new IntPtr(p + 0x020)); // 027003F23F18 0x20 TransitionProperty          ( 000185D0E158 ModelEnumListType List`1<StylePropertyName> List`1<StylePropertyName> List<StylePropertyName> Pointer )
            value.TransitionTimingFunction                  = GetEnumList<EasingFunction>(new IntPtr(p + 0x028)); // 027003F23F38 0x28 TransitionTimingFunction    ( 000185CD7CC8 ModelEnumListType List`1<EasingFunction> List`1<EasingFunction> List<EasingFunction> Pointer )

            return value;
        }
    }
}
