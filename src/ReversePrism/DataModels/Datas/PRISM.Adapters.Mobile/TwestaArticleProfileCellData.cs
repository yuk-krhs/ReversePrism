using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TwestaUserId                             0001865F4260 ModelPrimitiveType int int int Int32
    // 018 UserName                                 000186672F10 ModelPrimitiveType string string string String
    // 020 BodyText                                 000186672F10 ModelPrimitiveType string string string String
    // 028 IconAssetKey                             000186672F10 ModelPrimitiveType string string string String
    // 030 CommentCellDataList                      000185D17948 ModelClassListType IReadOnlyList`1<TwestaCommentCellData> IReadOnlyList`1<TwestaCommentCellData> List<TwestaCommentCellData> Pointer
    public partial class TwestaArticleProfileCellData : DataModel
    {
        public int                                      TwestaUserId                            { get; set; }
        public string                                   UserName                                { get; set; }
        public string                                   BodyText                                { get; set; }
        public string                                   IconAssetKey                            { get; set; }
        public List<TwestaCommentCellData>?             CommentCellDataList                     { get; set; }

        public static TwestaArticleProfileCellData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TwestaArticleProfileCellData() { Pointer= p0 };

            value.TwestaUserId                              = GetInt32(new IntPtr(p + 0x010)); // 02466694D3F0 0x10 TwestaUserId                ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.UserName                                  = GetString(new IntPtr(p + 0x018)); // 02466694D410 0x18 UserName                    ( 000186672F10 ModelPrimitiveType string string string String )
            value.BodyText                                  = GetString(new IntPtr(p + 0x020)); // 02466694D430 0x20 BodyText                    ( 000186672F10 ModelPrimitiveType string string string String )
            value.IconAssetKey                              = GetString(new IntPtr(p + 0x028)); // 02466694D450 0x28 IconAssetKey                ( 000186672F10 ModelPrimitiveType string string string String )
            value.CommentCellDataList                       = GetObjectList<TwestaCommentCellData>(new IntPtr(p + 0x030), ReversePrism.DataModels.TwestaCommentCellData.FromPointer); // 02466694D470 0x30 CommentCellDataList         ( 000185D17948 ModelClassListType IReadOnlyList`1<TwestaCommentCellData> IReadOnlyList`1<TwestaCommentCellData> List<TwestaCommentCellData> Pointer )

            return value;
        }
    }
}
