using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 PinPanelView                             000186583BF0 ModelClassType ChallengeTourStagePinPanelView ChallengeTourStagePinPanelView ChallengeTourStagePinPanelView Pointer
    // 040 ClearObject                              0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 048 Animator                                 0001866B8DE0 ModelClassType Animator Animator Animator Pointer
    public partial class ChallengeTourStageListViewCell
    {
        public ChallengeTourStagePinPanelView?          PinPanelView                            { get; set; }
        public GameObject?                              ClearObject                             { get; set; }
        public Animator?                                Animator                                { get; set; }

        public static ChallengeTourStageListViewCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourStageListViewCell();

            value.PinPanelView                              = GetObject<ChallengeTourStagePinPanelView>(new IntPtr(p + 0x038), ReversePrism.DataModels.ChallengeTourStagePinPanelView.FromPointer); // 0270DA1CCBD0 0x38 PinPanelView                ( 000186583BF0 ModelClassType ChallengeTourStagePinPanelView ChallengeTourStagePinPanelView ChallengeTourStagePinPanelView Pointer )
            value.ClearObject                               = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA1CCBF0 0x40 ClearObject                 ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.Animator                                  = GetObject<Animator>(new IntPtr(p + 0x048), ReversePrism.DataModels.Animator.FromPointer); // 0270DA1CCC10 0x48 Animator                    ( 0001866B8DE0 ModelClassType Animator Animator Animator Pointer )

            return value;
        }
    }
}
