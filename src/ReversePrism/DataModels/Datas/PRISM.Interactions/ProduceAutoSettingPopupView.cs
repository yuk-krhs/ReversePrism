using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 onClick                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 028 ScheduleSelectionTypeToggle              ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer
    // 030 SystemTypeToggle                         ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer
    // 038 RecoveryTimingTypeToggle                 ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer
    // 040 RankUpBalanceTypeToggle                  ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer
    // 048 CardDeleteTypeToggle                     ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer
    // 050 CardCostBalanceTypeToggle                ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer
    // 058 DeckPolicyTypeToggle                     ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer
    // 060 SelectSubSeasonToggle                    ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer
    // 068 SelectSubSeasonIdolToggle                ModelClassType ProduceAutoSettingSubSeasonIdolToggleGroup ProduceAutoSettingSubSeasonIdolToggleGroup ProduceAutoSettingSubSeasonIdolToggleGroup Pointer
    // 070 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class ProduceAutoSettingPopupView : DataModel
    {
        public ToggleButtonGroup?                       ScheduleSelectionTypeToggle             { get; set; }
        public ToggleButtonGroup?                       SystemTypeToggle                        { get; set; }
        public ToggleButtonGroup?                       RecoveryTimingTypeToggle                { get; set; }
        public ToggleButtonGroup?                       RankUpBalanceTypeToggle                 { get; set; }
        public ToggleButtonGroup?                       CardDeleteTypeToggle                    { get; set; }
        public ToggleButtonGroup?                       CardCostBalanceTypeToggle               { get; set; }
        public ToggleButtonGroup?                       DeckPolicyTypeToggle                    { get; set; }
        public ToggleButtonGroup?                       SelectSubSeasonToggle                   { get; set; }
        public ProduceAutoSettingSubSeasonIdolToggleGroup? SelectSubSeasonIdolToggle               { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static ProduceAutoSettingPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceAutoSettingPopupView() { Pointer= p0 };

            value.ScheduleSelectionTypeToggle               = GetObject<ToggleButtonGroup>(new IntPtr(p + 0x028), ReversePrism.DataModels.ToggleButtonGroup.FromPointer); // 0x28 ScheduleSelectionTypeToggle ( ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer )
            value.SystemTypeToggle                          = GetObject<ToggleButtonGroup>(new IntPtr(p + 0x030), ReversePrism.DataModels.ToggleButtonGroup.FromPointer); // 0x30 SystemTypeToggle            ( ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer )
            value.RecoveryTimingTypeToggle                  = GetObject<ToggleButtonGroup>(new IntPtr(p + 0x038), ReversePrism.DataModels.ToggleButtonGroup.FromPointer); // 0x38 RecoveryTimingTypeToggle    ( ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer )
            value.RankUpBalanceTypeToggle                   = GetObject<ToggleButtonGroup>(new IntPtr(p + 0x040), ReversePrism.DataModels.ToggleButtonGroup.FromPointer); // 0x40 RankUpBalanceTypeToggle     ( ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer )
            value.CardDeleteTypeToggle                      = GetObject<ToggleButtonGroup>(new IntPtr(p + 0x048), ReversePrism.DataModels.ToggleButtonGroup.FromPointer); // 0x48 CardDeleteTypeToggle        ( ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer )
            value.CardCostBalanceTypeToggle                 = GetObject<ToggleButtonGroup>(new IntPtr(p + 0x050), ReversePrism.DataModels.ToggleButtonGroup.FromPointer); // 0x50 CardCostBalanceTypeToggle   ( ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer )
            value.DeckPolicyTypeToggle                      = GetObject<ToggleButtonGroup>(new IntPtr(p + 0x058), ReversePrism.DataModels.ToggleButtonGroup.FromPointer); // 0x58 DeckPolicyTypeToggle        ( ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer )
            value.SelectSubSeasonToggle                     = GetObject<ToggleButtonGroup>(new IntPtr(p + 0x060), ReversePrism.DataModels.ToggleButtonGroup.FromPointer); // 0x60 SelectSubSeasonToggle       ( ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer )
            value.SelectSubSeasonIdolToggle                 = GetObject<ProduceAutoSettingSubSeasonIdolToggleGroup>(new IntPtr(p + 0x068), ReversePrism.DataModels.ProduceAutoSettingSubSeasonIdolToggleGroup.FromPointer); // 0x68 SelectSubSeasonIdolToggle   ( ModelClassType ProduceAutoSettingSubSeasonIdolToggleGroup ProduceAutoSettingSubSeasonIdolToggleGroup ProduceAutoSettingSubSeasonIdolToggleGroup Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x070), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x70 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
