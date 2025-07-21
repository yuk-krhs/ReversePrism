using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       ModelPrimitiveType int int int Int32
    // 014 StaminaRecoveryType                      ModelEnumType StaminaType StaminaType StaminaType Int32
    // 018 RecoveryValue                            ModelPrimitiveType int int int Int32
    public partial class StaminaRecoveryItemMasterModel : DataModel
    {
        public int                                      Id                                      { get; set; }
        public StaminaType                              StaminaRecoveryType                     { get; set; }
        public int                                      RecoveryValue                           { get; set; }

        public static StaminaRecoveryItemMasterModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StaminaRecoveryItemMasterModel() { Pointer= p0 };

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0x10 Id                          ( ModelPrimitiveType int int int Int32 )
            value.StaminaRecoveryType                       = (StaminaType)GetInt32(new IntPtr(p + 0x014)); // 0x14 StaminaRecoveryType         ( ModelEnumType StaminaType StaminaType StaminaType Int32 )
            value.RecoveryValue                             = GetInt32(new IntPtr(p + 0x018)); // 0x18 RecoveryValue               ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
