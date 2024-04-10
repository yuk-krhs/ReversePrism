using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 DEFAULT_SPIN_SP                          int IL2CPP_TYPE_I4
    // 010 m_lock                                   <object> IL2CPP_TYPE_OBJECT
    // 018 M_eventObj                               00018660A400 ModelClassType ManualResetEvent ManualResetEvent ManualResetEvent Pointer
    // 020 M_combinedState                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 SignalledState_BitMask                   int IL2CPP_TYPE_I4
    // 000 SignalledState_ShiftCount                int IL2CPP_TYPE_I4
    // 000 Dispose_BitMask                          int IL2CPP_TYPE_I4
    // 000 SpinCountState_BitMask                   int IL2CPP_TYPE_I4
    // 000 SpinCountState_ShiftCount                int IL2CPP_TYPE_I4
    // 000 SpinCountState_MaxValue                  int IL2CPP_TYPE_I4
    // 000 NumWaitersState_BitMask                  int IL2CPP_TYPE_I4
    // 000 NumWaitersState_ShiftCount               int IL2CPP_TYPE_I4
    // 000 NumWaitersState_MaxValue                 int IL2CPP_TYPE_I4
    // 000 s_cancellationTokenCallback              Action`1<<object>> IL2CPP_TYPE_GENERICINST
    public partial class ManualResetEventSlim : DataModel
    {
        public ManualResetEvent?                        M_eventObj                              { get; set; }
        public int                                      M_combinedState                         { get; set; }

        public static ManualResetEventSlim? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ManualResetEventSlim() { Pointer= p0 };

            value.M_eventObj                                = GetObject<ManualResetEvent>(new IntPtr(p + 0x018), ReversePrism.DataModels.ManualResetEvent.FromPointer); // 024666B24378 0x18 M_eventObj                  ( 00018660A400 ModelClassType ManualResetEvent ManualResetEvent ManualResetEvent Pointer )
            value.M_combinedState                           = GetInt32(new IntPtr(p + 0x020)); // 024666B24398 0x20 M_combinedState             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
