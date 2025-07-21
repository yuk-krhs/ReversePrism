using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 onSelectSubseasonSubject                 Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 028 SafeAreaRoot                             ModelClassType RectTransform RectTransform RectTransform Pointer
    // 030 ChoiceButtonRoot                         ModelClassType GameObject GameObject GameObject Pointer
    // 038 Buttons                                  ModelClassListType List`1<UIButton> List`1<UIButton> List<UIButton> Pointer
    // 040 ButtonTexts                              ModelClassListType List`1<UITextMeshProUGUI> List`1<UITextMeshProUGUI> List<UITextMeshProUGUI> Pointer
    // 048 Model3dLoader                            ModelClassType Model3dLoaderForProduceAdv Model3dLoaderForProduceAdv Model3dLoaderForProduceAdv Pointer
    // 050 BackKeyDisposable                        ModelClassType IDisposable IDisposable IDisposable Pointer
    public partial class ProduceSubSeasonSelectView : DataModel
    {
        public RectTransform?                           SafeAreaRoot                            { get; set; }
        public GameObject?                              ChoiceButtonRoot                        { get; set; }
        public List<UIButton>?                          Buttons                                 { get; set; }
        public List<UITextMeshProUGUI>?                 ButtonTexts                             { get; set; }
        public Model3dLoaderForProduceAdv?              Model3dLoader                           { get; set; }
        public IDisposable?                             BackKeyDisposable                       { get; set; }

        public static ProduceSubSeasonSelectView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceSubSeasonSelectView() { Pointer= p0 };

            value.SafeAreaRoot                              = GetObject<RectTransform>(new IntPtr(p + 0x028), ReversePrism.DataModels.RectTransform.FromPointer); // 0x28 SafeAreaRoot                ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.ChoiceButtonRoot                          = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0x30 ChoiceButtonRoot            ( ModelClassType GameObject GameObject GameObject Pointer )
            value.Buttons                                   = GetObjectList<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 0x38 Buttons                     ( ModelClassListType List`1<UIButton> List`1<UIButton> List<UIButton> Pointer )
            value.ButtonTexts                               = GetObjectList<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x40 ButtonTexts                 ( ModelClassListType List`1<UITextMeshProUGUI> List`1<UITextMeshProUGUI> List<UITextMeshProUGUI> Pointer )
            value.Model3dLoader                             = GetObject<Model3dLoaderForProduceAdv>(new IntPtr(p + 0x048), ReversePrism.DataModels.Model3dLoaderForProduceAdv.FromPointer); // 0x48 Model3dLoader               ( ModelClassType Model3dLoaderForProduceAdv Model3dLoaderForProduceAdv Model3dLoaderForProduceAdv Pointer )
            value.BackKeyDisposable                         = GetObject<IDisposable>(new IntPtr(p + 0x050), ReversePrism.DataModels.IDisposable.FromPointer); // 0x50 BackKeyDisposable           ( ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
