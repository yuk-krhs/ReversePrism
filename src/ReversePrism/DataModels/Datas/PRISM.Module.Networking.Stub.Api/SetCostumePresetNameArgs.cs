using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<SetCostumePresetNameArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 CostumePresetIdFieldNumber               int IL2CPP_TYPE_I4
    // 018 CostumePresetId                          000186671910 ModelPrimitiveType string string string String
    // 000 NameFieldNumber                          int IL2CPP_TYPE_I4
    // 020 Name                                     000186671910 ModelPrimitiveType string string string String
    public partial class SetCostumePresetNameArgs : DataModel
    {
        public string                                   CostumePresetId                         { get; set; }
        public string                                   Name                                    { get; set; }

        public static SetCostumePresetNameArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SetCostumePresetNameArgs() { Pointer= p0 };

            value.CostumePresetId                           = GetString(new IntPtr(p + 0x018)); // 0245A40521B0 0x18 CostumePresetId             ( 000186671910 ModelPrimitiveType string string string String )
            value.Name                                      = GetString(new IntPtr(p + 0x020)); // 0245A40521F0 0x20 Name                        ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
