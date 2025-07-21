using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TitleCheckBox                            ModelClassType ToggleButton ToggleButton ToggleButton Pointer
    // 028 GroupMemberCheckBoxes                    ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer
    // 030 onChangeSubject                          Subject`1<ValueTuple`2<int, bool>> IL2CPP_TYPE_GENERICINST
    public partial class UIFilterGroup : DataModel
    {
        public ToggleButton?                            TitleCheckBox                           { get; set; }
        public List<ToggleButton>?                      GroupMemberCheckBoxes                   { get; set; }

        public static UIFilterGroup? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UIFilterGroup() { Pointer= p0 };

            value.TitleCheckBox                             = GetObject<ToggleButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.ToggleButton.FromPointer); // 0x20 TitleCheckBox               ( ModelClassType ToggleButton ToggleButton ToggleButton Pointer )
            value.GroupMemberCheckBoxes                     = GetObjectList<ToggleButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.ToggleButton.FromPointer); // 0x28 GroupMemberCheckBoxes       ( ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer )

            return value;
        }
    }
}
