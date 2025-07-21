using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 PinPanelView                             ModelClassType ChallengeTourStagePinPanelView ChallengeTourStagePinPanelView ChallengeTourStagePinPanelView Pointer
    // 040 ClearObject                              ModelClassType GameObject GameObject GameObject Pointer
    // 048 Animator                                 ModelClassType Animator Animator Animator Pointer
    public partial class ChallengeTourStageListViewCell : DataModel
    {
        public ChallengeTourStagePinPanelView?          PinPanelView                            { get; set; }
        public GameObject?                              ClearObject                             { get; set; }
        public Animator?                                Animator                                { get; set; }

        public static ChallengeTourStageListViewCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourStageListViewCell() { Pointer= p0 };

            value.PinPanelView                              = GetObject<ChallengeTourStagePinPanelView>(new IntPtr(p + 0x038), ReversePrism.DataModels.ChallengeTourStagePinPanelView.FromPointer); // 0x38 PinPanelView                ( ModelClassType ChallengeTourStagePinPanelView ChallengeTourStagePinPanelView ChallengeTourStagePinPanelView Pointer )
            value.ClearObject                               = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0x40 ClearObject                 ( ModelClassType GameObject GameObject GameObject Pointer )
            value.Animator                                  = GetObject<Animator>(new IntPtr(p + 0x048), ReversePrism.DataModels.Animator.FromPointer); // 0x48 Animator                    ( ModelClassType Animator Animator Animator Pointer )

            return value;
        }
    }
}
