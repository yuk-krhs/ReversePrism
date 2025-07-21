using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_DelagateCallback                       ModelClassType SendOrPostCallback SendOrPostCallback SendOrPostCallback Pointer
    // 018 m_DelagateState                          <object> IL2CPP_TYPE_OBJECT
    // 020 M_WaitHandle                             ModelClassType ManualResetEvent ManualResetEvent ManualResetEvent Pointer
    public partial class WorkRequest : DataModel
    {
        public SendOrPostCallback?                      M_DelagateCallback                      { get; set; }
        public ManualResetEvent?                        M_WaitHandle                            { get; set; }

        public static WorkRequest? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WorkRequest() { Pointer= p0 };

            value.M_DelagateCallback                        = GetObject<SendOrPostCallback>(new IntPtr(p + 0x010), ReversePrism.DataModels.SendOrPostCallback.FromPointer); // 0x10 M_DelagateCallback          ( ModelClassType SendOrPostCallback SendOrPostCallback SendOrPostCallback Pointer )
            value.M_WaitHandle                              = GetObject<ManualResetEvent>(new IntPtr(p + 0x020), ReversePrism.DataModels.ManualResetEvent.FromPointer); // 0x20 M_WaitHandle                ( ModelClassType ManualResetEvent ManualResetEvent ManualResetEvent Pointer )

            return value;
        }
    }
}
