using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 EventTypes                               ModelClassListType Type[] Type[] List<Type> Pointer
    // 018 CategoryFlags                            ModelEnumType EventCategoryFlags EventCategoryFlags EventCategoryFlags Int32
    public partial class EventInterestAttribute : DataModel
    {
        public List<Type>?                              EventTypes                              { get; set; }
        public EventCategoryFlags                       CategoryFlags                           { get; set; }

        public static EventInterestAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EventInterestAttribute() { Pointer= p0 };

            value.EventTypes                                = GetObjectList<Type>(new IntPtr(p + 0x010), ReversePrism.DataModels.Type.FromPointer); // 0x10 EventTypes                  ( ModelClassListType Type[] Type[] List<Type> Pointer )
            value.CategoryFlags                             = (EventCategoryFlags)GetInt32(new IntPtr(p + 0x018)); // 0x18 CategoryFlags               ( ModelEnumType EventCategoryFlags EventCategoryFlags EventCategoryFlags Int32 )

            return value;
        }
    }
}
