using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CgBlackFade                              ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 028 Model3dLoader                            ModelClassType SimpleModel3dLoader SimpleModel3dLoader SimpleModel3dLoader Pointer
    // 030 ScenarioManager                          ModelClassType ScenarioManager ScenarioManager ScenarioManager Pointer
    // 038 Cts                                      ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    public partial class FittingRoomView : DataModel
    {
        public CanvasGroup?                             CgBlackFade                             { get; set; }
        public SimpleModel3dLoader?                     Model3dLoader                           { get; set; }
        public ScenarioManager?                         ScenarioManager                         { get; set; }
        public CancellationTokenSource?                 Cts                                     { get; set; }

        public static FittingRoomView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FittingRoomView() { Pointer= p0 };

            value.CgBlackFade                               = GetObject<CanvasGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x20 CgBlackFade                 ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.Model3dLoader                             = GetObject<SimpleModel3dLoader>(new IntPtr(p + 0x028), ReversePrism.DataModels.SimpleModel3dLoader.FromPointer); // 0x28 Model3dLoader               ( ModelClassType SimpleModel3dLoader SimpleModel3dLoader SimpleModel3dLoader Pointer )
            value.ScenarioManager                           = GetObject<ScenarioManager>(new IntPtr(p + 0x030), ReversePrism.DataModels.ScenarioManager.FromPointer); // 0x30 ScenarioManager             ( ModelClassType ScenarioManager ScenarioManager ScenarioManager Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x038), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x38 Cts                         ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )

            return value;
        }
    }
}
