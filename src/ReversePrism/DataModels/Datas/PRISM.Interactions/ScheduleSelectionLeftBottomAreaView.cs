using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 UnitParameterContent                     ModelClassType UnitParameterContent UnitParameterContent UnitParameterContent Pointer
    // 028 VitalityGaugeContent                     ModelClassType ScheduleVitalityGauge ScheduleVitalityGauge ScheduleVitalityGauge Pointer
    // 030 EditInfoButton                           ModelClassType UIButton UIButton UIButton Pointer
    // 038 DeckListButton                           ModelClassType UIButton UIButton UIButton Pointer
    // 040 InheritanceButton                        ModelClassType UIButton UIButton UIButton Pointer
    // 048 InheritanceButtonCover                   ModelClassType UIImage UIImage UIImage Pointer
    // 050 FanCountText                             ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 ScheduleSelectionLeftBottomAreaViewModel ModelClassType ScheduleSelectionLeftBottomAreaViewModel ScheduleSelectionLeftBottomAreaViewModel ScheduleSelectionLeftBottomAreaViewModel Pointer
    // 060 onRingIdolVoiceActivate                  Action`1<bool> IL2CPP_TYPE_GENERICINST
    public partial class ScheduleSelectionLeftBottomAreaView : DataModel
    {
        public UnitParameterContent?                    UnitParameterContent                    { get; set; }
        public ScheduleVitalityGauge?                   VitalityGaugeContent                    { get; set; }
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

            value.UnitParameterContent                      = GetObject<UnitParameterContent>(new IntPtr(p + 0x020), ReversePrism.DataModels.UnitParameterContent.FromPointer); // 0x20 UnitParameterContent        ( ModelClassType UnitParameterContent UnitParameterContent UnitParameterContent Pointer )
            value.VitalityGaugeContent                      = GetObject<ScheduleVitalityGauge>(new IntPtr(p + 0x028), ReversePrism.DataModels.ScheduleVitalityGauge.FromPointer); // 0x28 VitalityGaugeContent        ( ModelClassType ScheduleVitalityGauge ScheduleVitalityGauge ScheduleVitalityGauge Pointer )
            value.EditInfoButton                            = GetObject<UIButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIButton.FromPointer); // 0x30 EditInfoButton              ( ModelClassType UIButton UIButton UIButton Pointer )
            value.DeckListButton                            = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 0x38 DeckListButton              ( ModelClassType UIButton UIButton UIButton Pointer )
            value.InheritanceButton                         = GetObject<UIButton>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIButton.FromPointer); // 0x40 InheritanceButton           ( ModelClassType UIButton UIButton UIButton Pointer )
            value.InheritanceButtonCover                    = GetObject<UIImage>(new IntPtr(p + 0x048), ReversePrism.DataModels.UIImage.FromPointer); // 0x48 InheritanceButtonCover      ( ModelClassType UIImage UIImage UIImage Pointer )
            value.FanCountText                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x50 FanCountText                ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ScheduleSelectionLeftBottomAreaViewModel  = GetObject<ScheduleSelectionLeftBottomAreaViewModel>(new IntPtr(p + 0x058), ReversePrism.DataModels.ScheduleSelectionLeftBottomAreaViewModel.FromPointer); // 0x58 ScheduleSelectionLeftBottomAreaViewModel ( ModelClassType ScheduleSelectionLeftBottomAreaViewModel ScheduleSelectionLeftBottomAreaViewModel ScheduleSelectionLeftBottomAreaViewModel Pointer )

            return value;
        }
    }
}
