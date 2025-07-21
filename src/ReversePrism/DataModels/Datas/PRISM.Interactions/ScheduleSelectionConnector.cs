using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 088 AdvUI                                    ModelClassType AdvScreenView AdvScreenView AdvScreenView Pointer
    // 090 TouchAreaPanel                           ModelClassType GameObject GameObject GameObject Pointer
    public partial class ScheduleSelectionConnector : DataModel
    {
        public AdvScreenView?                           AdvUI                                   { get; set; }
        public GameObject?                              TouchAreaPanel                          { get; set; }

        public static ScheduleSelectionConnector? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScheduleSelectionConnector() { Pointer= p0 };

            value.AdvUI                                     = GetObject<AdvScreenView>(new IntPtr(p + 0x088), ReversePrism.DataModels.AdvScreenView.FromPointer); // 0x88 AdvUI                       ( ModelClassType AdvScreenView AdvScreenView AdvScreenView Pointer )
            value.TouchAreaPanel                            = GetObject<GameObject>(new IntPtr(p + 0x090), ReversePrism.DataModels.GameObject.FromPointer); // 0x90 TouchAreaPanel              ( ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
