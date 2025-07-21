using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DeckCardViewModels                       ModelClassListType PCardRankUpViewModel[] PCardRankUpViewModel[] List<PCardRankUpViewModel> Pointer
    // 018 rankUpCardViewModels                     ReactiveCollection`1<PCardRankUpViewModel> IL2CPP_TYPE_GENERICINST
    // 020 onUpdateRankUpCardViewModels             Subject`1<IReadOnlyList`1<IPCardRankUpViewModel>> IL2CPP_TYPE_GENERICINST
    // 028 Disposable                               ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 030 MaxRankUpCount                           ModelPrimitiveType int int int Int32
    public partial class PCardRankUpPopupViewModel : DataModel
    {
        public List<PCardRankUpViewModel>?              DeckCardViewModels                      { get; set; }
        public CompositeDisposable?                     Disposable                              { get; set; }
        public int                                      MaxRankUpCount                          { get; set; }

        public static PCardRankUpPopupViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PCardRankUpPopupViewModel() { Pointer= p0 };

            value.DeckCardViewModels                        = GetObjectList<PCardRankUpViewModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.PCardRankUpViewModel.FromPointer); // 0x10 DeckCardViewModels          ( ModelClassListType PCardRankUpViewModel[] PCardRankUpViewModel[] List<PCardRankUpViewModel> Pointer )
            value.Disposable                                = GetObject<CompositeDisposable>(new IntPtr(p + 0x028), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x28 Disposable                  ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.MaxRankUpCount                            = GetInt32(new IntPtr(p + 0x030)); // 0x30 MaxRankUpCount              ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
