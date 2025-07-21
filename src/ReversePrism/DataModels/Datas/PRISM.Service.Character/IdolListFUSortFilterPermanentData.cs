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
    // 018 SelectedUnitId                           ModelPrimitiveType int int int Int32
    // 020 SelectedFavoriteMarkIds                  ModelPrimitiveListType int[] int[] List<int> Pointer
    // 028 SortFilterSettings                       ModelClassType SortFilterSettings SortFilterSettings SortFilterSettings Pointer
    public partial class IdolListFUSortFilterPermanentData : DataModel
    {
        public int                                      SortTargetIndex                         { get; set; }
        public int                                      SortDirection                           { get; set; }
        public int                                      SelectedUnitId                          { get; set; }
        public List<int>?                               SelectedFavoriteMarkIds                 { get; set; }
        public SortFilterSettings?                      SortFilterSettings                      { get; set; }

        public static IdolListFUSortFilterPermanentData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolListFUSortFilterPermanentData() { Pointer= p0 };

            value.SortTargetIndex                           = GetInt32(new IntPtr(p + 0x010)); // 0x10 SortTargetIndex             ( ModelPrimitiveType int int int Int32 )
            value.SortDirection                             = GetInt32(new IntPtr(p + 0x014)); // 0x14 SortDirection               ( ModelPrimitiveType int int int Int32 )
            value.SelectedUnitId                            = GetInt32(new IntPtr(p + 0x018)); // 0x18 SelectedUnitId              ( ModelPrimitiveType int int int Int32 )
            value.SelectedFavoriteMarkIds                   = GetInt32List(new IntPtr(p + 0x020)); // 0x20 SelectedFavoriteMarkIds     ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.SortFilterSettings                        = GetObject<SortFilterSettings>(new IntPtr(p + 0x028), ReversePrism.DataModels.SortFilterSettings.FromPointer); // 0x28 SortFilterSettings          ( ModelClassType SortFilterSettings SortFilterSettings SortFilterSettings Pointer )

            return value;
        }
    }
}
