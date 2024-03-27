using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 SortFilterSettings                       0001865300A0 ModelClassType SortFilterSettings SortFilterSettings SortFilterSettings Pointer
    public partial class LiveUnitMemberChangeSaveData
    {
        public SortFilterSettings?                      SortFilterSettings                      { get; set; }

        public static LiveUnitMemberChangeSaveData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveUnitMemberChangeSaveData();

            value.SortFilterSettings                        = GetObject<SortFilterSettings>(new IntPtr(p + 0x020), ReversePrism.DataModels.SortFilterSettings.FromPointer); // 027003A73180 0x20 SortFilterSettings          ( 0001865300A0 ModelClassType SortFilterSettings SortFilterSettings SortFilterSettings Pointer )

            return value;
        }
    }
}
