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
    // 010 ThreadPool                               000186629AF0 ModelClassType IScheduler IScheduler IScheduler Pointer
    // 018 MainThread                               000186629400 ModelClassType IScheduler IScheduler IScheduler Pointer
    // 020 MainThreadIgnoreTimeScale                000186629400 ModelClassType IScheduler IScheduler IScheduler Pointer
    // 028 MainThreadFixedUpdate                    000186629400 ModelClassType IScheduler IScheduler IScheduler Pointer
    // 030 MainThreadEndOfFrame                     000186629400 ModelClassType IScheduler IScheduler IScheduler Pointer
    public partial class Scheduler
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
            var value   = new Scheduler();

            value.ThreadPool                                = GetObject<IScheduler>(new IntPtr(p + 0x010), ReversePrism.DataModels.IScheduler.FromPointer); // 027003C1DAD8 0x10 ThreadPool                  ( 000186629AF0 ModelClassType IScheduler IScheduler IScheduler Pointer )
            value.MainThread                                = GetObject<IScheduler>(new IntPtr(p + 0x018), ReversePrism.DataModels.IScheduler.FromPointer); // 027003C1DAF8 0x18 MainThread                  ( 000186629400 ModelClassType IScheduler IScheduler IScheduler Pointer )
            value.MainThreadIgnoreTimeScale                 = GetObject<IScheduler>(new IntPtr(p + 0x020), ReversePrism.DataModels.IScheduler.FromPointer); // 027003C1DB18 0x20 MainThreadIgnoreTimeScale   ( 000186629400 ModelClassType IScheduler IScheduler IScheduler Pointer )
            value.MainThreadFixedUpdate                     = GetObject<IScheduler>(new IntPtr(p + 0x028), ReversePrism.DataModels.IScheduler.FromPointer); // 027003C1DB38 0x28 MainThreadFixedUpdate       ( 000186629400 ModelClassType IScheduler IScheduler IScheduler Pointer )
            value.MainThreadEndOfFrame                      = GetObject<IScheduler>(new IntPtr(p + 0x030), ReversePrism.DataModels.IScheduler.FromPointer); // 027003C1DB58 0x30 MainThreadEndOfFrame        ( 000186629400 ModelClassType IScheduler IScheduler IScheduler Pointer )

            return value;
        }
    }
}
