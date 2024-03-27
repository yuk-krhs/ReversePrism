using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 M_Panel                                  000186742070 ModelClassType BaseRuntimePanel BaseRuntimePanel BaseRuntimePanel Pointer
    public partial class PanelRaycaster
    {
        public BaseRuntimePanel?                        M_Panel                                 { get; set; }

        public static PanelRaycaster? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PanelRaycaster();

            value.M_Panel                                   = GetObject<BaseRuntimePanel>(new IntPtr(p + 0x028), ReversePrism.DataModels.BaseRuntimePanel.FromPointer); // 0270068E4818 0x28 M_Panel                     ( 000186742070 ModelClassType BaseRuntimePanel BaseRuntimePanel BaseRuntimePanel Pointer )

            return value;
        }
    }
}
