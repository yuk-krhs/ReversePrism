using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BeforeLv                                 0001865F4260 ModelPrimitiveType int int int Int32
    // 014 AfterLv                                  0001865F4260 ModelPrimitiveType int int int Int32
    // 018 TrainingTicketsTotalExp                  0001865F8300 ModelPrimitiveType long long long Int64
    // 020 EarnedExpProgress                        000186666CB0 ModelPrimitiveType float float float Single
    // 024 CurrentExpProgress                       000186666CB0 ModelPrimitiveType float float float Single
    // 028 SkillEffects                             000185D10AD8 ModelClassListType List`1<SupportEffectContentViewModel> List`1<SupportEffectContentViewModel> List<SupportEffectContentViewModel> Pointer
    // 030 Icons                                    000185D02F78 ModelClassListType List`1<RequiredItemIconViewModel> List`1<RequiredItemIconViewModel> List<RequiredItemIconViewModel> Pointer
    // 038 RequiredMoney                            0001865F8300 ModelPrimitiveType long long long Int64
    // 040 Money                                    0001865F8300 ModelPrimitiveType long long long Int64
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

            value.BeforeLv                                  = GetInt32(new IntPtr(p + 0x010)); // 02466600CFE8 0x10 BeforeLv                    ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.AfterLv                                   = GetInt32(new IntPtr(p + 0x014)); // 02466600D008 0x14 AfterLv                     ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.TrainingTicketsTotalExp                   = GetInt64(new IntPtr(p + 0x018)); // 02466600D028 0x18 TrainingTicketsTotalExp     ( 0001865F8300 ModelPrimitiveType long long long Int64 )
            value.EarnedExpProgress                         = GetSingle(new IntPtr(p + 0x020)); // 02466600D048 0x20 EarnedExpProgress           ( 000186666CB0 ModelPrimitiveType float float float Single )
            value.CurrentExpProgress                        = GetSingle(new IntPtr(p + 0x024)); // 02466600D068 0x24 CurrentExpProgress          ( 000186666CB0 ModelPrimitiveType float float float Single )
            value.SkillEffects                              = GetObjectList<SupportEffectContentViewModel>(new IntPtr(p + 0x028), ReversePrism.DataModels.SupportEffectContentViewModel.FromPointer); // 02466600D088 0x28 SkillEffects                ( 000185D10AD8 ModelClassListType List`1<SupportEffectContentViewModel> List`1<SupportEffectContentViewModel> List<SupportEffectContentViewModel> Pointer )
            value.Icons                                     = GetObjectList<RequiredItemIconViewModel>(new IntPtr(p + 0x030), ReversePrism.DataModels.RequiredItemIconViewModel.FromPointer); // 02466600D0A8 0x30 Icons                       ( 000185D02F78 ModelClassListType List`1<RequiredItemIconViewModel> List`1<RequiredItemIconViewModel> List<RequiredItemIconViewModel> Pointer )
            value.RequiredMoney                             = GetInt64(new IntPtr(p + 0x038)); // 02466600D0C8 0x38 RequiredMoney               ( 0001865F8300 ModelPrimitiveType long long long Int64 )
            value.Money                                     = GetInt64(new IntPtr(p + 0x040)); // 02466600D0E8 0x40 Money                       ( 0001865F8300 ModelPrimitiveType long long long Int64 )

            return value;
        }
    }
}
