using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Phase                                    ModelEnumType CallbackPhase CallbackPhase CallbackPhase Int32
    // 014 InvokePolicy                             ModelEnumType InvokePolicy InvokePolicy InvokePolicy Int32
    public partial class EventCallbackFunctorBase : DataModel
    {
        public CallbackPhase                            Phase                                   { get; set; }
        public InvokePolicy                             InvokePolicy                            { get; set; }

        public static EventCallbackFunctorBase? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EventCallbackFunctorBase() { Pointer= p0 };

            value.Phase                                     = (CallbackPhase)GetInt32(new IntPtr(p + 0x010)); // 0x10 Phase                       ( ModelEnumType CallbackPhase CallbackPhase CallbackPhase Int32 )
            value.InvokePolicy                              = (InvokePolicy)GetInt32(new IntPtr(p + 0x014)); // 0x14 InvokePolicy                ( ModelEnumType InvokePolicy InvokePolicy InvokePolicy Int32 )

            return value;
        }
    }
}
