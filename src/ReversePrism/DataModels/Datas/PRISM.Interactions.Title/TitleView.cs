using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 AppVersionText                           ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 IdText                                   ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 MenuButton                               ModelClassType UIButton UIButton UIButton Pointer
    // 038 WholeScreenButton                        ModelClassType UIButton UIButton UIButton Pointer
    // 040 MoviePlayer                              ModelClassType MoviePlayer MoviePlayer MoviePlayer Pointer
    // 048 BackgroundImage                          ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 050 Popup                                    ModelClassType TitlePopupReference TitlePopupReference TitlePopupReference Pointer
    // 058 LoadProgress                             ModelClassType TitleLoadProgressBarView TitleLoadProgressBarView TitleLoadProgressBarView Pointer
    // 060 TouchToStart                             ModelClassType Animator Animator Animator Pointer
    // 068 BackgroundType                           ModelEnumType TitleBackgroundType TitleBackgroundType TitleBackgroundType Int32
    // 070 BackgroundKey                            ModelPrimitiveType string string string String
    // 078 BgmCueSheetName                          ModelPrimitiveType string string string String
    // 080 BgmCueName                               ModelPrimitiveType string string string String
    // 088 TitleCallCueSheetName                    ModelPrimitiveType string string string String
    // 090 TitleCallCueName                         ModelPrimitiveType string string string String
    // 098 MstTitleBackground                       ModelClassType MstTitleBackground MstTitleBackground MstTitleBackground Pointer
    // 0A0 IsTitleCallEnabled                       ModelPrimitiveType bool bool bool Bool
    // 0A8 BgmDisposable                            ModelClassType IDisposable IDisposable IDisposable Pointer
    // 0B0 LoadProgressValue                        ModelPrimitiveType float float float Single
    public partial class TitleView : DataModel
    {
        public UITextMeshProUGUI?                       AppVersionText                          { get; set; }
        public UITextMeshProUGUI?                       IdText                                  { get; set; }
        public UIButton?                                MenuButton                              { get; set; }
        public UIButton?                                WholeScreenButton                       { get; set; }
        public MoviePlayer?                             MoviePlayer                             { get; set; }
        public UIRawImage?                              BackgroundImage                         { get; set; }
        public TitlePopupReference?                     Popup                                   { get; set; }
        public TitleLoadProgressBarView?                LoadProgress                            { get; set; }
        public Animator?                                TouchToStart                            { get; set; }
        public TitleBackgroundType                      BackgroundType                          { get; set; }
        public string                                   BackgroundKey                           { get; set; }
        public string                                   BgmCueSheetName                         { get; set; }
        public string                                   BgmCueName                              { get; set; }
        public string                                   TitleCallCueSheetName                   { get; set; }
        public string                                   TitleCallCueName                        { get; set; }
        public MstTitleBackground?                      MstTitleBackground                      { get; set; }
        public bool                                     IsTitleCallEnabled                      { get; set; }
        public IDisposable?                             BgmDisposable                           { get; set; }
        public float                                    LoadProgressValue                       { get; set; }

        public static TitleView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TitleView() { Pointer= p0 };

            value.AppVersionText                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x20 AppVersionText              ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.IdText                                    = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x28 IdText                      ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.MenuButton                                = GetObject<UIButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIButton.FromPointer); // 0x30 MenuButton                  ( ModelClassType UIButton UIButton UIButton Pointer )
            value.WholeScreenButton                         = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 0x38 WholeScreenButton           ( ModelClassType UIButton UIButton UIButton Pointer )
            value.MoviePlayer                               = GetObject<MoviePlayer>(new IntPtr(p + 0x040), ReversePrism.DataModels.MoviePlayer.FromPointer); // 0x40 MoviePlayer                 ( ModelClassType MoviePlayer MoviePlayer MoviePlayer Pointer )
            value.BackgroundImage                           = GetObject<UIRawImage>(new IntPtr(p + 0x048), ReversePrism.DataModels.UIRawImage.FromPointer); // 0x48 BackgroundImage             ( ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.Popup                                     = GetObject<TitlePopupReference>(new IntPtr(p + 0x050), ReversePrism.DataModels.TitlePopupReference.FromPointer); // 0x50 Popup                       ( ModelClassType TitlePopupReference TitlePopupReference TitlePopupReference Pointer )
            value.LoadProgress                              = GetObject<TitleLoadProgressBarView>(new IntPtr(p + 0x058), ReversePrism.DataModels.TitleLoadProgressBarView.FromPointer); // 0x58 LoadProgress                ( ModelClassType TitleLoadProgressBarView TitleLoadProgressBarView TitleLoadProgressBarView Pointer )
            value.TouchToStart                              = GetObject<Animator>(new IntPtr(p + 0x060), ReversePrism.DataModels.Animator.FromPointer); // 0x60 TouchToStart                ( ModelClassType Animator Animator Animator Pointer )
            value.BackgroundType                            = (TitleBackgroundType)GetInt32(new IntPtr(p + 0x068)); // 0x68 BackgroundType              ( ModelEnumType TitleBackgroundType TitleBackgroundType TitleBackgroundType Int32 )
            value.BackgroundKey                             = GetString(new IntPtr(p + 0x070)); // 0x70 BackgroundKey               ( ModelPrimitiveType string string string String )
            value.BgmCueSheetName                           = GetString(new IntPtr(p + 0x078)); // 0x78 BgmCueSheetName             ( ModelPrimitiveType string string string String )
            value.BgmCueName                                = GetString(new IntPtr(p + 0x080)); // 0x80 BgmCueName                  ( ModelPrimitiveType string string string String )
            value.TitleCallCueSheetName                     = GetString(new IntPtr(p + 0x088)); // 0x88 TitleCallCueSheetName       ( ModelPrimitiveType string string string String )
            value.TitleCallCueName                          = GetString(new IntPtr(p + 0x090)); // 0x90 TitleCallCueName            ( ModelPrimitiveType string string string String )
            value.MstTitleBackground                        = GetObject<MstTitleBackground>(new IntPtr(p + 0x098), ReversePrism.DataModels.MstTitleBackground.FromPointer); // 0x98 MstTitleBackground          ( ModelClassType MstTitleBackground MstTitleBackground MstTitleBackground Pointer )
            value.IsTitleCallEnabled                        = GetBool(new IntPtr(p + 0x0A0)); // 0xA0 IsTitleCallEnabled          ( ModelPrimitiveType bool bool bool Bool )
            value.BgmDisposable                             = GetObject<IDisposable>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.IDisposable.FromPointer); // 0xA8 BgmDisposable               ( ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.LoadProgressValue                         = GetSingle(new IntPtr(p + 0x0B0)); // 0xB0 LoadProgressValue           ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
