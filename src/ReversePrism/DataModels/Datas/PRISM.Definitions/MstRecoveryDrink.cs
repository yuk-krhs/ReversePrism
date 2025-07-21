using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       ModelPrimitiveType int int int Int32
    // 014 StaminaType                              ModelPrimitiveType int int int Int32
    // 018 Value                                    ModelPrimitiveType int int int Int32
    public partial class MstRecoveryDrink : DataModel
    {
        public int                                      Id                                      { get; set; }
        public int                                      StaminaType                             { get; set; }
        public int                                      Value                                   { get; set; }

        public static MstRecoveryDrink? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstRecoveryDrink() { Pointer= p0 };

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0x10 Id                          ( ModelPrimitiveType int int int Int32 )
            value.StaminaType                               = GetInt32(new IntPtr(p + 0x014)); // 0x14 StaminaType                 ( ModelPrimitiveType int int int Int32 )
            value.Value                                     = GetInt32(new IntPtr(p + 0x018)); // 0x18 Value                       ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
