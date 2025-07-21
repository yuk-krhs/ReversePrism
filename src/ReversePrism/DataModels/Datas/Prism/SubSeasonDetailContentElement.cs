using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 EventTitleText                           ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 028 EventText                                ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 030 StateTitleText                           ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 038 StateText                                ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 040 TimingTitleText                          ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 048 TimingText                               ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 050 ConditionTitleText                       ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 058 NoConditionText                          ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 060 ParameterContent                         ModelClassType SubSeasonParameterConditionContent SubSeasonParameterConditionContent SubSeasonParameterConditionContent Pointer
    // 068 FanContant                               ModelClassType SubSeasonDearnessAndFanConditionContent SubSeasonDearnessAndFanConditionContent SubSeasonDearnessAndFanConditionContent Pointer
    // 070 DearnessContent                          ModelClassType SubSeasonDearnessAndFanConditionContent SubSeasonDearnessAndFanConditionContent SubSeasonDearnessAndFanConditionContent Pointer
    public partial class SubSeasonDetailContentElement : DataModel
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
            var value   = new SubSeasonDetailContentElement() { Pointer= p0 };

            value.EventTitleText                            = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0x20 EventTitleText              ( ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.EventText                                 = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0x28 EventText                   ( ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.StateTitleText                            = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0x30 StateTitleText              ( ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.StateText                                 = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0x38 StateText                   ( ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.TimingTitleText                           = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0x40 TimingTitleText             ( ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.TimingText                                = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0x48 TimingText                  ( ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.ConditionTitleText                        = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0x50 ConditionTitleText          ( ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.NoConditionText                           = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0x58 NoConditionText             ( ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.ParameterContent                          = GetObject<SubSeasonParameterConditionContent>(new IntPtr(p + 0x060), ReversePrism.DataModels.SubSeasonParameterConditionContent.FromPointer); // 0x60 ParameterContent            ( ModelClassType SubSeasonParameterConditionContent SubSeasonParameterConditionContent SubSeasonParameterConditionContent Pointer )
            value.FanContant                                = GetObject<SubSeasonDearnessAndFanConditionContent>(new IntPtr(p + 0x068), ReversePrism.DataModels.SubSeasonDearnessAndFanConditionContent.FromPointer); // 0x68 FanContant                  ( ModelClassType SubSeasonDearnessAndFanConditionContent SubSeasonDearnessAndFanConditionContent SubSeasonDearnessAndFanConditionContent Pointer )
            value.DearnessContent                           = GetObject<SubSeasonDearnessAndFanConditionContent>(new IntPtr(p + 0x070), ReversePrism.DataModels.SubSeasonDearnessAndFanConditionContent.FromPointer); // 0x70 DearnessContent             ( ModelClassType SubSeasonDearnessAndFanConditionContent SubSeasonDearnessAndFanConditionContent SubSeasonDearnessAndFanConditionContent Pointer )

            return value;
        }
    }
}
