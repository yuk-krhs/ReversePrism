using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     0001865EA370 ModelClassType IProduceIdolSelectView IProduceIdolSelectView IProduceIdolSelectView Pointer
    // 018 permanentDataPackage                     SavableJsonObject`1<ProduceIdolSelectPermanentData> IL2CPP_TYPE_GENERICINST
    // 020 Argument                                 00018654BA10 ModelClassType ProduceIdolSelectArgument ProduceIdolSelectArgument ProduceIdolSelectArgument Pointer
    // 028 Model                                    000186521780 ModelClassType ViewProducePreparationIdolSelectModel ViewProducePreparationIdolSelectModel ViewProducePreparationIdolSelectModel Pointer
    // 030 SubSeasonDetailContentViewModel          0001865D4BF0 ModelClassType SubSeasonDetailContentViewModel SubSeasonDetailContentViewModel SubSeasonDetailContentViewModel Pointer
    // 038 MasterData                               00018660B2F0 ModelClassType MasterData MasterData MasterData Pointer
    // 040 Disposables                              0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 048 Cts                                      0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 050 ResourceLoader                           00018661A8D0 ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
    // 058 IsPageMove                               000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class ProduceIdolSelectPresenter : DataModel
    {
        public IProduceIdolSelectView?                  View                                    { get; set; }
        public ProduceIdolSelectArgument?               Argument                                { get; set; }
        public ViewProducePreparationIdolSelectModel?   Model                                   { get; set; }
        public SubSeasonDetailContentViewModel?         SubSeasonDetailContentViewModel         { get; set; }
        public MasterData?                              MasterData                              { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }
        public CancellationTokenSource?                 Cts                                     { get; set; }
        public IResourceLoader?                         ResourceLoader                          { get; set; }
        public bool                                     IsPageMove                              { get; set; }

        public static ProduceIdolSelectPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceIdolSelectPresenter() { Pointer= p0 };

            value.View                                      = GetObject<IProduceIdolSelectView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IProduceIdolSelectView.FromPointer); // 0246665CF4C0 0x10 View                        ( 0001865EA370 ModelClassType IProduceIdolSelectView IProduceIdolSelectView IProduceIdolSelectView Pointer )
            value.Argument                                  = GetObject<ProduceIdolSelectArgument>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProduceIdolSelectArgument.FromPointer); // 0246665CF500 0x20 Argument                    ( 00018654BA10 ModelClassType ProduceIdolSelectArgument ProduceIdolSelectArgument ProduceIdolSelectArgument Pointer )
            value.Model                                     = GetObject<ViewProducePreparationIdolSelectModel>(new IntPtr(p + 0x028), ReversePrism.DataModels.ViewProducePreparationIdolSelectModel.FromPointer); // 0246665CF520 0x28 Model                       ( 000186521780 ModelClassType ViewProducePreparationIdolSelectModel ViewProducePreparationIdolSelectModel ViewProducePreparationIdolSelectModel Pointer )
            value.SubSeasonDetailContentViewModel           = GetObject<SubSeasonDetailContentViewModel>(new IntPtr(p + 0x030), ReversePrism.DataModels.SubSeasonDetailContentViewModel.FromPointer); // 0246665CF540 0x30 SubSeasonDetailContentViewModel ( 0001865D4BF0 ModelClassType SubSeasonDetailContentViewModel SubSeasonDetailContentViewModel SubSeasonDetailContentViewModel Pointer )
            value.MasterData                                = GetObject<MasterData>(new IntPtr(p + 0x038), ReversePrism.DataModels.MasterData.FromPointer); // 0246665CF560 0x38 MasterData                  ( 00018660B2F0 ModelClassType MasterData MasterData MasterData Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x040), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0246665CF580 0x40 Disposables                 ( 0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x048), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0246665CF5A0 0x48 Cts                         ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x050), ReversePrism.DataModels.IResourceLoader.FromPointer); // 0246665CF5C0 0x50 ResourceLoader              ( 00018661A8D0 ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )
            value.IsPageMove                                = GetBool(new IntPtr(p + 0x058)); // 0246665CF5E0 0x58 IsPageMove                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
