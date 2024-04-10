using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 LocalizedTextList                        000185CAE588 ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer
    // 068 FooterTextGameObject                     000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 070 MainGroupLayout                          000186515B70 ModelClassType VerticalLayoutGroup VerticalLayoutGroup VerticalLayoutGroup Pointer
    // 078 OpenTime                                 0001865B9010 ModelPrimitiveType DateTime DateTime DateTime DateTime
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

            value.LocalizedTextList                         = GetObjectList<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0245A440B440 0x60 LocalizedTextList           ( 000185CAE588 ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer )
            value.FooterTextGameObject                      = GetObjectList<GameObject>(new IntPtr(p + 0x068), ReversePrism.DataModels.GameObject.FromPointer); // 0245A440B460 0x68 FooterTextGameObject        ( 000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.MainGroupLayout                           = GetObject<VerticalLayoutGroup>(new IntPtr(p + 0x070), ReversePrism.DataModels.VerticalLayoutGroup.FromPointer); // 0245A440B480 0x70 MainGroupLayout             ( 000186515B70 ModelClassType VerticalLayoutGroup VerticalLayoutGroup VerticalLayoutGroup Pointer )
            value.OpenTime                                  = GetDateTime(new IntPtr(p + 0x078)); // 0245A440B4A0 0x78 OpenTime                    ( 0001865B9010 ModelPrimitiveType DateTime DateTime DateTime DateTime )

            return value;
        }
    }
}
