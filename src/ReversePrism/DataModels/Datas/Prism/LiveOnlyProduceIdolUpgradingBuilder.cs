using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TitleView                                ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer
    // 028 UiCharacterView                          ModelClassType ProduceIdolUpgradingUICharacterView ProduceIdolUpgradingUICharacterView ProduceIdolUpgradingUICharacterView Pointer
    // 030 View                                     ModelClassType LiveOnlyProduceIdolUpgradingView LiveOnlyProduceIdolUpgradingView LiveOnlyProduceIdolUpgradingView Pointer
    // 038 StatusView                               ModelClassType ProduceIdolStatusView ProduceIdolStatusView ProduceIdolStatusView Pointer
    // 040 TrainingView                             ModelClassType ProduceIdolTrainingView ProduceIdolTrainingView ProduceIdolTrainingView Pointer
    // 048 LiveSkillView                            ModelClassType ProduceIdolLiveSkillView ProduceIdolLiveSkillView ProduceIdolLiveSkillView Pointer
    public partial class LiveOnlyProduceIdolUpgradingBuilder : DataModel
    {
        public CommonTitleView?                         TitleView                               { get; set; }
        public ProduceIdolUpgradingUICharacterView?     UiCharacterView                         { get; set; }
        public LiveOnlyProduceIdolUpgradingView?        View                                    { get; set; }
        public ProduceIdolStatusView?                   StatusView                              { get; set; }
        public ProduceIdolTrainingView?                 TrainingView                            { get; set; }
        public ProduceIdolLiveSkillView?                LiveSkillView                           { get; set; }

        public static LiveOnlyProduceIdolUpgradingBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveOnlyProduceIdolUpgradingBuilder() { Pointer= p0 };

            value.TitleView                                 = GetObject<CommonTitleView>(new IntPtr(p + 0x020), ReversePrism.DataModels.CommonTitleView.FromPointer); // 0x20 TitleView                   ( ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer )
            value.UiCharacterView                           = GetObject<ProduceIdolUpgradingUICharacterView>(new IntPtr(p + 0x028), ReversePrism.DataModels.ProduceIdolUpgradingUICharacterView.FromPointer); // 0x28 UiCharacterView             ( ModelClassType ProduceIdolUpgradingUICharacterView ProduceIdolUpgradingUICharacterView ProduceIdolUpgradingUICharacterView Pointer )
            value.View                                      = GetObject<LiveOnlyProduceIdolUpgradingView>(new IntPtr(p + 0x030), ReversePrism.DataModels.LiveOnlyProduceIdolUpgradingView.FromPointer); // 0x30 View                        ( ModelClassType LiveOnlyProduceIdolUpgradingView LiveOnlyProduceIdolUpgradingView LiveOnlyProduceIdolUpgradingView Pointer )
            value.StatusView                                = GetObject<ProduceIdolStatusView>(new IntPtr(p + 0x038), ReversePrism.DataModels.ProduceIdolStatusView.FromPointer); // 0x38 StatusView                  ( ModelClassType ProduceIdolStatusView ProduceIdolStatusView ProduceIdolStatusView Pointer )
            value.TrainingView                              = GetObject<ProduceIdolTrainingView>(new IntPtr(p + 0x040), ReversePrism.DataModels.ProduceIdolTrainingView.FromPointer); // 0x40 TrainingView                ( ModelClassType ProduceIdolTrainingView ProduceIdolTrainingView ProduceIdolTrainingView Pointer )
            value.LiveSkillView                             = GetObject<ProduceIdolLiveSkillView>(new IntPtr(p + 0x048), ReversePrism.DataModels.ProduceIdolLiveSkillView.FromPointer); // 0x48 LiveSkillView               ( ModelClassType ProduceIdolLiveSkillView ProduceIdolLiveSkillView ProduceIdolLiveSkillView Pointer )

            return value;
        }
    }
}
