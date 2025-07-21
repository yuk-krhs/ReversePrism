using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Settings                               ModelClassType PanelSettings PanelSettings PanelSettings Pointer
    // 018 M_RuntimePanel                           ModelClassType BaseRuntimePanel BaseRuntimePanel BaseRuntimePanel Pointer
    public partial class RuntimePanelAccess : DataModel
    {
        public PanelSettings?                           M_Settings                              { get; set; }
        public BaseRuntimePanel?                        M_RuntimePanel                          { get; set; }

        public static RuntimePanelAccess? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RuntimePanelAccess() { Pointer= p0 };

            value.M_Settings                                = GetObject<PanelSettings>(new IntPtr(p + 0x010), ReversePrism.DataModels.PanelSettings.FromPointer); // 0x10 M_Settings                  ( ModelClassType PanelSettings PanelSettings PanelSettings Pointer )
            value.M_RuntimePanel                            = GetObject<BaseRuntimePanel>(new IntPtr(p + 0x018), ReversePrism.DataModels.BaseRuntimePanel.FromPointer); // 0x18 M_RuntimePanel              ( ModelClassType BaseRuntimePanel BaseRuntimePanel BaseRuntimePanel Pointer )

            return value;
        }
    }
}
