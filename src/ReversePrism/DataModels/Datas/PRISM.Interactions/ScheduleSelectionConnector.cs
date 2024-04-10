using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 AdvUI                                    000186669720 ModelClassType ADVUI ADVUI ADVUI Pointer
    // 098 TouchAreaPanel                           0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    public partial class ScheduleSelectionConnector : DataModel
    {
        public ADVUI?                                   AdvUI                                   { get; set; }
        public GameObject?                              TouchAreaPanel                          { get; set; }

        public static ScheduleSelectionConnector? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScheduleSelectionConnector() { Pointer= p0 };

            value.AdvUI                                     = GetObject<ADVUI>(new IntPtr(p + 0x090), ReversePrism.DataModels.ADVUI.FromPointer); // 02466A1E07A0 0x90 AdvUI                       ( 000186669720 ModelClassType ADVUI ADVUI ADVUI Pointer )
            value.TouchAreaPanel                            = GetObject<GameObject>(new IntPtr(p + 0x098), ReversePrism.DataModels.GameObject.FromPointer); // 02466A1E07C0 0x98 TouchAreaPanel              ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
