using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TabGroup                                 0001866F5490 ModelClassType UITabGroup UITabGroup UITabGroup Pointer
    // 028 CostumeTabGroup                          0001866F5B90 ModelClassType UITabGroupEx UITabGroupEx UITabGroupEx Pointer
    // 030 SetGridView                              000186634D60 ModelClassType CostumeSetSelectGridView CostumeSetSelectGridView CostumeSetSelectGridView Pointer
    // 038 GridView                                 0001866320B0 ModelClassType CostumeSelectGridView CostumeSelectGridView CostumeSelectGridView Pointer
    // 040 TxtPossess                               0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 onClick                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 050 onCostumeDetail                          Subject`1<ValueTuple`2<CostumePartType, int>> IL2CPP_TYPE_GENERICINST
    // 058 Vm                                       00018662F240 ModelClassType CostumePopupViewModel CostumePopupViewModel CostumePopupViewModel Pointer
    // 060 Disposables                              0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 068 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class CostumePopupView
    {
        public UITabGroup?                              TabGroup                                { get; set; }
        public UITabGroupEx?                            CostumeTabGroup                         { get; set; }
        public CostumeSetSelectGridView?                SetGridView                             { get; set; }
        public CostumeSelectGridView?                   GridView                                { get; set; }
        public UITextMeshProUGUI?                       TxtPossess                              { get; set; }
        public CostumePopupViewModel?                   Vm                                      { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static CostumePopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CostumePopupView();

            value.TabGroup                                  = GetObject<UITabGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITabGroup.FromPointer); // 0270DA291988 0x20 TabGroup                    ( 0001866F5490 ModelClassType UITabGroup UITabGroup UITabGroup Pointer )
            value.CostumeTabGroup                           = GetObject<UITabGroupEx>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITabGroupEx.FromPointer); // 0270DA2919A8 0x28 CostumeTabGroup             ( 0001866F5B90 ModelClassType UITabGroupEx UITabGroupEx UITabGroupEx Pointer )
            value.SetGridView                               = GetObject<CostumeSetSelectGridView>(new IntPtr(p + 0x030), ReversePrism.DataModels.CostumeSetSelectGridView.FromPointer); // 0270DA2919C8 0x30 SetGridView                 ( 000186634D60 ModelClassType CostumeSetSelectGridView CostumeSetSelectGridView CostumeSetSelectGridView Pointer )
            value.GridView                                  = GetObject<CostumeSelectGridView>(new IntPtr(p + 0x038), ReversePrism.DataModels.CostumeSelectGridView.FromPointer); // 0270DA2919E8 0x38 GridView                    ( 0001866320B0 ModelClassType CostumeSelectGridView CostumeSelectGridView CostumeSelectGridView Pointer )
            value.TxtPossess                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA291A08 0x40 TxtPossess                  ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Vm                                        = GetObject<CostumePopupViewModel>(new IntPtr(p + 0x058), ReversePrism.DataModels.CostumePopupViewModel.FromPointer); // 0270DA291A68 0x58 Vm                          ( 00018662F240 ModelClassType CostumePopupViewModel CostumePopupViewModel CostumePopupViewModel Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x060), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0270DA291A88 0x60 Disposables                 ( 0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x068), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0270DA291AA8 0x68 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
