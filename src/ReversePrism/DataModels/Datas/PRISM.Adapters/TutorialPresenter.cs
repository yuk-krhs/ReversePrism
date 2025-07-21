using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     ModelClassType ITutorialView ITutorialView ITutorialView Pointer
    // 018 Logger                                   ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer
    // 020 Service                                  ModelClassType TutorialService TutorialService TutorialService Pointer
    // 028 Cts                                      ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 030 Status                                   ModelClassType ITutorialStatus ITutorialStatus ITutorialStatus Pointer
    public partial class TutorialPresenter : DataModel
    {
        public ITutorialView?                           View                                    { get; set; }
        public CategorizedLogger?                       Logger                                  { get; set; }
        public TutorialService?                         Service                                 { get; set; }
        public CancellationTokenSource?                 Cts                                     { get; set; }
        public ITutorialStatus?                         Status                                  { get; set; }

        public static TutorialPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TutorialPresenter() { Pointer= p0 };

            value.View                                      = GetObject<ITutorialView>(new IntPtr(p + 0x010), ReversePrism.DataModels.ITutorialView.FromPointer); // 0x10 View                        ( ModelClassType ITutorialView ITutorialView ITutorialView Pointer )
            value.Logger                                    = GetObject<CategorizedLogger>(new IntPtr(p + 0x018), ReversePrism.DataModels.CategorizedLogger.FromPointer); // 0x18 Logger                      ( ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer )
            value.Service                                   = GetObject<TutorialService>(new IntPtr(p + 0x020), ReversePrism.DataModels.TutorialService.FromPointer); // 0x20 Service                     ( ModelClassType TutorialService TutorialService TutorialService Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x028), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x28 Cts                         ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Status                                    = GetObject<ITutorialStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.ITutorialStatus.FromPointer); // 0x30 Status                      ( ModelClassType ITutorialStatus ITutorialStatus ITutorialStatus Pointer )

            return value;
        }
    }
}
