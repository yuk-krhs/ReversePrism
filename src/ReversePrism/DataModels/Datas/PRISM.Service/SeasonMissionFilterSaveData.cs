using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SortFilterSettings                       0001865300A0 ModelClassType SortFilterSettings SortFilterSettings SortFilterSettings Pointer
    public partial class SeasonMissionFilterSaveData
    {
        public SortFilterSettings?                      SortFilterSettings                      { get; set; }

        public static SeasonMissionFilterSaveData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SeasonMissionFilterSaveData();

            value.SortFilterSettings                        = GetObject<SortFilterSettings>(new IntPtr(p + 0x010), ReversePrism.DataModels.SortFilterSettings.FromPointer); // 027003A6B918 0x10 SortFilterSettings          ( 0001865300A0 ModelClassType SortFilterSettings SortFilterSettings SortFilterSettings Pointer )

            return value;
        }
    }
}
