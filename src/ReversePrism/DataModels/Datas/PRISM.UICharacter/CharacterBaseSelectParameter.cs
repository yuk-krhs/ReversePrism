using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UnitId                                   0001865F4260 ModelPrimitiveType int int int Int32
    public partial class CharacterBaseSelectParameter
    {
        public int                                      UnitId                                  { get; set; }

        public static CharacterBaseSelectParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CharacterBaseSelectParameter();

            value.UnitId                                    = GetInt32(new IntPtr(p + 0x010)); // 0270D5DB04B8 0x10 UnitId                      ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
