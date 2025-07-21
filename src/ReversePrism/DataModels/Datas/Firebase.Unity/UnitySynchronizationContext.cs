using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _instance                                UnitySynchronizationContext IL2CPP_TYPE_CLASS
    // 018 queue                                    Queue`1<Tuple`2<SendOrPostCallback, <object>>> IL2CPP_TYPE_GENERICINST
    // 020 Behavior                                 ModelClassType SynchronizationContextBehavoir SynchronizationContextBehavoir SynchronizationContextBehavoir Pointer
    // 028 MainThreadId                             ModelPrimitiveType int int int Int32
    // 000 Timeout                                  int IL2CPP_TYPE_I4
    // 008 signalDictionary                         Dictionary`2<int, ManualResetEvent> IL2CPP_TYPE_GENERICINST
    public partial class UnitySynchronizationContext : DataModel
    {
        public SynchronizationContextBehavoir?          Behavior                                { get; set; }
        public int                                      MainThreadId                            { get; set; }

        public static UnitySynchronizationContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UnitySynchronizationContext() { Pointer= p0 };

            value.Behavior                                  = GetObject<SynchronizationContextBehavoir>(new IntPtr(p + 0x020), ReversePrism.DataModels.SynchronizationContextBehavoir.FromPointer); // 0x20 Behavior                    ( ModelClassType SynchronizationContextBehavoir SynchronizationContextBehavoir SynchronizationContextBehavoir Pointer )
            value.MainThreadId                              = GetInt32(new IntPtr(p + 0x028)); // 0x28 MainThreadId                ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
