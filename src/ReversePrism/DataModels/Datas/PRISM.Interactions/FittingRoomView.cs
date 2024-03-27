using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CgBlackFade                              000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 028 ScenarioManager                          0001866C9D90 ModelClassType ScenarioManager ScenarioManager ScenarioManager Pointer
    // 030 Cts                                      0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    public partial class FittingRoomView
    {
        public CanvasGroup?                             CgBlackFade                             { get; set; }
        public ScenarioManager?                         ScenarioManager                         { get; set; }
        public CancellationTokenSource?                 Cts                                     { get; set; }

        public static FittingRoomView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FittingRoomView();

            value.CgBlackFade                               = GetObject<CanvasGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0270DB615250 0x20 CgBlackFade                 ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.ScenarioManager                           = GetObject<ScenarioManager>(new IntPtr(p + 0x028), ReversePrism.DataModels.ScenarioManager.FromPointer); // 0270DB615270 0x28 ScenarioManager             ( 0001866C9D90 ModelClassType ScenarioManager ScenarioManager ScenarioManager Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x030), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0270DB615290 0x30 Cts                         ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )

            return value;
        }
    }
}
