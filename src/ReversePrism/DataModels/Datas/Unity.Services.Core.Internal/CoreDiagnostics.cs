using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 CorePackageName                          string IL2CPP_TYPE_STRING
    // 000 CircularDependencyDiagnosticName         string IL2CPP_TYPE_STRING
    // 000 CorePackageInitDiagnosticName            string IL2CPP_TYPE_STRING
    // 000 OperateServicesInitDiagnosticName        string IL2CPP_TYPE_STRING
    // 000 ProjectConfigTagName                     string IL2CPP_TYPE_STRING
    // 000 <Instance>k__BackingField                CoreDiagnostics IL2CPP_TYPE_CLASS
    // 010 <CoreTags>k__BackingField                IDictionary`2<string, string> IL2CPP_TYPE_GENERICINST
    // 018 DiagnosticsComponentProvider             ModelClassType IDiagnosticsComponentProvider IDiagnosticsComponentProvider IDiagnosticsComponentProvider Pointer
    // 020 Diagnostics                              ModelClassType IDiagnostics IDiagnostics IDiagnostics Pointer
    public partial class CoreDiagnostics : DataModel
    {
        public IDiagnosticsComponentProvider?           DiagnosticsComponentProvider            { get; set; }
        public IDiagnostics?                            Diagnostics                             { get; set; }

        public static CoreDiagnostics? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CoreDiagnostics() { Pointer= p0 };

            value.DiagnosticsComponentProvider              = GetObject<IDiagnosticsComponentProvider>(new IntPtr(p + 0x018), ReversePrism.DataModels.IDiagnosticsComponentProvider.FromPointer); // 0x18 DiagnosticsComponentProvider ( ModelClassType IDiagnosticsComponentProvider IDiagnosticsComponentProvider IDiagnosticsComponentProvider Pointer )
            value.Diagnostics                               = GetObject<IDiagnostics>(new IntPtr(p + 0x020), ReversePrism.DataModels.IDiagnostics.FromPointer); // 0x20 Diagnostics                 ( ModelClassType IDiagnostics IDiagnostics IDiagnostics Pointer )

            return value;
        }
    }
}
