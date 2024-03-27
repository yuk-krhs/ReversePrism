using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_TransitionDelayList                    List`1<TimeValue> IL2CPP_TYPE_GENERICINST
    // 008 s_TransitionDurationList                 List`1<TimeValue> IL2CPP_TYPE_GENERICINST
    // 010 S_TransitionPropertyList                 000185D0E1C8 ModelEnumListType List`1<StylePropertyName> List`1<StylePropertyName> List<StylePropertyName> Pointer
    // 018 S_TransitionTimingFunctionList           000185CD7D48 ModelEnumListType List`1<EasingFunction> List`1<EasingFunction> List<EasingFunction> Pointer
    public partial class ShorthandApplicator
    {
        public List<StylePropertyName>?                 S_TransitionPropertyList                { get; set; }
        public List<EasingFunction>?                    S_TransitionTimingFunctionList          { get; set; }

        public static ShorthandApplicator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShorthandApplicator();

            value.S_TransitionPropertyList                  = GetEnumList<StylePropertyName>(new IntPtr(p + 0x010)); // 027006882FF0 0x10 S_TransitionPropertyList    ( 000185D0E1C8 ModelEnumListType List`1<StylePropertyName> List`1<StylePropertyName> List<StylePropertyName> Pointer )
            value.S_TransitionTimingFunctionList            = GetEnumList<EasingFunction>(new IntPtr(p + 0x018)); // 027006883010 0x18 S_TransitionTimingFunctionList ( 000185CD7D48 ModelEnumListType List`1<EasingFunction> List`1<EasingFunction> List<EasingFunction> Pointer )

            return value;
        }
    }
}
