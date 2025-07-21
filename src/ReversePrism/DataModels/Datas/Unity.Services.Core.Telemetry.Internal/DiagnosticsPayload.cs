using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Diagnostics                              ModelEnumListType List`1<Diagnostic> List`1<Diagnostic> List<Diagnostic> Pointer
    // 018 CommonTags                               Dictionary`2<string, string> IL2CPP_TYPE_GENERICINST
    // 020 DiagnosticsCommonTags                    Dictionary`2<string, string> IL2CPP_TYPE_GENERICINST
    public partial class DiagnosticsPayload : DataModel
    {
        public List<Diagnostic>?                        Diagnostics                             { get; set; }

        public static DiagnosticsPayload? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DiagnosticsPayload() { Pointer= p0 };

            value.Diagnostics                               = GetEnumList<Diagnostic>(new IntPtr(p + 0x010)); // 0x10 Diagnostics                 ( ModelEnumListType List`1<Diagnostic> List`1<Diagnostic> List<Diagnostic> Pointer )

            return value;
        }
    }
}
