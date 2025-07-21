using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 _stateObject                             <object> IL2CPP_TYPE_OBJECT
    // 018 IsWrite                                  ModelPrimitiveType bool bool bool Bool
    // 020 WaitHandle                               ModelClassType ManualResetEvent ManualResetEvent ManualResetEvent Pointer
    // 028 ExceptionInfo                            ModelClassType ExceptionDispatchInfo ExceptionDispatchInfo ExceptionDispatchInfo Pointer
    // 030 EndXxxCalled                             ModelPrimitiveType bool bool bool Bool
    // 034 BytesRead                                ModelPrimitiveType int int int Int32
    public partial class SynchronousAsyncResult : DataModel
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
            var value   = new SynchronousAsyncResult() { Pointer= p0 };

            value.IsWrite                                   = GetBool(new IntPtr(p + 0x018)); // 0x18 IsWrite                     ( ModelPrimitiveType bool bool bool Bool )
            value.WaitHandle                                = GetObject<ManualResetEvent>(new IntPtr(p + 0x020), ReversePrism.DataModels.ManualResetEvent.FromPointer); // 0x20 WaitHandle                  ( ModelClassType ManualResetEvent ManualResetEvent ManualResetEvent Pointer )
            value.ExceptionInfo                             = GetObject<ExceptionDispatchInfo>(new IntPtr(p + 0x028), ReversePrism.DataModels.ExceptionDispatchInfo.FromPointer); // 0x28 ExceptionInfo               ( ModelClassType ExceptionDispatchInfo ExceptionDispatchInfo ExceptionDispatchInfo Pointer )
            value.EndXxxCalled                              = GetBool(new IntPtr(p + 0x030)); // 0x30 EndXxxCalled                ( ModelPrimitiveType bool bool bool Bool )
            value.BytesRead                                 = GetInt32(new IntPtr(p + 0x034)); // 0x34 BytesRead                   ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
