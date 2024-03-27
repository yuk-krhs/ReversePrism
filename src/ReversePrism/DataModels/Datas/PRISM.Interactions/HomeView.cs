using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 characterMessageView                     SerializableInterface`1<IHomeCharacterMessagePanelView> IL2CPP_TYPE_GENERICINST
    // 028 TouchDetector                            0001865A6E50 ModelClassType CharacterTouchDetector CharacterTouchDetector CharacterTouchDetector Pointer
    // 030 loginBonusOverlayFactory                 OverlayViewFactory`1<IHomeLoginBonusOverlayView> IL2CPP_TYPE_GENERICINST
    // 038 TutorialSequence                         0001866807A0 ModelClassType ITutorialSequence ITutorialSequence ITutorialSequence Pointer
    // 040 Scene3DView                              0001866B9180 ModelClassType Home3DSceneView Home3DSceneView Home3DSceneView Pointer
    // 048 ViewModel                                0001866D38A0 ModelClassType HomeViewModel HomeViewModel HomeViewModel Pointer
    // 050 ResourceTag                              00018661C960 ModelClassType IResourceTag IResourceTag IResourceTag Pointer
    public partial class HomeView
    {
        public CharacterTouchDetector?                  TouchDetector                           { get; set; }
        public ITutorialSequence?                       TutorialSequence                        { get; set; }
        public Home3DSceneView?                         Scene3DView                             { get; set; }
        public HomeViewModel?                           ViewModel                               { get; set; }
        public IResourceTag?                            ResourceTag                             { get; set; }

        public static HomeView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HomeView();

            value.TouchDetector                             = GetObject<CharacterTouchDetector>(new IntPtr(p + 0x028), ReversePrism.DataModels.CharacterTouchDetector.FromPointer); // 027004F812F0 0x28 TouchDetector               ( 0001865A6E50 ModelClassType CharacterTouchDetector CharacterTouchDetector CharacterTouchDetector Pointer )
            value.TutorialSequence                          = GetObject<ITutorialSequence>(new IntPtr(p + 0x038), ReversePrism.DataModels.ITutorialSequence.FromPointer); // 027004F81330 0x38 TutorialSequence            ( 0001866807A0 ModelClassType ITutorialSequence ITutorialSequence ITutorialSequence Pointer )
            value.Scene3DView                               = GetObject<Home3DSceneView>(new IntPtr(p + 0x040), ReversePrism.DataModels.Home3DSceneView.FromPointer); // 027004F81350 0x40 Scene3DView                 ( 0001866B9180 ModelClassType Home3DSceneView Home3DSceneView Home3DSceneView Pointer )
            value.ViewModel                                 = GetObject<HomeViewModel>(new IntPtr(p + 0x048), ReversePrism.DataModels.HomeViewModel.FromPointer); // 027004F81370 0x48 ViewModel                   ( 0001866D38A0 ModelClassType HomeViewModel HomeViewModel HomeViewModel Pointer )
            value.ResourceTag                               = GetObject<IResourceTag>(new IntPtr(p + 0x050), ReversePrism.DataModels.IResourceTag.FromPointer); // 027004F81390 0x50 ResourceTag                 ( 00018661C960 ModelClassType IResourceTag IResourceTag IResourceTag Pointer )

            return value;
        }
    }
}
