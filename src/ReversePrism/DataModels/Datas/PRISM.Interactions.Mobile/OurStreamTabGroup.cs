using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ContentTabGroup                          0001866F5490 ModelClassType UITabGroup UITabGroup UITabGroup Pointer
    // 028 TabButtonParent                          0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 030 TabButtonPrefab                          0001866F4F80 ModelClassType UITabButton UITabButton UITabButton Pointer
    // 038 Tabs                                     000185D186F8 ModelClassListType List`1<UITabButton> List`1<UITabButton> List<UITabButton> Pointer
    // 040 clickSubject                             Subject`1<ValueTuple`2<int, LiveStatus>> IL2CPP_TYPE_GENERICINST
    public partial class OurStreamTabGroup
    {
        public UITabGroup?                              ContentTabGroup                         { get; set; }
        public Transform?                               TabButtonParent                         { get; set; }
        public UITabButton?                             TabButtonPrefab                         { get; set; }
        public List<UITabButton>?                       Tabs                                    { get; set; }

        public static OurStreamTabGroup? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OurStreamTabGroup();

            value.ContentTabGroup                           = GetObject<UITabGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITabGroup.FromPointer); // 0270DB14F7D0 0x20 ContentTabGroup             ( 0001866F5490 ModelClassType UITabGroup UITabGroup UITabGroup Pointer )
            value.TabButtonParent                           = GetObject<Transform>(new IntPtr(p + 0x028), ReversePrism.DataModels.Transform.FromPointer); // 0270DB14F7F0 0x28 TabButtonParent             ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.TabButtonPrefab                           = GetObject<UITabButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITabButton.FromPointer); // 0270DB14F810 0x30 TabButtonPrefab             ( 0001866F4F80 ModelClassType UITabButton UITabButton UITabButton Pointer )
            value.Tabs                                      = GetObjectList<UITabButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITabButton.FromPointer); // 0270DB14F830 0x38 Tabs                        ( 000185D186F8 ModelClassListType List`1<UITabButton> List`1<UITabButton> List<UITabButton> Pointer )

            return value;
        }
    }
}
