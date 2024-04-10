using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 DescriptionUnderOffsetHeight             float IL2CPP_TYPE_R4
    // 038 LargeCategoryRoot                        000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 040 LargeCategoryText                        0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 ShowCategoryButton                       0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 050 LargeCategoryImage                       0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 058 LargeCategorySprites                     000185CA4898 ModelClassListType Sprite[] Sprite[] List<Sprite> Pointer
    // 060 SmallCategoryRoot                        000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 068 ShowDescriptionButton                    0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 070 ExpandSprite                             0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 078 ExpandOpenSprite                         00018666B610 ModelClassType Sprite Sprite Sprite Pointer
    // 080 ExpandCloseSprite                        00018666B610 ModelClassType Sprite Sprite Sprite Pointer
    // 088 SmallCategoryText                        0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 090 DescriptionRoot                          000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 098 DescriptionText                          0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    public partial class GameHelpListCategoryCellView : DataModel
    {
        public RectTransform?                           LargeCategoryRoot                       { get; set; }
        public UITextMeshProUGUI?                       LargeCategoryText                       { get; set; }
        public UIButton?                                ShowCategoryButton                      { get; set; }
        public UIImage?                                 LargeCategoryImage                      { get; set; }
        public List<Sprite>?                            LargeCategorySprites                    { get; set; }
        public RectTransform?                           SmallCategoryRoot                       { get; set; }
        public UIButton?                                ShowDescriptionButton                   { get; set; }
        public UIImage?                                 ExpandSprite                            { get; set; }
        public Sprite?                                  ExpandOpenSprite                        { get; set; }
        public Sprite?                                  ExpandCloseSprite                       { get; set; }
        public UITextMeshProUGUI?                       SmallCategoryText                       { get; set; }
        public RectTransform?                           DescriptionRoot                         { get; set; }
        public UITextMeshProUGUI?                       DescriptionText                         { get; set; }

        public static GameHelpListCategoryCellView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GameHelpListCategoryCellView() { Pointer= p0 };

            value.LargeCategoryRoot                         = GetObject<RectTransform>(new IntPtr(p + 0x038), ReversePrism.DataModels.RectTransform.FromPointer); // 02466B6279B0 0x38 LargeCategoryRoot           ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.LargeCategoryText                         = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B6279D0 0x40 LargeCategoryText           ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ShowCategoryButton                        = GetObject<UIButton>(new IntPtr(p + 0x048), ReversePrism.DataModels.UIButton.FromPointer); // 02466B6279F0 0x48 ShowCategoryButton          ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.LargeCategoryImage                        = GetObject<UIImage>(new IntPtr(p + 0x050), ReversePrism.DataModels.UIImage.FromPointer); // 02466B627A10 0x50 LargeCategoryImage          ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.LargeCategorySprites                      = GetObjectList<Sprite>(new IntPtr(p + 0x058), ReversePrism.DataModels.Sprite.FromPointer); // 02466B627A30 0x58 LargeCategorySprites        ( 000185CA4898 ModelClassListType Sprite[] Sprite[] List<Sprite> Pointer )
            value.SmallCategoryRoot                         = GetObject<RectTransform>(new IntPtr(p + 0x060), ReversePrism.DataModels.RectTransform.FromPointer); // 02466B627A50 0x60 SmallCategoryRoot           ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.ShowDescriptionButton                     = GetObject<UIButton>(new IntPtr(p + 0x068), ReversePrism.DataModels.UIButton.FromPointer); // 02466B627A70 0x68 ShowDescriptionButton       ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.ExpandSprite                              = GetObject<UIImage>(new IntPtr(p + 0x070), ReversePrism.DataModels.UIImage.FromPointer); // 02466B627A90 0x70 ExpandSprite                ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.ExpandOpenSprite                          = GetObject<Sprite>(new IntPtr(p + 0x078), ReversePrism.DataModels.Sprite.FromPointer); // 02466B627AB0 0x78 ExpandOpenSprite            ( 00018666B610 ModelClassType Sprite Sprite Sprite Pointer )
            value.ExpandCloseSprite                         = GetObject<Sprite>(new IntPtr(p + 0x080), ReversePrism.DataModels.Sprite.FromPointer); // 02466B627AD0 0x80 ExpandCloseSprite           ( 00018666B610 ModelClassType Sprite Sprite Sprite Pointer )
            value.SmallCategoryText                         = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x088), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B627AF0 0x88 SmallCategoryText           ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.DescriptionRoot                           = GetObject<RectTransform>(new IntPtr(p + 0x090), ReversePrism.DataModels.RectTransform.FromPointer); // 02466B627B10 0x90 DescriptionRoot             ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.DescriptionText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x098), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B627B30 0x98 DescriptionText             ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
