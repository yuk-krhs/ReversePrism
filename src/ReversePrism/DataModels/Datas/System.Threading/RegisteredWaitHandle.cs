using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 WaitObject                               ModelClassType WaitHandle WaitHandle WaitHandle Pointer
    // 020 Callback                                 ModelClassType WaitOrTimerCallback WaitOrTimerCallback WaitOrTimerCallback Pointer
    // 028 _state                                   <object> IL2CPP_TYPE_OBJECT
    // 030 FinalEvent                               ModelClassType WaitHandle WaitHandle WaitHandle Pointer
    // 038 CancelEvent                              ModelClassType ManualResetEvent ManualResetEvent ManualResetEvent Pointer
    // 040 Timeout                                  ModelEnumType TimeSpan TimeSpan TimeSpan Int32
    // 048 CallsInProcess                           ModelPrimitiveType int int int Int32
    // 04C ExecuteOnlyOnce                          ModelPrimitiveType bool bool bool Bool
    // 04D Unregistered                             ModelPrimitiveType bool bool bool Bool
    public partial class RegisteredWaitHandle : DataModel
    {
        public WaitHandle?                              WaitObject                              { get; set; }
        public WaitOrTimerCallback?                     Callback                                { get; set; }
        public WaitHandle?                              FinalEvent                              { get; set; }
        public ManualResetEvent?                        CancelEvent                             { get; set; }
        public TimeSpan                                 Timeout                                 { get; set; }
        public int                                      CallsInProcess                          { get; set; }
        public bool                                     ExecuteOnlyOnce                         { get; set; }
        public bool                                     Unregistered                            { get; set; }

        public static RegisteredWaitHandle? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RegisteredWaitHandle() { Pointer= p0 };

            value.WaitObject                                = GetObject<WaitHandle>(new IntPtr(p + 0x018), ReversePrism.DataModels.WaitHandle.FromPointer); // 0x18 WaitObject                  ( ModelClassType WaitHandle WaitHandle WaitHandle Pointer )
            value.Callback                                  = GetObject<WaitOrTimerCallback>(new IntPtr(p + 0x020), ReversePrism.DataModels.WaitOrTimerCallback.FromPointer); // 0x20 Callback                    ( ModelClassType WaitOrTimerCallback WaitOrTimerCallback WaitOrTimerCallback Pointer )
            value.FinalEvent                                = GetObject<WaitHandle>(new IntPtr(p + 0x030), ReversePrism.DataModels.WaitHandle.FromPointer); // 0x30 FinalEvent                  ( ModelClassType WaitHandle WaitHandle WaitHandle Pointer )
            value.CancelEvent                               = GetObject<ManualResetEvent>(new IntPtr(p + 0x038), ReversePrism.DataModels.ManualResetEvent.FromPointer); // 0x38 CancelEvent                 ( ModelClassType ManualResetEvent ManualResetEvent ManualResetEvent Pointer )
            value.Timeout                                   = (TimeSpan)GetInt32(new IntPtr(p + 0x040)); // 0x40 Timeout                     ( ModelEnumType TimeSpan TimeSpan TimeSpan Int32 )
            value.CallsInProcess                            = GetInt32(new IntPtr(p + 0x048)); // 0x48 CallsInProcess              ( ModelPrimitiveType int int int Int32 )
            value.ExecuteOnlyOnce                           = GetBool(new IntPtr(p + 0x04C)); // 0x4C ExecuteOnlyOnce             ( ModelPrimitiveType bool bool bool Bool )
            value.Unregistered                              = GetBool(new IntPtr(p + 0x04D)); // 0x4D Unregistered                ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
