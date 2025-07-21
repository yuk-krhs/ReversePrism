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
    // 020 SelectedIdolIds                          ModelPrimitiveListType int[] int[] List<int> Pointer
    // 028 SelectedStars                            ModelPrimitiveListType int[] int[] List<int> Pointer
    // 030 SelectedAwakeningLvs                     ModelPrimitiveListType int[] int[] List<int> Pointer
    // 038 SelectedLiveSkillIds                     ModelPrimitiveListType int[] int[] List<int> Pointer
    // 040 AllSkillIcons                            ModelPrimitiveType bool bool bool Bool
    // 048 SelectedIdolSkillIconIds                 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 050 SelectedEventIds                         ModelPrimitiveListType int[] int[] List<int> Pointer
    // 058 ProduceIdolTypeIds                       ModelPrimitiveListType int[] int[] List<int> Pointer
    // 060 SortFilterSettings                       ModelClassType SortFilterSettings SortFilterSettings SortFilterSettings Pointer
    public partial class CharacterSelectPIPermanentData : DataModel
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
        public List<int>?                               SelectedEventIds                        { get; set; }
        public List<int>?                               ProduceIdolTypeIds                      { get; set; }
        public SortFilterSettings?                      SortFilterSettings                      { get; set; }

        public static CharacterSelectPIPermanentData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CharacterSelectPIPermanentData() { Pointer= p0 };

            value.SortTargetIndex                           = GetInt32(new IntPtr(p + 0x010)); // 0x10 SortTargetIndex             ( ModelPrimitiveType int int int Int32 )
            value.SortDirection                             = GetInt32(new IntPtr(p + 0x014)); // 0x14 SortDirection               ( ModelPrimitiveType int int int Int32 )
            value.SelectedFavoriteMarkIds                   = GetInt32List(new IntPtr(p + 0x018)); // 0x18 SelectedFavoriteMarkIds     ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.SelectedIdolIds                           = GetInt32List(new IntPtr(p + 0x020)); // 0x20 SelectedIdolIds             ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.SelectedStars                             = GetInt32List(new IntPtr(p + 0x028)); // 0x28 SelectedStars               ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.SelectedAwakeningLvs                      = GetInt32List(new IntPtr(p + 0x030)); // 0x30 SelectedAwakeningLvs        ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.SelectedLiveSkillIds                      = GetInt32List(new IntPtr(p + 0x038)); // 0x38 SelectedLiveSkillIds        ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.AllSkillIcons                             = GetBool(new IntPtr(p + 0x040)); // 0x40 AllSkillIcons               ( ModelPrimitiveType bool bool bool Bool )
            value.SelectedIdolSkillIconIds                  = GetInt32List(new IntPtr(p + 0x048)); // 0x48 SelectedIdolSkillIconIds    ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.SelectedEventIds                          = GetInt32List(new IntPtr(p + 0x050)); // 0x50 SelectedEventIds            ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.ProduceIdolTypeIds                        = GetInt32List(new IntPtr(p + 0x058)); // 0x58 ProduceIdolTypeIds          ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.SortFilterSettings                        = GetObject<SortFilterSettings>(new IntPtr(p + 0x060), ReversePrism.DataModels.SortFilterSettings.FromPointer); // 0x60 SortFilterSettings          ( ModelClassType SortFilterSettings SortFilterSettings SortFilterSettings Pointer )

            return value;
        }
    }
}
