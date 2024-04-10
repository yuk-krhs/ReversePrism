using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ThumbnailAssetKey                        000186672F10 ModelPrimitiveType string string string String
    // 018 ThumbnailId                              0001865F4260 ModelPrimitiveType int int int Int32
    // 01C IsThumbnailClickable                     0001865965D0 ModelPrimitiveType bool bool bool Bool
    public partial class ChainTalkCellThumbnailData : DataModel
    {
        public string                                   ThumbnailAssetKey                       { get; set; }
        public int                                      ThumbnailId                             { get; set; }
        public bool                                     IsThumbnailClickable                    { get; set; }

        public static ChainTalkCellThumbnailData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChainTalkCellThumbnailData() { Pointer= p0 };

            value.ThumbnailAssetKey                         = GetString(new IntPtr(p + 0x010)); // 0246668C7008 0x10 ThumbnailAssetKey           ( 000186672F10 ModelPrimitiveType string string string String )
            value.ThumbnailId                               = GetInt32(new IntPtr(p + 0x018)); // 0246668C7028 0x18 ThumbnailId                 ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.IsThumbnailClickable                      = GetBool(new IntPtr(p + 0x01C)); // 0246668C7048 0x1C IsThumbnailClickable        ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
