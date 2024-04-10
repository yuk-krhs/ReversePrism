using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TabBadgeView                             0001866182E0 ModelClassType TabBadgeView TabBadgeView TabBadgeView Pointer
    // 028 TrPerformanceAreaParent                  0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 030 PerformanceFader                         000186732B30 ModelClassType PerformanceFader PerformanceFader PerformanceFader Pointer
    // 038 MasterTrainingPerformanceObj             0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 040 ResourceTag                              00018661C960 ModelClassType IResourceTag IResourceTag IResourceTag Pointer
    public partial class SupportCharaUpgradingView : DataModel
    {
        public TabBadgeView?                            TabBadgeView                            { get; set; }
        public Transform?                               TrPerformanceAreaParent                 { get; set; }
        public PerformanceFader?                        PerformanceFader                        { get; set; }
        public GameObject?                              MasterTrainingPerformanceObj            { get; set; }
        public IResourceTag?                            ResourceTag                             { get; set; }

        public static SupportCharaUpgradingView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SupportCharaUpgradingView() { Pointer= p0 };

            value.TabBadgeView                              = GetObject<TabBadgeView>(new IntPtr(p + 0x020), ReversePrism.DataModels.TabBadgeView.FromPointer); // 02466A3C7EB0 0x20 TabBadgeView                ( 0001866182E0 ModelClassType TabBadgeView TabBadgeView TabBadgeView Pointer )
            value.TrPerformanceAreaParent                   = GetObject<Transform>(new IntPtr(p + 0x028), ReversePrism.DataModels.Transform.FromPointer); // 02466A3C7ED0 0x28 TrPerformanceAreaParent     ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.PerformanceFader                          = GetObject<PerformanceFader>(new IntPtr(p + 0x030), ReversePrism.DataModels.PerformanceFader.FromPointer); // 02466A3C7EF0 0x30 PerformanceFader            ( 000186732B30 ModelClassType PerformanceFader PerformanceFader PerformanceFader Pointer )
            value.MasterTrainingPerformanceObj              = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 02466A3C7F10 0x38 MasterTrainingPerformanceObj ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ResourceTag                               = GetObject<IResourceTag>(new IntPtr(p + 0x040), ReversePrism.DataModels.IResourceTag.FromPointer); // 02466A3C7F30 0x40 ResourceTag                 ( 00018661C960 ModelClassType IResourceTag IResourceTag IResourceTag Pointer )

            return value;
        }
    }
}
