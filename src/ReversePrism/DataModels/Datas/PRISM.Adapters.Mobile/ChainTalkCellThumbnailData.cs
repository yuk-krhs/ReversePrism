using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ThumbnailImageKeys                       ModelPrimitiveListType IReadOnlyList`1<string> IReadOnlyList`1<string> List<string> Pointer
    // 018 IsThumbnailClickable                     ModelPrimitiveType bool bool bool Bool
    public partial class ChainTalkCellThumbnailData : DataModel
    {
        public List<string>?                            ThumbnailImageKeys                      { get; set; }
        public bool                                     IsThumbnailClickable                    { get; set; }

        public static ChainTalkCellThumbnailData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChainTalkCellThumbnailData() { Pointer= p0 };

            value.ThumbnailImageKeys                        = GetStringList(new IntPtr(p + 0x010)); // 0x10 ThumbnailImageKeys          ( ModelPrimitiveListType IReadOnlyList`1<string> IReadOnlyList`1<string> List<string> Pointer )
            value.IsThumbnailClickable                      = GetBool(new IntPtr(p + 0x018)); // 0x18 IsThumbnailClickable        ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
