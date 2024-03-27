using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 _stateObject                             <object> IL2CPP_TYPE_OBJECT
    // 018 IsWrite                                  0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 020 WaitHandle                               00018660A400 ModelClassType ManualResetEvent ManualResetEvent ManualResetEvent Pointer
    // 028 ExceptionInfo                            0001865CBD80 ModelClassType ExceptionDispatchInfo ExceptionDispatchInfo ExceptionDispatchInfo Pointer
    // 030 EndXxxCalled                             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 034 BytesRead                                0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class SynchronousAsyncResult
    {
        public bool                                     IsWrite                                 { get; set; }
        public ManualResetEvent?                        WaitHandle                              { get; set; }
        public ExceptionDispatchInfo?                   ExceptionInfo                           { get; set; }
        public bool                                     EndXxxCalled                            { get; set; }
        public int                                      BytesRead                               { get; set; }

        public static SynchronousAsyncResult? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SynchronousAsyncResult();

            value.IsWrite                                   = GetBool(new IntPtr(p + 0x018)); // 0270D6E3C720 0x18 IsWrite                     ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.WaitHandle                                = GetObject<ManualResetEvent>(new IntPtr(p + 0x020), ReversePrism.DataModels.ManualResetEvent.FromPointer); // 0270D6E3C740 0x20 WaitHandle                  ( 00018660A400 ModelClassType ManualResetEvent ManualResetEvent ManualResetEvent Pointer )
            value.ExceptionInfo                             = GetObject<ExceptionDispatchInfo>(new IntPtr(p + 0x028), ReversePrism.DataModels.ExceptionDispatchInfo.FromPointer); // 0270D6E3C760 0x28 ExceptionInfo               ( 0001865CBD80 ModelClassType ExceptionDispatchInfo ExceptionDispatchInfo ExceptionDispatchInfo Pointer )
            value.EndXxxCalled                              = GetBool(new IntPtr(p + 0x030)); // 0270D6E3C780 0x30 EndXxxCalled                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.BytesRead                                 = GetInt32(new IntPtr(p + 0x034)); // 0270D6E3C7A0 0x34 BytesRead                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
