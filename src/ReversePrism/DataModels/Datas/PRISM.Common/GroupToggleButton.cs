using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ChildToggleButtons                       ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer
    // 028 ToggleButton                             ModelClassType ToggleButton ToggleButton ToggleButton Pointer
    // 030 ManagedToggleButtons                     IEnumerable`1<ToggleButton> IL2CPP_TYPE_GENERICINST
    public partial class GroupToggleButton : DataModel
    {
        public List<ToggleButton>?                      ChildToggleButtons                      { get; set; }
        public ToggleButton?                            ToggleButton                            { get; set; }

        public static GroupToggleButton? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GroupToggleButton() { Pointer= p0 };

            value.ChildToggleButtons                        = GetObjectList<ToggleButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.ToggleButton.FromPointer); // 0x20 ChildToggleButtons          ( ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer )
            value.ToggleButton                              = GetObject<ToggleButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.ToggleButton.FromPointer); // 0x28 ToggleButton                ( ModelClassType ToggleButton ToggleButton ToggleButton Pointer )

            return value;
        }
    }
}
