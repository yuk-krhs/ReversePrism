using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TabGroup                                 ModelClassType UITabGroup UITabGroup UITabGroup Pointer
    // 028 CostumeTabGroup                          ModelClassType UITabGroupEx UITabGroupEx UITabGroupEx Pointer
    // 030 SetGridView                              ModelClassType CostumeSetSelectGridView CostumeSetSelectGridView CostumeSetSelectGridView Pointer
    // 038 GridView                                 ModelClassType CostumeSelectGridView CostumeSelectGridView CostumeSelectGridView Pointer
    // 040 TxtPossess                               ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 onClick                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 050 onCostumeDetail                          Subject`1<ValueTuple`2<CostumePartType, int>> IL2CPP_TYPE_GENERICINST
    // 058 Vm                                       ModelClassType CostumePopupViewModel CostumePopupViewModel CostumePopupViewModel Pointer
    // 060 Disposables                              ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 068 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class CostumePopupView : DataModel
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
            var value   = new CostumePopupView() { Pointer= p0 };

            value.TabGroup                                  = GetObject<UITabGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITabGroup.FromPointer); // 0x20 TabGroup                    ( ModelClassType UITabGroup UITabGroup UITabGroup Pointer )
            value.CostumeTabGroup                           = GetObject<UITabGroupEx>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITabGroupEx.FromPointer); // 0x28 CostumeTabGroup             ( ModelClassType UITabGroupEx UITabGroupEx UITabGroupEx Pointer )
            value.SetGridView                               = GetObject<CostumeSetSelectGridView>(new IntPtr(p + 0x030), ReversePrism.DataModels.CostumeSetSelectGridView.FromPointer); // 0x30 SetGridView                 ( ModelClassType CostumeSetSelectGridView CostumeSetSelectGridView CostumeSetSelectGridView Pointer )
            value.GridView                                  = GetObject<CostumeSelectGridView>(new IntPtr(p + 0x038), ReversePrism.DataModels.CostumeSelectGridView.FromPointer); // 0x38 GridView                    ( ModelClassType CostumeSelectGridView CostumeSelectGridView CostumeSelectGridView Pointer )
            value.TxtPossess                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x40 TxtPossess                  ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Vm                                        = GetObject<CostumePopupViewModel>(new IntPtr(p + 0x058), ReversePrism.DataModels.CostumePopupViewModel.FromPointer); // 0x58 Vm                          ( ModelClassType CostumePopupViewModel CostumePopupViewModel CostumePopupViewModel Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x060), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x60 Disposables                 ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x068), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x68 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
