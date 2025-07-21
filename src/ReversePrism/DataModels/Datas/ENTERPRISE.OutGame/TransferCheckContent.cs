using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 LocalizedTextList                        ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer
    // 068 FooterTextGameObject                     ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 070 MainGroupLayout                          ModelClassType VerticalLayoutGroup VerticalLayoutGroup VerticalLayoutGroup Pointer
    // 078 OpenTime                                 ModelPrimitiveType DateTime DateTime DateTime DateTime
    public partial class TransferCheckContent : DataModel
    {
        public List<UITextMeshProUGUI>?                 LocalizedTextList                       { get; set; }
        public List<GameObject>?                        FooterTextGameObject                    { get; set; }
        public VerticalLayoutGroup?                     MainGroupLayout                         { get; set; }
        public DateTime                                 OpenTime                                { get; set; }

        public static TransferCheckContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TransferCheckContent() { Pointer= p0 };

            value.LocalizedTextList                         = GetObjectList<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x60 LocalizedTextList           ( ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer )
            value.FooterTextGameObject                      = GetObjectList<GameObject>(new IntPtr(p + 0x068), ReversePrism.DataModels.GameObject.FromPointer); // 0x68 FooterTextGameObject        ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.MainGroupLayout                           = GetObject<VerticalLayoutGroup>(new IntPtr(p + 0x070), ReversePrism.DataModels.VerticalLayoutGroup.FromPointer); // 0x70 MainGroupLayout             ( ModelClassType VerticalLayoutGroup VerticalLayoutGroup VerticalLayoutGroup Pointer )
            value.OpenTime                                  = GetDateTime(new IntPtr(p + 0x078)); // 0x78 OpenTime                    ( ModelPrimitiveType DateTime DateTime DateTime DateTime )

            return value;
        }
    }
}
