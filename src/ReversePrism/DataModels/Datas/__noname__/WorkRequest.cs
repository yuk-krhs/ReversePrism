using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_DelagateCallback                       000186725340 ModelClassType SendOrPostCallback SendOrPostCallback SendOrPostCallback Pointer
    // 018 m_DelagateState                          <object> IL2CPP_TYPE_OBJECT
    // 020 M_WaitHandle                             00018660AB00 ModelClassType ManualResetEvent ManualResetEvent ManualResetEvent Pointer
    public partial class WorkRequest
    {
        public SendOrPostCallback?                      M_DelagateCallback                      { get; set; }
        public ManualResetEvent?                        M_WaitHandle                            { get; set; }

        public static WorkRequest? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WorkRequest();

            value.M_DelagateCallback                        = GetObject<SendOrPostCallback>(new IntPtr(p + 0x010), ReversePrism.DataModels.SendOrPostCallback.FromPointer); // 02700206E1F0 0x10 M_DelagateCallback          ( 000186725340 ModelClassType SendOrPostCallback SendOrPostCallback SendOrPostCallback Pointer )
            value.M_WaitHandle                              = GetObject<ManualResetEvent>(new IntPtr(p + 0x020), ReversePrism.DataModels.ManualResetEvent.FromPointer); // 02700206E230 0x20 M_WaitHandle                ( 00018660AB00 ModelClassType ManualResetEvent ManualResetEvent ManualResetEvent Pointer )

            return value;
        }
    }
}
