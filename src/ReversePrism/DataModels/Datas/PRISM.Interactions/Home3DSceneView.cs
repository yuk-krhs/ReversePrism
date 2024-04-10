using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ViewModel                                0001866D38A0 ModelClassType HomeViewModel HomeViewModel HomeViewModel Pointer
    // 018 Disposables                              0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 020 TouchDetector                            0001865A6E50 ModelClassType CharacterTouchDetector CharacterTouchDetector CharacterTouchDetector Pointer
    // 028 ScenarioManager                          0001866C9D90 ModelClassType ScenarioManager ScenarioManager ScenarioManager Pointer
    public partial class Home3DSceneView : DataModel
    {
        public HomeViewModel?                           ViewModel                               { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }
        public CharacterTouchDetector?                  TouchDetector                           { get; set; }
        public ScenarioManager?                         ScenarioManager                         { get; set; }

        public static Home3DSceneView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Home3DSceneView() { Pointer= p0 };

            value.ViewModel                                 = GetObject<HomeViewModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.HomeViewModel.FromPointer); // 0245A5B4C210 0x10 ViewModel                   ( 0001866D38A0 ModelClassType HomeViewModel HomeViewModel HomeViewModel Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x018), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0245A5B4C230 0x18 Disposables                 ( 0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.TouchDetector                             = GetObject<CharacterTouchDetector>(new IntPtr(p + 0x020), ReversePrism.DataModels.CharacterTouchDetector.FromPointer); // 0245A5B4C250 0x20 TouchDetector               ( 0001865A6E50 ModelClassType CharacterTouchDetector CharacterTouchDetector CharacterTouchDetector Pointer )
            value.ScenarioManager                           = GetObject<ScenarioManager>(new IntPtr(p + 0x028), ReversePrism.DataModels.ScenarioManager.FromPointer); // 0245A5B4C270 0x28 ScenarioManager             ( 0001866C9D90 ModelClassType ScenarioManager ScenarioManager ScenarioManager Pointer )

            return value;
        }
    }
}
