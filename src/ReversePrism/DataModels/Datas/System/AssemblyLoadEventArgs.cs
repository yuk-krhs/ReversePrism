using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 LoadedAssembly                           00018658BE80 ModelClassType Assembly Assembly Assembly Pointer
    public partial class AssemblyLoadEventArgs
    {
        public Assembly?                                LoadedAssembly                          { get; set; }

        public static AssemblyLoadEventArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AssemblyLoadEventArgs();

            value.LoadedAssembly                            = GetObject<Assembly>(new IntPtr(p + 0x010), ReversePrism.DataModels.Assembly.FromPointer); // 0270D69674D0 0x10 LoadedAssembly              ( 00018658BE80 ModelClassType Assembly Assembly Assembly Pointer )

            return value;
        }
    }
}
