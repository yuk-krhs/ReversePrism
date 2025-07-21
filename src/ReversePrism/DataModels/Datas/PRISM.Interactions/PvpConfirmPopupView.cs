using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TopText                                  ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 028 MyTotalPower                             ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 030 OpponentTotalPower                       ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 038 MyFUnitIcon                              ModelClassType FUnitIconView FUnitIconView FUnitIconView Pointer
    // 040 OpponentFUnitIcon                        ModelClassType FUnitIconView FUnitIconView FUnitIconView Pointer
    // 048 StaminaText                              ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 050 StaminaName                              ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 058 CloseButton                              ModelClassType Button Button Button Pointer
    // 060 onClosed                                 Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 068 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class PvpConfirmPopupView : DataModel
    {
        public TextMeshProUGUI?                         TopText                                 { get; set; }
        public TextMeshProUGUI?                         MyTotalPower                            { get; set; }
        public TextMeshProUGUI?                         OpponentTotalPower                      { get; set; }
        public FUnitIconView?                           MyFUnitIcon                             { get; set; }
        public FUnitIconView?                           OpponentFUnitIcon                       { get; set; }
        public TextMeshProUGUI?                         StaminaText                             { get; set; }
        public TextMeshProUGUI?                         StaminaName                             { get; set; }
        public Button?                                  CloseButton                             { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static PvpConfirmPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PvpConfirmPopupView() { Pointer= p0 };

            value.TopText                                   = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0x20 TopText                     ( ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.MyTotalPower                              = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0x28 MyTotalPower                ( ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.OpponentTotalPower                        = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0x30 OpponentTotalPower          ( ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.MyFUnitIcon                               = GetObject<FUnitIconView>(new IntPtr(p + 0x038), ReversePrism.DataModels.FUnitIconView.FromPointer); // 0x38 MyFUnitIcon                 ( ModelClassType FUnitIconView FUnitIconView FUnitIconView Pointer )
            value.OpponentFUnitIcon                         = GetObject<FUnitIconView>(new IntPtr(p + 0x040), ReversePrism.DataModels.FUnitIconView.FromPointer); // 0x40 OpponentFUnitIcon           ( ModelClassType FUnitIconView FUnitIconView FUnitIconView Pointer )
            value.StaminaText                               = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0x48 StaminaText                 ( ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.StaminaName                               = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0x50 StaminaName                 ( ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.CloseButton                               = GetObject<Button>(new IntPtr(p + 0x058), ReversePrism.DataModels.Button.FromPointer); // 0x58 CloseButton                 ( ModelClassType Button Button Button Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x068), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x68 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
