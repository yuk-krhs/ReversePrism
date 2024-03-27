using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 AppVersionText                           0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 IdText                                   0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 MenuButton                               0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 038 WholeScreenButton                        0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 040 BgmCueSheetName                          000186671910 ModelPrimitiveType string string string String
    // 048 BgmCueName                               000186671910 ModelPrimitiveType string string string String
    // 050 MoviePlayer                              000186658A40 ModelClassType MoviePlayer MoviePlayer MoviePlayer Pointer
    // 058 BackgroundImage                          0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 060 Popup                                    00018667AF50 ModelClassType TitlePopupReference TitlePopupReference TitlePopupReference Pointer
    // 068 LoadProgress                             000186678A90 ModelClassType TitleLoadProgressBarView TitleLoadProgressBarView TitleLoadProgressBarView Pointer
    // 070 TouchToStart                             0001866B8DE0 ModelClassType Animator Animator Animator Pointer
    // 078 DownloadOverlayViewFactory               0001866F1FE0 ModelClassType DownloadOverlayViewFactory DownloadOverlayViewFactory DownloadOverlayViewFactory Pointer
    // 080 ResourceTag                              00018661C960 ModelClassType IResourceTag IResourceTag IResourceTag Pointer
    // 088 TitleCall                                000186677ED0 ModelClassType TitleCall TitleCall TitleCall Pointer
    // 090 BgmDisposable                            0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    // 098 TitleImageExists                         000186594D10 ModelPrimitiveType bool bool bool Bool
    // 09C LoadProgressValue                        0001866656B0 ModelPrimitiveType float float float Single
    public partial class TitleView
    {
        public UITextMeshProUGUI?                       AppVersionText                          { get; set; }
        public UITextMeshProUGUI?                       IdText                                  { get; set; }
        public UIButton?                                MenuButton                              { get; set; }
        public UIButton?                                WholeScreenButton                       { get; set; }
        public string                                   BgmCueSheetName                         { get; set; }
        public string                                   BgmCueName                              { get; set; }
        public MoviePlayer?                             MoviePlayer                             { get; set; }
        public UIRawImage?                              BackgroundImage                         { get; set; }
        public TitlePopupReference?                     Popup                                   { get; set; }
        public TitleLoadProgressBarView?                LoadProgress                            { get; set; }
        public Animator?                                TouchToStart                            { get; set; }
        public DownloadOverlayViewFactory?              DownloadOverlayViewFactory              { get; set; }
        public IResourceTag?                            ResourceTag                             { get; set; }
        public TitleCall?                               TitleCall                               { get; set; }
        public IDisposable?                             BgmDisposable                           { get; set; }
        public bool                                     TitleImageExists                        { get; set; }
        public float                                    LoadProgressValue                       { get; set; }

        public static TitleView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TitleView();

            value.AppVersionText                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 027004371D90 0x20 AppVersionText              ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.IdText                                    = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 027004371DB0 0x28 IdText                      ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.MenuButton                                = GetObject<UIButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIButton.FromPointer); // 027004371DD0 0x30 MenuButton                  ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.WholeScreenButton                         = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 027004371DF0 0x38 WholeScreenButton           ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.BgmCueSheetName                           = GetString(new IntPtr(p + 0x040)); // 027004371E10 0x40 BgmCueSheetName             ( 000186671910 ModelPrimitiveType string string string String )
            value.BgmCueName                                = GetString(new IntPtr(p + 0x048)); // 027004371E30 0x48 BgmCueName                  ( 000186671910 ModelPrimitiveType string string string String )
            value.MoviePlayer                               = GetObject<MoviePlayer>(new IntPtr(p + 0x050), ReversePrism.DataModels.MoviePlayer.FromPointer); // 027004371E50 0x50 MoviePlayer                 ( 000186658A40 ModelClassType MoviePlayer MoviePlayer MoviePlayer Pointer )
            value.BackgroundImage                           = GetObject<UIRawImage>(new IntPtr(p + 0x058), ReversePrism.DataModels.UIRawImage.FromPointer); // 027004371E70 0x58 BackgroundImage             ( 0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.Popup                                     = GetObject<TitlePopupReference>(new IntPtr(p + 0x060), ReversePrism.DataModels.TitlePopupReference.FromPointer); // 027004371E90 0x60 Popup                       ( 00018667AF50 ModelClassType TitlePopupReference TitlePopupReference TitlePopupReference Pointer )
            value.LoadProgress                              = GetObject<TitleLoadProgressBarView>(new IntPtr(p + 0x068), ReversePrism.DataModels.TitleLoadProgressBarView.FromPointer); // 027004371EB0 0x68 LoadProgress                ( 000186678A90 ModelClassType TitleLoadProgressBarView TitleLoadProgressBarView TitleLoadProgressBarView Pointer )
            value.TouchToStart                              = GetObject<Animator>(new IntPtr(p + 0x070), ReversePrism.DataModels.Animator.FromPointer); // 027004371ED0 0x70 TouchToStart                ( 0001866B8DE0 ModelClassType Animator Animator Animator Pointer )
            value.DownloadOverlayViewFactory                = GetObject<DownloadOverlayViewFactory>(new IntPtr(p + 0x078), ReversePrism.DataModels.DownloadOverlayViewFactory.FromPointer); // 027004371EF0 0x78 DownloadOverlayViewFactory  ( 0001866F1FE0 ModelClassType DownloadOverlayViewFactory DownloadOverlayViewFactory DownloadOverlayViewFactory Pointer )
            value.ResourceTag                               = GetObject<IResourceTag>(new IntPtr(p + 0x080), ReversePrism.DataModels.IResourceTag.FromPointer); // 027004371F10 0x80 ResourceTag                 ( 00018661C960 ModelClassType IResourceTag IResourceTag IResourceTag Pointer )
            value.TitleCall                                 = GetObject<TitleCall>(new IntPtr(p + 0x088), ReversePrism.DataModels.TitleCall.FromPointer); // 027004371F30 0x88 TitleCall                   ( 000186677ED0 ModelClassType TitleCall TitleCall TitleCall Pointer )
            value.BgmDisposable                             = GetObject<IDisposable>(new IntPtr(p + 0x090), ReversePrism.DataModels.IDisposable.FromPointer); // 027004371F50 0x90 BgmDisposable               ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.TitleImageExists                          = GetBool(new IntPtr(p + 0x098)); // 027004371F70 0x98 TitleImageExists            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.LoadProgressValue                         = GetSingle(new IntPtr(p + 0x09C)); // 027004371F90 0x9C LoadProgressValue           ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
