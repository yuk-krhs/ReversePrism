using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CommonView                               0001866D6A90 ModelClassType InGamePlayerCommonView InGamePlayerCommonView InGamePlayerCommonView Pointer
    // 028 HandContent                              0001866A7030 ModelClassType HandContent HandContent HandContent Pointer
    // 030 IdolSkillContentListView                 0001866B8EE0 ModelClassType IdolSkillContentListView IdolSkillContentListView IdolSkillContentListView Pointer
    // 038 SkillCutIn                               000186512910 ModelClassType SkillCutIn SkillCutIn SkillCutIn Pointer
    // 040 TypeCounterContent                       0001866D27D0 ModelClassType TypeCounterContent TypeCounterContent TypeCounterContent Pointer
    // 048 PhaseContent                             000186738D30 ModelClassType PhaseContent PhaseContent PhaseContent Pointer
    // 050 ExclusionCardCountContent                000186520400 ModelClassType ExclusionCardCountContent ExclusionCardCountContent ExclusionCardCountContent Pointer
    // 058 AssetTag                                 000186671910 ModelPrimitiveType string string string String
    public partial class InGamePlayerView : DataModel
    {
        public InGamePlayerCommonView?                  CommonView                              { get; set; }
        public HandContent?                             HandContent                             { get; set; }
        public IdolSkillContentListView?                IdolSkillContentListView                { get; set; }
        public SkillCutIn?                              SkillCutIn                              { get; set; }
        public TypeCounterContent?                      TypeCounterContent                      { get; set; }
        public PhaseContent?                            PhaseContent                            { get; set; }
        public ExclusionCardCountContent?               ExclusionCardCountContent               { get; set; }
        public string                                   AssetTag                                { get; set; }

        public static InGamePlayerView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InGamePlayerView() { Pointer= p0 };

            value.CommonView                                = GetObject<InGamePlayerCommonView>(new IntPtr(p + 0x020), ReversePrism.DataModels.InGamePlayerCommonView.FromPointer); // 024665A228A8 0x20 CommonView                  ( 0001866D6A90 ModelClassType InGamePlayerCommonView InGamePlayerCommonView InGamePlayerCommonView Pointer )
            value.HandContent                               = GetObject<HandContent>(new IntPtr(p + 0x028), ReversePrism.DataModels.HandContent.FromPointer); // 024665A228C8 0x28 HandContent                 ( 0001866A7030 ModelClassType HandContent HandContent HandContent Pointer )
            value.IdolSkillContentListView                  = GetObject<IdolSkillContentListView>(new IntPtr(p + 0x030), ReversePrism.DataModels.IdolSkillContentListView.FromPointer); // 024665A228E8 0x30 IdolSkillContentListView    ( 0001866B8EE0 ModelClassType IdolSkillContentListView IdolSkillContentListView IdolSkillContentListView Pointer )
            value.SkillCutIn                                = GetObject<SkillCutIn>(new IntPtr(p + 0x038), ReversePrism.DataModels.SkillCutIn.FromPointer); // 024665A22908 0x38 SkillCutIn                  ( 000186512910 ModelClassType SkillCutIn SkillCutIn SkillCutIn Pointer )
            value.TypeCounterContent                        = GetObject<TypeCounterContent>(new IntPtr(p + 0x040), ReversePrism.DataModels.TypeCounterContent.FromPointer); // 024665A22928 0x40 TypeCounterContent          ( 0001866D27D0 ModelClassType TypeCounterContent TypeCounterContent TypeCounterContent Pointer )
            value.PhaseContent                              = GetObject<PhaseContent>(new IntPtr(p + 0x048), ReversePrism.DataModels.PhaseContent.FromPointer); // 024665A22948 0x48 PhaseContent                ( 000186738D30 ModelClassType PhaseContent PhaseContent PhaseContent Pointer )
            value.ExclusionCardCountContent                 = GetObject<ExclusionCardCountContent>(new IntPtr(p + 0x050), ReversePrism.DataModels.ExclusionCardCountContent.FromPointer); // 024665A22968 0x50 ExclusionCardCountContent   ( 000186520400 ModelClassType ExclusionCardCountContent ExclusionCardCountContent ExclusionCardCountContent Pointer )
            value.AssetTag                                  = GetString(new IntPtr(p + 0x058)); // 024665A22988 0x58 AssetTag                    ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
