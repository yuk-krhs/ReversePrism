using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 NameText                                 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 MessageText                              0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 CanvasGroup                              000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 038 MessageWindowCanvasGroup                 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 040 WindowObject                             0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 048 WindowImage                              0001866CCDB0 ModelClassType Image Image Image Pointer
    // 050 FadeCurve                                000186586CC0 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 058 WindowSprites                            000185CA4898 ModelClassListType Sprite[] Sprite[] List<Sprite> Pointer
    // 060 PanelViewFadeTimeDisposable              0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    // 068 MessageWindowFadeTimeDisposable          0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    // 070 CueSheetName                             000186671910 ModelPrimitiveType string string string String
    public partial class HomeCharacterMessagePanelView
    {
        public UITextMeshProUGUI?                       NameText                                { get; set; }
        public UITextMeshProUGUI?                       MessageText                             { get; set; }
        public CanvasGroup?                             CanvasGroup                             { get; set; }
        public CanvasGroup?                             MessageWindowCanvasGroup                { get; set; }
        public Transform?                               WindowObject                            { get; set; }
        public Image?                                   WindowImage                             { get; set; }
        public AnimationCurve?                          FadeCurve                               { get; set; }
        public List<Sprite>?                            WindowSprites                           { get; set; }
        public IDisposable?                             PanelViewFadeTimeDisposable             { get; set; }
        public IDisposable?                             MessageWindowFadeTimeDisposable         { get; set; }
        public string                                   CueSheetName                            { get; set; }

        public static HomeCharacterMessagePanelView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HomeCharacterMessagePanelView();

            value.NameText                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 027004FA8D50 0x20 NameText                    ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.MessageText                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 027004FA8D70 0x28 MessageText                 ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x030), ReversePrism.DataModels.CanvasGroup.FromPointer); // 027004FA8D90 0x30 CanvasGroup                 ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.MessageWindowCanvasGroup                  = GetObject<CanvasGroup>(new IntPtr(p + 0x038), ReversePrism.DataModels.CanvasGroup.FromPointer); // 027004FA8DB0 0x38 MessageWindowCanvasGroup    ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.WindowObject                              = GetObject<Transform>(new IntPtr(p + 0x040), ReversePrism.DataModels.Transform.FromPointer); // 027004FA8DD0 0x40 WindowObject                ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.WindowImage                               = GetObject<Image>(new IntPtr(p + 0x048), ReversePrism.DataModels.Image.FromPointer); // 027004FA8DF0 0x48 WindowImage                 ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.FadeCurve                                 = GetObject<AnimationCurve>(new IntPtr(p + 0x050), ReversePrism.DataModels.AnimationCurve.FromPointer); // 027004FA8E10 0x50 FadeCurve                   ( 000186586CC0 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.WindowSprites                             = GetObjectList<Sprite>(new IntPtr(p + 0x058), ReversePrism.DataModels.Sprite.FromPointer); // 027004FA8E30 0x58 WindowSprites               ( 000185CA4898 ModelClassListType Sprite[] Sprite[] List<Sprite> Pointer )
            value.PanelViewFadeTimeDisposable               = GetObject<IDisposable>(new IntPtr(p + 0x060), ReversePrism.DataModels.IDisposable.FromPointer); // 027004FA8E50 0x60 PanelViewFadeTimeDisposable ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.MessageWindowFadeTimeDisposable           = GetObject<IDisposable>(new IntPtr(p + 0x068), ReversePrism.DataModels.IDisposable.FromPointer); // 027004FA8E70 0x68 MessageWindowFadeTimeDisposable ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.CueSheetName                              = GetString(new IntPtr(p + 0x070)); // 027004FA8E90 0x70 CueSheetName                ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
