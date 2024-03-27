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
    // 028 SelectedLiveSkillIds                     000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 030 SortFilterSettings                       0001865300A0 ModelClassType SortFilterSettings SortFilterSettings SortFilterSettings Pointer
    public partial class IdolListFISortFilterPermanentData
    {
        public int                                      SortTargetIndex                         { get; set; }
        public int                                      SortDirection                           { get; set; }
        public List<int>?                               SelectedFavoriteMarkIds                 { get; set; }
        public List<int>?                               SelectedIdolIds                         { get; set; }
        public List<int>?                               SelectedLiveSkillIds                    { get; set; }
        public SortFilterSettings?                      SortFilterSettings                      { get; set; }

        public static IdolListFISortFilterPermanentData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolListFISortFilterPermanentData();

            value.SortTargetIndex                           = GetInt32(new IntPtr(p + 0x010)); // 027003A6CFF8 0x10 SortTargetIndex             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.SortDirection                             = GetInt32(new IntPtr(p + 0x014)); // 027003A6D018 0x14 SortDirection               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.SelectedFavoriteMarkIds                   = GetInt32List(new IntPtr(p + 0x018)); // 027003A6D038 0x18 SelectedFavoriteMarkIds     ( 000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.SelectedIdolIds                           = GetInt32List(new IntPtr(p + 0x020)); // 027003A6D058 0x20 SelectedIdolIds             ( 000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.SelectedLiveSkillIds                      = GetInt32List(new IntPtr(p + 0x028)); // 027003A6D078 0x28 SelectedLiveSkillIds        ( 000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.SortFilterSettings                        = GetObject<SortFilterSettings>(new IntPtr(p + 0x030), ReversePrism.DataModels.SortFilterSettings.FromPointer); // 027003A6D098 0x30 SortFilterSettings          ( 0001865300A0 ModelClassType SortFilterSettings SortFilterSettings SortFilterSettings Pointer )

            return value;
        }
    }
}
