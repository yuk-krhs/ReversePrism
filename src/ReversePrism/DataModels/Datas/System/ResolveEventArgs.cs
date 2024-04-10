using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     000186672F10 ModelPrimitiveType string string string String
    // 018 RequestingAssembly                       00018658BE80 ModelClassType Assembly Assembly Assembly Pointer
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

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 024666A75D40 0x10 Name                        ( 000186672F10 ModelPrimitiveType string string string String )
            value.RequestingAssembly                        = GetObject<Assembly>(new IntPtr(p + 0x018), ReversePrism.DataModels.Assembly.FromPointer); // 024666A75D60 0x18 RequestingAssembly          ( 00018658BE80 ModelClassType Assembly Assembly Assembly Pointer )

            return value;
        }
    }
}
