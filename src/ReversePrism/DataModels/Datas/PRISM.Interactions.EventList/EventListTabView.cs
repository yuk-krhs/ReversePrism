using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Texts                                    000185CAE588 ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer
    // 028 NewBadge                                 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 030 TabButton                                0001866F4F80 ModelClassType UITabButton UITabButton UITabButton Pointer
    // 038 Type                                     0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class EventListTabView : DataModel
    {
        public List<UITextMeshProUGUI>?                 Texts                                   { get; set; }
        public GameObject?                              NewBadge                                { get; set; }
        public UITabButton?                             TabButton                               { get; set; }
        public int                                      Type                                    { get; set; }

        public static EventListTabView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EventListTabView() { Pointer= p0 };

            value.Texts                                     = GetObjectList<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466BF59D28 0x20 Texts                       ( 000185CAE588 ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer )
            value.NewBadge                                  = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 02466BF59D48 0x28 NewBadge                    ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.TabButton                                 = GetObject<UITabButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITabButton.FromPointer); // 02466BF59D68 0x30 TabButton                   ( 0001866F4F80 ModelClassType UITabButton UITabButton UITabButton Pointer )
            value.Type                                      = GetInt32(new IntPtr(p + 0x038)); // 02466BF59D88 0x38 Type                        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
