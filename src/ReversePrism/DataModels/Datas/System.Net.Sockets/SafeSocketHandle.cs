using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Blocking_threads                         000185D14088 ModelClassListType List`1<Thread> List`1<Thread> List<Thread> Pointer
    // 028 threads_stacktraces                      Dictionary`2<Thread, StackTrace> IL2CPP_TYPE_GENERICINST
    // 030 In_cleanup                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 THROW_ON_ABORT_RETRIES                   bool IL2CPP_TYPE_BOOLEAN
    public partial class SafeSocketHandle : DataModel
    {
        public List<Thread>?                            Blocking_threads                        { get; set; }
        public bool                                     In_cleanup                              { get; set; }

        public static SafeSocketHandle? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SafeSocketHandle() { Pointer= p0 };

            value.Blocking_threads                          = GetObjectList<Thread>(new IntPtr(p + 0x020), ReversePrism.DataModels.Thread.FromPointer); // 024667B527A8 0x20 Blocking_threads            ( 000185D14088 ModelClassListType List`1<Thread> List`1<Thread> List<Thread> Pointer )
            value.In_cleanup                                = GetBool(new IntPtr(p + 0x030)); // 024667B527E8 0x30 In_cleanup                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
