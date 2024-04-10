using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Button                                   0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 028 Texts                                    000185CAE588 ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer
    // 030 PresentIndex                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 034 TextsCount                               0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class ToggleTextButton : DataModel
    {
        public UIButton?                                Button                                  { get; set; }
        public List<UITextMeshProUGUI>?                 Texts                                   { get; set; }
        public int                                      PresentIndex                            { get; set; }
        public int                                      TextsCount                              { get; set; }

        public static ToggleTextButton? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ToggleTextButton() { Pointer= p0 };

            value.Button                                    = GetObject<UIButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIButton.FromPointer); // 0245A4403318 0x20 Button                      ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.Texts                                     = GetObjectList<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0245A4403338 0x28 Texts                       ( 000185CAE588 ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer )
            value.PresentIndex                              = GetInt32(new IntPtr(p + 0x030)); // 0245A4403358 0x30 PresentIndex                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.TextsCount                                = GetInt32(new IntPtr(p + 0x034)); // 0245A4403378 0x34 TextsCount                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
