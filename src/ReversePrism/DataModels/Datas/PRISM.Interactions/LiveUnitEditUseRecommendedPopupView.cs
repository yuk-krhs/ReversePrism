using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 UnitToggleButtonGroup                    ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer
    // 028 PrioritizedStatusToggleButtonGroup       ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer
    // 030 MvOriginalMember                         ModelClassType GameObject GameObject GameObject Pointer
    // 038 onClick                                  Subject`1<ValueTuple`3<bool, LiveUnitEditUnitType, LiveUnitEditPrioritizedStatusType>> IL2CPP_TYPE_GENERICINST
    // 040 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class LiveUnitEditUseRecommendedPopupView : DataModel
    {
        public ToggleButtonGroup?                       UnitToggleButtonGroup                   { get; set; }
        public ToggleButtonGroup?                       PrioritizedStatusToggleButtonGroup      { get; set; }
        public GameObject?                              MvOriginalMember                        { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static LiveUnitEditUseRecommendedPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveUnitEditUseRecommendedPopupView() { Pointer= p0 };

            value.UnitToggleButtonGroup                     = GetObject<ToggleButtonGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.ToggleButtonGroup.FromPointer); // 0x20 UnitToggleButtonGroup       ( ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer )
            value.PrioritizedStatusToggleButtonGroup        = GetObject<ToggleButtonGroup>(new IntPtr(p + 0x028), ReversePrism.DataModels.ToggleButtonGroup.FromPointer); // 0x28 PrioritizedStatusToggleButtonGroup ( ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer )
            value.MvOriginalMember                          = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0x30 MvOriginalMember            ( ModelClassType GameObject GameObject GameObject Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x040), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x40 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
