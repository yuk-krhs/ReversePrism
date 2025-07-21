using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Type                                     ModelPrimitiveType int int int Int32
    public partial class CharacterTopParameter : DataModel
    {
        public int                                      Type                                    { get; set; }

        public static CharacterTopParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CharacterTopParameter() { Pointer= p0 };

            value.Type                                      = GetInt32(new IntPtr(p + 0x010)); // 0x10 Type                        ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
