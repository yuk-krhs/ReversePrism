using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UnitId                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class CharacterBaseSelectPermanentData
    {
        public int                                      UnitId                                  { get; set; }

        public static CharacterBaseSelectPermanentData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CharacterBaseSelectPermanentData();

            value.UnitId                                    = GetInt32(new IntPtr(p + 0x010)); // 027003A6C458 0x10 UnitId                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
