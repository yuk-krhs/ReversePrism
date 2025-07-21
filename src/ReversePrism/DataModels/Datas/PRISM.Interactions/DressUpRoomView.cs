using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ChildViewParent                          ModelClassType Transform Transform Transform Pointer
    // 028 TopViewPrefab                            ModelClassType DressUpRoomTopView DressUpRoomTopView DressUpRoomTopView Pointer
    // 030 CostumeChangeViewPrefab                  ModelClassType DressUpRoomCostumeChangeView DressUpRoomCostumeChangeView DressUpRoomCostumeChangeView Pointer
    // 038 Curtain                                  ModelClassType ScreenTransitionCurtain ScreenTransitionCurtain ScreenTransitionCurtain Pointer
    // 040 CgIdolChangeFader                        ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 048 ChildView                                ModelClassType GameObject GameObject GameObject Pointer
    public partial class DressUpRoomView : DataModel
    {
        public Transform?                               ChildViewParent                         { get; set; }
        public DressUpRoomTopView?                      TopViewPrefab                           { get; set; }
        public DressUpRoomCostumeChangeView?            CostumeChangeViewPrefab                 { get; set; }
        public ScreenTransitionCurtain?                 Curtain                                 { get; set; }
        public CanvasGroup?                             CgIdolChangeFader                       { get; set; }
        public GameObject?                              ChildView                               { get; set; }

        public static DressUpRoomView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DressUpRoomView() { Pointer= p0 };

            value.ChildViewParent                           = GetObject<Transform>(new IntPtr(p + 0x020), ReversePrism.DataModels.Transform.FromPointer); // 0x20 ChildViewParent             ( ModelClassType Transform Transform Transform Pointer )
            value.TopViewPrefab                             = GetObject<DressUpRoomTopView>(new IntPtr(p + 0x028), ReversePrism.DataModels.DressUpRoomTopView.FromPointer); // 0x28 TopViewPrefab               ( ModelClassType DressUpRoomTopView DressUpRoomTopView DressUpRoomTopView Pointer )
            value.CostumeChangeViewPrefab                   = GetObject<DressUpRoomCostumeChangeView>(new IntPtr(p + 0x030), ReversePrism.DataModels.DressUpRoomCostumeChangeView.FromPointer); // 0x30 CostumeChangeViewPrefab     ( ModelClassType DressUpRoomCostumeChangeView DressUpRoomCostumeChangeView DressUpRoomCostumeChangeView Pointer )
            value.Curtain                                   = GetObject<ScreenTransitionCurtain>(new IntPtr(p + 0x038), ReversePrism.DataModels.ScreenTransitionCurtain.FromPointer); // 0x38 Curtain                     ( ModelClassType ScreenTransitionCurtain ScreenTransitionCurtain ScreenTransitionCurtain Pointer )
            value.CgIdolChangeFader                         = GetObject<CanvasGroup>(new IntPtr(p + 0x040), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x40 CgIdolChangeFader           ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.ChildView                                 = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0x48 ChildView                   ( ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
