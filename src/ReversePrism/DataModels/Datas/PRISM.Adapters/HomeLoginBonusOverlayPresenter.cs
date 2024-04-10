using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ViewModel                                0001866D3DB0 ModelClassType HomeViewModel HomeViewModel HomeViewModel Pointer
    // 018 View                                     000186569400 ModelClassType IHomeLoginBonusOverlayView IHomeLoginBonusOverlayView IHomeLoginBonusOverlayView Pointer
    // 020 Home3dSceneView                          000186566E60 ModelClassType IHome3DSceneView IHome3DSceneView IHome3DSceneView Pointer
    // 028 CharacterMessagePresenter                0001866C26F0 ModelClassType HomeLoginBonusCharacterMessagePresenter HomeLoginBonusCharacterMessagePresenter HomeLoginBonusCharacterMessagePresenter Pointer
    // 030 Disposables                              0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 038 CurrentIndex                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 03C IsFadeInEnd                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 03D IsStamp                                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 03E IsLastSkip                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 040 onClickNextPhase                         Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    public partial class HomeLoginBonusOverlayPresenter : DataModel
    {
        public HomeViewModel?                           ViewModel                               { get; set; }
        public IHomeLoginBonusOverlayView?              View                                    { get; set; }
        public IHome3DSceneView?                        Home3dSceneView                         { get; set; }
        public HomeLoginBonusCharacterMessagePresenter? CharacterMessagePresenter               { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }
        public int                                      CurrentIndex                            { get; set; }
        public bool                                     IsFadeInEnd                             { get; set; }
        public bool                                     IsStamp                                 { get; set; }
        public bool                                     IsLastSkip                              { get; set; }

        public static HomeLoginBonusOverlayPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HomeLoginBonusOverlayPresenter() { Pointer= p0 };

            value.ViewModel                                 = GetObject<HomeViewModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.HomeViewModel.FromPointer); // 0245A365F5C0 0x10 ViewModel                   ( 0001866D3DB0 ModelClassType HomeViewModel HomeViewModel HomeViewModel Pointer )
            value.View                                      = GetObject<IHomeLoginBonusOverlayView>(new IntPtr(p + 0x018), ReversePrism.DataModels.IHomeLoginBonusOverlayView.FromPointer); // 0245A365F5E0 0x18 View                        ( 000186569400 ModelClassType IHomeLoginBonusOverlayView IHomeLoginBonusOverlayView IHomeLoginBonusOverlayView Pointer )
            value.Home3dSceneView                           = GetObject<IHome3DSceneView>(new IntPtr(p + 0x020), ReversePrism.DataModels.IHome3DSceneView.FromPointer); // 0245A365F600 0x20 Home3dSceneView             ( 000186566E60 ModelClassType IHome3DSceneView IHome3DSceneView IHome3DSceneView Pointer )
            value.CharacterMessagePresenter                 = GetObject<HomeLoginBonusCharacterMessagePresenter>(new IntPtr(p + 0x028), ReversePrism.DataModels.HomeLoginBonusCharacterMessagePresenter.FromPointer); // 0245A365F620 0x28 CharacterMessagePresenter   ( 0001866C26F0 ModelClassType HomeLoginBonusCharacterMessagePresenter HomeLoginBonusCharacterMessagePresenter HomeLoginBonusCharacterMessagePresenter Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x030), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0245A365F640 0x30 Disposables                 ( 0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.CurrentIndex                              = GetInt32(new IntPtr(p + 0x038)); // 0245A365F660 0x38 CurrentIndex                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IsFadeInEnd                               = GetBool(new IntPtr(p + 0x03C)); // 0245A365F680 0x3C IsFadeInEnd                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsStamp                                   = GetBool(new IntPtr(p + 0x03D)); // 0245A365F6A0 0x3D IsStamp                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsLastSkip                                = GetBool(new IntPtr(p + 0x03E)); // 0245A365F6C0 0x3E IsLastSkip                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
