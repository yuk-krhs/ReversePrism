using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Start                                    ModelPrimitiveType int int int Int32
    // 01C Count                                    ModelPrimitiveType int int int Int32
    // 020 Scheduler                                ModelClassType IScheduler IScheduler IScheduler Pointer
    public partial class RangeObservable : DataModel
    {
        public int                                      Start                                   { get; set; }
        public int                                      Count                                   { get; set; }
        public IScheduler?                              Scheduler                               { get; set; }

        public static RangeObservable? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RangeObservable() { Pointer= p0 };

            value.Start                                     = GetInt32(new IntPtr(p + 0x018)); // 0x18 Start                       ( ModelPrimitiveType int int int Int32 )
            value.Count                                     = GetInt32(new IntPtr(p + 0x01C)); // 0x1C Count                       ( ModelPrimitiveType int int int Int32 )
            value.Scheduler                                 = GetObject<IScheduler>(new IntPtr(p + 0x020), ReversePrism.DataModels.IScheduler.FromPointer); // 0x20 Scheduler                   ( ModelClassType IScheduler IScheduler IScheduler Pointer )

            return value;
        }
    }
}
