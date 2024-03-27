using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 UnitIconPanel                            00018651F170 ModelClassType ExchangeUnitIconPanel ExchangeUnitIconPanel ExchangeUnitIconPanel Pointer
    // 028 UnitToggle                               000186683C40 ModelClassType ToggleButton ToggleButton ToggleButton Pointer
    // 030 UnitNameText                             0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 charaIDToggles                           Dictionary`2<int, ToggleButton> IL2CPP_TYPE_GENERICINST
    // 040 UnderLineObj                             0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    public partial class ExchangePieceFilterCell
    {
        public ExchangeUnitIconPanel?                   UnitIconPanel                           { get; set; }
        public ToggleButton?                            UnitToggle                              { get; set; }
        public UITextMeshProUGUI?                       UnitNameText                            { get; set; }
        public GameObject?                              UnderLineObj                            { get; set; }

        public static ExchangePieceFilterCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExchangePieceFilterCell();

            value.UnitIconPanel                             = GetObject<ExchangeUnitIconPanel>(new IntPtr(p + 0x020), ReversePrism.DataModels.ExchangeUnitIconPanel.FromPointer); // 0270D54DD7F8 0x20 UnitIconPanel               ( 00018651F170 ModelClassType ExchangeUnitIconPanel ExchangeUnitIconPanel ExchangeUnitIconPanel Pointer )
            value.UnitToggle                                = GetObject<ToggleButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.ToggleButton.FromPointer); // 0270D54DD818 0x28 UnitToggle                  ( 000186683C40 ModelClassType ToggleButton ToggleButton ToggleButton Pointer )
            value.UnitNameText                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D54DD838 0x30 UnitNameText                ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.UnderLineObj                              = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0270D54DD878 0x40 UnderLineObj                ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
