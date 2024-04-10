using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 onClick                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 028 ScheduleSelectionTypeToggle              000186684350 ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer
    // 030 SystemTypeToggle                         000186684350 ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer
    // 038 RecoveryTimingTypeToggle                 000186684350 ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer
    // 040 RankUpBalanceTypeToggle                  000186684350 ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer
    // 048 CardDeleteTypeToggle                     000186684350 ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer
    // 050 CardCostBalanceTypeToggle                000186684350 ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer
    // 058 DeckPolicyTypeToggle                     000186684350 ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer
    // 060 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class ProduceAutoSettingPopupView : DataModel
    {
        public ToggleButtonGroup?                       ScheduleSelectionTypeToggle             { get; set; }
        public ToggleButtonGroup?                       SystemTypeToggle                        { get; set; }
        public ToggleButtonGroup?                       RecoveryTimingTypeToggle                { get; set; }
        public ToggleButtonGroup?                       RankUpBalanceTypeToggle                 { get; set; }
        public ToggleButtonGroup?                       CardDeleteTypeToggle                    { get; set; }
        public ToggleButtonGroup?                       CardCostBalanceTypeToggle               { get; set; }
        public ToggleButtonGroup?                       DeckPolicyTypeToggle                    { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static ProduceAutoSettingPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceAutoSettingPopupView() { Pointer= p0 };

            value.ScheduleSelectionTypeToggle               = GetObject<ToggleButtonGroup>(new IntPtr(p + 0x028), ReversePrism.DataModels.ToggleButtonGroup.FromPointer); // 02466A1217A0 0x28 ScheduleSelectionTypeToggle ( 000186684350 ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer )
            value.SystemTypeToggle                          = GetObject<ToggleButtonGroup>(new IntPtr(p + 0x030), ReversePrism.DataModels.ToggleButtonGroup.FromPointer); // 02466A1217C0 0x30 SystemTypeToggle            ( 000186684350 ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer )
            value.RecoveryTimingTypeToggle                  = GetObject<ToggleButtonGroup>(new IntPtr(p + 0x038), ReversePrism.DataModels.ToggleButtonGroup.FromPointer); // 02466A1217E0 0x38 RecoveryTimingTypeToggle    ( 000186684350 ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer )
            value.RankUpBalanceTypeToggle                   = GetObject<ToggleButtonGroup>(new IntPtr(p + 0x040), ReversePrism.DataModels.ToggleButtonGroup.FromPointer); // 02466A121800 0x40 RankUpBalanceTypeToggle     ( 000186684350 ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer )
            value.CardDeleteTypeToggle                      = GetObject<ToggleButtonGroup>(new IntPtr(p + 0x048), ReversePrism.DataModels.ToggleButtonGroup.FromPointer); // 02466A121820 0x48 CardDeleteTypeToggle        ( 000186684350 ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer )
            value.CardCostBalanceTypeToggle                 = GetObject<ToggleButtonGroup>(new IntPtr(p + 0x050), ReversePrism.DataModels.ToggleButtonGroup.FromPointer); // 02466A121840 0x50 CardCostBalanceTypeToggle   ( 000186684350 ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer )
            value.DeckPolicyTypeToggle                      = GetObject<ToggleButtonGroup>(new IntPtr(p + 0x058), ReversePrism.DataModels.ToggleButtonGroup.FromPointer); // 02466A121860 0x58 DeckPolicyTypeToggle        ( 000186684350 ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x060), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 02466A121880 0x60 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
