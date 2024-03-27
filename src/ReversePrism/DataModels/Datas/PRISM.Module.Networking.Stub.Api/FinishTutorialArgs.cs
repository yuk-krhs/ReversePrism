using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<FinishTutorialArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 NameFieldNumber                          int IL2CPP_TYPE_I4
    // 018 Name                                     000186671910 ModelPrimitiveType string string string String
    // 000 DisplayNameFieldNumber                   int IL2CPP_TYPE_I4
    // 020 DisplayName                              000186671910 ModelPrimitiveType string string string String
    public partial class FinishTutorialArgs
    {
        public string                                   Name                                    { get; set; }
        public string                                   DisplayName                             { get; set; }

        public static FinishTutorialArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FinishTutorialArgs();

            value.Name                                      = GetString(new IntPtr(p + 0x018)); // 0270D2C453E8 0x18 Name                        ( 000186671910 ModelPrimitiveType string string string String )
            value.DisplayName                               = GetString(new IntPtr(p + 0x020)); // 0270D2C45428 0x20 DisplayName                 ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
