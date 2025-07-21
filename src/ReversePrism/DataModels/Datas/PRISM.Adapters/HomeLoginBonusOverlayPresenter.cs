using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ViewModel                                ModelClassType HomeViewModel HomeViewModel HomeViewModel Pointer
    // 018 View                                     ModelClassType IHomeLoginBonusOverlayView IHomeLoginBonusOverlayView IHomeLoginBonusOverlayView Pointer
    // 020 Home3dSceneView                          ModelClassType IHome3DSceneView IHome3DSceneView IHome3DSceneView Pointer
    // 028 ResourceLoader                           ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
    // 030 CharacterMessagePresenter                ModelClassType HomeLoginBonusCharacterMessagePresenter HomeLoginBonusCharacterMessagePresenter HomeLoginBonusCharacterMessagePresenter Pointer
    // 038 Disposables                              ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 040 CurrentIndex                             ModelPrimitiveType int int int Int32
    // 044 IsFadeInEnd                              ModelPrimitiveType bool bool bool Bool
    // 045 IsStamp                                  ModelPrimitiveType bool bool bool Bool
    // 046 IsLastSkip                               ModelPrimitiveType bool bool bool Bool
    // 048 onClickNextPhase                         Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    public partial class HomeLoginBonusOverlayPresenter : DataModel
    {
        public HomeViewModel?                           ViewModel                               { get; set; }
        public IHomeLoginBonusOverlayView?              View                                    { get; set; }
        public IHome3DSceneView?                        Home3dSceneView                         { get; set; }
        public IResourceLoader?                         ResourceLoader                          { get; set; }
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

            value.ViewModel                                 = GetObject<HomeViewModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.HomeViewModel.FromPointer); // 0x10 ViewModel                   ( ModelClassType HomeViewModel HomeViewModel HomeViewModel Pointer )
            value.View                                      = GetObject<IHomeLoginBonusOverlayView>(new IntPtr(p + 0x018), ReversePrism.DataModels.IHomeLoginBonusOverlayView.FromPointer); // 0x18 View                        ( ModelClassType IHomeLoginBonusOverlayView IHomeLoginBonusOverlayView IHomeLoginBonusOverlayView Pointer )
            value.Home3dSceneView                           = GetObject<IHome3DSceneView>(new IntPtr(p + 0x020), ReversePrism.DataModels.IHome3DSceneView.FromPointer); // 0x20 Home3dSceneView             ( ModelClassType IHome3DSceneView IHome3DSceneView IHome3DSceneView Pointer )
            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x028), ReversePrism.DataModels.IResourceLoader.FromPointer); // 0x28 ResourceLoader              ( ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )
            value.CharacterMessagePresenter                 = GetObject<HomeLoginBonusCharacterMessagePresenter>(new IntPtr(p + 0x030), ReversePrism.DataModels.HomeLoginBonusCharacterMessagePresenter.FromPointer); // 0x30 CharacterMessagePresenter   ( ModelClassType HomeLoginBonusCharacterMessagePresenter HomeLoginBonusCharacterMessagePresenter HomeLoginBonusCharacterMessagePresenter Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x038), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x38 Disposables                 ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.CurrentIndex                              = GetInt32(new IntPtr(p + 0x040)); // 0x40 CurrentIndex                ( ModelPrimitiveType int int int Int32 )
            value.IsFadeInEnd                               = GetBool(new IntPtr(p + 0x044)); // 0x44 IsFadeInEnd                 ( ModelPrimitiveType bool bool bool Bool )
            value.IsStamp                                   = GetBool(new IntPtr(p + 0x045)); // 0x45 IsStamp                     ( ModelPrimitiveType bool bool bool Bool )
            value.IsLastSkip                                = GetBool(new IntPtr(p + 0x046)); // 0x46 IsLastSkip                  ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
