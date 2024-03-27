using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Disposable                               00018676B4A0 ModelClassType BooleanDisposable BooleanDisposable BooleanDisposable Pointer
    // 018 DueTime                                  00018668B520 ModelEnumType TimeSpan TimeSpan TimeSpan Int32
    // 020 Action                                   00018667A3C0 ModelClassType Action Action Action Pointer
    public partial class ScheduledItem
    {
        public BooleanDisposable?                       Disposable                              { get; set; }
        public TimeSpan                                 DueTime                                 { get; set; }
        public Action?                                  Action                                  { get; set; }

        public static ScheduledItem? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScheduledItem();

            value.Disposable                                = GetObject<BooleanDisposable>(new IntPtr(p + 0x010), ReversePrism.DataModels.BooleanDisposable.FromPointer); // 0270D985CDD8 0x10 Disposable                  ( 00018676B4A0 ModelClassType BooleanDisposable BooleanDisposable BooleanDisposable Pointer )
            value.DueTime                                   = (TimeSpan)GetInt32(new IntPtr(p + 0x018)); // 0270D985CDF8 0x18 DueTime                     ( 00018668B520 ModelEnumType TimeSpan TimeSpan TimeSpan Int32 )
            value.Action                                    = GetObject<Action>(new IntPtr(p + 0x020), ReversePrism.DataModels.Action.FromPointer); // 0270D985CE18 0x20 Action                      ( 00018667A3C0 ModelClassType Action Action Action Pointer )

            return value;
        }
    }
}
