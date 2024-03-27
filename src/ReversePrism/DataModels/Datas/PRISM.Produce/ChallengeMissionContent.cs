using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CharacterImage                           0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 028 TitleText                                0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 DescriptionText                          0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 MissionSuccessObj                        0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 040 MissionFailureObj                        0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 048 ParameterContent                         00018671BD80 ModelClassType ParameterContent ParameterContent ParameterContent Pointer
    public partial class ChallengeMissionContent
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
            var value   = new ChallengeMissionContent();

            value.CharacterImage                            = GetObject<UIRawImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIRawImage.FromPointer); // 0270D5D1FF18 0x20 CharacterImage              ( 0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.TitleText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5D1FF38 0x28 TitleText                   ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.DescriptionText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5D1FF58 0x30 DescriptionText             ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.MissionSuccessObj                         = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0270D5D1FF78 0x38 MissionSuccessObj           ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.MissionFailureObj                         = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0270D5D1FF98 0x40 MissionFailureObj           ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ParameterContent                          = GetObject<ParameterContent>(new IntPtr(p + 0x048), ReversePrism.DataModels.ParameterContent.FromPointer); // 0270D5D1FFB8 0x48 ParameterContent            ( 00018671BD80 ModelClassType ParameterContent ParameterContent ParameterContent Pointer )

            return value;
        }
    }
}
