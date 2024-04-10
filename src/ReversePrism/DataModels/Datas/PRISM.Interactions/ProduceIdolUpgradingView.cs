using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CharaColorBg                             0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 028 ImgFavorite                              000186613190 ModelClassType RawImage RawImage RawImage Pointer
    // 030 BtnFavorite                              0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 038 TabBadgeView                             0001866182E0 ModelClassType TabBadgeView TabBadgeView TabBadgeView Pointer
    // 040 TrPerformanceAreaParent                  0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 048 PerformanceFader                         000186732B30 ModelClassType PerformanceFader PerformanceFader PerformanceFader Pointer
    // 050 onFavoriteMark                           Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 058 AwakeningPerformanceObj                  0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 060 PiTrainingPerformanceObj                 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 068 ResourceTag                              00018661C960 ModelClassType IResourceTag IResourceTag IResourceTag Pointer
    public partial class ProduceIdolUpgradingView : DataModel
    {
        public UIImage?                                 CharaColorBg                            { get; set; }
        public RawImage?                                ImgFavorite                             { get; set; }
        public UIButton?                                BtnFavorite                             { get; set; }
        public TabBadgeView?                            TabBadgeView                            { get; set; }
        public Transform?                               TrPerformanceAreaParent                 { get; set; }
        public PerformanceFader?                        PerformanceFader                        { get; set; }
        public GameObject?                              AwakeningPerformanceObj                 { get; set; }
        public GameObject?                              PiTrainingPerformanceObj                { get; set; }
        public IResourceTag?                            ResourceTag                             { get; set; }

        public static ProduceIdolUpgradingView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceIdolUpgradingView() { Pointer= p0 };

            value.CharaColorBg                              = GetObject<UIImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIImage.FromPointer); // 02466A3C1108 0x20 CharaColorBg                ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.ImgFavorite                               = GetObject<RawImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.RawImage.FromPointer); // 02466A3C1128 0x28 ImgFavorite                 ( 000186613190 ModelClassType RawImage RawImage RawImage Pointer )
            value.BtnFavorite                               = GetObject<UIButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIButton.FromPointer); // 02466A3C1148 0x30 BtnFavorite                 ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.TabBadgeView                              = GetObject<TabBadgeView>(new IntPtr(p + 0x038), ReversePrism.DataModels.TabBadgeView.FromPointer); // 02466A3C1168 0x38 TabBadgeView                ( 0001866182E0 ModelClassType TabBadgeView TabBadgeView TabBadgeView Pointer )
            value.TrPerformanceAreaParent                   = GetObject<Transform>(new IntPtr(p + 0x040), ReversePrism.DataModels.Transform.FromPointer); // 02466A3C1188 0x40 TrPerformanceAreaParent     ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.PerformanceFader                          = GetObject<PerformanceFader>(new IntPtr(p + 0x048), ReversePrism.DataModels.PerformanceFader.FromPointer); // 02466A3C11A8 0x48 PerformanceFader            ( 000186732B30 ModelClassType PerformanceFader PerformanceFader PerformanceFader Pointer )
            value.AwakeningPerformanceObj                   = GetObject<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 02466A3C11E8 0x58 AwakeningPerformanceObj     ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.PiTrainingPerformanceObj                  = GetObject<GameObject>(new IntPtr(p + 0x060), ReversePrism.DataModels.GameObject.FromPointer); // 02466A3C1208 0x60 PiTrainingPerformanceObj    ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ResourceTag                               = GetObject<IResourceTag>(new IntPtr(p + 0x068), ReversePrism.DataModels.IResourceTag.FromPointer); // 02466A3C1228 0x68 ResourceTag                 ( 00018661C960 ModelClassType IResourceTag IResourceTag IResourceTag Pointer )

            return value;
        }
    }
}
