using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TabGroup                                 ModelClassType UITabGroup UITabGroup UITabGroup Pointer
    // 028 TabButtonPrefab                          ModelClassType StoryTopTabButton StoryTopTabButton StoryTopTabButton Pointer
    // 030 Tabs                                     ModelClassListType List`1<UITabButton> List`1<UITabButton> List<UITabButton> Pointer
    // 038 onClickTabButtonSubject                  Subject`1<int> IL2CPP_TYPE_GENERICINST
    public partial class StoryTopTabGroup : DataModel
    {
        public UITabGroup?                              TabGroup                                { get; set; }
        public StoryTopTabButton?                       TabButtonPrefab                         { get; set; }
        public List<UITabButton>?                       Tabs                                    { get; set; }

        public static StoryTopTabGroup? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StoryTopTabGroup() { Pointer= p0 };

            value.TabGroup                                  = GetObject<UITabGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITabGroup.FromPointer); // 0x20 TabGroup                    ( ModelClassType UITabGroup UITabGroup UITabGroup Pointer )
            value.TabButtonPrefab                           = GetObject<StoryTopTabButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.StoryTopTabButton.FromPointer); // 0x28 TabButtonPrefab             ( ModelClassType StoryTopTabButton StoryTopTabButton StoryTopTabButton Pointer )
            value.Tabs                                      = GetObjectList<UITabButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITabButton.FromPointer); // 0x30 Tabs                        ( ModelClassListType List`1<UITabButton> List`1<UITabButton> List<UITabButton> Pointer )

            return value;
        }
    }
}
