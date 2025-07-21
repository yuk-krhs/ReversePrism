using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 RewardItemIcon                           ModelClassType RewardItemIcon RewardItemIcon RewardItemIcon Pointer
    // 028 GaugePointIcon                           ModelClassType GameObject GameObject GameObject Pointer
    // 030 GaugePointButton                         ModelClassType UIButton UIButton UIButton Pointer
    // 038 GaugePointText                           ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 Disposable                               ModelClassType IDisposable IDisposable IDisposable Pointer
    // 048 onClickGaugePointDetail                  Subject`1<ValueTuple`2<int, int>> IL2CPP_TYPE_GENERICINST
    public partial class MissionListRewardItemIcon : DataModel
    {
        public RewardItemIcon?                          RewardItemIcon                          { get; set; }
        public GameObject?                              GaugePointIcon                          { get; set; }
        public UIButton?                                GaugePointButton                        { get; set; }
        public UITextMeshProUGUI?                       GaugePointText                          { get; set; }
        public IDisposable?                             Disposable                              { get; set; }

        public static MissionListRewardItemIcon? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MissionListRewardItemIcon() { Pointer= p0 };

            value.RewardItemIcon                            = GetObject<RewardItemIcon>(new IntPtr(p + 0x020), ReversePrism.DataModels.RewardItemIcon.FromPointer); // 0x20 RewardItemIcon              ( ModelClassType RewardItemIcon RewardItemIcon RewardItemIcon Pointer )
            value.GaugePointIcon                            = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0x28 GaugePointIcon              ( ModelClassType GameObject GameObject GameObject Pointer )
            value.GaugePointButton                          = GetObject<UIButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIButton.FromPointer); // 0x30 GaugePointButton            ( ModelClassType UIButton UIButton UIButton Pointer )
            value.GaugePointText                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x38 GaugePointText              ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Disposable                                = GetObject<IDisposable>(new IntPtr(p + 0x040), ReversePrism.DataModels.IDisposable.FromPointer); // 0x40 Disposable                  ( ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
