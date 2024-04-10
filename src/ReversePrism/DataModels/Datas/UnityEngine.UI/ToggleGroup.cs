using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 M_AllowSwitchOff                         000186594D10 ModelPrimitiveType bool bool bool Bool
    // 028 M_Toggles                                000185D150E8 ModelClassListType List`1<Toggle> List`1<Toggle> List<Toggle> Pointer
    public partial class ToggleGroup : DataModel
    {
        public bool                                     M_AllowSwitchOff                        { get; set; }
        public List<Toggle>?                            M_Toggles                               { get; set; }

        public static ToggleGroup? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ToggleGroup() { Pointer= p0 };

            value.M_AllowSwitchOff                          = GetBool(new IntPtr(p + 0x020)); // 0245A4F4FB48 0x20 M_AllowSwitchOff            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_Toggles                                 = GetObjectList<Toggle>(new IntPtr(p + 0x028), ReversePrism.DataModels.Toggle.FromPointer); // 0245A4F4FB68 0x28 M_Toggles                   ( 000185D150E8 ModelClassListType List`1<Toggle> List`1<Toggle> List<Toggle> Pointer )

            return value;
        }
    }
}
