using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Scheduler                                ModelClassType IScheduler IScheduler IScheduler Pointer
    // 018 Disposable                               ModelClassType IDisposable IDisposable IDisposable Pointer
    // 020 IsDisposed                               ModelPrimitiveType int int int Int32
    public partial class ScheduledDisposable : DataModel
    {
        public IScheduler?                              Scheduler                               { get; set; }
        public IDisposable?                             Disposable                              { get; set; }
        public int                                      IsDisposed                              { get; set; }

        public static ScheduledDisposable? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScheduledDisposable() { Pointer= p0 };

            value.Scheduler                                 = GetObject<IScheduler>(new IntPtr(p + 0x010), ReversePrism.DataModels.IScheduler.FromPointer); // 0x10 Scheduler                   ( ModelClassType IScheduler IScheduler IScheduler Pointer )
            value.Disposable                                = GetObject<IDisposable>(new IntPtr(p + 0x018), ReversePrism.DataModels.IDisposable.FromPointer); // 0x18 Disposable                  ( ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.IsDisposed                                = GetInt32(new IntPtr(p + 0x020)); // 0x20 IsDisposed                  ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
