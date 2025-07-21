using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 SortFilterSettings                       ModelClassType SortFilterSettings SortFilterSettings SortFilterSettings Pointer
    public partial class MissionFilterSaveData : DataModel
    {
        public SortFilterSettings?                      SortFilterSettings                      { get; set; }

        public static MissionFilterSaveData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MissionFilterSaveData() { Pointer= p0 };

            value.SortFilterSettings                        = GetObject<SortFilterSettings>(new IntPtr(p + 0x020), ReversePrism.DataModels.SortFilterSettings.FromPointer); // 0x20 SortFilterSettings          ( ModelClassType SortFilterSettings SortFilterSettings SortFilterSettings Pointer )

            return value;
        }
    }
}
