using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Settings                                 0001865300A0 ModelClassType SortFilterSettings SortFilterSettings SortFilterSettings Pointer
    public partial class StorySortFilterSaveData
    {
        public SortFilterSettings?                      Settings                                { get; set; }

        public static StorySortFilterSaveData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StorySortFilterSaveData();

            value.Settings                                  = GetObject<SortFilterSettings>(new IntPtr(p + 0x020), ReversePrism.DataModels.SortFilterSettings.FromPointer); // 027003A7ED48 0x20 Settings                    ( 0001865300A0 ModelClassType SortFilterSettings SortFilterSettings SortFilterSettings Pointer )

            return value;
        }
    }
}
