using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 PanelMoveSpeed                           float IL2CPP_TYPE_R4
    // 020 PanelRootObject                          ModelClassType GameObject GameObject GameObject Pointer
    // 028 CanvasGroup                              ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 030 panelViews                               SerializableInterface`1<IHomeLoginBonusPanelView>[] IL2CPP_TYPE_SZARRAY
    // 038 TransitionView                           ModelClassType HomeTransitionView HomeTransitionView HomeTransitionView Pointer
    // 040 DefaultPosition                          ModelEnumType Vector3 Vector3 Vector3 Int32
    // 050 Sequence                                 ModelClassType Sequence Sequence Sequence Pointer
    public partial class HomeLoginBonusOverlayView : DataModel
    {
        public GameObject?                              PanelRootObject                         { get; set; }
        public CanvasGroup?                             CanvasGroup                             { get; set; }
        public HomeTransitionView?                      TransitionView                          { get; set; }
        public Vector3                                  DefaultPosition                         { get; set; }
        public Sequence?                                Sequence                                { get; set; }

        public static HomeLoginBonusOverlayView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HomeLoginBonusOverlayView() { Pointer= p0 };

            value.PanelRootObject                           = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0x20 PanelRootObject             ( ModelClassType GameObject GameObject GameObject Pointer )
            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x028), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x28 CanvasGroup                 ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.TransitionView                            = GetObject<HomeTransitionView>(new IntPtr(p + 0x038), ReversePrism.DataModels.HomeTransitionView.FromPointer); // 0x38 TransitionView              ( ModelClassType HomeTransitionView HomeTransitionView HomeTransitionView Pointer )
            value.DefaultPosition                           = (Vector3)GetInt32(new IntPtr(p + 0x040)); // 0x40 DefaultPosition             ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.Sequence                                  = GetObject<Sequence>(new IntPtr(p + 0x050), ReversePrism.DataModels.Sequence.FromPointer); // 0x50 Sequence                    ( ModelClassType Sequence Sequence Sequence Pointer )

            return value;
        }
    }
}
