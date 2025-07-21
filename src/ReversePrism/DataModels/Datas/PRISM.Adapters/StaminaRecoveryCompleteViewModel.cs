using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 RecoveryType                             ModelEnumType RecoveryType RecoveryType RecoveryType Int32
    // 018 StaminaModel                             ModelClassType StaminaModel StaminaModel StaminaModel Pointer
    // 020 BeforeValue                              ModelPrimitiveType int int int Int32
    // 024 AfterValue                               ModelPrimitiveType int int int Int32
    // 028 RecoveryValue                            ModelPrimitiveType int int int Int32
    // 02C UseJewelAmount                           ModelPrimitiveType int int int Int32
    public partial class StaminaRecoveryCompleteViewModel : DataModel
    {
        public RecoveryType                             RecoveryType                            { get; set; }
        public StaminaModel?                            StaminaModel                            { get; set; }
        public int                                      BeforeValue                             { get; set; }
        public int                                      AfterValue                              { get; set; }
        public int                                      RecoveryValue                           { get; set; }
        public int                                      UseJewelAmount                          { get; set; }

        public static StaminaRecoveryCompleteViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StaminaRecoveryCompleteViewModel() { Pointer= p0 };

            value.RecoveryType                              = (RecoveryType)GetInt32(new IntPtr(p + 0x010)); // 0x10 RecoveryType                ( ModelEnumType RecoveryType RecoveryType RecoveryType Int32 )
            value.StaminaModel                              = GetObject<StaminaModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.StaminaModel.FromPointer); // 0x18 StaminaModel                ( ModelClassType StaminaModel StaminaModel StaminaModel Pointer )
            value.BeforeValue                               = GetInt32(new IntPtr(p + 0x020)); // 0x20 BeforeValue                 ( ModelPrimitiveType int int int Int32 )
            value.AfterValue                                = GetInt32(new IntPtr(p + 0x024)); // 0x24 AfterValue                  ( ModelPrimitiveType int int int Int32 )
            value.RecoveryValue                             = GetInt32(new IntPtr(p + 0x028)); // 0x28 RecoveryValue               ( ModelPrimitiveType int int int Int32 )
            value.UseJewelAmount                            = GetInt32(new IntPtr(p + 0x02C)); // 0x2C UseJewelAmount              ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
