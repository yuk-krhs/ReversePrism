using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ClearCostumePresetArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 CostumePresetIdFieldNumber               int IL2CPP_TYPE_I4
    // 018 CostumePresetId                          ModelPrimitiveType string string string String
    public partial class ClearCostumePresetArgs : DataModel
    {
        public string                                   CostumePresetId                         { get; set; }

        public static ClearCostumePresetArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ClearCostumePresetArgs() { Pointer= p0 };

            value.CostumePresetId                           = GetString(new IntPtr(p + 0x018)); // 0x18 CostumePresetId             ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
