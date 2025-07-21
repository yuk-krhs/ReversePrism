using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<RecoverStaminaByInGameCurrencyArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 StaminaTypeFieldNumber                   int IL2CPP_TYPE_I4
    // 018 StaminaType                              ModelEnumType StaminaType StaminaType StaminaType Int32
    // 000 RecoverCountFieldNumber                  int IL2CPP_TYPE_I4
    // 01C RecoverCount                             ModelPrimitiveType int int int Int32
    public partial class RecoverStaminaByInGameCurrencyArgs : DataModel
    {
        public StaminaType                              StaminaType                             { get; set; }
        public int                                      RecoverCount                            { get; set; }

        public static RecoverStaminaByInGameCurrencyArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RecoverStaminaByInGameCurrencyArgs() { Pointer= p0 };

            value.StaminaType                               = (StaminaType)GetInt32(new IntPtr(p + 0x018)); // 0x18 StaminaType                 ( ModelEnumType StaminaType StaminaType StaminaType Int32 )
            value.RecoverCount                              = GetInt32(new IntPtr(p + 0x01C)); // 0x1C RecoverCount                ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
