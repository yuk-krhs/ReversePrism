using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TwestaArticle                            000186684100 ModelClassType ITwestaArticleStatus ITwestaArticleStatus ITwestaArticleStatus Pointer
    // 018 ThumbnailId                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 UserName                                 000186671910 ModelPrimitiveType string string string String
    // 028 BodyText                                 000186671910 ModelPrimitiveType string string string String
    // 030 HasThumbnail                             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 038 ThumbnailAssetKey                        000186671910 ModelPrimitiveType string string string String
    // 040 IconAssetKey                             000186671910 ModelPrimitiveType string string string String
    // 048 NeedsShowCommentCount                    000186594D10 ModelPrimitiveType bool bool bool Bool
    // 050 CommentCellDataList                      000185D178B8 ModelClassListType IReadOnlyList`1<TwestaCommentCellData> IReadOnlyList`1<TwestaCommentCellData> List<TwestaCommentCellData> Pointer
    public partial class TwestaArticleCellDataForFavorite
    {
        public ITwestaArticleStatus?                    TwestaArticle                           { get; set; }
        public int                                      ThumbnailId                             { get; set; }
        public string                                   UserName                                { get; set; }
        public string                                   BodyText                                { get; set; }
        public bool                                     HasThumbnail                            { get; set; }
        public string                                   ThumbnailAssetKey                       { get; set; }
        public string                                   IconAssetKey                            { get; set; }
        public bool                                     NeedsShowCommentCount                   { get; set; }
        public List<TwestaCommentCellData>?             CommentCellDataList                     { get; set; }

        public static TwestaArticleCellDataForFavorite? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TwestaArticleCellDataForFavorite();

            value.TwestaArticle                             = GetObject<ITwestaArticleStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.ITwestaArticleStatus.FromPointer); // 0270D68DA100 0x10 TwestaArticle               ( 000186684100 ModelClassType ITwestaArticleStatus ITwestaArticleStatus ITwestaArticleStatus Pointer )
            value.ThumbnailId                               = GetInt32(new IntPtr(p + 0x018)); // 0270D68DA120 0x18 ThumbnailId                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.UserName                                  = GetString(new IntPtr(p + 0x020)); // 0270D68DA140 0x20 UserName                    ( 000186671910 ModelPrimitiveType string string string String )
            value.BodyText                                  = GetString(new IntPtr(p + 0x028)); // 0270D68DA160 0x28 BodyText                    ( 000186671910 ModelPrimitiveType string string string String )
            value.HasThumbnail                              = GetBool(new IntPtr(p + 0x030)); // 0270D68DA180 0x30 HasThumbnail                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ThumbnailAssetKey                         = GetString(new IntPtr(p + 0x038)); // 0270D68DA1A0 0x38 ThumbnailAssetKey           ( 000186671910 ModelPrimitiveType string string string String )
            value.IconAssetKey                              = GetString(new IntPtr(p + 0x040)); // 0270D68DA1C0 0x40 IconAssetKey                ( 000186671910 ModelPrimitiveType string string string String )
            value.NeedsShowCommentCount                     = GetBool(new IntPtr(p + 0x048)); // 0270D68DA1E0 0x48 NeedsShowCommentCount       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.CommentCellDataList                       = GetObjectList<TwestaCommentCellData>(new IntPtr(p + 0x050), ReversePrism.DataModels.TwestaCommentCellData.FromPointer); // 0270D68DA200 0x50 CommentCellDataList         ( 000185D178B8 ModelClassListType IReadOnlyList`1<TwestaCommentCellData> IReadOnlyList`1<TwestaCommentCellData> List<TwestaCommentCellData> Pointer )

            return value;
        }
    }
}
