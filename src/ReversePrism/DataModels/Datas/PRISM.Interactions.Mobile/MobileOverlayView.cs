using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 MobilePuDeviceIn                         0001865F4260 ModelPrimitiveType int int int Int32
    // 024 MobilePuDeviceInSkip                     0001865F4260 ModelPrimitiveType int int int Int32
    // 028 MobilePuDeviceOut                        0001865F4260 ModelPrimitiveType int int int Int32
    // 02C MobilePuDeviceOutSkip                    0001865F4260 ModelPrimitiveType int int int Int32
    // 030 Animator                                 0001866B8DE0 ModelClassType Animator Animator Animator Pointer
    // 038 screenConnectorBuilder                   SerializableInterface`1<IMobileScreenConnectorBuilder> IL2CPP_TYPE_GENERICINST
    // 040 standbyScreenBuilder                     SerializableInterface`1<IMobileStandbyScreenBuilder> IL2CPP_TYPE_GENERICINST
    // 048 OverlayTitleBody                         0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 050 OverlayTitleText                         0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 LoadingScreen                            00018662E3F0 ModelClassType MobileLoadingScreen MobileLoadingScreen MobileLoadingScreen Pointer
    // 060 UiParent                                 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 068 BackButton                               0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 070 CanselButton                             0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 078 MobileMenu                               00018662E8A0 ModelClassType MobileMenu MobileMenu MobileMenu Pointer
    // 080 OurStreamTabGroup                        0001866F82E0 ModelClassType OurStreamTabGroup OurStreamTabGroup OurStreamTabGroup Pointer
    // 088 BackKeyDisposable                        0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
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
        public UIButton?                                CanselButton                            { get; set; }
        public MobileMenu?                              MobileMenu                              { get; set; }
        public OurStreamTabGroup?                       OurStreamTabGroup                       { get; set; }
        public IDisposable?                             BackKeyDisposable                       { get; set; }

        public static MobileOverlayView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MobileOverlayView() { Pointer= p0 };

            value.MobilePuDeviceIn                          = GetInt32(new IntPtr(p + 0x020)); // 02466B1BEDE0 0x20 MobilePuDeviceIn            ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.MobilePuDeviceInSkip                      = GetInt32(new IntPtr(p + 0x024)); // 02466B1BEE00 0x24 MobilePuDeviceInSkip        ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.MobilePuDeviceOut                         = GetInt32(new IntPtr(p + 0x028)); // 02466B1BEE20 0x28 MobilePuDeviceOut           ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.MobilePuDeviceOutSkip                     = GetInt32(new IntPtr(p + 0x02C)); // 02466B1BEE40 0x2C MobilePuDeviceOutSkip       ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Animator                                  = GetObject<Animator>(new IntPtr(p + 0x030), ReversePrism.DataModels.Animator.FromPointer); // 02466B1BEE60 0x30 Animator                    ( 0001866B8DE0 ModelClassType Animator Animator Animator Pointer )
            value.OverlayTitleBody                          = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 02466B1BEEC0 0x48 OverlayTitleBody            ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.OverlayTitleText                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B1BEEE0 0x50 OverlayTitleText            ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.LoadingScreen                             = GetObject<MobileLoadingScreen>(new IntPtr(p + 0x058), ReversePrism.DataModels.MobileLoadingScreen.FromPointer); // 02466B1BEF00 0x58 LoadingScreen               ( 00018662E3F0 ModelClassType MobileLoadingScreen MobileLoadingScreen MobileLoadingScreen Pointer )
            value.UiParent                                  = GetObject<GameObject>(new IntPtr(p + 0x060), ReversePrism.DataModels.GameObject.FromPointer); // 02466B1BEF20 0x60 UiParent                    ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.BackButton                                = GetObject<UIButton>(new IntPtr(p + 0x068), ReversePrism.DataModels.UIButton.FromPointer); // 02466B1BEF40 0x68 BackButton                  ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.CanselButton                              = GetObject<UIButton>(new IntPtr(p + 0x070), ReversePrism.DataModels.UIButton.FromPointer); // 02466B1BEF60 0x70 CanselButton                ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.MobileMenu                                = GetObject<MobileMenu>(new IntPtr(p + 0x078), ReversePrism.DataModels.MobileMenu.FromPointer); // 02466B1BEF80 0x78 MobileMenu                  ( 00018662E8A0 ModelClassType MobileMenu MobileMenu MobileMenu Pointer )
            value.OurStreamTabGroup                         = GetObject<OurStreamTabGroup>(new IntPtr(p + 0x080), ReversePrism.DataModels.OurStreamTabGroup.FromPointer); // 02466B1BEFA0 0x80 OurStreamTabGroup           ( 0001866F82E0 ModelClassType OurStreamTabGroup OurStreamTabGroup OurStreamTabGroup Pointer )
            value.BackKeyDisposable                         = GetObject<IDisposable>(new IntPtr(p + 0x088), ReversePrism.DataModels.IDisposable.FromPointer); // 02466B1BEFC0 0x88 BackKeyDisposable           ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
