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
    public partial class ScheduleSelectionLeftBottomAreaPresenter : DataModel
    {
        public IScheduleSelectionLeftBottomAreaView?    View                                    { get; set; }
        public CancellationTokenSource?                 TokenSource                             { get; set; }

        public static ScheduleSelectionLeftBottomAreaPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScheduleSelectionLeftBottomAreaPresenter() { Pointer= p0 };

            value.View                                      = GetObject<IScheduleSelectionLeftBottomAreaView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IScheduleSelectionLeftBottomAreaView.FromPointer); // 024665EB20B8 0x10 View                        ( 000186626010 ModelClassType IScheduleSelectionLeftBottomAreaView IScheduleSelectionLeftBottomAreaView IScheduleSelectionLeftBottomAreaView Pointer )
            value.TokenSource                               = GetObject<CancellationTokenSource>(new IntPtr(p + 0x018), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 024665EB20D8 0x18 TokenSource                 ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )

            return value;
        }
    }
}
