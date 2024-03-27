using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 M_DropData                               00018663F0E0 ModelClassType DropData DropData DropData Pointer
    // 030 M_TreeView                               000186743B70 ModelClassType BaseTreeView BaseTreeView BaseTreeView Pointer
    // 038 M_ExpandDropItemScheduledItem            000186697790 ModelClassType IVisualElementScheduledItem IVisualElementScheduledItem IVisualElementScheduledItem Pointer
    // 040 M_ExpandDropItemCallback                 0001866792B0 ModelClassType Action Action Action Pointer
    public partial class TreeViewReorderableDragAndDropController
    {
        public DropData?                                M_DropData                              { get; set; }
        public BaseTreeView?                            M_TreeView                              { get; set; }
        public IVisualElementScheduledItem?             M_ExpandDropItemScheduledItem           { get; set; }
        public Action?                                  M_ExpandDropItemCallback                { get; set; }

        public static TreeViewReorderableDragAndDropController? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TreeViewReorderableDragAndDropController();

            value.M_DropData                                = GetObject<DropData>(new IntPtr(p + 0x028), ReversePrism.DataModels.DropData.FromPointer); // 027006757B28 0x28 M_DropData                  ( 00018663F0E0 ModelClassType DropData DropData DropData Pointer )
            value.M_TreeView                                = GetObject<BaseTreeView>(new IntPtr(p + 0x030), ReversePrism.DataModels.BaseTreeView.FromPointer); // 027006757B48 0x30 M_TreeView                  ( 000186743B70 ModelClassType BaseTreeView BaseTreeView BaseTreeView Pointer )
            value.M_ExpandDropItemScheduledItem             = GetObject<IVisualElementScheduledItem>(new IntPtr(p + 0x038), ReversePrism.DataModels.IVisualElementScheduledItem.FromPointer); // 027006757B68 0x38 M_ExpandDropItemScheduledItem ( 000186697790 ModelClassType IVisualElementScheduledItem IVisualElementScheduledItem IVisualElementScheduledItem Pointer )
            value.M_ExpandDropItemCallback                  = GetObject<Action>(new IntPtr(p + 0x040), ReversePrism.DataModels.Action.FromPointer); // 027006757B88 0x40 M_ExpandDropItemCallback    ( 0001866792B0 ModelClassType Action Action Action Pointer )

            return value;
        }
    }
}
