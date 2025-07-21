using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 UiTabGroup                               ModelClassType UITabGroup UITabGroup UITabGroup Pointer
    // 028 BtnUITabs                                ModelClassListType UITabButton[] UITabButton[] List<UITabButton> Pointer
    // 030 BtnInputPartyName                        ModelClassType UIButton UIButton UIButton Pointer
    // 038 onTabIndex                               Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 040 onRename                                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    public partial class PartyTabGroupView : DataModel
    {
        public UITabGroup?                              UiTabGroup                              { get; set; }
        public List<UITabButton>?                       BtnUITabs                               { get; set; }
        public UIButton?                                BtnInputPartyName                       { get; set; }

        public static PartyTabGroupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PartyTabGroupView() { Pointer= p0 };

            value.UiTabGroup                                = GetObject<UITabGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITabGroup.FromPointer); // 0x20 UiTabGroup                  ( ModelClassType UITabGroup UITabGroup UITabGroup Pointer )
            value.BtnUITabs                                 = GetObjectList<UITabButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITabButton.FromPointer); // 0x28 BtnUITabs                   ( ModelClassListType UITabButton[] UITabButton[] List<UITabButton> Pointer )
            value.BtnInputPartyName                         = GetObject<UIButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIButton.FromPointer); // 0x30 BtnInputPartyName           ( ModelClassType UIButton UIButton UIButton Pointer )

            return value;
        }
    }
}
