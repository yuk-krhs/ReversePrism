using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 characterMessageView                     SerializableInterface`1<IHomeCharacterMessagePanelView> IL2CPP_TYPE_GENERICINST
    // 028 TouchDetector                            ModelClassType CharacterTouchDetector CharacterTouchDetector CharacterTouchDetector Pointer
    // 030 TutorialSequence                         ModelClassType ITutorialSequence ITutorialSequence ITutorialSequence Pointer
    // 038 Scene3DView                              ModelClassType Home3DSceneView Home3DSceneView Home3DSceneView Pointer
    // 040 ViewModel                                ModelClassType HomeViewModel HomeViewModel HomeViewModel Pointer
    public partial class HomeView : DataModel
    {
        public CharacterTouchDetector?                  TouchDetector                           { get; set; }
        public ITutorialSequence?                       TutorialSequence                        { get; set; }
        public Home3DSceneView?                         Scene3DView                             { get; set; }
        public HomeViewModel?                           ViewModel                               { get; set; }

        public static HomeView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HomeView() { Pointer= p0 };

            value.TouchDetector                             = GetObject<CharacterTouchDetector>(new IntPtr(p + 0x028), ReversePrism.DataModels.CharacterTouchDetector.FromPointer); // 0x28 TouchDetector               ( ModelClassType CharacterTouchDetector CharacterTouchDetector CharacterTouchDetector Pointer )
            value.TutorialSequence                          = GetObject<ITutorialSequence>(new IntPtr(p + 0x030), ReversePrism.DataModels.ITutorialSequence.FromPointer); // 0x30 TutorialSequence            ( ModelClassType ITutorialSequence ITutorialSequence ITutorialSequence Pointer )
            value.Scene3DView                               = GetObject<Home3DSceneView>(new IntPtr(p + 0x038), ReversePrism.DataModels.Home3DSceneView.FromPointer); // 0x38 Scene3DView                 ( ModelClassType Home3DSceneView Home3DSceneView Home3DSceneView Pointer )
            value.ViewModel                                 = GetObject<HomeViewModel>(new IntPtr(p + 0x040), ReversePrism.DataModels.HomeViewModel.FromPointer); // 0x40 ViewModel                   ( ModelClassType HomeViewModel HomeViewModel HomeViewModel Pointer )

            return value;
        }
    }
}
