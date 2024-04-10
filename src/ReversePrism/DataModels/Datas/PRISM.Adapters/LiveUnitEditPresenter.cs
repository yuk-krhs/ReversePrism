using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Argument                                 00018658D5D0 ModelClassType LiveUnitEditArgument LiveUnitEditArgument LiveUnitEditArgument Pointer
    // 018 View                                     00018659D1B0 ModelClassType ILiveUnitEditView ILiveUnitEditView ILiveUnitEditView Pointer
    // 020 UnitListWindowView                       00018668A680 ModelClassType IUnitListWindowView IUnitListWindowView IUnitListWindowView Pointer
    // 028 TitleView                                0001865EA1D0 ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer
    // 030 permanentDataPackage                     SavableJsonObject`1<LiveUnitEditPermanentData> IL2CPP_TYPE_GENERICINST
    // 038 Cts                                      0001865A4380 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 040 Disposables                              0001865F38F0 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 048 Vm                                       000186592340 ModelClassType LiveUnitEditViewModel LiveUnitEditViewModel LiveUnitEditViewModel Pointer
    // 050 IsEvent                                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 058 useRecommendedPopupViewFactory           IPopupViewFactory`1<ILiveUnitEditUseRecommendedPopupView> IL2CPP_TYPE_GENERICINST
    public partial class LiveUnitEditPresenter : DataModel
    {
        public LiveUnitEditArgument?                    Argument                                { get; set; }
        public ILiveUnitEditView?                       View                                    { get; set; }
        public IUnitListWindowView?                     UnitListWindowView                      { get; set; }
        public CommonTitleView?                         TitleView                               { get; set; }
        public CancellationTokenSource?                 Cts                                     { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }
        public LiveUnitEditViewModel?                   Vm                                      { get; set; }
        public bool                                     IsEvent                                 { get; set; }

        public static LiveUnitEditPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveUnitEditPresenter() { Pointer= p0 };

            value.Argument                                  = GetObject<LiveUnitEditArgument>(new IntPtr(p + 0x010), ReversePrism.DataModels.LiveUnitEditArgument.FromPointer); // 024665F74D48 0x10 Argument                    ( 00018658D5D0 ModelClassType LiveUnitEditArgument LiveUnitEditArgument LiveUnitEditArgument Pointer )
            value.View                                      = GetObject<ILiveUnitEditView>(new IntPtr(p + 0x018), ReversePrism.DataModels.ILiveUnitEditView.FromPointer); // 024665F74D68 0x18 View                        ( 00018659D1B0 ModelClassType ILiveUnitEditView ILiveUnitEditView ILiveUnitEditView Pointer )
            value.UnitListWindowView                        = GetObject<IUnitListWindowView>(new IntPtr(p + 0x020), ReversePrism.DataModels.IUnitListWindowView.FromPointer); // 024665F74D88 0x20 UnitListWindowView          ( 00018668A680 ModelClassType IUnitListWindowView IUnitListWindowView IUnitListWindowView Pointer )
            value.TitleView                                 = GetObject<CommonTitleView>(new IntPtr(p + 0x028), ReversePrism.DataModels.CommonTitleView.FromPointer); // 024665F74DA8 0x28 TitleView                   ( 0001865EA1D0 ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x038), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 024665F74DE8 0x38 Cts                         ( 0001865A4380 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x040), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 024665F74E08 0x40 Disposables                 ( 0001865F38F0 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.Vm                                        = GetObject<LiveUnitEditViewModel>(new IntPtr(p + 0x048), ReversePrism.DataModels.LiveUnitEditViewModel.FromPointer); // 024665F74E28 0x48 Vm                          ( 000186592340 ModelClassType LiveUnitEditViewModel LiveUnitEditViewModel LiveUnitEditViewModel Pointer )
            value.IsEvent                                   = GetBool(new IntPtr(p + 0x050)); // 024665F74E48 0x50 IsEvent                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
