using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CueSheetName                             ModelPrimitiveType string string string String
    // 028 TextDuration                             ModelPrimitiveType float float float Single
    // 02C WithCharacterFramePositionX              ModelPrimitiveType float float float Single
    // 030 Character                                ModelClassType GameObject GameObject GameObject Pointer
    // 038 Frame                                    ModelClassType RectTransform RectTransform RectTransform Pointer
    // 040 Text                                     ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 048 Next                                     ModelClassType GameObject GameObject GameObject Pointer
    // 050 CoverButton                              ModelClassType Button Button Button Pointer
    public partial class TutorialTextWindowView : DataModel
    {
        public string                                   CueSheetName                            { get; set; }
        public float                                    TextDuration                            { get; set; }
        public float                                    WithCharacterFramePositionX             { get; set; }
        public GameObject?                              Character                               { get; set; }
        public RectTransform?                           Frame                                   { get; set; }
        public TextMeshProUGUI?                         Text                                    { get; set; }
        public GameObject?                              Next                                    { get; set; }
        public Button?                                  CoverButton                             { get; set; }

        public static TutorialTextWindowView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TutorialTextWindowView() { Pointer= p0 };

            value.CueSheetName                              = GetString(new IntPtr(p + 0x020)); // 0x20 CueSheetName                ( ModelPrimitiveType string string string String )
            value.TextDuration                              = GetSingle(new IntPtr(p + 0x028)); // 0x28 TextDuration                ( ModelPrimitiveType float float float Single )
            value.WithCharacterFramePositionX               = GetSingle(new IntPtr(p + 0x02C)); // 0x2C WithCharacterFramePositionX ( ModelPrimitiveType float float float Single )
            value.Character                                 = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0x30 Character                   ( ModelClassType GameObject GameObject GameObject Pointer )
            value.Frame                                     = GetObject<RectTransform>(new IntPtr(p + 0x038), ReversePrism.DataModels.RectTransform.FromPointer); // 0x38 Frame                       ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.Text                                      = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0x40 Text                        ( ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.Next                                      = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0x48 Next                        ( ModelClassType GameObject GameObject GameObject Pointer )
            value.CoverButton                               = GetObject<Button>(new IntPtr(p + 0x050), ReversePrism.DataModels.Button.FromPointer); // 0x50 CoverButton                 ( ModelClassType Button Button Button Pointer )

            return value;
        }
    }
}
