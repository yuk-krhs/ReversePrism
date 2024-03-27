using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 RecoveryCost                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 014 RecoveryValue                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 UseAmount                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 CurrentJewel                             0001865F7700 ModelPrimitiveType long long long Int64
    public partial class StaminaRecoveryUseJewelModel
    {
        public int                                      RecoveryCost                            { get; set; }
        public int                                      RecoveryValue                           { get; set; }
        public int                                      UseAmount                               { get; set; }
        public long                                     CurrentJewel                            { get; set; }

        public static StaminaRecoveryUseJewelModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StaminaRecoveryUseJewelModel();

            value.RecoveryCost                              = GetInt32(new IntPtr(p + 0x010)); // 0270D5616380 0x10 RecoveryCost                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.RecoveryValue                             = GetInt32(new IntPtr(p + 0x014)); // 0270D56163A0 0x14 RecoveryValue               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.UseAmount                                 = GetInt32(new IntPtr(p + 0x018)); // 0270D56163C0 0x18 UseAmount                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CurrentJewel                              = GetInt64(new IntPtr(p + 0x020)); // 0270D56163E0 0x20 CurrentJewel                ( 0001865F7700 ModelPrimitiveType long long long Int64 )

            return value;
        }
    }
}
