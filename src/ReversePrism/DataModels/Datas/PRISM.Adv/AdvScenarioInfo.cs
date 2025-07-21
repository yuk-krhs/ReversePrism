using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MainTitle                                ModelPrimitiveType string string string String
    // 018 SubTitle                                 ModelPrimitiveType string string string String
    // 020 Summary                                  ModelPrimitiveType string string string String
    // 028 AdvTitleViewModel                        ModelClassType IAdvTitleViewModel IAdvTitleViewModel IAdvTitleViewModel Pointer
    // 030 AdvSkipConfirmationPopupViewModel        ModelClassType AdvSkipConfirmationPopupViewModel AdvSkipConfirmationPopupViewModel AdvSkipConfirmationPopupViewModel Pointer
    // 038 AdvTextLogTitle                          ModelPrimitiveType string string string String
    // 040 ScenarioId                               ModelClassType ScenarioID ScenarioID ScenarioID Pointer
    // 048 AdvFavoriteStatus                        ModelClassType AdvFavoriteStatus AdvFavoriteStatus AdvFavoriteStatus Pointer
    public partial class AdvScenarioInfo : DataModel
    {
        public string                                   MainTitle                               { get; set; }
        public string                                   SubTitle                                { get; set; }
        public string                                   Summary                                 { get; set; }
        public IAdvTitleViewModel?                      AdvTitleViewModel                       { get; set; }
        public AdvSkipConfirmationPopupViewModel?       AdvSkipConfirmationPopupViewModel       { get; set; }
        public string                                   AdvTextLogTitle                         { get; set; }
        public ScenarioID?                              ScenarioId                              { get; set; }
        public AdvFavoriteStatus?                       AdvFavoriteStatus                       { get; set; }

        public static AdvScenarioInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AdvScenarioInfo() { Pointer= p0 };

            value.MainTitle                                 = GetString(new IntPtr(p + 0x010)); // 0x10 MainTitle                   ( ModelPrimitiveType string string string String )
            value.SubTitle                                  = GetString(new IntPtr(p + 0x018)); // 0x18 SubTitle                    ( ModelPrimitiveType string string string String )
            value.Summary                                   = GetString(new IntPtr(p + 0x020)); // 0x20 Summary                     ( ModelPrimitiveType string string string String )
            value.AdvTitleViewModel                         = GetObject<IAdvTitleViewModel>(new IntPtr(p + 0x028), ReversePrism.DataModels.IAdvTitleViewModel.FromPointer); // 0x28 AdvTitleViewModel           ( ModelClassType IAdvTitleViewModel IAdvTitleViewModel IAdvTitleViewModel Pointer )
            value.AdvSkipConfirmationPopupViewModel         = GetObject<AdvSkipConfirmationPopupViewModel>(new IntPtr(p + 0x030), ReversePrism.DataModels.AdvSkipConfirmationPopupViewModel.FromPointer); // 0x30 AdvSkipConfirmationPopupViewModel ( ModelClassType AdvSkipConfirmationPopupViewModel AdvSkipConfirmationPopupViewModel AdvSkipConfirmationPopupViewModel Pointer )
            value.AdvTextLogTitle                           = GetString(new IntPtr(p + 0x038)); // 0x38 AdvTextLogTitle             ( ModelPrimitiveType string string string String )
            value.ScenarioId                                = GetObject<ScenarioID>(new IntPtr(p + 0x040), ReversePrism.DataModels.ScenarioID.FromPointer); // 0x40 ScenarioId                  ( ModelClassType ScenarioID ScenarioID ScenarioID Pointer )
            value.AdvFavoriteStatus                         = GetObject<AdvFavoriteStatus>(new IntPtr(p + 0x048), ReversePrism.DataModels.AdvFavoriteStatus.FromPointer); // 0x48 AdvFavoriteStatus           ( ModelClassType AdvFavoriteStatus AdvFavoriteStatus AdvFavoriteStatus Pointer )

            return value;
        }
    }
}
