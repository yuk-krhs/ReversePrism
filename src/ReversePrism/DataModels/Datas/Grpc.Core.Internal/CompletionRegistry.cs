using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Logger                                   ILogger IL2CPP_TYPE_CLASS
    // 010 Environment                              00018669E6D0 ModelClassType GrpcEnvironment GrpcEnvironment GrpcEnvironment Pointer
    // 018 batchContextFactory                      Func`1<BatchContextSafeHandle> IL2CPP_TYPE_GENERICINST
    // 020 requestCallContextFactory                Func`1<RequestCallContextSafeHandle> IL2CPP_TYPE_GENERICINST
    // 028 dict                                     Dictionary`2<<int>, IOpCompletionCallback> IL2CPP_TYPE_GENERICINST
    // 030 SpinLock                                 00018654CAA0 ModelEnumType SpinLock SpinLock SpinLock Int32
    // 038 lastRegisteredKey                        <int> IL2CPP_TYPE_I
    public partial class CompletionRegistry
    {
        public GrpcEnvironment?                         Environment                             { get; set; }
        public SpinLock                                 SpinLock                                { get; set; }

        public static CompletionRegistry? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CompletionRegistry();

            value.Environment                               = GetObject<GrpcEnvironment>(new IntPtr(p + 0x010), ReversePrism.DataModels.GrpcEnvironment.FromPointer); // 02700410DBF0 0x10 Environment                 ( 00018669E6D0 ModelClassType GrpcEnvironment GrpcEnvironment GrpcEnvironment Pointer )
            value.SpinLock                                  = (SpinLock)GetInt32(new IntPtr(p + 0x030)); // 02700410DC70 0x30 SpinLock                    ( 00018654CAA0 ModelEnumType SpinLock SpinLock SpinLock Int32 )

            return value;
        }
    }
}
