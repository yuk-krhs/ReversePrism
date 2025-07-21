using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 NoteDesignInput                          ModelClassType NumericInput NumericInput NumericInput Pointer
    // 048 NoteEffectDesignInput                    ModelClassType NumericInput NumericInput NumericInput Pointer
    // 050 ShowNoteEffectToggle                     ModelClassType ToggleSwitch ToggleSwitch ToggleSwitch Pointer
    // 058 ShowLifeGaugeToggle                      ModelClassType ToggleSwitch ToggleSwitch ToggleSwitch Pointer
    // 060 ShowLifeWarningToggle                    ModelClassType ToggleSwitch ToggleSwitch ToggleSwitch Pointer
    // 068 ShowScoreGaugeToggle                     ModelClassType ToggleSwitch ToggleSwitch ToggleSwitch Pointer
    // 070 ShowShinyEffectToggle                    ModelClassType ToggleSwitch ToggleSwitch ToggleSwitch Pointer
    // 078 ComboShowTypeToggleGroup                 ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer
    // 080 ShowGreatComboEffectToggle               ModelClassType ToggleSwitch ToggleSwitch ToggleSwitch Pointer
    // 088 ShowPerfectComboEffectToggle             ModelClassType ToggleSwitch ToggleSwitch ToggleSwitch Pointer
    // 090 ShowShinyComboEffectToggle               ModelClassType ToggleSwitch ToggleSwitch ToggleSwitch Pointer
    // 098 JudgementShowTypeToggleGroup             ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer
    // 0A0 JudgementShowPositionTypeToggleGroup     ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer
    // 0A8 ShowJudgementLagTypeToggle               ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer
    // 0B0 ShowPerfectJudgementLagToggle            ModelClassType ToggleSwitch ToggleSwitch ToggleSwitch Pointer
    // 0B8 ShowSkillCutinToggle                     ModelClassType ToggleSwitch ToggleSwitch ToggleSwitch Pointer
    // 0C0 ShowSkillEffectToggle                    ModelClassType ToggleSwitch ToggleSwitch ToggleSwitch Pointer
    // 0C8 ShowKeyBeamToggle                        ModelClassType ToggleSwitch ToggleSwitch ToggleSwitch Pointer
    // 0D0 LaneCutRateInput                         ModelClassType NumericInput NumericInput NumericInput Pointer
    // 0D8 IsMirrorToggle                           ModelClassType ToggleSwitch ToggleSwitch ToggleSwitch Pointer
    public partial class LiveSettingDetailTabView : DataModel
    {
        public NumericInput?                            NoteDesignInput                         { get; set; }
        public NumericInput?                            NoteEffectDesignInput                   { get; set; }
        public ToggleSwitch?                            ShowNoteEffectToggle                    { get; set; }
        public ToggleSwitch?                            ShowLifeGaugeToggle                     { get; set; }
        public ToggleSwitch?                            ShowLifeWarningToggle                   { get; set; }
        public ToggleSwitch?                            ShowScoreGaugeToggle                    { get; set; }
        public ToggleSwitch?                            ShowShinyEffectToggle                   { get; set; }
        public ToggleButtonGroup?                       ComboShowTypeToggleGroup                { get; set; }
        public ToggleSwitch?                            ShowGreatComboEffectToggle              { get; set; }
        public ToggleSwitch?                            ShowPerfectComboEffectToggle            { get; set; }
        public ToggleSwitch?                            ShowShinyComboEffectToggle              { get; set; }
        public ToggleButtonGroup?                       JudgementShowTypeToggleGroup            { get; set; }
        public ToggleButtonGroup?                       JudgementShowPositionTypeToggleGroup    { get; set; }
        public ToggleButtonGroup?                       ShowJudgementLagTypeToggle              { get; set; }
        public ToggleSwitch?                            ShowPerfectJudgementLagToggle           { get; set; }
        public ToggleSwitch?                            ShowSkillCutinToggle                    { get; set; }
        public ToggleSwitch?                            ShowSkillEffectToggle                   { get; set; }
        public ToggleSwitch?                            ShowKeyBeamToggle                       { get; set; }
        public NumericInput?                            LaneCutRateInput                        { get; set; }
        public ToggleSwitch?                            IsMirrorToggle                          { get; set; }

        public static LiveSettingDetailTabView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveSettingDetailTabView() { Pointer= p0 };

            value.NoteDesignInput                           = GetObject<NumericInput>(new IntPtr(p + 0x040), ReversePrism.DataModels.NumericInput.FromPointer); // 0x40 NoteDesignInput             ( ModelClassType NumericInput NumericInput NumericInput Pointer )
            value.NoteEffectDesignInput                     = GetObject<NumericInput>(new IntPtr(p + 0x048), ReversePrism.DataModels.NumericInput.FromPointer); // 0x48 NoteEffectDesignInput       ( ModelClassType NumericInput NumericInput NumericInput Pointer )
            value.ShowNoteEffectToggle                      = GetObject<ToggleSwitch>(new IntPtr(p + 0x050), ReversePrism.DataModels.ToggleSwitch.FromPointer); // 0x50 ShowNoteEffectToggle        ( ModelClassType ToggleSwitch ToggleSwitch ToggleSwitch Pointer )
            value.ShowLifeGaugeToggle                       = GetObject<ToggleSwitch>(new IntPtr(p + 0x058), ReversePrism.DataModels.ToggleSwitch.FromPointer); // 0x58 ShowLifeGaugeToggle         ( ModelClassType ToggleSwitch ToggleSwitch ToggleSwitch Pointer )
            value.ShowLifeWarningToggle                     = GetObject<ToggleSwitch>(new IntPtr(p + 0x060), ReversePrism.DataModels.ToggleSwitch.FromPointer); // 0x60 ShowLifeWarningToggle       ( ModelClassType ToggleSwitch ToggleSwitch ToggleSwitch Pointer )
            value.ShowScoreGaugeToggle                      = GetObject<ToggleSwitch>(new IntPtr(p + 0x068), ReversePrism.DataModels.ToggleSwitch.FromPointer); // 0x68 ShowScoreGaugeToggle        ( ModelClassType ToggleSwitch ToggleSwitch ToggleSwitch Pointer )
            value.ShowShinyEffectToggle                     = GetObject<ToggleSwitch>(new IntPtr(p + 0x070), ReversePrism.DataModels.ToggleSwitch.FromPointer); // 0x70 ShowShinyEffectToggle       ( ModelClassType ToggleSwitch ToggleSwitch ToggleSwitch Pointer )
            value.ComboShowTypeToggleGroup                  = GetObject<ToggleButtonGroup>(new IntPtr(p + 0x078), ReversePrism.DataModels.ToggleButtonGroup.FromPointer); // 0x78 ComboShowTypeToggleGroup    ( ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer )
            value.ShowGreatComboEffectToggle                = GetObject<ToggleSwitch>(new IntPtr(p + 0x080), ReversePrism.DataModels.ToggleSwitch.FromPointer); // 0x80 ShowGreatComboEffectToggle  ( ModelClassType ToggleSwitch ToggleSwitch ToggleSwitch Pointer )
            value.ShowPerfectComboEffectToggle              = GetObject<ToggleSwitch>(new IntPtr(p + 0x088), ReversePrism.DataModels.ToggleSwitch.FromPointer); // 0x88 ShowPerfectComboEffectToggle ( ModelClassType ToggleSwitch ToggleSwitch ToggleSwitch Pointer )
            value.ShowShinyComboEffectToggle                = GetObject<ToggleSwitch>(new IntPtr(p + 0x090), ReversePrism.DataModels.ToggleSwitch.FromPointer); // 0x90 ShowShinyComboEffectToggle  ( ModelClassType ToggleSwitch ToggleSwitch ToggleSwitch Pointer )
            value.JudgementShowTypeToggleGroup              = GetObject<ToggleButtonGroup>(new IntPtr(p + 0x098), ReversePrism.DataModels.ToggleButtonGroup.FromPointer); // 0x98 JudgementShowTypeToggleGroup ( ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer )
            value.JudgementShowPositionTypeToggleGroup      = GetObject<ToggleButtonGroup>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.ToggleButtonGroup.FromPointer); // 0xA0 JudgementShowPositionTypeToggleGroup ( ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer )
            value.ShowJudgementLagTypeToggle                = GetObject<ToggleButtonGroup>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.ToggleButtonGroup.FromPointer); // 0xA8 ShowJudgementLagTypeToggle  ( ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer )
            value.ShowPerfectJudgementLagToggle             = GetObject<ToggleSwitch>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.ToggleSwitch.FromPointer); // 0xB0 ShowPerfectJudgementLagToggle ( ModelClassType ToggleSwitch ToggleSwitch ToggleSwitch Pointer )
            value.ShowSkillCutinToggle                      = GetObject<ToggleSwitch>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.ToggleSwitch.FromPointer); // 0xB8 ShowSkillCutinToggle        ( ModelClassType ToggleSwitch ToggleSwitch ToggleSwitch Pointer )
            value.ShowSkillEffectToggle                     = GetObject<ToggleSwitch>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.ToggleSwitch.FromPointer); // 0xC0 ShowSkillEffectToggle       ( ModelClassType ToggleSwitch ToggleSwitch ToggleSwitch Pointer )
            value.ShowKeyBeamToggle                         = GetObject<ToggleSwitch>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.ToggleSwitch.FromPointer); // 0xC8 ShowKeyBeamToggle           ( ModelClassType ToggleSwitch ToggleSwitch ToggleSwitch Pointer )
            value.LaneCutRateInput                          = GetObject<NumericInput>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.NumericInput.FromPointer); // 0xD0 LaneCutRateInput            ( ModelClassType NumericInput NumericInput NumericInput Pointer )
            value.IsMirrorToggle                            = GetObject<ToggleSwitch>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.ToggleSwitch.FromPointer); // 0xD8 IsMirrorToggle              ( ModelClassType ToggleSwitch ToggleSwitch ToggleSwitch Pointer )

            return value;
        }
    }
}
