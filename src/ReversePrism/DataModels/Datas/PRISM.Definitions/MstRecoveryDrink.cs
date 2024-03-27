using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       0001865F4260 ModelPrimitiveType int int int Int32
    // 014 StaminaType                              0001865F4260 ModelPrimitiveType int int int Int32
    // 018 Value                                    0001865F4260 ModelPrimitiveType int int int Int32
    public partial class MstRecoveryDrink
    {
        public int                                      Id                                      { get; set; }
        public int                                      StaminaType                             { get; set; }
        public int                                      Value                                   { get; set; }

        public static MstRecoveryDrink? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstRecoveryDrink();

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0270046748E8 0x10 Id                          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.StaminaType                               = GetInt32(new IntPtr(p + 0x014)); // 027004674908 0x14 StaminaType                 ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Value                                     = GetInt32(new IntPtr(p + 0x018)); // 027004674928 0x18 Value                       ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
