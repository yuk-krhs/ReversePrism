using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<JumpStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ButtonGoToTypeFieldNumber                int IL2CPP_TYPE_I4
    // 018 ButtonGoToType                           ModelEnumType ButtonGoToType ButtonGoToType ButtonGoToType Int32
    // 000 ParameterFieldNumber                     int IL2CPP_TYPE_I4
    // 020 Parameter                                ModelPrimitiveType string string string String
    public partial class JumpStatus : DataModel
    {
        public ButtonGoToType                           ButtonGoToType                          { get; set; }
        public string                                   Parameter                               { get; set; }

        public static JumpStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JumpStatus() { Pointer= p0 };

            value.ButtonGoToType                            = (ButtonGoToType)GetInt32(new IntPtr(p + 0x018)); // 0x18 ButtonGoToType              ( ModelEnumType ButtonGoToType ButtonGoToType ButtonGoToType Int32 )
            value.Parameter                                 = GetString(new IntPtr(p + 0x020)); // 0x20 Parameter                   ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
