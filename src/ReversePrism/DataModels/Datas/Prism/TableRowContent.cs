using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 GoWhite                                  ModelClassType GameObject GameObject GameObject Pointer
    // 028 GoBlue                                   ModelClassType GameObject GameObject GameObject Pointer
    // 030 TxtVolues                                ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer
    // 038 IsHead                                   ModelPrimitiveType bool bool bool Bool
    public partial class TableRowContent : DataModel
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
            var value   = new TableRowContent() { Pointer= p0 };

            value.GoWhite                                   = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0x20 GoWhite                     ( ModelClassType GameObject GameObject GameObject Pointer )
            value.GoBlue                                    = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0x28 GoBlue                      ( ModelClassType GameObject GameObject GameObject Pointer )
            value.TxtVolues                                 = GetObjectList<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 TxtVolues                   ( ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer )
            value.IsHead                                    = GetBool(new IntPtr(p + 0x038)); // 0x38 IsHead                      ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
