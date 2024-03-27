using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     00018672C500 ModelClassType ICharacterSelectView ICharacterSelectView ICharacterSelectView Pointer
    // 018 TitleView                                0001865EA1D0 ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer
    // 020 PiView                                   0001865E9A80 ModelClassType IProduceIdolListView IProduceIdolListView IProduceIdolListView Pointer
    // 028 ScView                                   000186666630 ModelClassType ISupportCharaListView ISupportCharaListView ISupportCharaListView Pointer
    // 030 PiUpgradingView                          0001865D04C0 ModelClassType IPIdolUpgradingButtonView IPIdolUpgradingButtonView IPIdolUpgradingButtonView Pointer
    // 038 ScUpgradingView                          000186623350 ModelClassType ISCharaUpgradingButtonView ISCharaUpgradingButtonView ISCharaUpgradingButtonView Pointer
    // 040 piSortFilterSaveData                     SavableJsonObject`1<CharacterSelectPIPermanentData> IL2CPP_TYPE_GENERICINST
    // 048 scSortFilterSaveData                     SavableJsonObject`1<CharacterSelectSCPermanentData> IL2CPP_TYPE_GENERICINST
    // 050 piUpgradingFilterSaveData                SavableJsonObject`1<CharacterSelectPIUpgradingFilterPermanentData> IL2CPP_TYPE_GENERICINST
    // 058 scUpgradingFilterSaveData                SavableJsonObject`1<CharacterSelectSCUpgradingFilterPermanentData> IL2CPP_TYPE_GENERICINST
    // 060 PIdolDetailPopupViewFactory              0001865D0010 ModelClassType IPIdolDetailPopupViewFactory IPIdolDetailPopupViewFactory IPIdolDetailPopupViewFactory Pointer
    // 068 pIdolSearchPopupViewFactory              IPopupViewFactory`1<IProduceIdolSearchPopupView> IL2CPP_TYPE_GENERICINST
    // 070 SCharaDetailPopupViewFactory             000186622C10 ModelClassType ISCharaDetailPopupViewFactory ISCharaDetailPopupViewFactory ISCharaDetailPopupViewFactory Pointer
    // 078 sCharaSearchPopupViewFactory             IPopupViewFactory`1<ISupportCharaSearchPopupView> IL2CPP_TYPE_GENERICINST
    // 080 Cts                                      0001865A4380 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 088 Disposables                              0001865F38F0 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 090 CharacterType                            0001865A75C0 ModelEnumType CharacterType CharacterType CharacterType Int32
    // 098 produceIdolSelectModel                   ProduceIdolSelectModel`1<CharacterSelectPIPermanentData> IL2CPP_TYPE_GENERICINST
    // 0A0 supportCharacterSelectModel              SupportCharacterSelectModel`1<CharacterSelectSCPermanentData> IL2CPP_TYPE_GENERICINST
    // 0A8 ProduceAdvStatusList                     000185D05518 ModelClassListType IReadOnlyList`1<IProduceAdvStatus> IReadOnlyList`1<IProduceAdvStatus> List<IProduceAdvStatus> Pointer
    public partial class CharacterSelectPresenter
    {
        public ICharacterSelectView?                    View                                    { get; set; }
        public CommonTitleView?                         TitleView                               { get; set; }
        public IProduceIdolListView?                    PiView                                  { get; set; }
        public ISupportCharaListView?                   ScView                                  { get; set; }
        public IPIdolUpgradingButtonView?               PiUpgradingView                         { get; set; }
        public ISCharaUpgradingButtonView?              ScUpgradingView                         { get; set; }
        public IPIdolDetailPopupViewFactory?            PIdolDetailPopupViewFactory             { get; set; }
        public ISCharaDetailPopupViewFactory?           SCharaDetailPopupViewFactory            { get; set; }
        public CancellationTokenSource?                 Cts                                     { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }
        public CharacterType                            CharacterType                           { get; set; }
        public List<IProduceAdvStatus>?                 ProduceAdvStatusList                    { get; set; }

        public static CharacterSelectPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CharacterSelectPresenter();

            value.View                                      = GetObject<ICharacterSelectView>(new IntPtr(p + 0x010), ReversePrism.DataModels.ICharacterSelectView.FromPointer); // 0270D5E93830 0x10 View                        ( 00018672C500 ModelClassType ICharacterSelectView ICharacterSelectView ICharacterSelectView Pointer )
            value.TitleView                                 = GetObject<CommonTitleView>(new IntPtr(p + 0x018), ReversePrism.DataModels.CommonTitleView.FromPointer); // 0270D5E93850 0x18 TitleView                   ( 0001865EA1D0 ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer )
            value.PiView                                    = GetObject<IProduceIdolListView>(new IntPtr(p + 0x020), ReversePrism.DataModels.IProduceIdolListView.FromPointer); // 0270D5E93870 0x20 PiView                      ( 0001865E9A80 ModelClassType IProduceIdolListView IProduceIdolListView IProduceIdolListView Pointer )
            value.ScView                                    = GetObject<ISupportCharaListView>(new IntPtr(p + 0x028), ReversePrism.DataModels.ISupportCharaListView.FromPointer); // 0270D5E93890 0x28 ScView                      ( 000186666630 ModelClassType ISupportCharaListView ISupportCharaListView ISupportCharaListView Pointer )
            value.PiUpgradingView                           = GetObject<IPIdolUpgradingButtonView>(new IntPtr(p + 0x030), ReversePrism.DataModels.IPIdolUpgradingButtonView.FromPointer); // 0270D5E938B0 0x30 PiUpgradingView             ( 0001865D04C0 ModelClassType IPIdolUpgradingButtonView IPIdolUpgradingButtonView IPIdolUpgradingButtonView Pointer )
            value.ScUpgradingView                           = GetObject<ISCharaUpgradingButtonView>(new IntPtr(p + 0x038), ReversePrism.DataModels.ISCharaUpgradingButtonView.FromPointer); // 0270D5E938D0 0x38 ScUpgradingView             ( 000186623350 ModelClassType ISCharaUpgradingButtonView ISCharaUpgradingButtonView ISCharaUpgradingButtonView Pointer )
            value.PIdolDetailPopupViewFactory               = GetObject<IPIdolDetailPopupViewFactory>(new IntPtr(p + 0x060), ReversePrism.DataModels.IPIdolDetailPopupViewFactory.FromPointer); // 0270D5E93970 0x60 PIdolDetailPopupViewFactory ( 0001865D0010 ModelClassType IPIdolDetailPopupViewFactory IPIdolDetailPopupViewFactory IPIdolDetailPopupViewFactory Pointer )
            value.SCharaDetailPopupViewFactory              = GetObject<ISCharaDetailPopupViewFactory>(new IntPtr(p + 0x070), ReversePrism.DataModels.ISCharaDetailPopupViewFactory.FromPointer); // 0270D5E939B0 0x70 SCharaDetailPopupViewFactory ( 000186622C10 ModelClassType ISCharaDetailPopupViewFactory ISCharaDetailPopupViewFactory ISCharaDetailPopupViewFactory Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x080), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0270D5E939F0 0x80 Cts                         ( 0001865A4380 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x088), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0270D5E93A10 0x88 Disposables                 ( 0001865F38F0 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.CharacterType                             = (CharacterType)GetInt32(new IntPtr(p + 0x090)); // 0270D5E93A30 0x90 CharacterType               ( 0001865A75C0 ModelEnumType CharacterType CharacterType CharacterType Int32 )
            value.ProduceAdvStatusList                      = GetObjectList<IProduceAdvStatus>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.IProduceAdvStatus.FromPointer); // 0270D5E93A90 0xA8 ProduceAdvStatusList        ( 000185D05518 ModelClassListType IReadOnlyList`1<IProduceAdvStatus> IReadOnlyList`1<IProduceAdvStatus> List<IProduceAdvStatus> Pointer )

            return value;
        }
    }
}
