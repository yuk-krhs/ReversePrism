using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 UnitParameterContent                     00018670F700 ModelClassType UnitParameterContent UnitParameterContent UnitParameterContent Pointer
    // 028 VitalityGaugeContent                     00018652E260 ModelClassType VitalityGauge VitalityGauge VitalityGauge Pointer
    // 030 EditInfoButton                           0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 038 DeckListButton                           0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 040 InheritanceButton                        0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 048 InheritanceButtonCover                   0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 050 FanCountText                             0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 produceEditInformationPopupViewFactory   PopupViewFactory`1<IProduceEditInformationPopupView> IL2CPP_TYPE_GENERICINST
    // 060 ScheduleSelectionLeftBottomAreaViewModel 0001866DA490 ModelClassType ScheduleSelectionLeftBottomAreaViewModel ScheduleSelectionLeftBottomAreaViewModel ScheduleSelectionLeftBottomAreaViewModel Pointer
    // 068 onRingIdolVoiceActivate                  Action`1<bool> IL2CPP_TYPE_GENERICINST
    public partial class ScheduleSelectionLeftBottomAreaView : DataModel
    {
        public UnitParameterContent?                    UnitParameterContent                    { get; set; }
        public VitalityGauge?                           VitalityGaugeContent                    { get; set; }
        public UIButton?                                EditInfoButton                          { get; set; }
        public UIButton?                                DeckListButton                          { get; set; }
        public UIButton?                                InheritanceButton                       { get; set; }
        public UIImage?                                 InheritanceButtonCover                  { get; set; }
        public UITextMeshProUGUI?                       FanCountText                            { get; set; }
        public ScheduleSelectionLeftBottomAreaViewModel? ScheduleSelectionLeftBottomAreaViewModel { get; set; }

        public static ScheduleSelectionLeftBottomAreaView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScheduleSelectionLeftBottomAreaView() { Pointer= p0 };

            value.UnitParameterContent                      = GetObject<UnitParameterContent>(new IntPtr(p + 0x020), ReversePrism.DataModels.UnitParameterContent.FromPointer); // 02466A1E8E88 0x20 UnitParameterContent        ( 00018670F700 ModelClassType UnitParameterContent UnitParameterContent UnitParameterContent Pointer )
            value.VitalityGaugeContent                      = GetObject<VitalityGauge>(new IntPtr(p + 0x028), ReversePrism.DataModels.VitalityGauge.FromPointer); // 02466A1E8EA8 0x28 VitalityGaugeContent        ( 00018652E260 ModelClassType VitalityGauge VitalityGauge VitalityGauge Pointer )
            value.EditInfoButton                            = GetObject<UIButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIButton.FromPointer); // 02466A1E8EC8 0x30 EditInfoButton              ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.DeckListButton                            = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 02466A1E8EE8 0x38 DeckListButton              ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.InheritanceButton                         = GetObject<UIButton>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIButton.FromPointer); // 02466A1E8F08 0x40 InheritanceButton           ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.InheritanceButtonCover                    = GetObject<UIImage>(new IntPtr(p + 0x048), ReversePrism.DataModels.UIImage.FromPointer); // 02466A1E8F28 0x48 InheritanceButtonCover      ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.FanCountText                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A1E8F48 0x50 FanCountText                ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ScheduleSelectionLeftBottomAreaViewModel  = GetObject<ScheduleSelectionLeftBottomAreaViewModel>(new IntPtr(p + 0x060), ReversePrism.DataModels.ScheduleSelectionLeftBottomAreaViewModel.FromPointer); // 02466A1E8F88 0x60 ScheduleSelectionLeftBottomAreaViewModel ( 0001866DA490 ModelClassType ScheduleSelectionLeftBottomAreaViewModel ScheduleSelectionLeftBottomAreaViewModel ScheduleSelectionLeftBottomAreaViewModel Pointer )

            return value;
        }
    }
}
