using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 OnTabSelected                            0001866187C0 ModelClassType TabEvent TabEvent TabEvent Pointer
    // 028 Tabs                                     000185CAE378 ModelClassListType UITabButton[] UITabButton[] List<UITabButton> Pointer
    // 030 SelectedIndex                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 034 IsRestructTab                            000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class UITabGroup
    {
        public TabEvent?                                OnTabSelected                           { get; set; }
        public List<UITabButton>?                       Tabs                                    { get; set; }
        public int                                      SelectedIndex                           { get; set; }
        public bool                                     IsRestructTab                           { get; set; }

        public static UITabGroup? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UITabGroup();

            value.OnTabSelected                             = GetObject<TabEvent>(new IntPtr(p + 0x020), ReversePrism.DataModels.TabEvent.FromPointer); // 0270D4BCCBE0 0x20 OnTabSelected               ( 0001866187C0 ModelClassType TabEvent TabEvent TabEvent Pointer )
            value.Tabs                                      = GetObjectList<UITabButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITabButton.FromPointer); // 0270D4BCCC00 0x28 Tabs                        ( 000185CAE378 ModelClassListType UITabButton[] UITabButton[] List<UITabButton> Pointer )
            value.SelectedIndex                             = GetInt32(new IntPtr(p + 0x030)); // 0270D4BCCC20 0x30 SelectedIndex               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IsRestructTab                             = GetBool(new IntPtr(p + 0x034)); // 0270D4BCCC40 0x34 IsRestructTab               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
