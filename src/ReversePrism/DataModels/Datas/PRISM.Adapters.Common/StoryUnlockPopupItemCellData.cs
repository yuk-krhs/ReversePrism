using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 StoryCategoryText                        000186672F10 ModelPrimitiveType string string string String
    // 018 StoryTitleText                           000186672F10 ModelPrimitiveType string string string String
    // 020 StoryThumbnailAssetKey                   000186672F10 ModelPrimitiveType string string string String
    // 028 CategorySortOrder                        0001865F4260 ModelPrimitiveType int int int Int32
    // 02C StorySortOrder                           0001865F4260 ModelPrimitiveType int int int Int32
    public partial class StoryUnlockPopupItemCellData : DataModel
    {
        public string                                   StoryCategoryText                       { get; set; }
        public string                                   StoryTitleText                          { get; set; }
        public string                                   StoryThumbnailAssetKey                  { get; set; }
        public int                                      CategorySortOrder                       { get; set; }
        public int                                      StorySortOrder                          { get; set; }

        public static StoryUnlockPopupItemCellData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StoryUnlockPopupItemCellData() { Pointer= p0 };

            value.StoryCategoryText                         = GetString(new IntPtr(p + 0x010)); // 024666980568 0x10 StoryCategoryText           ( 000186672F10 ModelPrimitiveType string string string String )
            value.StoryTitleText                            = GetString(new IntPtr(p + 0x018)); // 024666980588 0x18 StoryTitleText              ( 000186672F10 ModelPrimitiveType string string string String )
            value.StoryThumbnailAssetKey                    = GetString(new IntPtr(p + 0x020)); // 0246669805A8 0x20 StoryThumbnailAssetKey      ( 000186672F10 ModelPrimitiveType string string string String )
            value.CategorySortOrder                         = GetInt32(new IntPtr(p + 0x028)); // 0246669805C8 0x28 CategorySortOrder           ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.StorySortOrder                            = GetInt32(new IntPtr(p + 0x02C)); // 0246669805E8 0x2C StorySortOrder              ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
