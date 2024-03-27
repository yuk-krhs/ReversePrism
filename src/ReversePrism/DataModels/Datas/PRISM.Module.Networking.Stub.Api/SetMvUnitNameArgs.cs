using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<SetMvUnitNameArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 UnitNumberFieldNumber                    int IL2CPP_TYPE_I4
    // 018 UnitNumber                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 NameFieldNumber                          int IL2CPP_TYPE_I4
    // 020 Name                                     000186671910 ModelPrimitiveType string string string String
    public partial class SetMvUnitNameArgs
    {
        public int                                      UnitNumber                              { get; set; }
        public string                                   Name                                    { get; set; }

        public static SetMvUnitNameArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SetMvUnitNameArgs();

            value.UnitNumber                                = GetInt32(new IntPtr(p + 0x018)); // 0270D21F37C0 0x18 UnitNumber                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Name                                      = GetString(new IntPtr(p + 0x020)); // 0270D21F3800 0x20 Name                        ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
