using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_PlayerPointerLocations                 PointerLocation[] IL2CPP_TYPE_SZARRAY
    // 008 s_PressedButtons                         int[] IL2CPP_TYPE_SZARRAY
    // 010 S_PlayerPanelWithSoftPointerCapture      000185B88420 ModelClassListType IPanel[] IPanel[] List<IPanel> Pointer
    public partial class PointerDeviceState : DataModel
    {
        public List<IPanel>?                            S_PlayerPanelWithSoftPointerCapture     { get; set; }

        public static PointerDeviceState? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PointerDeviceState() { Pointer= p0 };

            value.S_PlayerPanelWithSoftPointerCapture       = GetObjectList<IPanel>(new IntPtr(p + 0x010), ReversePrism.DataModels.IPanel.FromPointer); // 0245A676CF08 0x10 S_PlayerPanelWithSoftPointerCapture ( 000185B88420 ModelClassListType IPanel[] IPanel[] List<IPanel> Pointer )

            return value;
        }
    }
}
