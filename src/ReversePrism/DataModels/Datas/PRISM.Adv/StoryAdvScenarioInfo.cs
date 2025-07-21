using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ScenarioId                               ModelClassType ScenarioID ScenarioID ScenarioID Pointer
    // 018 MainTitle                                ModelPrimitiveType string string string String
    // 020 SubTitle                                 ModelPrimitiveType string string string String
    // 028 Summary                                  ModelPrimitiveType string string string String
    // 030 AdvTextLogTitle                          ModelPrimitiveType string string string String
    // 038 AdvTitleViewModel                        ModelClassType IAdvTitleViewModel IAdvTitleViewModel IAdvTitleViewModel Pointer
    // 040 AdvSkipConfirmationPopupViewModel        ModelClassType AdvSkipConfirmationPopupViewModel AdvSkipConfirmationPopupViewModel AdvSkipConfirmationPopupViewModel Pointer
    // 048 AdvFavoriteStatus                        ModelClassType AdvFavoriteStatus AdvFavoriteStatus AdvFavoriteStatus Pointer
    // 050 StoryIdStatus                            ModelClassType IStoryIDStatus IStoryIDStatus IStoryIDStatus Pointer
    public partial class StoryAdvScenarioInfo : DataModel
    {
        public ScenarioID?                              ScenarioId                              { get; set; }
        public string                                   MainTitle                               { get; set; }
        public string                                   SubTitle                                { get; set; }
        public string                                   Summary                                 { get; set; }
        public string                                   AdvTextLogTitle                         { get; set; }
        public IAdvTitleViewModel?                      AdvTitleViewModel                       { get; set; }
        public AdvSkipConfirmationPopupViewModel?       AdvSkipConfirmationPopupViewModel       { get; set; }
        public AdvFavoriteStatus?                       AdvFavoriteStatus                       { get; set; }
        public IStoryIDStatus?                          StoryIdStatus                           { get; set; }

        public static StoryAdvScenarioInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StoryAdvScenarioInfo() { Pointer= p0 };

            value.ScenarioId                                = GetObject<ScenarioID>(new IntPtr(p + 0x010), ReversePrism.DataModels.ScenarioID.FromPointer); // 0x10 ScenarioId                  ( ModelClassType ScenarioID ScenarioID ScenarioID Pointer )
            value.MainTitle                                 = GetString(new IntPtr(p + 0x018)); // 0x18 MainTitle                   ( ModelPrimitiveType string string string String )
            value.SubTitle                                  = GetString(new IntPtr(p + 0x020)); // 0x20 SubTitle                    ( ModelPrimitiveType string string string String )
            value.Summary                                   = GetString(new IntPtr(p + 0x028)); // 0x28 Summary                     ( ModelPrimitiveType string string string String )
            value.AdvTextLogTitle                           = GetString(new IntPtr(p + 0x030)); // 0x30 AdvTextLogTitle             ( ModelPrimitiveType string string string String )
            value.AdvTitleViewModel                         = GetObject<IAdvTitleViewModel>(new IntPtr(p + 0x038), ReversePrism.DataModels.IAdvTitleViewModel.FromPointer); // 0x38 AdvTitleViewModel           ( ModelClassType IAdvTitleViewModel IAdvTitleViewModel IAdvTitleViewModel Pointer )
            value.AdvSkipConfirmationPopupViewModel         = GetObject<AdvSkipConfirmationPopupViewModel>(new IntPtr(p + 0x040), ReversePrism.DataModels.AdvSkipConfirmationPopupViewModel.FromPointer); // 0x40 AdvSkipConfirmationPopupViewModel ( ModelClassType AdvSkipConfirmationPopupViewModel AdvSkipConfirmationPopupViewModel AdvSkipConfirmationPopupViewModel Pointer )
            value.AdvFavoriteStatus                         = GetObject<AdvFavoriteStatus>(new IntPtr(p + 0x048), ReversePrism.DataModels.AdvFavoriteStatus.FromPointer); // 0x48 AdvFavoriteStatus           ( ModelClassType AdvFavoriteStatus AdvFavoriteStatus AdvFavoriteStatus Pointer )
            value.StoryIdStatus                             = GetObject<IStoryIDStatus>(new IntPtr(p + 0x050), ReversePrism.DataModels.IStoryIDStatus.FromPointer); // 0x50 StoryIdStatus               ( ModelClassType IStoryIDStatus IStoryIDStatus IStoryIDStatus Pointer )

            return value;
        }
    }
}
