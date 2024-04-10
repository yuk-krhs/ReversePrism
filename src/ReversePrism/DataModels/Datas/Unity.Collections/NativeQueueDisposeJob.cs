using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Data                                     0001866900F0 ModelEnumType NativeQueueDispose NativeQueueDispose NativeQueueDispose Int32
    public partial class NativeQueueDisposeJob : DataModel
    {
        public NativeQueueDispose                       Data                                    { get; set; }

        public static NativeQueueDisposeJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NativeQueueDisposeJob() { Pointer= p0 };

            value.Data                                      = (NativeQueueDispose)GetInt32(new IntPtr(p + 0x010)); // 0246608B0D18 0x10 Data                        ( 0001866900F0 ModelEnumType NativeQueueDispose NativeQueueDispose NativeQueueDispose Int32 )

            return value;
        }
    }
}
