using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SortTargetIndex                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 014 SortDirection                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 SelectedFavoriteMarkIds                  000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 020 SelectedChara                            000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 028 SelectedGoodSchedule                     000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 030 SelectedRarity                           000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 038 SelectedDiamond                          000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 040 SelectedSkillSlot                        000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 048 IncludesNotYetAcquiredSkills             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 04C OnEffect1EffectFilterId                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 050 OnEffect1ScheduleFilterId                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 054 OnEffect2EffectFilterId                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 058 OnEffect2ScheduleFilterId                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 060 PotentialSupportSkill                    000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 068 SortFilterSettings                       0001865300A0 ModelClassType SortFilterSettings SortFilterSettings SortFilterSettings Pointer
    public partial class IdolListSCSortFilterPermanentData : DataModel
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

        public static IdolListSCSortFilterPermanentData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolListSCSortFilterPermanentData() { Pointer= p0 };

            value.SortTargetIndex                           = GetInt32(new IntPtr(p + 0x010)); // 0245A3A75718 0x10 SortTargetIndex             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.SortDirection                             = GetInt32(new IntPtr(p + 0x014)); // 0245A3A75738 0x14 SortDirection               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.SelectedFavoriteMarkIds                   = GetInt32List(new IntPtr(p + 0x018)); // 0245A3A75758 0x18 SelectedFavoriteMarkIds     ( 000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.SelectedChara                             = GetInt32List(new IntPtr(p + 0x020)); // 0245A3A75778 0x20 SelectedChara               ( 000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.SelectedGoodSchedule                      = GetInt32List(new IntPtr(p + 0x028)); // 0245A3A75798 0x28 SelectedGoodSchedule        ( 000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.SelectedRarity                            = GetInt32List(new IntPtr(p + 0x030)); // 0245A3A757B8 0x30 SelectedRarity              ( 000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.SelectedDiamond                           = GetInt32List(new IntPtr(p + 0x038)); // 0245A3A757D8 0x38 SelectedDiamond             ( 000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.SelectedSkillSlot                         = GetInt32List(new IntPtr(p + 0x040)); // 0245A3A757F8 0x40 SelectedSkillSlot           ( 000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.IncludesNotYetAcquiredSkills              = GetInt32(new IntPtr(p + 0x048)); // 0245A3A75818 0x48 IncludesNotYetAcquiredSkills ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.OnEffect1EffectFilterId                   = GetInt32(new IntPtr(p + 0x04C)); // 0245A3A75838 0x4C OnEffect1EffectFilterId     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.OnEffect1ScheduleFilterId                 = GetInt32(new IntPtr(p + 0x050)); // 0245A3A75858 0x50 OnEffect1ScheduleFilterId   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.OnEffect2EffectFilterId                   = GetInt32(new IntPtr(p + 0x054)); // 0245A3A75878 0x54 OnEffect2EffectFilterId     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.OnEffect2ScheduleFilterId                 = GetInt32(new IntPtr(p + 0x058)); // 0245A3A75898 0x58 OnEffect2ScheduleFilterId   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.PotentialSupportSkill                     = GetInt32List(new IntPtr(p + 0x060)); // 0245A3A758B8 0x60 PotentialSupportSkill       ( 000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.SortFilterSettings                        = GetObject<SortFilterSettings>(new IntPtr(p + 0x068), ReversePrism.DataModels.SortFilterSettings.FromPointer); // 0245A3A758D8 0x68 SortFilterSettings          ( 0001865300A0 ModelClassType SortFilterSettings SortFilterSettings SortFilterSettings Pointer )

            return value;
        }
    }
}
