using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CharacterImage                           ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 028 TitleText                                ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 DescriptionText                          ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 MissionSuccessObj                        ModelClassType GameObject GameObject GameObject Pointer
    // 040 MissionFailureObj                        ModelClassType GameObject GameObject GameObject Pointer
    // 048 ParameterContent                         ModelClassType ParameterContent ParameterContent ParameterContent Pointer
    public partial class ChallengeMissionContent : DataModel
    {
        public UIRawImage?                              CharacterImage                          { get; set; }
        public UITextMeshProUGUI?                       TitleText                               { get; set; }
        public UITextMeshProUGUI?                       DescriptionText                         { get; set; }
        public GameObject?                              MissionSuccessObj                       { get; set; }
        public GameObject?                              MissionFailureObj                       { get; set; }
        public ParameterContent?                        ParameterContent                        { get; set; }

        public static ChallengeMissionContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeMissionContent() { Pointer= p0 };

            value.CharacterImage                            = GetObject<UIRawImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIRawImage.FromPointer); // 0x20 CharacterImage              ( ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.TitleText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x28 TitleText                   ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.DescriptionText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 DescriptionText             ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.MissionSuccessObj                         = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0x38 MissionSuccessObj           ( ModelClassType GameObject GameObject GameObject Pointer )
            value.MissionFailureObj                         = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0x40 MissionFailureObj           ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ParameterContent                          = GetObject<ParameterContent>(new IntPtr(p + 0x048), ReversePrism.DataModels.ParameterContent.FromPointer); // 0x48 ParameterContent            ( ModelClassType ParameterContent ParameterContent ParameterContent Pointer )

            return value;
        }
    }
}
