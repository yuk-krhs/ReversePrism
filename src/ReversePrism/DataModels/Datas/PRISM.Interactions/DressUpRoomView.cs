using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ChildViewParent                          0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 028 TopViewPrefab                            0001867031B0 ModelClassType DressUpRoomTopView DressUpRoomTopView DressUpRoomTopView Pointer
    // 030 CostumeChangeViewPrefab                  0001866FE980 ModelClassType DressUpRoomCostumeChangeView DressUpRoomCostumeChangeView DressUpRoomCostumeChangeView Pointer
    // 038 Curtain                                  0001866F45A0 ModelClassType ScreenTransitionCurtain ScreenTransitionCurtain ScreenTransitionCurtain Pointer
    // 040 CgIdolChangeFader                        000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 048 ChildView                                0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 050 ResourceTag                              00018661C960 ModelClassType IResourceTag IResourceTag IResourceTag Pointer
    public partial class DressUpRoomView : DataModel
    {
        public Transform?                               ChildViewParent                         { get; set; }
        public DressUpRoomTopView?                      TopViewPrefab                           { get; set; }
        public DressUpRoomCostumeChangeView?            CostumeChangeViewPrefab                 { get; set; }
        public ScreenTransitionCurtain?                 Curtain                                 { get; set; }
        public CanvasGroup?                             CgIdolChangeFader                       { get; set; }
        public GameObject?                              ChildView                               { get; set; }
        public IResourceTag?                            ResourceTag                             { get; set; }

        public static DressUpRoomView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DressUpRoomView() { Pointer= p0 };

            value.ChildViewParent                           = GetObject<Transform>(new IntPtr(p + 0x020), ReversePrism.DataModels.Transform.FromPointer); // 02466B6D1678 0x20 ChildViewParent             ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.TopViewPrefab                             = GetObject<DressUpRoomTopView>(new IntPtr(p + 0x028), ReversePrism.DataModels.DressUpRoomTopView.FromPointer); // 02466B6D1698 0x28 TopViewPrefab               ( 0001867031B0 ModelClassType DressUpRoomTopView DressUpRoomTopView DressUpRoomTopView Pointer )
            value.CostumeChangeViewPrefab                   = GetObject<DressUpRoomCostumeChangeView>(new IntPtr(p + 0x030), ReversePrism.DataModels.DressUpRoomCostumeChangeView.FromPointer); // 02466B6D16B8 0x30 CostumeChangeViewPrefab     ( 0001866FE980 ModelClassType DressUpRoomCostumeChangeView DressUpRoomCostumeChangeView DressUpRoomCostumeChangeView Pointer )
            value.Curtain                                   = GetObject<ScreenTransitionCurtain>(new IntPtr(p + 0x038), ReversePrism.DataModels.ScreenTransitionCurtain.FromPointer); // 02466B6D16D8 0x38 Curtain                     ( 0001866F45A0 ModelClassType ScreenTransitionCurtain ScreenTransitionCurtain ScreenTransitionCurtain Pointer )
            value.CgIdolChangeFader                         = GetObject<CanvasGroup>(new IntPtr(p + 0x040), ReversePrism.DataModels.CanvasGroup.FromPointer); // 02466B6D16F8 0x40 CgIdolChangeFader           ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.ChildView                                 = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 02466B6D1718 0x48 ChildView                   ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ResourceTag                               = GetObject<IResourceTag>(new IntPtr(p + 0x050), ReversePrism.DataModels.IResourceTag.FromPointer); // 02466B6D1738 0x50 ResourceTag                 ( 00018661C960 ModelClassType IResourceTag IResourceTag IResourceTag Pointer )

            return value;
        }
    }
}
