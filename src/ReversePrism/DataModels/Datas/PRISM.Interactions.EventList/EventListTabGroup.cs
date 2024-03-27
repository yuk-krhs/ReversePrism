using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 TabViewPrefab                            00018675E470 ModelClassType EventListTabView EventListTabView EventListTabView Pointer
    // 040 TabViewContainer                         0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 048 TabViews                                 000185CD98E8 ModelClassListType List`1<EventListTabView> List`1<EventListTabView> List<EventListTabView> Pointer
    // 050 onSelectTab                              Subject`1<int> IL2CPP_TYPE_GENERICINST
    public partial class EventListTabGroup
    {
        public EventListTabView?                        TabViewPrefab                           { get; set; }
        public Transform?                               TabViewContainer                        { get; set; }
        public List<EventListTabView>?                  TabViews                                { get; set; }

        public static EventListTabGroup? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EventListTabGroup();

            value.TabViewPrefab                             = GetObject<EventListTabView>(new IntPtr(p + 0x038), ReversePrism.DataModels.EventListTabView.FromPointer); // 0270DBEB5968 0x38 TabViewPrefab               ( 00018675E470 ModelClassType EventListTabView EventListTabView EventListTabView Pointer )
            value.TabViewContainer                          = GetObject<Transform>(new IntPtr(p + 0x040), ReversePrism.DataModels.Transform.FromPointer); // 0270DBEB5988 0x40 TabViewContainer            ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.TabViews                                  = GetObjectList<EventListTabView>(new IntPtr(p + 0x048), ReversePrism.DataModels.EventListTabView.FromPointer); // 0270DBEB59A8 0x48 TabViews                    ( 000185CD98E8 ModelClassListType List`1<EventListTabView> List`1<EventListTabView> List<EventListTabView> Pointer )

            return value;
        }
    }
}
