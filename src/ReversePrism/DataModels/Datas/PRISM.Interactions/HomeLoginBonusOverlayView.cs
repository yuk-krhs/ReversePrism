using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 PanelMoveSpeed                           float IL2CPP_TYPE_R4
    // 020 PanelRootObject                          0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 028 CanvasGroup                              000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 030 panelViews                               SerializableInterface`1<IHomeLoginBonusPanelView>[] IL2CPP_TYPE_SZARRAY
    // 038 TransitionView                           0001866D2A50 ModelClassType HomeTransitionView HomeTransitionView HomeTransitionView Pointer
    // 040 DefaultPosition                          0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 050 Sequence                                 0001867264E0 ModelClassType Sequence Sequence Sequence Pointer
    // 058 ResourceTag                              00018661C960 ModelClassType IResourceTag IResourceTag IResourceTag Pointer
    public partial class HomeLoginBonusOverlayView
    {
        public GameObject?                              PanelRootObject                         { get; set; }
        public CanvasGroup?                             CanvasGroup                             { get; set; }
        public HomeTransitionView?                      TransitionView                          { get; set; }
        public Vector3                                  DefaultPosition                         { get; set; }
        public Sequence?                                Sequence                                { get; set; }
        public IResourceTag?                            ResourceTag                             { get; set; }

        public static HomeLoginBonusOverlayView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HomeLoginBonusOverlayView();

            value.PanelRootObject                           = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0270DB509348 0x20 PanelRootObject             ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x028), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0270DB509368 0x28 CanvasGroup                 ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.TransitionView                            = GetObject<HomeTransitionView>(new IntPtr(p + 0x038), ReversePrism.DataModels.HomeTransitionView.FromPointer); // 0270DB5093A8 0x38 TransitionView              ( 0001866D2A50 ModelClassType HomeTransitionView HomeTransitionView HomeTransitionView Pointer )
            value.DefaultPosition                           = (Vector3)GetInt32(new IntPtr(p + 0x040)); // 0270DB5093C8 0x40 DefaultPosition             ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.Sequence                                  = GetObject<Sequence>(new IntPtr(p + 0x050), ReversePrism.DataModels.Sequence.FromPointer); // 0270DB5093E8 0x50 Sequence                    ( 0001867264E0 ModelClassType Sequence Sequence Sequence Pointer )
            value.ResourceTag                               = GetObject<IResourceTag>(new IntPtr(p + 0x058), ReversePrism.DataModels.IResourceTag.FromPointer); // 0270DB509408 0x58 ResourceTag                 ( 00018661C960 ModelClassType IResourceTag IResourceTag IResourceTag Pointer )

            return value;
        }
    }
}
