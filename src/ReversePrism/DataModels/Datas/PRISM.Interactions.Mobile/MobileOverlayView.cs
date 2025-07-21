using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 MobilePuDeviceIn                         ModelPrimitiveType int int int Int32
    // 024 MobilePuDeviceInSkip                     ModelPrimitiveType int int int Int32
    // 028 MobilePuDeviceOut                        ModelPrimitiveType int int int Int32
    // 02C MobilePuDeviceOutSkip                    ModelPrimitiveType int int int Int32
    // 030 Animator                                 ModelClassType Animator Animator Animator Pointer
    // 038 OverlayTitleBody                         ModelClassType GameObject GameObject GameObject Pointer
    // 040 OverlayTitleText                         ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 LoadingScreen                            ModelClassType MobileLoadingScreen MobileLoadingScreen MobileLoadingScreen Pointer
    // 050 UiParent                                 ModelClassType GameObject GameObject GameObject Pointer
    // 058 BackButton                               ModelClassType UIButton UIButton UIButton Pointer
    // 060 HeaderBackButtonSimple                   ModelClassType UIButton UIButton UIButton Pointer
    // 068 HeaderBackButtonWithBg                   ModelClassType UIButton UIButton UIButton Pointer
    // 070 CanselButton                             ModelClassType UIButton UIButton UIButton Pointer
    // 078 MobileMenu                               ModelClassType MobileMenu MobileMenu MobileMenu Pointer
    // 080 OurStreamTabGroup                        ModelClassType OurStreamTabGroup OurStreamTabGroup OurStreamTabGroup Pointer
    // 088 HowToPlayOurStreamButton                 ModelClassType UIButton UIButton UIButton Pointer
    // 090 StandbyScreenView                        ModelClassType MobileStandbyScreenView MobileStandbyScreenView MobileStandbyScreenView Pointer
    // 098 ScreenConnectorView                      ModelClassType MobileScreenConnectorView MobileScreenConnectorView MobileScreenConnectorView Pointer
    // 0A0 onCloseRequested                         Subject`1<MobileOverlayResult> IL2CPP_TYPE_GENERICINST
    // 0A8 ViewModel                                ModelClassType MobileOverlayViewModel MobileOverlayViewModel MobileOverlayViewModel Pointer
    // 0B0 onHideAsyncFunc                          Func`1<UniTask> IL2CPP_TYPE_GENERICINST
    public partial class MobileOverlayView : DataModel
    {
        public int                                      MobilePuDeviceIn                        { get; set; }
        public int                                      MobilePuDeviceInSkip                    { get; set; }
        public int                                      MobilePuDeviceOut                       { get; set; }
        public int                                      MobilePuDeviceOutSkip                   { get; set; }
        public Animator?                                Animator                                { get; set; }
        public GameObject?                              OverlayTitleBody                        { get; set; }
        public UITextMeshProUGUI?                       OverlayTitleText                        { get; set; }
        public MobileLoadingScreen?                     LoadingScreen                           { get; set; }
        public GameObject?                              UiParent                                { get; set; }
        public UIButton?                                BackButton                              { get; set; }
        public UIButton?                                HeaderBackButtonSimple                  { get; set; }
        public UIButton?                                HeaderBackButtonWithBg                  { get; set; }
        public UIButton?                                CanselButton                            { get; set; }
        public MobileMenu?                              MobileMenu                              { get; set; }
        public OurStreamTabGroup?                       OurStreamTabGroup                       { get; set; }
        public UIButton?                                HowToPlayOurStreamButton                { get; set; }
        public MobileStandbyScreenView?                 StandbyScreenView                       { get; set; }
        public MobileScreenConnectorView?               ScreenConnectorView                     { get; set; }
        public MobileOverlayViewModel?                  ViewModel                               { get; set; }

        public static MobileOverlayView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MobileOverlayView() { Pointer= p0 };

            value.MobilePuDeviceIn                          = GetInt32(new IntPtr(p + 0x020)); // 0x20 MobilePuDeviceIn            ( ModelPrimitiveType int int int Int32 )
            value.MobilePuDeviceInSkip                      = GetInt32(new IntPtr(p + 0x024)); // 0x24 MobilePuDeviceInSkip        ( ModelPrimitiveType int int int Int32 )
            value.MobilePuDeviceOut                         = GetInt32(new IntPtr(p + 0x028)); // 0x28 MobilePuDeviceOut           ( ModelPrimitiveType int int int Int32 )
            value.MobilePuDeviceOutSkip                     = GetInt32(new IntPtr(p + 0x02C)); // 0x2C MobilePuDeviceOutSkip       ( ModelPrimitiveType int int int Int32 )
            value.Animator                                  = GetObject<Animator>(new IntPtr(p + 0x030), ReversePrism.DataModels.Animator.FromPointer); // 0x30 Animator                    ( ModelClassType Animator Animator Animator Pointer )
            value.OverlayTitleBody                          = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0x38 OverlayTitleBody            ( ModelClassType GameObject GameObject GameObject Pointer )
            value.OverlayTitleText                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x40 OverlayTitleText            ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.LoadingScreen                             = GetObject<MobileLoadingScreen>(new IntPtr(p + 0x048), ReversePrism.DataModels.MobileLoadingScreen.FromPointer); // 0x48 LoadingScreen               ( ModelClassType MobileLoadingScreen MobileLoadingScreen MobileLoadingScreen Pointer )
            value.UiParent                                  = GetObject<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 0x50 UiParent                    ( ModelClassType GameObject GameObject GameObject Pointer )
            value.BackButton                                = GetObject<UIButton>(new IntPtr(p + 0x058), ReversePrism.DataModels.UIButton.FromPointer); // 0x58 BackButton                  ( ModelClassType UIButton UIButton UIButton Pointer )
            value.HeaderBackButtonSimple                    = GetObject<UIButton>(new IntPtr(p + 0x060), ReversePrism.DataModels.UIButton.FromPointer); // 0x60 HeaderBackButtonSimple      ( ModelClassType UIButton UIButton UIButton Pointer )
            value.HeaderBackButtonWithBg                    = GetObject<UIButton>(new IntPtr(p + 0x068), ReversePrism.DataModels.UIButton.FromPointer); // 0x68 HeaderBackButtonWithBg      ( ModelClassType UIButton UIButton UIButton Pointer )
            value.CanselButton                              = GetObject<UIButton>(new IntPtr(p + 0x070), ReversePrism.DataModels.UIButton.FromPointer); // 0x70 CanselButton                ( ModelClassType UIButton UIButton UIButton Pointer )
            value.MobileMenu                                = GetObject<MobileMenu>(new IntPtr(p + 0x078), ReversePrism.DataModels.MobileMenu.FromPointer); // 0x78 MobileMenu                  ( ModelClassType MobileMenu MobileMenu MobileMenu Pointer )
            value.OurStreamTabGroup                         = GetObject<OurStreamTabGroup>(new IntPtr(p + 0x080), ReversePrism.DataModels.OurStreamTabGroup.FromPointer); // 0x80 OurStreamTabGroup           ( ModelClassType OurStreamTabGroup OurStreamTabGroup OurStreamTabGroup Pointer )
            value.HowToPlayOurStreamButton                  = GetObject<UIButton>(new IntPtr(p + 0x088), ReversePrism.DataModels.UIButton.FromPointer); // 0x88 HowToPlayOurStreamButton    ( ModelClassType UIButton UIButton UIButton Pointer )
            value.StandbyScreenView                         = GetObject<MobileStandbyScreenView>(new IntPtr(p + 0x090), ReversePrism.DataModels.MobileStandbyScreenView.FromPointer); // 0x90 StandbyScreenView           ( ModelClassType MobileStandbyScreenView MobileStandbyScreenView MobileStandbyScreenView Pointer )
            value.ScreenConnectorView                       = GetObject<MobileScreenConnectorView>(new IntPtr(p + 0x098), ReversePrism.DataModels.MobileScreenConnectorView.FromPointer); // 0x98 ScreenConnectorView         ( ModelClassType MobileScreenConnectorView MobileScreenConnectorView MobileScreenConnectorView Pointer )
            value.ViewModel                                 = GetObject<MobileOverlayViewModel>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.MobileOverlayViewModel.FromPointer); // 0xA8 ViewModel                   ( ModelClassType MobileOverlayViewModel MobileOverlayViewModel MobileOverlayViewModel Pointer )

            return value;
        }
    }
}
