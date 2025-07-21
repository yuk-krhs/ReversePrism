using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ToggleButton                             ModelClassType ToggleButton ToggleButton ToggleButton Pointer
    // 028 LabelOn                                  ModelClassType GameObject GameObject GameObject Pointer
    // 030 LabelOff                                 ModelClassType GameObject GameObject GameObject Pointer
    public partial class VocalSettingButton : DataModel
    {
        public ToggleButton?                            ToggleButton                            { get; set; }
        public GameObject?                              LabelOn                                 { get; set; }
        public GameObject?                              LabelOff                                { get; set; }

        public static VocalSettingButton? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VocalSettingButton() { Pointer= p0 };

            value.ToggleButton                              = GetObject<ToggleButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.ToggleButton.FromPointer); // 0x20 ToggleButton                ( ModelClassType ToggleButton ToggleButton ToggleButton Pointer )
            value.LabelOn                                   = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0x28 LabelOn                     ( ModelClassType GameObject GameObject GameObject Pointer )
            value.LabelOff                                  = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0x30 LabelOff                    ( ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
