using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TitleCheckBox                            000186683C40 ModelClassType ToggleButton ToggleButton ToggleButton Pointer
    // 028 GroupMemberCheckBoxes                    000185CAC208 ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer
    // 030 onChangeSubject                          Subject`1<ValueTuple`2<int, bool>> IL2CPP_TYPE_GENERICINST
    public partial class UIFilterGroup
    {
        public ToggleButton?                            TitleCheckBox                           { get; set; }
        public List<ToggleButton>?                      GroupMemberCheckBoxes                   { get; set; }

        public static UIFilterGroup? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UIFilterGroup();

            value.TitleCheckBox                             = GetObject<ToggleButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.ToggleButton.FromPointer); // 0270D5488BF0 0x20 TitleCheckBox               ( 000186683C40 ModelClassType ToggleButton ToggleButton ToggleButton Pointer )
            value.GroupMemberCheckBoxes                     = GetObjectList<ToggleButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.ToggleButton.FromPointer); // 0270D5488C10 0x28 GroupMemberCheckBoxes       ( 000185CAC208 ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer )

            return value;
        }
    }
}
