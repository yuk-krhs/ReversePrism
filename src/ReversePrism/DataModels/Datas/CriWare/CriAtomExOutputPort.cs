using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 MaxNameLength                            uint IL2CPP_TYPE_U4
    // 020 <NativeHandle>k__BackingField            <int> IL2CPP_TYPE_I
    // 028 HasExistingNativeHandle                  000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class CriAtomExOutputPort : DataModel
    {
        public bool                                     HasExistingNativeHandle                 { get; set; }

        public static CriAtomExOutputPort? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CriAtomExOutputPort() { Pointer= p0 };

            value.HasExistingNativeHandle                   = GetBool(new IntPtr(p + 0x028)); // 02466ACDB360 0x28 HasExistingNativeHandle     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
