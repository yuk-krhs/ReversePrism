using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_MenuItems                              000185CD7A58 ModelClassListType List`1<DropdownMenuItem> List`1<DropdownMenuItem> List<DropdownMenuItem> Pointer
    // 018 M_DropdownMenuEventInfo                  000186708110 ModelClassType DropdownMenuEventInfo DropdownMenuEventInfo DropdownMenuEventInfo Pointer
    public partial class DropdownMenu
    {
        public List<DropdownMenuItem>?                  M_MenuItems                             { get; set; }
        public DropdownMenuEventInfo?                   M_DropdownMenuEventInfo                 { get; set; }

        public static DropdownMenu? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DropdownMenu();

            value.M_MenuItems                               = GetObjectList<DropdownMenuItem>(new IntPtr(p + 0x010), ReversePrism.DataModels.DropdownMenuItem.FromPointer); // 0270067586A0 0x10 M_MenuItems                 ( 000185CD7A58 ModelClassListType List`1<DropdownMenuItem> List`1<DropdownMenuItem> List<DropdownMenuItem> Pointer )
            value.M_DropdownMenuEventInfo                   = GetObject<DropdownMenuEventInfo>(new IntPtr(p + 0x018), ReversePrism.DataModels.DropdownMenuEventInfo.FromPointer); // 0270067586C0 0x18 M_DropdownMenuEventInfo     ( 000186708110 ModelClassType DropdownMenuEventInfo DropdownMenuEventInfo DropdownMenuEventInfo Pointer )

            return value;
        }
    }
}
