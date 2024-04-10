using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_DefaultEventInterests                  Dictionary`2<Type, DefaultEventInterests> IL2CPP_TYPE_GENERICINST
    // 008 s_EventCategories                        Dictionary`2<Type, EventCategory> IL2CPP_TYPE_GENERICINST
    public partial class EventInterestReflectionUtils : DataModel
    {

        public static EventInterestReflectionUtils? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EventInterestReflectionUtils() { Pointer= p0 };


            return value;
        }
    }
}
