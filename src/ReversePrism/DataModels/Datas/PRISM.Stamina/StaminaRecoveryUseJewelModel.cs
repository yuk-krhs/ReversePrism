using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 RecoveryCost                             ModelPrimitiveType int int int Int32
    // 014 RecoveryValue                            ModelPrimitiveType int int int Int32
    // 018 UseAmount                                ModelPrimitiveType int int int Int32
    // 020 CurrentJewel                             ModelPrimitiveType long long long Int64
    public partial class StaminaRecoveryUseJewelModel : DataModel
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
            var value   = new StaminaRecoveryUseJewelModel() { Pointer= p0 };

            value.RecoveryCost                              = GetInt32(new IntPtr(p + 0x010)); // 0x10 RecoveryCost                ( ModelPrimitiveType int int int Int32 )
            value.RecoveryValue                             = GetInt32(new IntPtr(p + 0x014)); // 0x14 RecoveryValue               ( ModelPrimitiveType int int int Int32 )
            value.UseAmount                                 = GetInt32(new IntPtr(p + 0x018)); // 0x18 UseAmount                   ( ModelPrimitiveType int int int Int32 )
            value.CurrentJewel                              = GetInt64(new IntPtr(p + 0x020)); // 0x20 CurrentJewel                ( ModelPrimitiveType long long long Int64 )

            return value;
        }
    }
}
