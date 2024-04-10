using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MenuName                                 000186672F10 ModelPrimitiveType string string string String
    // 018 Order                                    0001865F4260 ModelPrimitiveType int int int Int32
    // 000 k_Separeters                             char[] IL2CPP_TYPE_SZARRAY
    public partial class AddTypeMenuAttribute : DataModel
    {
        public string                                   MenuName                                { get; set; }
        public int                                      Order                                   { get; set; }

        public static AddTypeMenuAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AddTypeMenuAttribute() { Pointer= p0 };

            value.MenuName                                  = GetString(new IntPtr(p + 0x010)); // 02466BFBC440 0x10 MenuName                    ( 000186672F10 ModelPrimitiveType string string string String )
            value.Order                                     = GetInt32(new IntPtr(p + 0x018)); // 02466BFBC460 0x18 Order                       ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
