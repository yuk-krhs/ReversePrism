using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ViewModel                                ModelClassType HomeViewModel HomeViewModel HomeViewModel Pointer
    // 018 Disposables                              ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 020 TouchDetector                            ModelClassType CharacterTouchDetector CharacterTouchDetector CharacterTouchDetector Pointer
    // 028 ScenarioManager                          ModelClassType ScenarioManager ScenarioManager ScenarioManager Pointer
    // 030 Model3dLoader                            ModelClassType Model3dLoaderForHome Model3dLoaderForHome Model3dLoaderForHome Pointer
    public partial class Home3DSceneView : DataModel
    {
        public HomeViewModel?                           ViewModel                               { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }
        public CharacterTouchDetector?                  TouchDetector                           { get; set; }
        public ScenarioManager?                         ScenarioManager                         { get; set; }
        public Model3dLoaderForHome?                    Model3dLoader                           { get; set; }

        public static Home3DSceneView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Home3DSceneView() { Pointer= p0 };

            value.ViewModel                                 = GetObject<HomeViewModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.HomeViewModel.FromPointer); // 0x10 ViewModel                   ( ModelClassType HomeViewModel HomeViewModel HomeViewModel Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x018), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x18 Disposables                 ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.TouchDetector                             = GetObject<CharacterTouchDetector>(new IntPtr(p + 0x020), ReversePrism.DataModels.CharacterTouchDetector.FromPointer); // 0x20 TouchDetector               ( ModelClassType CharacterTouchDetector CharacterTouchDetector CharacterTouchDetector Pointer )
            value.ScenarioManager                           = GetObject<ScenarioManager>(new IntPtr(p + 0x028), ReversePrism.DataModels.ScenarioManager.FromPointer); // 0x28 ScenarioManager             ( ModelClassType ScenarioManager ScenarioManager ScenarioManager Pointer )
            value.Model3dLoader                             = GetObject<Model3dLoaderForHome>(new IntPtr(p + 0x030), ReversePrism.DataModels.Model3dLoaderForHome.FromPointer); // 0x30 Model3dLoader               ( ModelClassType Model3dLoaderForHome Model3dLoaderForHome Model3dLoaderForHome Pointer )

            return value;
        }
    }
}
