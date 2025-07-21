using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     ModelClassType ILiveUnitEditView ILiveUnitEditView ILiveUnitEditView Pointer
    // 018 UnitListWindowView                       ModelClassType IUnitListWindowView IUnitListWindowView IUnitListWindowView Pointer
    // 020 TitleView                                ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer
    // 028 permanentDataPackage                     SavableJsonObject`1<LiveUnitEditPermanentData> IL2CPP_TYPE_GENERICINST
    // 030 Cts                                      ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 038 Disposables                              ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 040 Vm                                       ModelClassType LiveUnitEditViewModel LiveUnitEditViewModel LiveUnitEditViewModel Pointer
    // 048 IsEvent                                  ModelPrimitiveType bool bool bool Bool
    public partial class LiveUnitEditPresenter : DataModel
    {
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

            value.View                                      = GetObject<ILiveUnitEditView>(new IntPtr(p + 0x010), ReversePrism.DataModels.ILiveUnitEditView.FromPointer); // 0x10 View                        ( ModelClassType ILiveUnitEditView ILiveUnitEditView ILiveUnitEditView Pointer )
            value.UnitListWindowView                        = GetObject<IUnitListWindowView>(new IntPtr(p + 0x018), ReversePrism.DataModels.IUnitListWindowView.FromPointer); // 0x18 UnitListWindowView          ( ModelClassType IUnitListWindowView IUnitListWindowView IUnitListWindowView Pointer )
            value.TitleView                                 = GetObject<CommonTitleView>(new IntPtr(p + 0x020), ReversePrism.DataModels.CommonTitleView.FromPointer); // 0x20 TitleView                   ( ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x030), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x30 Cts                         ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x038), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x38 Disposables                 ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.Vm                                        = GetObject<LiveUnitEditViewModel>(new IntPtr(p + 0x040), ReversePrism.DataModels.LiveUnitEditViewModel.FromPointer); // 0x40 Vm                          ( ModelClassType LiveUnitEditViewModel LiveUnitEditViewModel LiveUnitEditViewModel Pointer )
            value.IsEvent                                   = GetBool(new IntPtr(p + 0x048)); // 0x48 IsEvent                     ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
