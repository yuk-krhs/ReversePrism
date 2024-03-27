using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     0001865F6F60 ModelClassType IProduceUnitEditView IProduceUnitEditView IProduceUnitEditView Pointer
    // 018 TitleView                                0001865EA1D0 ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer
    // 020 permanentDataPackage                     SavableJsonObject`1<ProduceUnitEditPermanentData> IL2CPP_TYPE_GENERICINST
    // 028 produceIdolSelectPermanentDataPackage    SavableJsonObject`1<ProduceIdolSelectPermanentData> IL2CPP_TYPE_GENERICINST
    // 030 PIdolDetailPopupViewFactory              0001865D0010 ModelClassType IPIdolDetailPopupViewFactory IPIdolDetailPopupViewFactory IPIdolDetailPopupViewFactory Pointer
    // 038 SCharaDetailPopupViewFactory             000186622C10 ModelClassType ISCharaDetailPopupViewFactory ISCharaDetailPopupViewFactory ISCharaDetailPopupViewFactory Pointer
    // 040 editUnitNamePopupViewFactory             IPopupViewFactory`1<IEditUnitNamePopupView> IL2CPP_TYPE_GENERICINST
    // 048 producePreparationIdolSkillSelectPopupViewFactory IPopupViewFactory`1<IProducePreparationIdolSkillSelectPopupView> IL2CPP_TYPE_GENERICINST
    // 050 produceSupportCharaSelectPopupViewFactory IPopupViewFactory`1<IProduceSupportCharaSelectPopupView> IL2CPP_TYPE_GENERICINST
    // 058 supportCharaUnitSetupPopupViewFactory    IPopupViewFactory`1<ISupportCharaUnitSetupPopupView> IL2CPP_TYPE_GENERICINST
    // 060 Cts                                      0001865A4380 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 068 Disposables                              0001865F38F0 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 070 Vm                                       00018659A140 ModelClassType ProduceUnitEditViewModel ProduceUnitEditViewModel ProduceUnitEditViewModel Pointer
    // 078 ProduceAdvStatusList                     000185D05518 ModelClassListType IReadOnlyList`1<IProduceAdvStatus> IReadOnlyList`1<IProduceAdvStatus> List<IProduceAdvStatus> Pointer
    public partial class ProduceUnitEditPresenter
    {
        public IProduceUnitEditView?                    View                                    { get; set; }
        public CommonTitleView?                         TitleView                               { get; set; }
        public IPIdolDetailPopupViewFactory?            PIdolDetailPopupViewFactory             { get; set; }
        public ISCharaDetailPopupViewFactory?           SCharaDetailPopupViewFactory            { get; set; }
        public CancellationTokenSource?                 Cts                                     { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }
        public ProduceUnitEditViewModel?                Vm                                      { get; set; }
        public List<IProduceAdvStatus>?                 ProduceAdvStatusList                    { get; set; }

        public static ProduceUnitEditPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceUnitEditPresenter();

            value.View                                      = GetObject<IProduceUnitEditView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IProduceUnitEditView.FromPointer); // 0270D600DFB0 0x10 View                        ( 0001865F6F60 ModelClassType IProduceUnitEditView IProduceUnitEditView IProduceUnitEditView Pointer )
            value.TitleView                                 = GetObject<CommonTitleView>(new IntPtr(p + 0x018), ReversePrism.DataModels.CommonTitleView.FromPointer); // 0270D600DFD0 0x18 TitleView                   ( 0001865EA1D0 ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer )
            value.PIdolDetailPopupViewFactory               = GetObject<IPIdolDetailPopupViewFactory>(new IntPtr(p + 0x030), ReversePrism.DataModels.IPIdolDetailPopupViewFactory.FromPointer); // 0270D600E030 0x30 PIdolDetailPopupViewFactory ( 0001865D0010 ModelClassType IPIdolDetailPopupViewFactory IPIdolDetailPopupViewFactory IPIdolDetailPopupViewFactory Pointer )
            value.SCharaDetailPopupViewFactory              = GetObject<ISCharaDetailPopupViewFactory>(new IntPtr(p + 0x038), ReversePrism.DataModels.ISCharaDetailPopupViewFactory.FromPointer); // 0270D600E050 0x38 SCharaDetailPopupViewFactory ( 000186622C10 ModelClassType ISCharaDetailPopupViewFactory ISCharaDetailPopupViewFactory ISCharaDetailPopupViewFactory Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x060), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0270D600E0F0 0x60 Cts                         ( 0001865A4380 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x068), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0270D600E110 0x68 Disposables                 ( 0001865F38F0 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.Vm                                        = GetObject<ProduceUnitEditViewModel>(new IntPtr(p + 0x070), ReversePrism.DataModels.ProduceUnitEditViewModel.FromPointer); // 0270D600E130 0x70 Vm                          ( 00018659A140 ModelClassType ProduceUnitEditViewModel ProduceUnitEditViewModel ProduceUnitEditViewModel Pointer )
            value.ProduceAdvStatusList                      = GetObjectList<IProduceAdvStatus>(new IntPtr(p + 0x078), ReversePrism.DataModels.IProduceAdvStatus.FromPointer); // 0270D600E150 0x78 ProduceAdvStatusList        ( 000185D05518 ModelClassListType IReadOnlyList`1<IProduceAdvStatus> IReadOnlyList`1<IProduceAdvStatus> List<IProduceAdvStatus> Pointer )

            return value;
        }
    }
}
