using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TabGroup                                 0001866F5490 ModelClassType UITabGroup UITabGroup UITabGroup Pointer
    // 028 TabStates                                000185CC4E38 ModelEnumListType State[] State[] List<State> Pointer
    public partial class UITabGroupEx
    {
        public UITabGroup?                              TabGroup                                { get; set; }
        public List<State>?                             TabStates                               { get; set; }

        public static UITabGroupEx? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UITabGroupEx();

            value.TabGroup                                  = GetObject<UITabGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITabGroup.FromPointer); // 0270D4CB9B38 0x20 TabGroup                    ( 0001866F5490 ModelClassType UITabGroup UITabGroup UITabGroup Pointer )
            value.TabStates                                 = GetEnumList<State>(new IntPtr(p + 0x028)); // 0270D4CB9B58 0x28 TabStates                   ( 000185CC4E38 ModelEnumListType State[] State[] List<State> Pointer )

            return value;
        }
    }
}
