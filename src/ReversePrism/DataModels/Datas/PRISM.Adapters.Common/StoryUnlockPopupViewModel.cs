using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ItemCellDataList                         000185D16D18 ModelClassListType IReadOnlyList`1<StoryUnlockPopupItemCellData> IReadOnlyList`1<StoryUnlockPopupItemCellData> List<StoryUnlockPopupItemCellData> Pointer
    public partial class StoryUnlockPopupViewModel
    {
        public List<StoryUnlockPopupItemCellData>?      ItemCellDataList                        { get; set; }

        public static StoryUnlockPopupViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StoryUnlockPopupViewModel();

            value.ItemCellDataList                          = GetObjectList<StoryUnlockPopupItemCellData>(new IntPtr(p + 0x010), ReversePrism.DataModels.StoryUnlockPopupItemCellData.FromPointer); // 0270D6910518 0x10 ItemCellDataList            ( 000185D16D18 ModelClassListType IReadOnlyList`1<StoryUnlockPopupItemCellData> IReadOnlyList`1<StoryUnlockPopupItemCellData> List<StoryUnlockPopupItemCellData> Pointer )

            return value;
        }
    }
}
