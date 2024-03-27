using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     000186626010 ModelClassType IScheduleSelectionLeftBottomAreaView IScheduleSelectionLeftBottomAreaView IScheduleSelectionLeftBottomAreaView Pointer
    // 018 TokenSource                              0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    public partial class ScheduleSelectionLeftBottomAreaPresenter
    {
        public IScheduleSelectionLeftBottomAreaView?    View                                    { get; set; }
        public CancellationTokenSource?                 TokenSource                             { get; set; }

        public static ScheduleSelectionLeftBottomAreaPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScheduleSelectionLeftBottomAreaPresenter();

            value.View                                      = GetObject<IScheduleSelectionLeftBottomAreaView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IScheduleSelectionLeftBottomAreaView.FromPointer); // 0270D5E41940 0x10 View                        ( 000186626010 ModelClassType IScheduleSelectionLeftBottomAreaView IScheduleSelectionLeftBottomAreaView IScheduleSelectionLeftBottomAreaView Pointer )
            value.TokenSource                               = GetObject<CancellationTokenSource>(new IntPtr(p + 0x018), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0270D5E41960 0x18 TokenSource                 ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )

            return value;
        }
    }
}
