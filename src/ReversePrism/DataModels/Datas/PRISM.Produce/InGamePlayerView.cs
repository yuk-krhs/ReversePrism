using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CommonView                               ModelClassType InGamePlayerCommonView InGamePlayerCommonView InGamePlayerCommonView Pointer
    // 028 HandContent                              ModelClassType HandContent HandContent HandContent Pointer
    // 030 IdolSkillContentListView                 ModelClassType IdolSkillContentListView IdolSkillContentListView IdolSkillContentListView Pointer
    // 038 SkillCutIn                               ModelClassType SkillCutIn SkillCutIn SkillCutIn Pointer
    // 040 TypeCounterContent                       ModelClassType TypeCounterContent TypeCounterContent TypeCounterContent Pointer
    // 048 PhaseContent                             ModelClassType PhaseContent PhaseContent PhaseContent Pointer
    // 050 ExclusionCardCountContent                ModelClassType ExclusionCardCountContent ExclusionCardCountContent ExclusionCardCountContent Pointer
    // 058 AssetTag                                 ModelPrimitiveType string string string String
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

            value.CommonView                                = GetObject<InGamePlayerCommonView>(new IntPtr(p + 0x020), ReversePrism.DataModels.InGamePlayerCommonView.FromPointer); // 0x20 CommonView                  ( ModelClassType InGamePlayerCommonView InGamePlayerCommonView InGamePlayerCommonView Pointer )
            value.HandContent                               = GetObject<HandContent>(new IntPtr(p + 0x028), ReversePrism.DataModels.HandContent.FromPointer); // 0x28 HandContent                 ( ModelClassType HandContent HandContent HandContent Pointer )
            value.IdolSkillContentListView                  = GetObject<IdolSkillContentListView>(new IntPtr(p + 0x030), ReversePrism.DataModels.IdolSkillContentListView.FromPointer); // 0x30 IdolSkillContentListView    ( ModelClassType IdolSkillContentListView IdolSkillContentListView IdolSkillContentListView Pointer )
            value.SkillCutIn                                = GetObject<SkillCutIn>(new IntPtr(p + 0x038), ReversePrism.DataModels.SkillCutIn.FromPointer); // 0x38 SkillCutIn                  ( ModelClassType SkillCutIn SkillCutIn SkillCutIn Pointer )
            value.TypeCounterContent                        = GetObject<TypeCounterContent>(new IntPtr(p + 0x040), ReversePrism.DataModels.TypeCounterContent.FromPointer); // 0x40 TypeCounterContent          ( ModelClassType TypeCounterContent TypeCounterContent TypeCounterContent Pointer )
            value.PhaseContent                              = GetObject<PhaseContent>(new IntPtr(p + 0x048), ReversePrism.DataModels.PhaseContent.FromPointer); // 0x48 PhaseContent                ( ModelClassType PhaseContent PhaseContent PhaseContent Pointer )
            value.ExclusionCardCountContent                 = GetObject<ExclusionCardCountContent>(new IntPtr(p + 0x050), ReversePrism.DataModels.ExclusionCardCountContent.FromPointer); // 0x50 ExclusionCardCountContent   ( ModelClassType ExclusionCardCountContent ExclusionCardCountContent ExclusionCardCountContent Pointer )
            value.AssetTag                                  = GetString(new IntPtr(p + 0x058)); // 0x58 AssetTag                    ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
