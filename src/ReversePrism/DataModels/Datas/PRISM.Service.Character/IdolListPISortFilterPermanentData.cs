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
    // 020 SelectedIdolIds                          000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 028 SelectedStars                            000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 030 SelectedAwakeningLvs                     000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 038 SelectedLiveSkillIds                     000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 040 AllSkillIcons                            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 048 SelectedIdolSkillIconIds                 000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 050 SortFilterSettings                       0001865300A0 ModelClassType SortFilterSettings SortFilterSettings SortFilterSettings Pointer
    public partial class IdolListPISortFilterPermanentData : DataModel
    {
        public int                                      SortTargetIndex                         { get; set; }
        public int                                      SortDirection                           { get; set; }
        public List<int>?                               SelectedFavoriteMarkIds                 { get; set; }
        public List<int>?                               SelectedIdolIds                         { get; set; }
        public List<int>?                               SelectedStars                           { get; set; }
        public List<int>?                               SelectedAwakeningLvs                    { get; set; }
        public List<int>?                               SelectedLiveSkillIds                    { get; set; }
        public bool                                     AllSkillIcons                           { get; set; }
        public List<int>?                               SelectedIdolSkillIconIds                { get; set; }
        public SortFilterSettings?                      SortFilterSettings                      { get; set; }

        public static IdolListPISortFilterPermanentData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolListPISortFilterPermanentData() { Pointer= p0 };

            value.SortTargetIndex                           = GetInt32(new IntPtr(p + 0x010)); // 0245A3A799E8 0x10 SortTargetIndex             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.SortDirection                             = GetInt32(new IntPtr(p + 0x014)); // 0245A3A79A08 0x14 SortDirection               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.SelectedFavoriteMarkIds                   = GetInt32List(new IntPtr(p + 0x018)); // 0245A3A79A28 0x18 SelectedFavoriteMarkIds     ( 000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.SelectedIdolIds                           = GetInt32List(new IntPtr(p + 0x020)); // 0245A3A79A48 0x20 SelectedIdolIds             ( 000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.SelectedStars                             = GetInt32List(new IntPtr(p + 0x028)); // 0245A3A79A68 0x28 SelectedStars               ( 000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.SelectedAwakeningLvs                      = GetInt32List(new IntPtr(p + 0x030)); // 0245A3A79A88 0x30 SelectedAwakeningLvs        ( 000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.SelectedLiveSkillIds                      = GetInt32List(new IntPtr(p + 0x038)); // 0245A3A79AA8 0x38 SelectedLiveSkillIds        ( 000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.AllSkillIcons                             = GetBool(new IntPtr(p + 0x040)); // 0245A3A79AC8 0x40 AllSkillIcons               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.SelectedIdolSkillIconIds                  = GetInt32List(new IntPtr(p + 0x048)); // 0245A3A79AE8 0x48 SelectedIdolSkillIconIds    ( 000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.SortFilterSettings                        = GetObject<SortFilterSettings>(new IntPtr(p + 0x050), ReversePrism.DataModels.SortFilterSettings.FromPointer); // 0245A3A79B08 0x50 SortFilterSettings          ( 0001865300A0 ModelClassType SortFilterSettings SortFilterSettings SortFilterSettings Pointer )

            return value;
        }
    }
}
