using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<SetCostumePresetReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 CostumePresetFieldNumber                 int IL2CPP_TYPE_I4
    // 018 CostumePreset                            000186630330 ModelClassType CostumePresetStatus CostumePresetStatus CostumePresetStatus Pointer
    public partial class SetCostumePresetReply
    {
        public CostumePresetStatus?                     CostumePreset                           { get; set; }

        public static SetCostumePresetReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SetCostumePresetReply();

            value.CostumePreset                             = GetObject<CostumePresetStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.CostumePresetStatus.FromPointer); // 0270D0D7CCD0 0x18 CostumePreset               ( 000186630330 ModelClassType CostumePresetStatus CostumePresetStatus CostumePresetStatus Pointer )

            return value;
        }
    }
}
