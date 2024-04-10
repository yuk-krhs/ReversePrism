using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CanvasGroup                              000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 028 GoMemberPrefab                           00018670EBE0 ModelClassType UnitMemberView UnitMemberView UnitMemberView Pointer
    // 030 GoSeparator                              0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 038 TrMembersParent                          000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 040 onFIdolDetail                            Subject`1<string> IL2CPP_TYPE_GENERICINST
    // 048 onLiveSkillDetail                        Subject`1<LiveSkillViewModel> IL2CPP_TYPE_GENERICINST
    public partial class FUnitDetailIdolView : DataModel
    {
        public CanvasGroup?                             CanvasGroup                             { get; set; }
        public UnitMemberView?                          GoMemberPrefab                          { get; set; }
        public GameObject?                              GoSeparator                             { get; set; }
        public RectTransform?                           TrMembersParent                         { get; set; }

        public static FUnitDetailIdolView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FUnitDetailIdolView() { Pointer= p0 };

            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.CanvasGroup.FromPointer); // 02466A3195B0 0x20 CanvasGroup                 ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.GoMemberPrefab                            = GetObject<UnitMemberView>(new IntPtr(p + 0x028), ReversePrism.DataModels.UnitMemberView.FromPointer); // 02466A3195D0 0x28 GoMemberPrefab              ( 00018670EBE0 ModelClassType UnitMemberView UnitMemberView UnitMemberView Pointer )
            value.GoSeparator                               = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 02466A3195F0 0x30 GoSeparator                 ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.TrMembersParent                           = GetObject<RectTransform>(new IntPtr(p + 0x038), ReversePrism.DataModels.RectTransform.FromPointer); // 02466A319610 0x38 TrMembersParent             ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )

            return value;
        }
    }
}
