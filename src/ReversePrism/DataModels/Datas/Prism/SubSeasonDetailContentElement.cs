using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 EventTitleText                           0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 028 EventText                                0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 030 StateTitleText                           0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 038 StateText                                0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 040 TimingTitleText                          0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 048 TimingText                               0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 050 ConditionTitleText                       0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 058 NoConditionText                          0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 060 ParameterContent                         0001865D6F30 ModelClassType SubSeasonParameterConditionContent SubSeasonParameterConditionContent SubSeasonParameterConditionContent Pointer
    // 068 FanContant                               0001865D3700 ModelClassType SubSeasonDearnessAndFanConditionContent SubSeasonDearnessAndFanConditionContent SubSeasonDearnessAndFanConditionContent Pointer
    // 070 DearnessContent                          0001865D3700 ModelClassType SubSeasonDearnessAndFanConditionContent SubSeasonDearnessAndFanConditionContent SubSeasonDearnessAndFanConditionContent Pointer
    public partial class SubSeasonDetailContentElement
    {
        public TextMeshProUGUI?                         EventTitleText                          { get; set; }
        public TextMeshProUGUI?                         EventText                               { get; set; }
        public TextMeshProUGUI?                         StateTitleText                          { get; set; }
        public TextMeshProUGUI?                         StateText                               { get; set; }
        public TextMeshProUGUI?                         TimingTitleText                         { get; set; }
        public TextMeshProUGUI?                         TimingText                              { get; set; }
        public TextMeshProUGUI?                         ConditionTitleText                      { get; set; }
        public TextMeshProUGUI?                         NoConditionText                         { get; set; }
        public SubSeasonParameterConditionContent?      ParameterContent                        { get; set; }
        public SubSeasonDearnessAndFanConditionContent? FanContant                              { get; set; }
        public SubSeasonDearnessAndFanConditionContent? DearnessContent                         { get; set; }

        public static SubSeasonDetailContentElement? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SubSeasonDetailContentElement();

            value.EventTitleText                            = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0270D4D21430 0x20 EventTitleText              ( 0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.EventText                                 = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0270D4D21450 0x28 EventText                   ( 0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.StateTitleText                            = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0270D4D21470 0x30 StateTitleText              ( 0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.StateText                                 = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0270D4D21490 0x38 StateText                   ( 0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.TimingTitleText                           = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0270D4D214B0 0x40 TimingTitleText             ( 0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.TimingText                                = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0270D4D214D0 0x48 TimingText                  ( 0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.ConditionTitleText                        = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0270D4D214F0 0x50 ConditionTitleText          ( 0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.NoConditionText                           = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0270D4D21510 0x58 NoConditionText             ( 0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.ParameterContent                          = GetObject<SubSeasonParameterConditionContent>(new IntPtr(p + 0x060), ReversePrism.DataModels.SubSeasonParameterConditionContent.FromPointer); // 0270D4D21530 0x60 ParameterContent            ( 0001865D6F30 ModelClassType SubSeasonParameterConditionContent SubSeasonParameterConditionContent SubSeasonParameterConditionContent Pointer )
            value.FanContant                                = GetObject<SubSeasonDearnessAndFanConditionContent>(new IntPtr(p + 0x068), ReversePrism.DataModels.SubSeasonDearnessAndFanConditionContent.FromPointer); // 0270D4D21550 0x68 FanContant                  ( 0001865D3700 ModelClassType SubSeasonDearnessAndFanConditionContent SubSeasonDearnessAndFanConditionContent SubSeasonDearnessAndFanConditionContent Pointer )
            value.DearnessContent                           = GetObject<SubSeasonDearnessAndFanConditionContent>(new IntPtr(p + 0x070), ReversePrism.DataModels.SubSeasonDearnessAndFanConditionContent.FromPointer); // 0270D4D21570 0x70 DearnessContent             ( 0001865D3700 ModelClassType SubSeasonDearnessAndFanConditionContent SubSeasonDearnessAndFanConditionContent SubSeasonDearnessAndFanConditionContent Pointer )

            return value;
        }
    }
}
