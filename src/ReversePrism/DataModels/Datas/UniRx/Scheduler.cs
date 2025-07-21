using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 CurrentThread                            IScheduler IL2CPP_TYPE_CLASS
    // 008 Immediate                                IScheduler IL2CPP_TYPE_CLASS
    // 010 ThreadPool                               ModelClassType IScheduler IScheduler IScheduler Pointer
    // 018 MainThread                               ModelClassType IScheduler IScheduler IScheduler Pointer
    // 020 MainThreadIgnoreTimeScale                ModelClassType IScheduler IScheduler IScheduler Pointer
    // 028 MainThreadFixedUpdate                    ModelClassType IScheduler IScheduler IScheduler Pointer
    // 030 MainThreadEndOfFrame                     ModelClassType IScheduler IScheduler IScheduler Pointer
    public partial class Scheduler : DataModel
    {
        public IScheduler?                              ThreadPool                              { get; set; }
        public IScheduler?                              MainThread                              { get; set; }
        public IScheduler?                              MainThreadIgnoreTimeScale               { get; set; }
        public IScheduler?                              MainThreadFixedUpdate                   { get; set; }
        public IScheduler?                              MainThreadEndOfFrame                    { get; set; }

        public static Scheduler? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Scheduler() { Pointer= p0 };

            value.ThreadPool                                = GetObject<IScheduler>(new IntPtr(p + 0x010), ReversePrism.DataModels.IScheduler.FromPointer); // 0x10 ThreadPool                  ( ModelClassType IScheduler IScheduler IScheduler Pointer )
            value.MainThread                                = GetObject<IScheduler>(new IntPtr(p + 0x018), ReversePrism.DataModels.IScheduler.FromPointer); // 0x18 MainThread                  ( ModelClassType IScheduler IScheduler IScheduler Pointer )
            value.MainThreadIgnoreTimeScale                 = GetObject<IScheduler>(new IntPtr(p + 0x020), ReversePrism.DataModels.IScheduler.FromPointer); // 0x20 MainThreadIgnoreTimeScale   ( ModelClassType IScheduler IScheduler IScheduler Pointer )
            value.MainThreadFixedUpdate                     = GetObject<IScheduler>(new IntPtr(p + 0x028), ReversePrism.DataModels.IScheduler.FromPointer); // 0x28 MainThreadFixedUpdate       ( ModelClassType IScheduler IScheduler IScheduler Pointer )
            value.MainThreadEndOfFrame                      = GetObject<IScheduler>(new IntPtr(p + 0x030), ReversePrism.DataModels.IScheduler.FromPointer); // 0x30 MainThreadEndOfFrame        ( ModelClassType IScheduler IScheduler IScheduler Pointer )

            return value;
        }
    }
}
