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
    // 050 SelectedEventIds                         000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 058 SortFilterSettings                       0001865300A0 ModelClassType SortFilterSettings SortFilterSettings SortFilterSettings Pointer
    public partial class CharacterSelectPIPermanentData
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
        public SortFilterSettings?                      SortFilterSettings                      { get; set; }

        public static CharacterSelectPIPermanentData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CharacterSelectPIPermanentData();

            value.SortTargetIndex                           = GetInt32(new IntPtr(p + 0x010)); // 027003A6B520 0x10 SortTargetIndex             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.SortDirection                             = GetInt32(new IntPtr(p + 0x014)); // 027003A6B540 0x14 SortDirection               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.SelectedFavoriteMarkIds                   = GetInt32List(new IntPtr(p + 0x018)); // 027003A6B560 0x18 SelectedFavoriteMarkIds     ( 000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.SelectedIdolIds                           = GetInt32List(new IntPtr(p + 0x020)); // 027003A6B580 0x20 SelectedIdolIds             ( 000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.SelectedStars                             = GetInt32List(new IntPtr(p + 0x028)); // 027003A6B5A0 0x28 SelectedStars               ( 000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.SelectedAwakeningLvs                      = GetInt32List(new IntPtr(p + 0x030)); // 027003A6B5C0 0x30 SelectedAwakeningLvs        ( 000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.SelectedLiveSkillIds                      = GetInt32List(new IntPtr(p + 0x038)); // 027003A6B5E0 0x38 SelectedLiveSkillIds        ( 000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.AllSkillIcons                             = GetBool(new IntPtr(p + 0x040)); // 027003A6B600 0x40 AllSkillIcons               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.SelectedIdolSkillIconIds                  = GetInt32List(new IntPtr(p + 0x048)); // 027003A6B620 0x48 SelectedIdolSkillIconIds    ( 000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.SelectedEventIds                          = GetInt32List(new IntPtr(p + 0x050)); // 027003A6B640 0x50 SelectedEventIds            ( 000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.SortFilterSettings                        = GetObject<SortFilterSettings>(new IntPtr(p + 0x058), ReversePrism.DataModels.SortFilterSettings.FromPointer); // 027003A6B660 0x58 SortFilterSettings          ( 0001865300A0 ModelClassType SortFilterSettings SortFilterSettings SortFilterSettings Pointer )

            return value;
        }
    }
}
