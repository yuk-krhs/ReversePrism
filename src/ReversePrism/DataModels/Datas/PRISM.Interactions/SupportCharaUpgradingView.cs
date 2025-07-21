using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TabBadgeView                             ModelClassType TabBadgeView TabBadgeView TabBadgeView Pointer
    // 028 TrPerformanceAreaParent                  ModelClassType Transform Transform Transform Pointer
    // 030 PerformanceFader                         ModelClassType PerformanceFader PerformanceFader PerformanceFader Pointer
    // 038 MasterTrainingPerformanceObj             ModelClassType GameObject GameObject GameObject Pointer
    public partial class SupportCharaUpgradingView : DataModel
    {
        public TabBadgeView?                            TabBadgeView                            { get; set; }
        public Transform?                               TrPerformanceAreaParent                 { get; set; }
        public PerformanceFader?                        PerformanceFader                        { get; set; }
        public GameObject?                              MasterTrainingPerformanceObj            { get; set; }

        public static SupportCharaUpgradingView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SupportCharaUpgradingView() { Pointer= p0 };

            value.TabBadgeView                              = GetObject<TabBadgeView>(new IntPtr(p + 0x020), ReversePrism.DataModels.TabBadgeView.FromPointer); // 0x20 TabBadgeView                ( ModelClassType TabBadgeView TabBadgeView TabBadgeView Pointer )
            value.TrPerformanceAreaParent                   = GetObject<Transform>(new IntPtr(p + 0x028), ReversePrism.DataModels.Transform.FromPointer); // 0x28 TrPerformanceAreaParent     ( ModelClassType Transform Transform Transform Pointer )
            value.PerformanceFader                          = GetObject<PerformanceFader>(new IntPtr(p + 0x030), ReversePrism.DataModels.PerformanceFader.FromPointer); // 0x30 PerformanceFader            ( ModelClassType PerformanceFader PerformanceFader PerformanceFader Pointer )
            value.MasterTrainingPerformanceObj              = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0x38 MasterTrainingPerformanceObj ( ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
