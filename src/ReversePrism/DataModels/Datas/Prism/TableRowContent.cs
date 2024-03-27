using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 GoWhite                                  0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 028 GoBlue                                   0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 030 TxtVolues                                000185CAE588 ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer
    // 038 IsHead                                   000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class TableRowContent
    {
        public GameObject?                              GoWhite                                 { get; set; }
        public GameObject?                              GoBlue                                  { get; set; }
        public List<UITextMeshProUGUI>?                 TxtVolues                               { get; set; }
        public bool                                     IsHead                                  { get; set; }

        public static TableRowContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TableRowContent();

            value.GoWhite                                   = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0270D4CC8320 0x20 GoWhite                     ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.GoBlue                                    = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0270D4CC8340 0x28 GoBlue                      ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.TxtVolues                                 = GetObjectList<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D4CC8360 0x30 TxtVolues                   ( 000185CAE588 ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer )
            value.IsHead                                    = GetBool(new IntPtr(p + 0x038)); // 0270D4CC8380 0x38 IsHead                      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
