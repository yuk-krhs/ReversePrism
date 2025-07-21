using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Cts                                      ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 018 Disposables                              ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 020 Argument                                 ModelClassType CharacterTopArgument CharacterTopArgument CharacterTopArgument Pointer
    // 028 TitleView                                ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer
    // 030 TopView                                  ModelClassType ICharacterTopView ICharacterTopView ICharacterTopView Pointer
    // 038 UiCharacterView                          ModelClassType ICharacterTopUICharacterView ICharacterTopUICharacterView ICharacterTopUICharacterView Pointer
    // 040 CurrentDisplay                           ModelEnumType DisplayType DisplayType DisplayType Int32
    public partial class CharacterTopPresenter : DataModel
    {
        public CancellationTokenSource?                 Cts                                     { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }
        public CharacterTopArgument?                    Argument                                { get; set; }
        public CommonTitleView?                         TitleView                               { get; set; }
        public ICharacterTopView?                       TopView                                 { get; set; }
        public ICharacterTopUICharacterView?            UiCharacterView                         { get; set; }
        public DisplayType                              CurrentDisplay                          { get; set; }

        public static CharacterTopPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CharacterTopPresenter() { Pointer= p0 };

            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x010), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x10 Cts                         ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x018), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x18 Disposables                 ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.Argument                                  = GetObject<CharacterTopArgument>(new IntPtr(p + 0x020), ReversePrism.DataModels.CharacterTopArgument.FromPointer); // 0x20 Argument                    ( ModelClassType CharacterTopArgument CharacterTopArgument CharacterTopArgument Pointer )
            value.TitleView                                 = GetObject<CommonTitleView>(new IntPtr(p + 0x028), ReversePrism.DataModels.CommonTitleView.FromPointer); // 0x28 TitleView                   ( ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer )
            value.TopView                                   = GetObject<ICharacterTopView>(new IntPtr(p + 0x030), ReversePrism.DataModels.ICharacterTopView.FromPointer); // 0x30 TopView                     ( ModelClassType ICharacterTopView ICharacterTopView ICharacterTopView Pointer )
            value.UiCharacterView                           = GetObject<ICharacterTopUICharacterView>(new IntPtr(p + 0x038), ReversePrism.DataModels.ICharacterTopUICharacterView.FromPointer); // 0x38 UiCharacterView             ( ModelClassType ICharacterTopUICharacterView ICharacterTopUICharacterView ICharacterTopUICharacterView Pointer )
            value.CurrentDisplay                            = (DisplayType)GetInt32(new IntPtr(p + 0x040)); // 0x40 CurrentDisplay              ( ModelEnumType DisplayType DisplayType DisplayType Int32 )

            return value;
        }
    }
}
