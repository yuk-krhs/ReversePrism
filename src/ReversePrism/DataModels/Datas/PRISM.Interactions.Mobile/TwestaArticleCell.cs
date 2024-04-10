using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 ArticleButton                            0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 040 NoticeBadge                              0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 048 FavoriteToggle                           0001866CB3F0 ModelClassType TwestaFavoriteToggle TwestaFavoriteToggle TwestaFavoriteToggle Pointer
    // 050 UserNameText                             0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 ArticleBodyText                          0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 060 IconImage                                0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 068 IconButton                               0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 070 ThumbnailPos                             0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 078 ThumbnailImage                           0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 080 ThumbnailButton                          0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 088 CommentCountPos                          0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 090 CommentCountText                         0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 098 CommentPos                               0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 0A0 CommentCellPrefab                        0001866C88C0 ModelClassType TwestaCommentCell TwestaCommentCell TwestaCommentCell Pointer
    // 0A8 MaxCommentNum                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 0B0 Separator                                0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 0B8 ActiveCommentCellViewList                000185D16B98 ModelClassListType List`1<TwestaCommentCell> List`1<TwestaCommentCell> List<TwestaCommentCell> Pointer
    // 0C0 commentCellViewPool                      ObjectPool`1<TwestaCommentCell> IL2CPP_TYPE_GENERICINST
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
        public UIImage?                                 ThumbnailImage                          { get; set; }
        public UIButton?                                ThumbnailButton                         { get; set; }
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

            value.ArticleButton                             = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 02466B1BFB40 0x38 ArticleButton               ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.NoticeBadge                               = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 02466B1BFB60 0x40 NoticeBadge                 ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.FavoriteToggle                            = GetObject<TwestaFavoriteToggle>(new IntPtr(p + 0x048), ReversePrism.DataModels.TwestaFavoriteToggle.FromPointer); // 02466B1BFB80 0x48 FavoriteToggle              ( 0001866CB3F0 ModelClassType TwestaFavoriteToggle TwestaFavoriteToggle TwestaFavoriteToggle Pointer )
            value.UserNameText                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B1BFBA0 0x50 UserNameText                ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ArticleBodyText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B1BFBC0 0x58 ArticleBodyText             ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.IconImage                                 = GetObject<UIImage>(new IntPtr(p + 0x060), ReversePrism.DataModels.UIImage.FromPointer); // 02466B1BFBE0 0x60 IconImage                   ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.IconButton                                = GetObject<UIButton>(new IntPtr(p + 0x068), ReversePrism.DataModels.UIButton.FromPointer); // 02466B1BFC00 0x68 IconButton                  ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.ThumbnailPos                              = GetObject<GameObject>(new IntPtr(p + 0x070), ReversePrism.DataModels.GameObject.FromPointer); // 02466B1BFC20 0x70 ThumbnailPos                ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ThumbnailImage                            = GetObject<UIImage>(new IntPtr(p + 0x078), ReversePrism.DataModels.UIImage.FromPointer); // 02466B1BFC40 0x78 ThumbnailImage              ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.ThumbnailButton                           = GetObject<UIButton>(new IntPtr(p + 0x080), ReversePrism.DataModels.UIButton.FromPointer); // 02466B1BFC60 0x80 ThumbnailButton             ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.CommentCountPos                           = GetObject<GameObject>(new IntPtr(p + 0x088), ReversePrism.DataModels.GameObject.FromPointer); // 02466B1BFC80 0x88 CommentCountPos             ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.CommentCountText                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x090), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B1BFCA0 0x90 CommentCountText            ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CommentPos                                = GetObject<Transform>(new IntPtr(p + 0x098), ReversePrism.DataModels.Transform.FromPointer); // 02466B1BFCC0 0x98 CommentPos                  ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.CommentCellPrefab                         = GetObject<TwestaCommentCell>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.TwestaCommentCell.FromPointer); // 02466B1BFCE0 0xA0 CommentCellPrefab           ( 0001866C88C0 ModelClassType TwestaCommentCell TwestaCommentCell TwestaCommentCell Pointer )
            value.MaxCommentNum                             = GetInt32(new IntPtr(p + 0x0A8)); // 02466B1BFD00 0xA8 MaxCommentNum               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Separator                                 = GetObject<GameObject>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.GameObject.FromPointer); // 02466B1BFD20 0xB0 Separator                   ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ActiveCommentCellViewList                 = GetObjectList<TwestaCommentCell>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.TwestaCommentCell.FromPointer); // 02466B1BFD40 0xB8 ActiveCommentCellViewList   ( 000185D16B98 ModelClassListType List`1<TwestaCommentCell> List`1<TwestaCommentCell> List<TwestaCommentCell> Pointer )

            return value;
        }
    }
}
