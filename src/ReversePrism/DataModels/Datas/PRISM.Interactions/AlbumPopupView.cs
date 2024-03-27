using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TabGroup                                 0001866F5490 ModelClassType UITabGroup UITabGroup UITabGroup Pointer
    // 028 TabFixed                                 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 030 PIdolGridView                            0001867335D0 ModelClassType EnhancedCharacterSelectGridView EnhancedCharacterSelectGridView EnhancedCharacterSelectGridView Pointer
    // 038 SCharaGridView                           0001867335D0 ModelClassType EnhancedCharacterSelectGridView EnhancedCharacterSelectGridView EnhancedCharacterSelectGridView Pointer
    // 040 TxtPossess                               0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 BtnPIdolToggleOverlay                    0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 050 BtnSCharaToggleOverlay                   0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 058 TogglePIdol                              0001866876D0 ModelClassType ToggleSwitch ToggleSwitch ToggleSwitch Pointer
    // 060 ToggleSChara                             0001866876D0 ModelClassType ToggleSwitch ToggleSwitch ToggleSwitch Pointer
    // 068 onClick                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 070 onPIdolSelected                          Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 078 onSCharaSelected                         Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 080 PIdolDisposable                          0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 088 SCharaDisposable                         0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 090 Vm                                       0001866A02C0 ModelClassType AlbumViewModel AlbumViewModel AlbumViewModel Pointer
    // 098 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class AlbumPopupView
    {
        public UITabGroup?                              TabGroup                                { get; set; }
        public GameObject?                              TabFixed                                { get; set; }
        public EnhancedCharacterSelectGridView?         PIdolGridView                           { get; set; }
        public EnhancedCharacterSelectGridView?         SCharaGridView                          { get; set; }
        public UITextMeshProUGUI?                       TxtPossess                              { get; set; }
        public UIButton?                                BtnPIdolToggleOverlay                   { get; set; }
        public UIButton?                                BtnSCharaToggleOverlay                  { get; set; }
        public ToggleSwitch?                            TogglePIdol                             { get; set; }
        public ToggleSwitch?                            ToggleSChara                            { get; set; }
        public CompositeDisposable?                     PIdolDisposable                         { get; set; }
        public CompositeDisposable?                     SCharaDisposable                        { get; set; }
        public AlbumViewModel?                          Vm                                      { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static AlbumPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AlbumPopupView();

            value.TabGroup                                  = GetObject<UITabGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITabGroup.FromPointer); // 0270DA290E50 0x20 TabGroup                    ( 0001866F5490 ModelClassType UITabGroup UITabGroup UITabGroup Pointer )
            value.TabFixed                                  = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA290E70 0x28 TabFixed                    ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.PIdolGridView                             = GetObject<EnhancedCharacterSelectGridView>(new IntPtr(p + 0x030), ReversePrism.DataModels.EnhancedCharacterSelectGridView.FromPointer); // 0270DA290E90 0x30 PIdolGridView               ( 0001867335D0 ModelClassType EnhancedCharacterSelectGridView EnhancedCharacterSelectGridView EnhancedCharacterSelectGridView Pointer )
            value.SCharaGridView                            = GetObject<EnhancedCharacterSelectGridView>(new IntPtr(p + 0x038), ReversePrism.DataModels.EnhancedCharacterSelectGridView.FromPointer); // 0270DA290EB0 0x38 SCharaGridView              ( 0001867335D0 ModelClassType EnhancedCharacterSelectGridView EnhancedCharacterSelectGridView EnhancedCharacterSelectGridView Pointer )
            value.TxtPossess                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA290ED0 0x40 TxtPossess                  ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.BtnPIdolToggleOverlay                     = GetObject<UIButton>(new IntPtr(p + 0x048), ReversePrism.DataModels.UIButton.FromPointer); // 0270DA290EF0 0x48 BtnPIdolToggleOverlay       ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.BtnSCharaToggleOverlay                    = GetObject<UIButton>(new IntPtr(p + 0x050), ReversePrism.DataModels.UIButton.FromPointer); // 0270DA290F10 0x50 BtnSCharaToggleOverlay      ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.TogglePIdol                               = GetObject<ToggleSwitch>(new IntPtr(p + 0x058), ReversePrism.DataModels.ToggleSwitch.FromPointer); // 0270DA290F30 0x58 TogglePIdol                 ( 0001866876D0 ModelClassType ToggleSwitch ToggleSwitch ToggleSwitch Pointer )
            value.ToggleSChara                              = GetObject<ToggleSwitch>(new IntPtr(p + 0x060), ReversePrism.DataModels.ToggleSwitch.FromPointer); // 0270DA290F50 0x60 ToggleSChara                ( 0001866876D0 ModelClassType ToggleSwitch ToggleSwitch ToggleSwitch Pointer )
            value.PIdolDisposable                           = GetObject<CompositeDisposable>(new IntPtr(p + 0x080), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0270DA290FD0 0x80 PIdolDisposable             ( 0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.SCharaDisposable                          = GetObject<CompositeDisposable>(new IntPtr(p + 0x088), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0270DA290FF0 0x88 SCharaDisposable            ( 0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.Vm                                        = GetObject<AlbumViewModel>(new IntPtr(p + 0x090), ReversePrism.DataModels.AlbumViewModel.FromPointer); // 0270DA291010 0x90 Vm                          ( 0001866A02C0 ModelClassType AlbumViewModel AlbumViewModel AlbumViewModel Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x098), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0270DA291030 0x98 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
