using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 ArticleButton                            ModelClassType UIButton UIButton UIButton Pointer
    // 040 NoticeBadge                              ModelClassType GameObject GameObject GameObject Pointer
    // 048 FavoriteToggle                           ModelClassType TwestaFavoriteToggle TwestaFavoriteToggle TwestaFavoriteToggle Pointer
    // 050 UserNameText                             ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 ArticleBodyText                          ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 060 IconImage                                ModelClassType UIImage UIImage UIImage Pointer
    // 068 IconButton                               ModelClassType UIButton UIButton UIButton Pointer
    // 070 ThumbnailPos                             ModelClassType GameObject GameObject GameObject Pointer
    // 078 Thumbnail                                ModelClassType MobileThumbnail MobileThumbnail MobileThumbnail Pointer
    // 080 CommentCountPos                          ModelClassType GameObject GameObject GameObject Pointer
    // 088 CommentCountText                         ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 090 CommentPos                               ModelClassType Transform Transform Transform Pointer
    // 098 CommentCellPrefab                        ModelClassType TwestaCommentCell TwestaCommentCell TwestaCommentCell Pointer
    // 0A0 MaxCommentNum                            ModelPrimitiveType int int int Int32
    // 0A8 Separator                                ModelClassType GameObject GameObject GameObject Pointer
    // 0B0 ActiveCommentCellViewList                ModelClassListType List`1<TwestaCommentCell> List`1<TwestaCommentCell> List<TwestaCommentCell> Pointer
    // 0B8 commentCellViewPool                      ObjectPool`1<TwestaCommentCell> IL2CPP_TYPE_GENERICINST
    public partial class TwestaArticleCell : DataModel
    {
        public UIButton?                                ArticleButton                           { get; set; }
        public GameObject?                              NoticeBadge                             { get; set; }
        public TwestaFavoriteToggle?                    FavoriteToggle                          { get; set; }
        public UITextMeshProUGUI?                       UserNameText                            { get; set; }
        public UITextMeshProUGUI?                       ArticleBodyText                         { get; set; }
        public UIImage?                                 IconImage                               { get; set; }
        public UIButton?                                IconButton                              { get; set; }
        public GameObject?                              ThumbnailPos                            { get; set; }
        public MobileThumbnail?                         Thumbnail                               { get; set; }
        public GameObject?                              CommentCountPos                         { get; set; }
        public UITextMeshProUGUI?                       CommentCountText                        { get; set; }
        public Transform?                               CommentPos                              { get; set; }
        public TwestaCommentCell?                       CommentCellPrefab                       { get; set; }
        public int                                      MaxCommentNum                           { get; set; }
        public GameObject?                              Separator                               { get; set; }
        public List<TwestaCommentCell>?                 ActiveCommentCellViewList               { get; set; }

        public static TwestaArticleCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TwestaArticleCell() { Pointer= p0 };

            value.ArticleButton                             = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 0x38 ArticleButton               ( ModelClassType UIButton UIButton UIButton Pointer )
            value.NoticeBadge                               = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0x40 NoticeBadge                 ( ModelClassType GameObject GameObject GameObject Pointer )
            value.FavoriteToggle                            = GetObject<TwestaFavoriteToggle>(new IntPtr(p + 0x048), ReversePrism.DataModels.TwestaFavoriteToggle.FromPointer); // 0x48 FavoriteToggle              ( ModelClassType TwestaFavoriteToggle TwestaFavoriteToggle TwestaFavoriteToggle Pointer )
            value.UserNameText                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x50 UserNameText                ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ArticleBodyText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x58 ArticleBodyText             ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.IconImage                                 = GetObject<UIImage>(new IntPtr(p + 0x060), ReversePrism.DataModels.UIImage.FromPointer); // 0x60 IconImage                   ( ModelClassType UIImage UIImage UIImage Pointer )
            value.IconButton                                = GetObject<UIButton>(new IntPtr(p + 0x068), ReversePrism.DataModels.UIButton.FromPointer); // 0x68 IconButton                  ( ModelClassType UIButton UIButton UIButton Pointer )
            value.ThumbnailPos                              = GetObject<GameObject>(new IntPtr(p + 0x070), ReversePrism.DataModels.GameObject.FromPointer); // 0x70 ThumbnailPos                ( ModelClassType GameObject GameObject GameObject Pointer )
            value.Thumbnail                                 = GetObject<MobileThumbnail>(new IntPtr(p + 0x078), ReversePrism.DataModels.MobileThumbnail.FromPointer); // 0x78 Thumbnail                   ( ModelClassType MobileThumbnail MobileThumbnail MobileThumbnail Pointer )
            value.CommentCountPos                           = GetObject<GameObject>(new IntPtr(p + 0x080), ReversePrism.DataModels.GameObject.FromPointer); // 0x80 CommentCountPos             ( ModelClassType GameObject GameObject GameObject Pointer )
            value.CommentCountText                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x088), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x88 CommentCountText            ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CommentPos                                = GetObject<Transform>(new IntPtr(p + 0x090), ReversePrism.DataModels.Transform.FromPointer); // 0x90 CommentPos                  ( ModelClassType Transform Transform Transform Pointer )
            value.CommentCellPrefab                         = GetObject<TwestaCommentCell>(new IntPtr(p + 0x098), ReversePrism.DataModels.TwestaCommentCell.FromPointer); // 0x98 CommentCellPrefab           ( ModelClassType TwestaCommentCell TwestaCommentCell TwestaCommentCell Pointer )
            value.MaxCommentNum                             = GetInt32(new IntPtr(p + 0x0A0)); // 0xA0 MaxCommentNum               ( ModelPrimitiveType int int int Int32 )
            value.Separator                                 = GetObject<GameObject>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.GameObject.FromPointer); // 0xA8 Separator                   ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ActiveCommentCellViewList                 = GetObjectList<TwestaCommentCell>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.TwestaCommentCell.FromPointer); // 0xB0 ActiveCommentCellViewList   ( ModelClassListType List`1<TwestaCommentCell> List`1<TwestaCommentCell> List<TwestaCommentCell> Pointer )

            return value;
        }
    }
}
