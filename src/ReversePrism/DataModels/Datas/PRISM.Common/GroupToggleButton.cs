using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ChildToggleButtons                       000185CAC208 ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer
    // 028 ToggleButton                             000186683C40 ModelClassType ToggleButton ToggleButton ToggleButton Pointer
    // 030 ManagedToggleButtons                     IEnumerable`1<ToggleButton> IL2CPP_TYPE_GENERICINST
    public partial class GroupToggleButton
    {
        public List<ToggleButton>?                      ChildToggleButtons                      { get; set; }
        public ToggleButton?                            ToggleButton                            { get; set; }

        public static GroupToggleButton? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GroupToggleButton();

            value.ChildToggleButtons                        = GetObjectList<ToggleButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.ToggleButton.FromPointer); // 0270D4C82390 0x20 ChildToggleButtons          ( 000185CAC208 ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer )
            value.ToggleButton                              = GetObject<ToggleButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.ToggleButton.FromPointer); // 0270D4C823B0 0x28 ToggleButton                ( 000186683C40 ModelClassType ToggleButton ToggleButton ToggleButton Pointer )

            return value;
        }
    }
}
