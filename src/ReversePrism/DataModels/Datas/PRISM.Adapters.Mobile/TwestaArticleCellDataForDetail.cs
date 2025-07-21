using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TwestaArticle                            ModelClassType ITwestaArticleStatus ITwestaArticleStatus ITwestaArticleStatus Pointer
    // 018 UserName                                 ModelPrimitiveType string string string String
    // 020 BodyText                                 ModelPrimitiveType string string string String
    // 028 ThumbnailImageKeys                       ModelPrimitiveListType IReadOnlyList`1<string> IReadOnlyList`1<string> List<string> Pointer
    // 030 IconAssetKey                             ModelPrimitiveType string string string String
    // 038 NeedsShowComments                        ModelPrimitiveType bool bool bool Bool
    // 040 CommentCellDataList                      ModelClassListType IReadOnlyList`1<TwestaCommentCellData> IReadOnlyList`1<TwestaCommentCellData> List<TwestaCommentCellData> Pointer
    public partial class TwestaArticleCellDataForDetail : DataModel
    {
        public ITwestaArticleStatus?                    TwestaArticle                           { get; set; }
        public string                                   UserName                                { get; set; }
        public string                                   BodyText                                { get; set; }
        public List<string>?                            ThumbnailImageKeys                      { get; set; }
        public string                                   IconAssetKey                            { get; set; }
        public bool                                     NeedsShowComments                       { get; set; }
        public List<TwestaCommentCellData>?             CommentCellDataList                     { get; set; }

        public static TwestaArticleCellDataForDetail? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TwestaArticleCellDataForDetail() { Pointer= p0 };

            value.TwestaArticle                             = GetObject<ITwestaArticleStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.ITwestaArticleStatus.FromPointer); // 0x10 TwestaArticle               ( ModelClassType ITwestaArticleStatus ITwestaArticleStatus ITwestaArticleStatus Pointer )
            value.UserName                                  = GetString(new IntPtr(p + 0x018)); // 0x18 UserName                    ( ModelPrimitiveType string string string String )
            value.BodyText                                  = GetString(new IntPtr(p + 0x020)); // 0x20 BodyText                    ( ModelPrimitiveType string string string String )
            value.ThumbnailImageKeys                        = GetStringList(new IntPtr(p + 0x028)); // 0x28 ThumbnailImageKeys          ( ModelPrimitiveListType IReadOnlyList`1<string> IReadOnlyList`1<string> List<string> Pointer )
            value.IconAssetKey                              = GetString(new IntPtr(p + 0x030)); // 0x30 IconAssetKey                ( ModelPrimitiveType string string string String )
            value.NeedsShowComments                         = GetBool(new IntPtr(p + 0x038)); // 0x38 NeedsShowComments           ( ModelPrimitiveType bool bool bool Bool )
            value.CommentCellDataList                       = GetObjectList<TwestaCommentCellData>(new IntPtr(p + 0x040), ReversePrism.DataModels.TwestaCommentCellData.FromPointer); // 0x40 CommentCellDataList         ( ModelClassListType IReadOnlyList`1<TwestaCommentCellData> IReadOnlyList`1<TwestaCommentCellData> List<TwestaCommentCellData> Pointer )

            return value;
        }
    }
}
