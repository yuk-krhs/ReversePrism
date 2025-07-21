using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CharaColorBg                             ModelClassType UIImage UIImage UIImage Pointer
    // 028 ImgFavorite                              ModelClassType RawImage RawImage RawImage Pointer
    // 030 BtnFavorite                              ModelClassType UIButton UIButton UIButton Pointer
    // 038 TabBadgeView                             ModelClassType TabBadgeView TabBadgeView TabBadgeView Pointer
    // 040 TrPerformanceAreaParent                  ModelClassType Transform Transform Transform Pointer
    // 048 PerformanceFader                         ModelClassType PerformanceFader PerformanceFader PerformanceFader Pointer
    // 050 onFavoriteMark                           Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 058 AwakeningPerformanceObj                  ModelClassType GameObject GameObject GameObject Pointer
    // 060 PiTrainingPerformanceObj                 ModelClassType GameObject GameObject GameObject Pointer
    public partial class LiveOnlyProduceIdolUpgradingView : DataModel
    {
        public UIImage?                                 CharaColorBg                            { get; set; }
        public RawImage?                                ImgFavorite                             { get; set; }
        public UIButton?                                BtnFavorite                             { get; set; }
        public TabBadgeView?                            TabBadgeView                            { get; set; }
        public Transform?                               TrPerformanceAreaParent                 { get; set; }
        public PerformanceFader?                        PerformanceFader                        { get; set; }
        public GameObject?                              AwakeningPerformanceObj                 { get; set; }
        public GameObject?                              PiTrainingPerformanceObj                { get; set; }

        public static LiveOnlyProduceIdolUpgradingView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveOnlyProduceIdolUpgradingView() { Pointer= p0 };

            value.CharaColorBg                              = GetObject<UIImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIImage.FromPointer); // 0x20 CharaColorBg                ( ModelClassType UIImage UIImage UIImage Pointer )
            value.ImgFavorite                               = GetObject<RawImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.RawImage.FromPointer); // 0x28 ImgFavorite                 ( ModelClassType RawImage RawImage RawImage Pointer )
            value.BtnFavorite                               = GetObject<UIButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIButton.FromPointer); // 0x30 BtnFavorite                 ( ModelClassType UIButton UIButton UIButton Pointer )
            value.TabBadgeView                              = GetObject<TabBadgeView>(new IntPtr(p + 0x038), ReversePrism.DataModels.TabBadgeView.FromPointer); // 0x38 TabBadgeView                ( ModelClassType TabBadgeView TabBadgeView TabBadgeView Pointer )
            value.TrPerformanceAreaParent                   = GetObject<Transform>(new IntPtr(p + 0x040), ReversePrism.DataModels.Transform.FromPointer); // 0x40 TrPerformanceAreaParent     ( ModelClassType Transform Transform Transform Pointer )
            value.PerformanceFader                          = GetObject<PerformanceFader>(new IntPtr(p + 0x048), ReversePrism.DataModels.PerformanceFader.FromPointer); // 0x48 PerformanceFader            ( ModelClassType PerformanceFader PerformanceFader PerformanceFader Pointer )
            value.AwakeningPerformanceObj                   = GetObject<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 0x58 AwakeningPerformanceObj     ( ModelClassType GameObject GameObject GameObject Pointer )
            value.PiTrainingPerformanceObj                  = GetObject<GameObject>(new IntPtr(p + 0x060), ReversePrism.DataModels.GameObject.FromPointer); // 0x60 PiTrainingPerformanceObj    ( ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
