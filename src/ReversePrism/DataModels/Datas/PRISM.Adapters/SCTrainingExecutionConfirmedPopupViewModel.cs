using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BeforeLv                                 ModelPrimitiveType int int int Int32
    // 014 AfterLv                                  ModelPrimitiveType int int int Int32
    // 018 TrainingTicketsTotalExp                  ModelPrimitiveType long long long Int64
    // 020 EarnedExpProgress                        ModelPrimitiveType float float float Single
    // 024 CurrentExpProgress                       ModelPrimitiveType float float float Single
    // 028 SkillEffects                             ModelClassListType List`1<SupportEffectContentViewModel> List`1<SupportEffectContentViewModel> List<SupportEffectContentViewModel> Pointer
    // 030 Icons                                    ModelClassListType List`1<RequiredItemIconViewModel> List`1<RequiredItemIconViewModel> List<RequiredItemIconViewModel> Pointer
    // 038 RequiredMoney                            ModelPrimitiveType long long long Int64
    // 040 Money                                    ModelPrimitiveType long long long Int64
    public partial class SCTrainingExecutionConfirmedPopupViewModel : DataModel
    {
        public int                                      BeforeLv                                { get; set; }
        public int                                      AfterLv                                 { get; set; }
        public long                                     TrainingTicketsTotalExp                 { get; set; }
        public float                                    EarnedExpProgress                       { get; set; }
        public float                                    CurrentExpProgress                      { get; set; }
        public List<SupportEffectContentViewModel>?     SkillEffects                            { get; set; }
        public List<RequiredItemIconViewModel>?         Icons                                   { get; set; }
        public long                                     RequiredMoney                           { get; set; }
        public long                                     Money                                   { get; set; }

        public static SCTrainingExecutionConfirmedPopupViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SCTrainingExecutionConfirmedPopupViewModel() { Pointer= p0 };

            value.BeforeLv                                  = GetInt32(new IntPtr(p + 0x010)); // 0x10 BeforeLv                    ( ModelPrimitiveType int int int Int32 )
            value.AfterLv                                   = GetInt32(new IntPtr(p + 0x014)); // 0x14 AfterLv                     ( ModelPrimitiveType int int int Int32 )
            value.TrainingTicketsTotalExp                   = GetInt64(new IntPtr(p + 0x018)); // 0x18 TrainingTicketsTotalExp     ( ModelPrimitiveType long long long Int64 )
            value.EarnedExpProgress                         = GetSingle(new IntPtr(p + 0x020)); // 0x20 EarnedExpProgress           ( ModelPrimitiveType float float float Single )
            value.CurrentExpProgress                        = GetSingle(new IntPtr(p + 0x024)); // 0x24 CurrentExpProgress          ( ModelPrimitiveType float float float Single )
            value.SkillEffects                              = GetObjectList<SupportEffectContentViewModel>(new IntPtr(p + 0x028), ReversePrism.DataModels.SupportEffectContentViewModel.FromPointer); // 0x28 SkillEffects                ( ModelClassListType List`1<SupportEffectContentViewModel> List`1<SupportEffectContentViewModel> List<SupportEffectContentViewModel> Pointer )
            value.Icons                                     = GetObjectList<RequiredItemIconViewModel>(new IntPtr(p + 0x030), ReversePrism.DataModels.RequiredItemIconViewModel.FromPointer); // 0x30 Icons                       ( ModelClassListType List`1<RequiredItemIconViewModel> List`1<RequiredItemIconViewModel> List<RequiredItemIconViewModel> Pointer )
            value.RequiredMoney                             = GetInt64(new IntPtr(p + 0x038)); // 0x38 RequiredMoney               ( ModelPrimitiveType long long long Int64 )
            value.Money                                     = GetInt64(new IntPtr(p + 0x040)); // 0x40 Money                       ( ModelPrimitiveType long long long Int64 )

            return value;
        }
    }
}
