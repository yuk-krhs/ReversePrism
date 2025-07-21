using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ContentTabGroup                          ModelClassType UITabGroup UITabGroup UITabGroup Pointer
    // 028 TabButtonParent                          ModelClassType Transform Transform Transform Pointer
    // 030 TabButtonPrefab                          ModelClassType UITabButton UITabButton UITabButton Pointer
    // 038 Tabs                                     ModelClassListType List`1<UITabButton> List`1<UITabButton> List<UITabButton> Pointer
    // 040 clickSubject                             Subject`1<ValueTuple`2<int, LiveStatus>> IL2CPP_TYPE_GENERICINST
    public partial class OurStreamTabGroup : DataModel
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
            var value   = new OurStreamTabGroup() { Pointer= p0 };

            value.ContentTabGroup                           = GetObject<UITabGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITabGroup.FromPointer); // 0x20 ContentTabGroup             ( ModelClassType UITabGroup UITabGroup UITabGroup Pointer )
            value.TabButtonParent                           = GetObject<Transform>(new IntPtr(p + 0x028), ReversePrism.DataModels.Transform.FromPointer); // 0x28 TabButtonParent             ( ModelClassType Transform Transform Transform Pointer )
            value.TabButtonPrefab                           = GetObject<UITabButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITabButton.FromPointer); // 0x30 TabButtonPrefab             ( ModelClassType UITabButton UITabButton UITabButton Pointer )
            value.Tabs                                      = GetObjectList<UITabButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITabButton.FromPointer); // 0x38 Tabs                        ( ModelClassListType List`1<UITabButton> List`1<UITabButton> List<UITabButton> Pointer )

            return value;
        }
    }
}
