using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 exceptionTrace                           ExceptionTrace IL2CPP_TYPE_CLASS
    // 008 diagnosticTrace                          EtwDiagnosticTrace IL2CPP_TYPE_CLASS
    // 010 AsynchronousThreadExceptionHandler       0001866DF5A0 ModelClassType ExceptionHandler ExceptionHandler ExceptionHandler Pointer
    public partial class Fx
    {
        public ExceptionHandler?                        AsynchronousThreadExceptionHandler      { get; set; }

        public static Fx? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Fx();

            value.AsynchronousThreadExceptionHandler        = GetObject<ExceptionHandler>(new IntPtr(p + 0x010), ReversePrism.DataModels.ExceptionHandler.FromPointer); // 027004CF71F0 0x10 AsynchronousThreadExceptionHandler ( 0001866DF5A0 ModelClassType ExceptionHandler ExceptionHandler ExceptionHandler Pointer )

            return value;
        }
    }
}
