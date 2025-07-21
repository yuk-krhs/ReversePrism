using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Disposable                               ModelClassType BooleanDisposable BooleanDisposable BooleanDisposable Pointer
    // 018 DueTime                                  ModelEnumType TimeSpan TimeSpan TimeSpan Int32
    // 020 Action                                   ModelClassType Action Action Action Pointer
    public partial class ScheduledItem : DataModel
    {
        public BooleanDisposable?                       Disposable                              { get; set; }
        public TimeSpan                                 DueTime                                 { get; set; }
        public Action?                                  Action                                  { get; set; }

        public static ScheduledItem? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScheduledItem() { Pointer= p0 };

            value.Disposable                                = GetObject<BooleanDisposable>(new IntPtr(p + 0x010), ReversePrism.DataModels.BooleanDisposable.FromPointer); // 0x10 Disposable                  ( ModelClassType BooleanDisposable BooleanDisposable BooleanDisposable Pointer )
            value.DueTime                                   = (TimeSpan)GetInt32(new IntPtr(p + 0x018)); // 0x18 DueTime                     ( ModelEnumType TimeSpan TimeSpan TimeSpan Int32 )
            value.Action                                    = GetObject<Action>(new IntPtr(p + 0x020), ReversePrism.DataModels.Action.FromPointer); // 0x20 Action                      ( ModelClassType Action Action Action Pointer )

            return value;
        }
    }
}
