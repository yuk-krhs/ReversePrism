using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Implementation                           00018662B3B0 ModelClassType IScriptableRuntimeReflectionSystem IScriptableRuntimeReflectionSystem IScriptableRuntimeReflectionSystem Pointer
    public partial class ScriptableRuntimeReflectionSystemWrapper : DataModel
    {
        public IScriptableRuntimeReflectionSystem?      Implementation                          { get; set; }

        public static ScriptableRuntimeReflectionSystemWrapper? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScriptableRuntimeReflectionSystemWrapper() { Pointer= p0 };

            value.Implementation                            = GetObject<IScriptableRuntimeReflectionSystem>(new IntPtr(p + 0x010), ReversePrism.DataModels.IScriptableRuntimeReflectionSystem.FromPointer); // 0245A23A0E38 0x10 Implementation              ( 00018662B3B0 ModelClassType IScriptableRuntimeReflectionSystem IScriptableRuntimeReflectionSystem IScriptableRuntimeReflectionSystem Pointer )

            return value;
        }
    }
}
