using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     ModelClassType IProduceUnitEditView IProduceUnitEditView IProduceUnitEditView Pointer
    // 018 TitleView                                ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer
    // 020 permanentDataPackage                     SavableJsonObject`1<ProduceUnitEditPermanentData> IL2CPP_TYPE_GENERICINST
    // 028 Cts                                      ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 030 Disposables                              ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 038 Vm                                       ModelClassType ProduceUnitEditViewModel ProduceUnitEditViewModel ProduceUnitEditViewModel Pointer
    // 040 ProduceAdvStatusList                     ModelClassListType IReadOnlyList`1<IProduceAdvStatus> IReadOnlyList`1<IProduceAdvStatus> List<IProduceAdvStatus> Pointer
    public partial class ProduceUnitEditPresenter : DataModel
    {
        public IProduceUnitEditView?                    View                                    { get; set; }
        public CommonTitleView?                         TitleView                               { get; set; }
        public CancellationTokenSource?                 Cts                                     { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }
        public ProduceUnitEditViewModel?                Vm                                      { get; set; }
        public List<IProduceAdvStatus>?                 ProduceAdvStatusList                    { get; set; }

        public static ProduceUnitEditPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceUnitEditPresenter() { Pointer= p0 };

            value.View                                      = GetObject<IProduceUnitEditView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IProduceUnitEditView.FromPointer); // 0x10 View                        ( ModelClassType IProduceUnitEditView IProduceUnitEditView IProduceUnitEditView Pointer )
            value.TitleView                                 = GetObject<CommonTitleView>(new IntPtr(p + 0x018), ReversePrism.DataModels.CommonTitleView.FromPointer); // 0x18 TitleView                   ( ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x028), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x28 Cts                         ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x030), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x30 Disposables                 ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.Vm                                        = GetObject<ProduceUnitEditViewModel>(new IntPtr(p + 0x038), ReversePrism.DataModels.ProduceUnitEditViewModel.FromPointer); // 0x38 Vm                          ( ModelClassType ProduceUnitEditViewModel ProduceUnitEditViewModel ProduceUnitEditViewModel Pointer )
            value.ProduceAdvStatusList                      = GetObjectList<IProduceAdvStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.IProduceAdvStatus.FromPointer); // 0x40 ProduceAdvStatusList        ( ModelClassListType IReadOnlyList`1<IProduceAdvStatus> IReadOnlyList`1<IProduceAdvStatus> List<IProduceAdvStatus> Pointer )

            return value;
        }
    }
}
