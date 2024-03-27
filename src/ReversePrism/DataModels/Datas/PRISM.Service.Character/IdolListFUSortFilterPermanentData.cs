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
    // 018 SelectedUnitId                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 SelectedFavoriteMarkIds                  000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 028 SortFilterSettings                       0001865300A0 ModelClassType SortFilterSettings SortFilterSettings SortFilterSettings Pointer
    public partial class IdolListFUSortFilterPermanentData
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
            var value   = new IdolListFUSortFilterPermanentData();

            value.SortTargetIndex                           = GetInt32(new IntPtr(p + 0x010)); // 027003A6C9E8 0x10 SortTargetIndex             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.SortDirection                             = GetInt32(new IntPtr(p + 0x014)); // 027003A6CA08 0x14 SortDirection               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.SelectedUnitId                            = GetInt32(new IntPtr(p + 0x018)); // 027003A6CA28 0x18 SelectedUnitId              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.SelectedFavoriteMarkIds                   = GetInt32List(new IntPtr(p + 0x020)); // 027003A6CA48 0x20 SelectedFavoriteMarkIds     ( 000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.SortFilterSettings                        = GetObject<SortFilterSettings>(new IntPtr(p + 0x028), ReversePrism.DataModels.SortFilterSettings.FromPointer); // 027003A6CA68 0x28 SortFilterSettings          ( 0001865300A0 ModelClassType SortFilterSettings SortFilterSettings SortFilterSettings Pointer )

            return value;
        }
    }
}
