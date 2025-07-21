using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 NameText                                 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 MessageText                              ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 CanvasGroup                              ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 038 MessageWindowCanvasGroup                 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 040 WindowObject                             ModelClassType Transform Transform Transform Pointer
    // 048 WindowImage                              ModelClassType Image Image Image Pointer
    // 050 FadeCurve                                ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 058 WindowSprites                            ModelClassListType Sprite[] Sprite[] List<Sprite> Pointer
    // 060 PanelViewFadeTimeDisposable              ModelClassType IDisposable IDisposable IDisposable Pointer
    // 068 MessageWindowFadeTimeDisposable          ModelClassType IDisposable IDisposable IDisposable Pointer
    // 070 CueSheetName                             ModelPrimitiveType string string string String
    public partial class HomeCharacterMessagePanelView : DataModel
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
            var value   = new HomeCharacterMessagePanelView() { Pointer= p0 };

            value.NameText                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x20 NameText                    ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.MessageText                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x28 MessageText                 ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x030), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x30 CanvasGroup                 ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.MessageWindowCanvasGroup                  = GetObject<CanvasGroup>(new IntPtr(p + 0x038), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x38 MessageWindowCanvasGroup    ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.WindowObject                              = GetObject<Transform>(new IntPtr(p + 0x040), ReversePrism.DataModels.Transform.FromPointer); // 0x40 WindowObject                ( ModelClassType Transform Transform Transform Pointer )
            value.WindowImage                               = GetObject<Image>(new IntPtr(p + 0x048), ReversePrism.DataModels.Image.FromPointer); // 0x48 WindowImage                 ( ModelClassType Image Image Image Pointer )
            value.FadeCurve                                 = GetObject<AnimationCurve>(new IntPtr(p + 0x050), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0x50 FadeCurve                   ( ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.WindowSprites                             = GetObjectList<Sprite>(new IntPtr(p + 0x058), ReversePrism.DataModels.Sprite.FromPointer); // 0x58 WindowSprites               ( ModelClassListType Sprite[] Sprite[] List<Sprite> Pointer )
            value.PanelViewFadeTimeDisposable               = GetObject<IDisposable>(new IntPtr(p + 0x060), ReversePrism.DataModels.IDisposable.FromPointer); // 0x60 PanelViewFadeTimeDisposable ( ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.MessageWindowFadeTimeDisposable           = GetObject<IDisposable>(new IntPtr(p + 0x068), ReversePrism.DataModels.IDisposable.FromPointer); // 0x68 MessageWindowFadeTimeDisposable ( ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.CueSheetName                              = GetString(new IntPtr(p + 0x070)); // 0x70 CueSheetName                ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
