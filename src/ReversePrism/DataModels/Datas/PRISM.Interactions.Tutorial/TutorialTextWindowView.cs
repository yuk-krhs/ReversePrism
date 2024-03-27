using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CueSheetName                             000186671910 ModelPrimitiveType string string string String
    // 028 TextDuration                             0001866656B0 ModelPrimitiveType float float float Single
    // 02C WithCharacterFramePositionX              0001866656B0 ModelPrimitiveType float float float Single
    // 030 Character                                0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 038 Frame                                    000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 040 Text                                     0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 048 Next                                     0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 050 CoverButton                              0001865140C0 ModelClassType Button Button Button Pointer
    public partial class TutorialTextWindowView
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
            var value   = new TutorialTextWindowView();

            value.CueSheetName                              = GetString(new IntPtr(p + 0x020)); // 0270DBC134D8 0x20 CueSheetName                ( 000186671910 ModelPrimitiveType string string string String )
            value.TextDuration                              = GetSingle(new IntPtr(p + 0x028)); // 0270DBC134F8 0x28 TextDuration                ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.WithCharacterFramePositionX               = GetSingle(new IntPtr(p + 0x02C)); // 0270DBC13518 0x2C WithCharacterFramePositionX ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.Character                                 = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0270DBC13538 0x30 Character                   ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.Frame                                     = GetObject<RectTransform>(new IntPtr(p + 0x038), ReversePrism.DataModels.RectTransform.FromPointer); // 0270DBC13558 0x38 Frame                       ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.Text                                      = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0270DBC13578 0x40 Text                        ( 0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.Next                                      = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0270DBC13598 0x48 Next                        ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.CoverButton                               = GetObject<Button>(new IntPtr(p + 0x050), ReversePrism.DataModels.Button.FromPointer); // 0270DBC135B8 0x50 CoverButton                 ( 0001865140C0 ModelClassType Button Button Button Pointer )

            return value;
        }
    }
}
