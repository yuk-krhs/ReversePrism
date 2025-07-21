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
    // 028 SelectedLiveSkillIds                     ModelPrimitiveListType int[] int[] List<int> Pointer
    // 030 SortFilterSettings                       ModelClassType SortFilterSettings SortFilterSettings SortFilterSettings Pointer
    public partial class IdolListFISortFilterPermanentData : DataModel
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
            var value   = new IdolListFISortFilterPermanentData() { Pointer= p0 };

            value.SortTargetIndex                           = GetInt32(new IntPtr(p + 0x010)); // 0x10 SortTargetIndex             ( ModelPrimitiveType int int int Int32 )
            value.SortDirection                             = GetInt32(new IntPtr(p + 0x014)); // 0x14 SortDirection               ( ModelPrimitiveType int int int Int32 )
            value.SelectedFavoriteMarkIds                   = GetInt32List(new IntPtr(p + 0x018)); // 0x18 SelectedFavoriteMarkIds     ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.SelectedIdolIds                           = GetInt32List(new IntPtr(p + 0x020)); // 0x20 SelectedIdolIds             ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.SelectedLiveSkillIds                      = GetInt32List(new IntPtr(p + 0x028)); // 0x28 SelectedLiveSkillIds        ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.SortFilterSettings                        = GetObject<SortFilterSettings>(new IntPtr(p + 0x030), ReversePrism.DataModels.SortFilterSettings.FromPointer); // 0x30 SortFilterSettings          ( ModelClassType SortFilterSettings SortFilterSettings SortFilterSettings Pointer )

            return value;
        }
    }
}
