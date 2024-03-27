using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Start                                    0001866BA8B0 ModelClassType Delegate Delegate Delegate Pointer
    // 018 _startArg                                <object> IL2CPP_TYPE_OBJECT
    // 020 ExecutionContext                         0001865CCA80 ModelClassType ExecutionContext ExecutionContext ExecutionContext Pointer
    // 000 _ccb                                     ContextCallback IL2CPP_TYPE_CLASS
    public partial class ThreadHelper
    {
        public Delegate?                                Start                                   { get; set; }
        public ExecutionContext?                        ExecutionContext                        { get; set; }

        public static ThreadHelper? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ThreadHelper();

            value.Start                                     = GetObject<Delegate>(new IntPtr(p + 0x010), ReversePrism.DataModels.Delegate.FromPointer); // 027003E52860 0x10 Start                       ( 0001866BA8B0 ModelClassType Delegate Delegate Delegate Pointer )
            value.ExecutionContext                          = GetObject<ExecutionContext>(new IntPtr(p + 0x020), ReversePrism.DataModels.ExecutionContext.FromPointer); // 027003E528A0 0x20 ExecutionContext            ( 0001865CCA80 ModelClassType ExecutionContext ExecutionContext ExecutionContext Pointer )

            return value;
        }
    }
}
