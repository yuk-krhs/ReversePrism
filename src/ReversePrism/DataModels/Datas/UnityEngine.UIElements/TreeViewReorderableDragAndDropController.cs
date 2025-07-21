using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 M_DropData                               ModelClassType DropData DropData DropData Pointer
    // 030 M_TreeView                               ModelClassType BaseTreeView BaseTreeView BaseTreeView Pointer
    // 038 M_ExpandDropItemScheduledItem            ModelClassType IVisualElementScheduledItem IVisualElementScheduledItem IVisualElementScheduledItem Pointer
    // 040 M_ExpandDropItemCallback                 ModelClassType Action Action Action Pointer
    public partial class TreeViewReorderableDragAndDropController : DataModel
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
            var value   = new TreeViewReorderableDragAndDropController() { Pointer= p0 };

            value.M_DropData                                = GetObject<DropData>(new IntPtr(p + 0x028), ReversePrism.DataModels.DropData.FromPointer); // 0x28 M_DropData                  ( ModelClassType DropData DropData DropData Pointer )
            value.M_TreeView                                = GetObject<BaseTreeView>(new IntPtr(p + 0x030), ReversePrism.DataModels.BaseTreeView.FromPointer); // 0x30 M_TreeView                  ( ModelClassType BaseTreeView BaseTreeView BaseTreeView Pointer )
            value.M_ExpandDropItemScheduledItem             = GetObject<IVisualElementScheduledItem>(new IntPtr(p + 0x038), ReversePrism.DataModels.IVisualElementScheduledItem.FromPointer); // 0x38 M_ExpandDropItemScheduledItem ( ModelClassType IVisualElementScheduledItem IVisualElementScheduledItem IVisualElementScheduledItem Pointer )
            value.M_ExpandDropItemCallback                  = GetObject<Action>(new IntPtr(p + 0x040), ReversePrism.DataModels.Action.FromPointer); // 0x40 M_ExpandDropItemCallback    ( ModelClassType Action Action Action Pointer )

            return value;
        }
    }
}
