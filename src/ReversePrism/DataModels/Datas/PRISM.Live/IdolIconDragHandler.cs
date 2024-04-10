using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 ValidDragMinDistance                     float IL2CPP_TYPE_R4
    // 010 Icons                                    000185B91AB0 ModelClassListType LiveUnitEditCharacterIcon[] LiveUnitEditCharacterIcon[] List<LiveUnitEditCharacterIcon> Pointer
    // 018 IconParent                               0001866AADB0 ModelClassType Transform Transform Transform Pointer
    // 020 DragIcon                                 000186703B70 ModelClassType PFIdolIconRectView PFIdolIconRectView PFIdolIconRectView Pointer
    // 028 <OnSwapIconAsync>k__BackingField         Func`3<int, int, UniTask> IL2CPP_TYPE_GENERICINST
    // 030 <OnChangeDragStatus>k__BackingField      Action`1<bool> IL2CPP_TYPE_GENERICINST
    // 038 <IsDraggable>k__BackingField             Func`1<bool> IL2CPP_TYPE_GENERICINST
    public partial class IdolIconDragHandler : DataModel
    {
        public List<LiveUnitEditCharacterIcon>?         Icons                                   { get; set; }
        public Transform?                               IconParent                              { get; set; }
        public PFIdolIconRectView?                      DragIcon                                { get; set; }

        public static IdolIconDragHandler? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolIconDragHandler() { Pointer= p0 };

            value.Icons                                     = GetObjectList<LiveUnitEditCharacterIcon>(new IntPtr(p + 0x010), ReversePrism.DataModels.LiveUnitEditCharacterIcon.FromPointer); // 024665145C30 0x10 Icons                       ( 000185B91AB0 ModelClassListType LiveUnitEditCharacterIcon[] LiveUnitEditCharacterIcon[] List<LiveUnitEditCharacterIcon> Pointer )
            value.IconParent                                = GetObject<Transform>(new IntPtr(p + 0x018), ReversePrism.DataModels.Transform.FromPointer); // 024665145C50 0x18 IconParent                  ( 0001866AADB0 ModelClassType Transform Transform Transform Pointer )
            value.DragIcon                                  = GetObject<PFIdolIconRectView>(new IntPtr(p + 0x020), ReversePrism.DataModels.PFIdolIconRectView.FromPointer); // 024665145C70 0x20 DragIcon                    ( 000186703B70 ModelClassType PFIdolIconRectView PFIdolIconRectView PFIdolIconRectView Pointer )

            return value;
        }
    }
}
