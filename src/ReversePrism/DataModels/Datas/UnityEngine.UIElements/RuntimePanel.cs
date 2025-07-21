using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_EventDispatcher                        EventDispatcher IL2CPP_TYPE_CLASS
    // 1E8 M_PanelSettings                          ModelClassType PanelSettings PanelSettings PanelSettings Pointer
    public partial class RuntimePanel : DataModel
    {
        public PanelSettings?                           M_PanelSettings                         { get; set; }

        public static RuntimePanel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RuntimePanel() { Pointer= p0 };

            value.M_PanelSettings                           = GetObject<PanelSettings>(new IntPtr(p + 0x1E8), ReversePrism.DataModels.PanelSettings.FromPointer); // 0x1E8 M_PanelSettings             ( ModelClassType PanelSettings PanelSettings PanelSettings Pointer )

            return value;
        }
    }
}
