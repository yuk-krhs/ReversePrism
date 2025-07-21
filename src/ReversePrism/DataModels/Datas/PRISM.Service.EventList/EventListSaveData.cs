using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AlreadyReadEventIds                      ModelPrimitiveListType string[] string[] List<string> Pointer
    // 018 <AlreadyReadEventIds>k__BackingField     HashSet`1<string> IL2CPP_TYPE_GENERICINST
    public partial class EventListSaveData : DataModel
    {
        public List<string>?                            AlreadyReadEventIds                     { get; set; }

        public static EventListSaveData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EventListSaveData() { Pointer= p0 };

            value.AlreadyReadEventIds                       = GetStringList(new IntPtr(p + 0x010)); // 0x10 AlreadyReadEventIds         ( ModelPrimitiveListType string[] string[] List<string> Pointer )

            return value;
        }
    }
}
