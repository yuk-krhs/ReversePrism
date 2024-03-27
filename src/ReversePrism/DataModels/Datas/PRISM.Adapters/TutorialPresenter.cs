using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     000186682240 ModelClassType ITutorialView ITutorialView ITutorialView Pointer
    // 018 Logger                                   00018654E610 ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer
    // 020 Service                                  0001866BD440 ModelClassType TutorialService TutorialService TutorialService Pointer
    // 028 Cts                                      0001865A4380 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 030 Status                                   000186681B00 ModelClassType ITutorialStatus ITutorialStatus ITutorialStatus Pointer
    public partial class TutorialPresenter
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
            var value   = new TutorialPresenter();

            value.View                                      = GetObject<ITutorialView>(new IntPtr(p + 0x010), ReversePrism.DataModels.ITutorialView.FromPointer); // 0270D676E498 0x10 View                        ( 000186682240 ModelClassType ITutorialView ITutorialView ITutorialView Pointer )
            value.Logger                                    = GetObject<CategorizedLogger>(new IntPtr(p + 0x018), ReversePrism.DataModels.CategorizedLogger.FromPointer); // 0270D676E4B8 0x18 Logger                      ( 00018654E610 ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer )
            value.Service                                   = GetObject<TutorialService>(new IntPtr(p + 0x020), ReversePrism.DataModels.TutorialService.FromPointer); // 0270D676E4D8 0x20 Service                     ( 0001866BD440 ModelClassType TutorialService TutorialService TutorialService Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x028), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0270D676E4F8 0x28 Cts                         ( 0001865A4380 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Status                                    = GetObject<ITutorialStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.ITutorialStatus.FromPointer); // 0270D676E518 0x30 Status                      ( 000186681B00 ModelClassType ITutorialStatus ITutorialStatus ITutorialStatus Pointer )

            return value;
        }
    }
}
