using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     00018672B180 ModelClassType ICharacterBaseSelectView ICharacterBaseSelectView ICharacterBaseSelectView Pointer
    // 018 TitleView                                0001865EA1D0 ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer
    // 020 permanentDataPackage                     SavableJsonObject`1<CharacterBaseSelectPermanentData> IL2CPP_TYPE_GENERICINST
    // 028 Cts                                      0001865A4380 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 030 Disposables                              0001865F38F0 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 038 Vm                                       00018659BBB0 ModelClassType CharacterBaseSelectViewModel CharacterBaseSelectViewModel CharacterBaseSelectViewModel Pointer
    public partial class CharacterBaseSelectPresenter
    {
        public ICharacterBaseSelectView?                View                                    { get; set; }
        public CommonTitleView?                         TitleView                               { get; set; }
        public CancellationTokenSource?                 Cts                                     { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }
        public CharacterBaseSelectViewModel?            Vm                                      { get; set; }

        public static CharacterBaseSelectPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CharacterBaseSelectPresenter();

            value.View                                      = GetObject<ICharacterBaseSelectView>(new IntPtr(p + 0x010), ReversePrism.DataModels.ICharacterBaseSelectView.FromPointer); // 0270D5E91DC0 0x10 View                        ( 00018672B180 ModelClassType ICharacterBaseSelectView ICharacterBaseSelectView ICharacterBaseSelectView Pointer )
            value.TitleView                                 = GetObject<CommonTitleView>(new IntPtr(p + 0x018), ReversePrism.DataModels.CommonTitleView.FromPointer); // 0270D5E91DE0 0x18 TitleView                   ( 0001865EA1D0 ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x028), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0270D5E91E20 0x28 Cts                         ( 0001865A4380 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x030), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0270D5E91E40 0x30 Disposables                 ( 0001865F38F0 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.Vm                                        = GetObject<CharacterBaseSelectViewModel>(new IntPtr(p + 0x038), ReversePrism.DataModels.CharacterBaseSelectViewModel.FromPointer); // 0270D5E91E60 0x38 Vm                          ( 00018659BBB0 ModelClassType CharacterBaseSelectViewModel CharacterBaseSelectViewModel CharacterBaseSelectViewModel Pointer )

            return value;
        }
    }
}
