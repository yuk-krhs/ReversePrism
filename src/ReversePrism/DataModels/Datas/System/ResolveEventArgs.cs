using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     ModelPrimitiveType string string string String
    // 018 RequestingAssembly                       ModelClassType Assembly Assembly Assembly Pointer
    public partial class ResolveEventArgs : DataModel
    {
        public string                                   Name                                    { get; set; }
        public Assembly?                                RequestingAssembly                      { get; set; }

        public static ResolveEventArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ResolveEventArgs() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0x10 Name                        ( ModelPrimitiveType string string string String )
            value.RequestingAssembly                        = GetObject<Assembly>(new IntPtr(p + 0x018), ReversePrism.DataModels.Assembly.FromPointer); // 0x18 RequestingAssembly          ( ModelClassType Assembly Assembly Assembly Pointer )

            return value;
        }
    }
}
