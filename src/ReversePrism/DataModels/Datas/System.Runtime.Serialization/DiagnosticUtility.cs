using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 ShouldTraceError                         bool IL2CPP_TYPE_BOOLEAN
    // 001 ShouldTraceWarning                       bool IL2CPP_TYPE_BOOLEAN
    // 002 ShouldTraceInformation                   bool IL2CPP_TYPE_BOOLEAN
    // 003 ShouldTraceVerbose                       bool IL2CPP_TYPE_BOOLEAN
    public partial class DiagnosticUtility
    {

        public static DiagnosticUtility? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DiagnosticUtility();


            return value;
        }
    }
}
