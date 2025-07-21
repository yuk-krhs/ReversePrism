using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TransitionDelay                          ModelEnumListType List`1<TimeValue> List`1<TimeValue> List<TimeValue> Pointer
    // 018 TransitionDuration                       ModelEnumListType List`1<TimeValue> List`1<TimeValue> List<TimeValue> Pointer
    // 020 TransitionProperty                       ModelEnumListType List`1<StylePropertyName> List`1<StylePropertyName> List<StylePropertyName> Pointer
    // 028 TransitionTimingFunction                 ModelEnumListType List`1<EasingFunction> List`1<EasingFunction> List<EasingFunction> Pointer
    public partial class TransitionData : DataModel
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
            var value   = new TransitionData() { Pointer= p0 };

            value.TransitionDelay                           = GetEnumList<TimeValue>(new IntPtr(p + 0x010)); // 0x10 TransitionDelay             ( ModelEnumListType List`1<TimeValue> List`1<TimeValue> List<TimeValue> Pointer )
            value.TransitionDuration                        = GetEnumList<TimeValue>(new IntPtr(p + 0x018)); // 0x18 TransitionDuration          ( ModelEnumListType List`1<TimeValue> List`1<TimeValue> List<TimeValue> Pointer )
            value.TransitionProperty                        = GetEnumList<StylePropertyName>(new IntPtr(p + 0x020)); // 0x20 TransitionProperty          ( ModelEnumListType List`1<StylePropertyName> List`1<StylePropertyName> List<StylePropertyName> Pointer )
            value.TransitionTimingFunction                  = GetEnumList<EasingFunction>(new IntPtr(p + 0x028)); // 0x28 TransitionTimingFunction    ( ModelEnumListType List`1<EasingFunction> List`1<EasingFunction> List<EasingFunction> Pointer )

            return value;
        }
    }
}
