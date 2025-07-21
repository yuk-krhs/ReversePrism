using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 OpenTime                                 ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 068 LocalizedTextList                        ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer
    // 070 FooterTextGameObject                     ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 078 MainGroupLayout                          ModelClassType VerticalLayoutGroup VerticalLayoutGroup VerticalLayoutGroup Pointer
    // 080 UiTextMeshProUgui1                       ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 088 UiTextMeshProUgui2                       ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    public partial class DataTransferContent : DataModel
    {
        public DateTime                                 OpenTime                                { get; set; }
        public List<UITextMeshProUGUI>?                 LocalizedTextList                       { get; set; }
        public List<GameObject>?                        FooterTextGameObject                    { get; set; }
        public VerticalLayoutGroup?                     MainGroupLayout                         { get; set; }
        public UITextMeshProUGUI?                       UiTextMeshProUgui1                      { get; set; }
        public UITextMeshProUGUI?                       UiTextMeshProUgui2                      { get; set; }

        public static DataTransferContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DataTransferContent() { Pointer= p0 };

            value.OpenTime                                  = GetDateTime(new IntPtr(p + 0x060)); // 0x60 OpenTime                    ( ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.LocalizedTextList                         = GetObjectList<UITextMeshProUGUI>(new IntPtr(p + 0x068), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x68 LocalizedTextList           ( ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer )
            value.FooterTextGameObject                      = GetObjectList<GameObject>(new IntPtr(p + 0x070), ReversePrism.DataModels.GameObject.FromPointer); // 0x70 FooterTextGameObject        ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.MainGroupLayout                           = GetObject<VerticalLayoutGroup>(new IntPtr(p + 0x078), ReversePrism.DataModels.VerticalLayoutGroup.FromPointer); // 0x78 MainGroupLayout             ( ModelClassType VerticalLayoutGroup VerticalLayoutGroup VerticalLayoutGroup Pointer )
            value.UiTextMeshProUgui1                        = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x080), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x80 UiTextMeshProUgui1          ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.UiTextMeshProUgui2                        = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x088), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x88 UiTextMeshProUgui2          ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
