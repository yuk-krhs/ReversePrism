using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     000186574B90 ModelClassType IIdolListView IIdolListView IIdolListView Pointer
    // 018 TitleView                                0001865EA1D0 ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer
    // 020 PiView                                   000186574110 ModelClassType IIdolListProduceIdolListView IIdolListProduceIdolListView IIdolListProduceIdolListView Pointer
    // 028 ScView                                   000186574650 ModelClassType IIdolListSupportCharaListView IIdolListSupportCharaListView IIdolListSupportCharaListView Pointer
    // 030 FuView                                   000186573C30 ModelClassType IIdolListFesUnitListView IIdolListFesUnitListView IIdolListFesUnitListView Pointer
    // 038 FiView                                   000186573710 ModelClassType IIdolListFesIdolListView IIdolListFesIdolListView IIdolListFesIdolListView Pointer
    // 040 Argument                                 0001866B1540 ModelClassType IdolListArgument IdolListArgument IdolListArgument Pointer
    // 048 idolListSaveData                         SavableJsonObject`1<IdolListPermanentData> IL2CPP_TYPE_GENERICINST
    // 050 piSortFilterSaveData                     SavableJsonObject`1<IdolListPISortFilterPermanentData> IL2CPP_TYPE_GENERICINST
    // 058 scSortFilterSaveData                     SavableJsonObject`1<IdolListSCSortFilterPermanentData> IL2CPP_TYPE_GENERICINST
    // 060 fuSortFilterSaveData                     SavableJsonObject`1<IdolListFUSortFilterPermanentData> IL2CPP_TYPE_GENERICINST
    // 068 fiSortFilterSaveData                     SavableJsonObject`1<IdolListFISortFilterPermanentData> IL2CPP_TYPE_GENERICINST
    // 070 PIdolDetailPopupViewFactory              0001865D0010 ModelClassType IPIdolDetailPopupViewFactory IPIdolDetailPopupViewFactory IPIdolDetailPopupViewFactory Pointer
    // 078 pIdolSearchPopupViewFactory              IPopupViewFactory`1<IProduceIdolSearchPopupView> IL2CPP_TYPE_GENERICINST
    // 080 SCharaDetailPopupViewFactory             000186622C10 ModelClassType ISCharaDetailPopupViewFactory ISCharaDetailPopupViewFactory ISCharaDetailPopupViewFactory Pointer
    // 088 sCharaSearchPopupViewFactory             IPopupViewFactory`1<ISupportCharaSearchPopupView> IL2CPP_TYPE_GENERICINST
    // 090 FUnitDetailPopupViewFactory              000186774B10 ModelClassType IFUnitDetailPopupViewFactory IFUnitDetailPopupViewFactory IFUnitDetailPopupViewFactory Pointer
    // 098 fUnitSearchPopupViewFactory              IPopupViewFactory`1<IFesUnitSearchPopupView> IL2CPP_TYPE_GENERICINST
    // 0A0 selectFavoriteMarkPopupViewFactory       IPopupViewFactory`1<ISelectFavoriteMarkPopupView> IL2CPP_TYPE_GENERICINST
    // 0A8 fUnitTransferConfirmedPopupViewFactory   IPopupViewFactory`1<IFesUnitTransferConfirmedPopupView> IL2CPP_TYPE_GENERICINST
    // 0B0 FIdolDetailPopupViewFactory              000186774150 ModelClassType IFIdolDetailPopupViewFactory IFIdolDetailPopupViewFactory IFIdolDetailPopupViewFactory Pointer
    // 0B8 fIdolSearchPopupViewFactory              IPopupViewFactory`1<IFesIdolSearchPopupView> IL2CPP_TYPE_GENERICINST
    // 0C0 fIdolTransferConfirmedPopupViewFactory   IPopupViewFactory`1<IFesIdolTransferConfirmedPopupView> IL2CPP_TYPE_GENERICINST
    // 0C8 fDataTransferCompletedPopupViewFactory   IPopupViewFactory`1<IFesDataTransferCompletedPopupView> IL2CPP_TYPE_GENERICINST
    // 0D0 MasterData                               00018660B7A0 ModelClassType MasterData MasterData MasterData Pointer
    // 0D8 piModel                                  ProduceIdolSelectModel`1<IdolListPISortFilterPermanentData> IL2CPP_TYPE_GENERICINST
    // 0E0 scModel                                  SupportCharacterSelectModel`1<IdolListSCSortFilterPermanentData> IL2CPP_TYPE_GENERICINST
    // 0E8 FuModel                                  00018656BAF0 ModelClassType FesUnitSelectModel FesUnitSelectModel FesUnitSelectModel Pointer
    // 0F0 FiModel                                  0001865640D0 ModelClassType FesIdolSelectModel FesIdolSelectModel FesIdolSelectModel Pointer
    // 0F8 Cts                                      0001865A4380 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 100 Disposables                              0001865F38F0 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 108 ProduceAdvStatusList                     000185D05518 ModelClassListType IReadOnlyList`1<IProduceAdvStatus> IReadOnlyList`1<IProduceAdvStatus> List<IProduceAdvStatus> Pointer
    public partial class IdolListPresenter
    {
        public IIdolListView?                           View                                    { get; set; }
        public CommonTitleView?                         TitleView                               { get; set; }
        public IIdolListProduceIdolListView?            PiView                                  { get; set; }
        public IIdolListSupportCharaListView?           ScView                                  { get; set; }
        public IIdolListFesUnitListView?                FuView                                  { get; set; }
        public IIdolListFesIdolListView?                FiView                                  { get; set; }
        public IdolListArgument?                        Argument                                { get; set; }
        public IPIdolDetailPopupViewFactory?            PIdolDetailPopupViewFactory             { get; set; }
        public ISCharaDetailPopupViewFactory?           SCharaDetailPopupViewFactory            { get; set; }
        public IFUnitDetailPopupViewFactory?            FUnitDetailPopupViewFactory             { get; set; }
        public IFIdolDetailPopupViewFactory?            FIdolDetailPopupViewFactory             { get; set; }
        public MasterData?                              MasterData                              { get; set; }
        public FesUnitSelectModel?                      FuModel                                 { get; set; }
        public FesIdolSelectModel?                      FiModel                                 { get; set; }
        public CancellationTokenSource?                 Cts                                     { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }
        public List<IProduceAdvStatus>?                 ProduceAdvStatusList                    { get; set; }

        public static IdolListPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolListPresenter();

            value.View                                      = GetObject<IIdolListView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IIdolListView.FromPointer); // 0270D5ED6510 0x10 View                        ( 000186574B90 ModelClassType IIdolListView IIdolListView IIdolListView Pointer )
            value.TitleView                                 = GetObject<CommonTitleView>(new IntPtr(p + 0x018), ReversePrism.DataModels.CommonTitleView.FromPointer); // 0270D5ED6530 0x18 TitleView                   ( 0001865EA1D0 ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer )
            value.PiView                                    = GetObject<IIdolListProduceIdolListView>(new IntPtr(p + 0x020), ReversePrism.DataModels.IIdolListProduceIdolListView.FromPointer); // 0270D5ED6550 0x20 PiView                      ( 000186574110 ModelClassType IIdolListProduceIdolListView IIdolListProduceIdolListView IIdolListProduceIdolListView Pointer )
            value.ScView                                    = GetObject<IIdolListSupportCharaListView>(new IntPtr(p + 0x028), ReversePrism.DataModels.IIdolListSupportCharaListView.FromPointer); // 0270D5ED6570 0x28 ScView                      ( 000186574650 ModelClassType IIdolListSupportCharaListView IIdolListSupportCharaListView IIdolListSupportCharaListView Pointer )
            value.FuView                                    = GetObject<IIdolListFesUnitListView>(new IntPtr(p + 0x030), ReversePrism.DataModels.IIdolListFesUnitListView.FromPointer); // 0270D5ED6590 0x30 FuView                      ( 000186573C30 ModelClassType IIdolListFesUnitListView IIdolListFesUnitListView IIdolListFesUnitListView Pointer )
            value.FiView                                    = GetObject<IIdolListFesIdolListView>(new IntPtr(p + 0x038), ReversePrism.DataModels.IIdolListFesIdolListView.FromPointer); // 0270D5ED65B0 0x38 FiView                      ( 000186573710 ModelClassType IIdolListFesIdolListView IIdolListFesIdolListView IIdolListFesIdolListView Pointer )
            value.Argument                                  = GetObject<IdolListArgument>(new IntPtr(p + 0x040), ReversePrism.DataModels.IdolListArgument.FromPointer); // 0270D5ED65D0 0x40 Argument                    ( 0001866B1540 ModelClassType IdolListArgument IdolListArgument IdolListArgument Pointer )
            value.PIdolDetailPopupViewFactory               = GetObject<IPIdolDetailPopupViewFactory>(new IntPtr(p + 0x070), ReversePrism.DataModels.IPIdolDetailPopupViewFactory.FromPointer); // 0270D5ED6690 0x70 PIdolDetailPopupViewFactory ( 0001865D0010 ModelClassType IPIdolDetailPopupViewFactory IPIdolDetailPopupViewFactory IPIdolDetailPopupViewFactory Pointer )
            value.SCharaDetailPopupViewFactory              = GetObject<ISCharaDetailPopupViewFactory>(new IntPtr(p + 0x080), ReversePrism.DataModels.ISCharaDetailPopupViewFactory.FromPointer); // 0270D5ED66D0 0x80 SCharaDetailPopupViewFactory ( 000186622C10 ModelClassType ISCharaDetailPopupViewFactory ISCharaDetailPopupViewFactory ISCharaDetailPopupViewFactory Pointer )
            value.FUnitDetailPopupViewFactory               = GetObject<IFUnitDetailPopupViewFactory>(new IntPtr(p + 0x090), ReversePrism.DataModels.IFUnitDetailPopupViewFactory.FromPointer); // 0270D5ED6710 0x90 FUnitDetailPopupViewFactory ( 000186774B10 ModelClassType IFUnitDetailPopupViewFactory IFUnitDetailPopupViewFactory IFUnitDetailPopupViewFactory Pointer )
            value.FIdolDetailPopupViewFactory               = GetObject<IFIdolDetailPopupViewFactory>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.IFIdolDetailPopupViewFactory.FromPointer); // 0270D5ED6790 0xB0 FIdolDetailPopupViewFactory ( 000186774150 ModelClassType IFIdolDetailPopupViewFactory IFIdolDetailPopupViewFactory IFIdolDetailPopupViewFactory Pointer )
            value.MasterData                                = GetObject<MasterData>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.MasterData.FromPointer); // 0270D5ED6810 0xD0 MasterData                  ( 00018660B7A0 ModelClassType MasterData MasterData MasterData Pointer )
            value.FuModel                                   = GetObject<FesUnitSelectModel>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.FesUnitSelectModel.FromPointer); // 0270D5ED6870 0xE8 FuModel                     ( 00018656BAF0 ModelClassType FesUnitSelectModel FesUnitSelectModel FesUnitSelectModel Pointer )
            value.FiModel                                   = GetObject<FesIdolSelectModel>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.FesIdolSelectModel.FromPointer); // 0270D5ED6890 0xF0 FiModel                     ( 0001865640D0 ModelClassType FesIdolSelectModel FesIdolSelectModel FesIdolSelectModel Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0270D5ED68B0 0xF8 Cts                         ( 0001865A4380 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x100), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0270D5ED68D0 0x100 Disposables                 ( 0001865F38F0 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.ProduceAdvStatusList                      = GetObjectList<IProduceAdvStatus>(new IntPtr(p + 0x108), ReversePrism.DataModels.IProduceAdvStatus.FromPointer); // 0270D5ED68F0 0x108 ProduceAdvStatusList        ( 000185D05518 ModelClassListType IReadOnlyList`1<IProduceAdvStatus> IReadOnlyList`1<IProduceAdvStatus> List<IProduceAdvStatus> Pointer )

            return value;
        }
    }
}
