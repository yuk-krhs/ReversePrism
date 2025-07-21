using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ClearCostumePresetReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 CostumePresetFieldNumber                 int IL2CPP_TYPE_I4
    // 018 CostumePreset                            ModelClassType CostumePresetStatus CostumePresetStatus CostumePresetStatus Pointer
    public partial class ClearCostumePresetReply : DataModel
    {
        public CostumePresetStatus?                     CostumePreset                           { get; set; }

        public static ClearCostumePresetReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ClearCostumePresetReply() { Pointer= p0 };

            value.CostumePreset                             = GetObject<CostumePresetStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.CostumePresetStatus.FromPointer); // 0x18 CostumePreset               ( ModelClassType CostumePresetStatus CostumePresetStatus CostumePresetStatus Pointer )

            return value;
        }
    }
}
