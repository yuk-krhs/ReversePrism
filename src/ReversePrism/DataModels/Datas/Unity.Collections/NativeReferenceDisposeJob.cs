using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Data                                     000186690AB0 ModelEnumType NativeReferenceDispose NativeReferenceDispose NativeReferenceDispose Int32
    public partial class NativeReferenceDisposeJob
    {
        public NativeReferenceDispose                   Data                                    { get; set; }

        public static NativeReferenceDisposeJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NativeReferenceDisposeJob();

            value.Data                                      = (NativeReferenceDispose)GetInt32(new IntPtr(p + 0x010)); // 0270D0869A68 0x10 Data                        ( 000186690AB0 ModelEnumType NativeReferenceDispose NativeReferenceDispose NativeReferenceDispose Int32 )

            return value;
        }
    }
}
