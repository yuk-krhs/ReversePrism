using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Widgets                                ModelClassListType List`1<Widget> List`1<Widget> List<Widget> Pointer
    // 018 M_DisplayInfo                            ModelClassType DisplayInfoAttribute DisplayInfoAttribute DisplayInfoAttribute Pointer
    public partial class DebugDisplaySettingsPanel : DataModel
    {
        public List<Widget>?                            M_Widgets                               { get; set; }
        public DisplayInfoAttribute?                    M_DisplayInfo                           { get; set; }

        public static DebugDisplaySettingsPanel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DebugDisplaySettingsPanel() { Pointer= p0 };

            value.M_Widgets                                 = GetObjectList<Widget>(new IntPtr(p + 0x010), ReversePrism.DataModels.Widget.FromPointer); // 0x10 M_Widgets                   ( ModelClassListType List`1<Widget> List`1<Widget> List<Widget> Pointer )
            value.M_DisplayInfo                             = GetObject<DisplayInfoAttribute>(new IntPtr(p + 0x018), ReversePrism.DataModels.DisplayInfoAttribute.FromPointer); // 0x18 M_DisplayInfo               ( ModelClassType DisplayInfoAttribute DisplayInfoAttribute DisplayInfoAttribute Pointer )

            return value;
        }
    }
}
