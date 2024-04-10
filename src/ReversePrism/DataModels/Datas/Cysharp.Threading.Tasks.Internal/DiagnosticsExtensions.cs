using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 displayFilenames                         bool IL2CPP_TYPE_BOOLEAN
    // 008 typeBeautifyRegex                        Regex IL2CPP_TYPE_CLASS
    // 010 builtInTypeNames                         Dictionary`2<Type, string> IL2CPP_TYPE_GENERICINST
    public partial class DiagnosticsExtensions : DataModel
    {

        public static DiagnosticsExtensions? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DiagnosticsExtensions() { Pointer= p0 };


            return value;
        }
    }
}
