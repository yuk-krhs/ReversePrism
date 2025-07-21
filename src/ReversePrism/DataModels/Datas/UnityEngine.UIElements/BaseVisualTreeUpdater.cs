using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 panelChanged                             Action`1<BaseVisualElementPanel> IL2CPP_TYPE_GENERICINST
    // 018 M_Panel                                  ModelClassType BaseVisualElementPanel BaseVisualElementPanel BaseVisualElementPanel Pointer
    public partial class BaseVisualTreeUpdater : DataModel
    {
        public BaseVisualElementPanel?                  M_Panel                                 { get; set; }

        public static BaseVisualTreeUpdater? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BaseVisualTreeUpdater() { Pointer= p0 };

            value.M_Panel                                   = GetObject<BaseVisualElementPanel>(new IntPtr(p + 0x018), ReversePrism.DataModels.BaseVisualElementPanel.FromPointer); // 0x18 M_Panel                     ( ModelClassType BaseVisualElementPanel BaseVisualElementPanel BaseVisualElementPanel Pointer )

            return value;
        }
    }
}
