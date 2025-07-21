using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SortTargetIndex                          ModelPrimitiveType int int int Int32
    // 014 SortDirection                            ModelPrimitiveType int int int Int32
    // 018 SelectedFavoriteMarkIds                  ModelPrimitiveListType int[] int[] List<int> Pointer
    // 020 SelectedChara                            ModelPrimitiveListType int[] int[] List<int> Pointer
    // 028 SelectedGoodSchedule                     ModelPrimitiveListType int[] int[] List<int> Pointer
    // 030 SelectedRarity                           ModelPrimitiveListType int[] int[] List<int> Pointer
    // 038 SelectedDiamond                          ModelPrimitiveListType int[] int[] List<int> Pointer
    // 040 SelectedSkillSlot                        ModelPrimitiveListType int[] int[] List<int> Pointer
    // 048 IncludesNotYetAcquiredSkills             ModelPrimitiveType int int int Int32
    // 04C OnEffect1EffectFilterId                  ModelPrimitiveType int int int Int32
    // 050 OnEffect1ScheduleFilterId                ModelPrimitiveType int int int Int32
    // 054 OnEffect2EffectFilterId                  ModelPrimitiveType int int int Int32
    // 058 OnEffect2ScheduleFilterId                ModelPrimitiveType int int int Int32
    // 060 PotentialSupportSkill                    ModelPrimitiveListType int[] int[] List<int> Pointer
    // 068 SortFilterSettings                       ModelClassType SortFilterSettings SortFilterSettings SortFilterSettings Pointer
    public partial class CharacterSelectSCPermanentData : DataModel
    {
        public int                                      SortTargetIndex                         { get; set; }
        public int                                      SortDirection                           { get; set; }
        public List<int>?                               SelectedFavoriteMarkIds                 { get; set; }
        public List<int>?                               SelectedChara                           { get; set; }
        public List<int>?                               SelectedGoodSchedule                    { get; set; }
        public List<int>?                               SelectedRarity                          { get; set; }
        public List<int>?                               SelectedDiamond                         { get; set; }
        public List<int>?                               SelectedSkillSlot                       { get; set; }
        public int                                      IncludesNotYetAcquiredSkills            { get; set; }
        public int                                      OnEffect1EffectFilterId                 { get; set; }
        public int                                      OnEffect1ScheduleFilterId               { get; set; }
        public int                                      OnEffect2EffectFilterId                 { get; set; }
        public int                                      OnEffect2ScheduleFilterId               { get; set; }
        public List<int>?                               PotentialSupportSkill                   { get; set; }
        public SortFilterSettings?                      SortFilterSettings                      { get; set; }

        public static CharacterSelectSCPermanentData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CharacterSelectSCPermanentData() { Pointer= p0 };

            value.SortTargetIndex                           = GetInt32(new IntPtr(p + 0x010)); // 0x10 SortTargetIndex             ( ModelPrimitiveType int int int Int32 )
            value.SortDirection                             = GetInt32(new IntPtr(p + 0x014)); // 0x14 SortDirection               ( ModelPrimitiveType int int int Int32 )
            value.SelectedFavoriteMarkIds                   = GetInt32List(new IntPtr(p + 0x018)); // 0x18 SelectedFavoriteMarkIds     ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.SelectedChara                             = GetInt32List(new IntPtr(p + 0x020)); // 0x20 SelectedChara               ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.SelectedGoodSchedule                      = GetInt32List(new IntPtr(p + 0x028)); // 0x28 SelectedGoodSchedule        ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.SelectedRarity                            = GetInt32List(new IntPtr(p + 0x030)); // 0x30 SelectedRarity              ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.SelectedDiamond                           = GetInt32List(new IntPtr(p + 0x038)); // 0x38 SelectedDiamond             ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.SelectedSkillSlot                         = GetInt32List(new IntPtr(p + 0x040)); // 0x40 SelectedSkillSlot           ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.IncludesNotYetAcquiredSkills              = GetInt32(new IntPtr(p + 0x048)); // 0x48 IncludesNotYetAcquiredSkills ( ModelPrimitiveType int int int Int32 )
            value.OnEffect1EffectFilterId                   = GetInt32(new IntPtr(p + 0x04C)); // 0x4C OnEffect1EffectFilterId     ( ModelPrimitiveType int int int Int32 )
            value.OnEffect1ScheduleFilterId                 = GetInt32(new IntPtr(p + 0x050)); // 0x50 OnEffect1ScheduleFilterId   ( ModelPrimitiveType int int int Int32 )
            value.OnEffect2EffectFilterId                   = GetInt32(new IntPtr(p + 0x054)); // 0x54 OnEffect2EffectFilterId     ( ModelPrimitiveType int int int Int32 )
            value.OnEffect2ScheduleFilterId                 = GetInt32(new IntPtr(p + 0x058)); // 0x58 OnEffect2ScheduleFilterId   ( ModelPrimitiveType int int int Int32 )
            value.PotentialSupportSkill                     = GetInt32List(new IntPtr(p + 0x060)); // 0x60 PotentialSupportSkill       ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.SortFilterSettings                        = GetObject<SortFilterSettings>(new IntPtr(p + 0x068), ReversePrism.DataModels.SortFilterSettings.FromPointer); // 0x68 SortFilterSettings          ( ModelClassType SortFilterSettings SortFilterSettings SortFilterSettings Pointer )

            return value;
        }
    }
}
