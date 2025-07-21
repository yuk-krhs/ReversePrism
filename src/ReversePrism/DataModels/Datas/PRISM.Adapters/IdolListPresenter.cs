using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     ModelClassType IIdolListView IIdolListView IIdolListView Pointer
    // 018 TitleView                                ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer
    // 020 PiView                                   ModelClassType IIdolListProduceIdolListView IIdolListProduceIdolListView IIdolListProduceIdolListView Pointer
    // 028 ScView                                   ModelClassType IIdolListSupportCharaListView IIdolListSupportCharaListView IIdolListSupportCharaListView Pointer
    // 030 FuView                                   ModelClassType IIdolListFesUnitListView IIdolListFesUnitListView IIdolListFesUnitListView Pointer
    // 038 FiView                                   ModelClassType IIdolListFesIdolListView IIdolListFesIdolListView IIdolListFesIdolListView Pointer
    // 040 Argument                                 ModelClassType IdolListArgument IdolListArgument IdolListArgument Pointer
    // 048 MasterData                               ModelClassType MasterData MasterData MasterData Pointer
    // 050 piModel                                  ProduceIdolSelectModel`1<IdolListPISortFilterPermanentData> IL2CPP_TYPE_GENERICINST
    // 058 scModel                                  SupportCharacterSelectModel`1<IdolListSCSortFilterPermanentData> IL2CPP_TYPE_GENERICINST
    // 060 FuModel                                  ModelClassType FesUnitSelectModel FesUnitSelectModel FesUnitSelectModel Pointer
    // 068 FiModel                                  ModelClassType FesIdolSelectModel FesIdolSelectModel FesIdolSelectModel Pointer
    // 070 Cts                                      ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 078 Disposables                              ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    public partial class IdolListPresenter : DataModel
    {
        public IIdolListView?                           View                                    { get; set; }
        public CommonTitleView?                         TitleView                               { get; set; }
        public IIdolListProduceIdolListView?            PiView                                  { get; set; }
        public IIdolListSupportCharaListView?           ScView                                  { get; set; }
        public IIdolListFesUnitListView?                FuView                                  { get; set; }
        public IIdolListFesIdolListView?                FiView                                  { get; set; }
        public IdolListArgument?                        Argument                                { get; set; }
        public MasterData?                              MasterData                              { get; set; }
        public FesUnitSelectModel?                      FuModel                                 { get; set; }
        public FesIdolSelectModel?                      FiModel                                 { get; set; }
        public CancellationTokenSource?                 Cts                                     { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }

        public static IdolListPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolListPresenter() { Pointer= p0 };

            value.View                                      = GetObject<IIdolListView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IIdolListView.FromPointer); // 0x10 View                        ( ModelClassType IIdolListView IIdolListView IIdolListView Pointer )
            value.TitleView                                 = GetObject<CommonTitleView>(new IntPtr(p + 0x018), ReversePrism.DataModels.CommonTitleView.FromPointer); // 0x18 TitleView                   ( ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer )
            value.PiView                                    = GetObject<IIdolListProduceIdolListView>(new IntPtr(p + 0x020), ReversePrism.DataModels.IIdolListProduceIdolListView.FromPointer); // 0x20 PiView                      ( ModelClassType IIdolListProduceIdolListView IIdolListProduceIdolListView IIdolListProduceIdolListView Pointer )
            value.ScView                                    = GetObject<IIdolListSupportCharaListView>(new IntPtr(p + 0x028), ReversePrism.DataModels.IIdolListSupportCharaListView.FromPointer); // 0x28 ScView                      ( ModelClassType IIdolListSupportCharaListView IIdolListSupportCharaListView IIdolListSupportCharaListView Pointer )
            value.FuView                                    = GetObject<IIdolListFesUnitListView>(new IntPtr(p + 0x030), ReversePrism.DataModels.IIdolListFesUnitListView.FromPointer); // 0x30 FuView                      ( ModelClassType IIdolListFesUnitListView IIdolListFesUnitListView IIdolListFesUnitListView Pointer )
            value.FiView                                    = GetObject<IIdolListFesIdolListView>(new IntPtr(p + 0x038), ReversePrism.DataModels.IIdolListFesIdolListView.FromPointer); // 0x38 FiView                      ( ModelClassType IIdolListFesIdolListView IIdolListFesIdolListView IIdolListFesIdolListView Pointer )
            value.Argument                                  = GetObject<IdolListArgument>(new IntPtr(p + 0x040), ReversePrism.DataModels.IdolListArgument.FromPointer); // 0x40 Argument                    ( ModelClassType IdolListArgument IdolListArgument IdolListArgument Pointer )
            value.MasterData                                = GetObject<MasterData>(new IntPtr(p + 0x048), ReversePrism.DataModels.MasterData.FromPointer); // 0x48 MasterData                  ( ModelClassType MasterData MasterData MasterData Pointer )
            value.FuModel                                   = GetObject<FesUnitSelectModel>(new IntPtr(p + 0x060), ReversePrism.DataModels.FesUnitSelectModel.FromPointer); // 0x60 FuModel                     ( ModelClassType FesUnitSelectModel FesUnitSelectModel FesUnitSelectModel Pointer )
            value.FiModel                                   = GetObject<FesIdolSelectModel>(new IntPtr(p + 0x068), ReversePrism.DataModels.FesIdolSelectModel.FromPointer); // 0x68 FiModel                     ( ModelClassType FesIdolSelectModel FesIdolSelectModel FesIdolSelectModel Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x070), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x70 Cts                         ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x078), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x78 Disposables                 ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )

            return value;
        }
    }
}
