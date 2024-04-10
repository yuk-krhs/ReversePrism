using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<RecoverSettingStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 StaminaTypeFieldNumber                   int IL2CPP_TYPE_I4
    // 018 StaminaType                              00018656BC30 ModelEnumType StaminaType StaminaType StaminaType Int32
    // 000 AmountFieldNumber                        int IL2CPP_TYPE_I4
    // 01C Amount                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 RecoverFieldNumber                       int IL2CPP_TYPE_I4
    // 020 Recover                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class RecoverSettingStatus : DataModel
    {
        public StaminaType                              StaminaType                             { get; set; }
        public int                                      Amount                                  { get; set; }
        public int                                      Recover                                 { get; set; }

        public static RecoverSettingStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RecoverSettingStatus() { Pointer= p0 };

            value.StaminaType                               = (StaminaType)GetInt32(new IntPtr(p + 0x018)); // 024661909078 0x18 StaminaType                 ( 00018656BC30 ModelEnumType StaminaType StaminaType StaminaType Int32 )
            value.Amount                                    = GetInt32(new IntPtr(p + 0x01C)); // 0246619090B8 0x1C Amount                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Recover                                   = GetInt32(new IntPtr(p + 0x020)); // 0246619090F8 0x20 Recover                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
