using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SyncContext                              000186601DB0 ModelClassType SynchronizationContext SynchronizationContext SynchronizationContext Pointer
    // 018 SyncContextNoFlow                        000186601DB0 ModelClassType SynchronizationContext SynchronizationContext SynchronizationContext Pointer
    // 020 LogicalCallContext                       0001865B5810 ModelClassType LogicalCallContext LogicalCallContext LogicalCallContext Pointer
    // 028 IllogicalCallContext                     0001866CCA10 ModelClassType IllogicalCallContext IllogicalCallContext IllogicalCallContext Pointer
    // 030 Flags                                    000186663720 ModelEnumType Flags Flags Flags Int32
    // 038 _localValues                             Dictionary`2<IAsyncLocal, <object>> IL2CPP_TYPE_GENERICINST
    // 040 LocalChangeNotifications                 000185CE0EF8 ModelClassListType List`1<IAsyncLocal> List`1<IAsyncLocal> List<IAsyncLocal> Pointer
    // 000 s_dummyDefaultEC                         ExecutionContext IL2CPP_TYPE_CLASS
    // 008 Default                                  ExecutionContext IL2CPP_TYPE_CLASS
    public partial class ExecutionContext : DataModel
    {
        public SynchronizationContext?                  SyncContext                             { get; set; }
        public SynchronizationContext?                  SyncContextNoFlow                       { get; set; }
        public LogicalCallContext?                      LogicalCallContext                      { get; set; }
        public IllogicalCallContext?                    IllogicalCallContext                    { get; set; }
        public Flags                                    Flags                                   { get; set; }
        public List<IAsyncLocal>?                       LocalChangeNotifications                { get; set; }

        public static ExecutionContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExecutionContext() { Pointer= p0 };

            value.SyncContext                               = GetObject<SynchronizationContext>(new IntPtr(p + 0x010), ReversePrism.DataModels.SynchronizationContext.FromPointer); // 0245A20A1C78 0x10 SyncContext                 ( 000186601DB0 ModelClassType SynchronizationContext SynchronizationContext SynchronizationContext Pointer )
            value.SyncContextNoFlow                         = GetObject<SynchronizationContext>(new IntPtr(p + 0x018), ReversePrism.DataModels.SynchronizationContext.FromPointer); // 0245A20A1C98 0x18 SyncContextNoFlow           ( 000186601DB0 ModelClassType SynchronizationContext SynchronizationContext SynchronizationContext Pointer )
            value.LogicalCallContext                        = GetObject<LogicalCallContext>(new IntPtr(p + 0x020), ReversePrism.DataModels.LogicalCallContext.FromPointer); // 0245A20A1CB8 0x20 LogicalCallContext          ( 0001865B5810 ModelClassType LogicalCallContext LogicalCallContext LogicalCallContext Pointer )
            value.IllogicalCallContext                      = GetObject<IllogicalCallContext>(new IntPtr(p + 0x028), ReversePrism.DataModels.IllogicalCallContext.FromPointer); // 0245A20A1CD8 0x28 IllogicalCallContext        ( 0001866CCA10 ModelClassType IllogicalCallContext IllogicalCallContext IllogicalCallContext Pointer )
            value.Flags                                     = (Flags)GetInt32(new IntPtr(p + 0x030)); // 0245A20A1CF8 0x30 Flags                       ( 000186663720 ModelEnumType Flags Flags Flags Int32 )
            value.LocalChangeNotifications                  = GetObjectList<IAsyncLocal>(new IntPtr(p + 0x040), ReversePrism.DataModels.IAsyncLocal.FromPointer); // 0245A20A1D38 0x40 LocalChangeNotifications    ( 000185CE0EF8 ModelClassListType List`1<IAsyncLocal> List`1<IAsyncLocal> List<IAsyncLocal> Pointer )

            return value;
        }
    }
}
