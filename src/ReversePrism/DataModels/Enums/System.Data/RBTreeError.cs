using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum RBTreeError
    {
        InvalidPageSize,
        PagePositionInSlotInUse,
        NoFreeSlots,
        InvalidStateinInsert,
        InvalidNextSizeInDelete,
        InvalidStateinDelete,
        InvalidNodeSizeinDelete,
        InvalidStateinEndDelete,
        CannotRotateInvalidsuccessorNodeinDelete,
        IndexOutOFRangeinGetNodeByIndex,
        RBDeleteFixup,
        UnsupportedAccessMethod1,
        UnsupportedAccessMethod2,
        UnsupportedAccessMethodInNonNillRootSubtree,
        AttachedNodeWithZerorbTreeNodeId,
        CompareNodeInDataRowTree,
        CompareSateliteTreeNodeInDataRowTree,
        NestedSatelliteTreeEnumerator,
    }
}
