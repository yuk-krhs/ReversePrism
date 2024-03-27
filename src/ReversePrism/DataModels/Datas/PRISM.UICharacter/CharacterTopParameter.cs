using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Type                                     0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class CharacterTopParameter
    {
        public int                                      Type                                    { get; set; }

        public static CharacterTopParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CharacterTopParameter();

            value.Type                                      = GetInt32(new IntPtr(p + 0x010)); // 0270D5DB0798 0x10 Type                        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
