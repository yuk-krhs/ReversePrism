using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     ModelClassType ICharacterSelectView ICharacterSelectView ICharacterSelectView Pointer
    // 018 TitleView                                ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer
    // 020 PiView                                   ModelClassType IProduceIdolListView IProduceIdolListView IProduceIdolListView Pointer
    // 028 ScView                                   ModelClassType ISupportCharaListView ISupportCharaListView ISupportCharaListView Pointer
    // 030 PiUpgradingView                          ModelClassType IPIdolUpgradingButtonView IPIdolUpgradingButtonView IPIdolUpgradingButtonView Pointer
    // 038 ScUpgradingView                          ModelClassType ISCharaUpgradingButtonView ISCharaUpgradingButtonView ISCharaUpgradingButtonView Pointer
    // 040 piSortFilterSaveData                     SavableJsonObject`1<CharacterSelectPIPermanentData> IL2CPP_TYPE_GENERICINST
    // 048 scSortFilterSaveData                     SavableJsonObject`1<CharacterSelectSCPermanentData> IL2CPP_TYPE_GENERICINST
    // 050 piUpgradingFilterSaveData                SavableJsonObject`1<CharacterSelectPIUpgradingFilterPermanentData> IL2CPP_TYPE_GENERICINST
    // 058 scUpgradingFilterSaveData                SavableJsonObject`1<CharacterSelectSCUpgradingFilterPermanentData> IL2CPP_TYPE_GENERICINST
    // 060 Cts                                      ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 068 Disposables                              ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 070 CharacterType                            ModelEnumType CharacterType CharacterType CharacterType Int32
    // 078 produceIdolSelectModel                   ProduceIdolSelectModel`1<CharacterSelectPIPermanentData> IL2CPP_TYPE_GENERICINST
    // 080 supportCharacterSelectModel              SupportCharacterSelectModel`1<CharacterSelectSCPermanentData> IL2CPP_TYPE_GENERICINST
    // 088 ProduceAdvStatusList                     ModelClassListType IReadOnlyList`1<IProduceAdvStatus> IReadOnlyList`1<IProduceAdvStatus> List<IProduceAdvStatus> Pointer
    public partial class CharacterSelectPresenter : DataModel
    {
        public ICharacterSelectView?                    View                                    { get; set; }
        public CommonTitleView?                         TitleView                               { get; set; }
        public IProduceIdolListView?                    PiView                                  { get; set; }
        public ISupportCharaListView?                   ScView                                  { get; set; }
        public IPIdolUpgradingButtonView?               PiUpgradingView                         { get; set; }
        public ISCharaUpgradingButtonView?              ScUpgradingView                         { get; set; }
        public CancellationTokenSource?                 Cts                                     { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }
        public CharacterType                            CharacterType                           { get; set; }
        public List<IProduceAdvStatus>?                 ProduceAdvStatusList                    { get; set; }

        public static CharacterSelectPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CharacterSelectPresenter() { Pointer= p0 };

            value.View                                      = GetObject<ICharacterSelectView>(new IntPtr(p + 0x010), ReversePrism.DataModels.ICharacterSelectView.FromPointer); // 0x10 View                        ( ModelClassType ICharacterSelectView ICharacterSelectView ICharacterSelectView Pointer )
            value.TitleView                                 = GetObject<CommonTitleView>(new IntPtr(p + 0x018), ReversePrism.DataModels.CommonTitleView.FromPointer); // 0x18 TitleView                   ( ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer )
            value.PiView                                    = GetObject<IProduceIdolListView>(new IntPtr(p + 0x020), ReversePrism.DataModels.IProduceIdolListView.FromPointer); // 0x20 PiView                      ( ModelClassType IProduceIdolListView IProduceIdolListView IProduceIdolListView Pointer )
            value.ScView                                    = GetObject<ISupportCharaListView>(new IntPtr(p + 0x028), ReversePrism.DataModels.ISupportCharaListView.FromPointer); // 0x28 ScView                      ( ModelClassType ISupportCharaListView ISupportCharaListView ISupportCharaListView Pointer )
            value.PiUpgradingView                           = GetObject<IPIdolUpgradingButtonView>(new IntPtr(p + 0x030), ReversePrism.DataModels.IPIdolUpgradingButtonView.FromPointer); // 0x30 PiUpgradingView             ( ModelClassType IPIdolUpgradingButtonView IPIdolUpgradingButtonView IPIdolUpgradingButtonView Pointer )
            value.ScUpgradingView                           = GetObject<ISCharaUpgradingButtonView>(new IntPtr(p + 0x038), ReversePrism.DataModels.ISCharaUpgradingButtonView.FromPointer); // 0x38 ScUpgradingView             ( ModelClassType ISCharaUpgradingButtonView ISCharaUpgradingButtonView ISCharaUpgradingButtonView Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x060), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x60 Cts                         ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x068), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x68 Disposables                 ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.CharacterType                             = (CharacterType)GetInt32(new IntPtr(p + 0x070)); // 0x70 CharacterType               ( ModelEnumType CharacterType CharacterType CharacterType Int32 )
            value.ProduceAdvStatusList                      = GetObjectList<IProduceAdvStatus>(new IntPtr(p + 0x088), ReversePrism.DataModels.IProduceAdvStatus.FromPointer); // 0x88 ProduceAdvStatusList        ( ModelClassListType IReadOnlyList`1<IProduceAdvStatus> IReadOnlyList`1<IProduceAdvStatus> List<IProduceAdvStatus> Pointer )

            return value;
        }
    }
}
