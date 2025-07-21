using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<VoiceResourceStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstVoiceResourceIdFieldNumber            int IL2CPP_TYPE_I4
    // 018 MstVoiceResourceId                       ModelPrimitiveType int int int Int32
    // 000 CueSheetNameFieldNumber                  int IL2CPP_TYPE_I4
    // 020 CueSheetName                             ModelPrimitiveType string string string String
    // 000 CueNameFieldNumber                       int IL2CPP_TYPE_I4
    // 028 CueName                                  ModelPrimitiveType string string string String
    public partial class VoiceResourceStatus : DataModel
    {
        public int                                      MstVoiceResourceId                      { get; set; }
        public string                                   CueSheetName                            { get; set; }
        public string                                   CueName                                 { get; set; }

        public static VoiceResourceStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VoiceResourceStatus() { Pointer= p0 };

            value.MstVoiceResourceId                        = GetInt32(new IntPtr(p + 0x018)); // 0x18 MstVoiceResourceId          ( ModelPrimitiveType int int int Int32 )
            value.CueSheetName                              = GetString(new IntPtr(p + 0x020)); // 0x20 CueSheetName                ( ModelPrimitiveType string string string String )
            value.CueName                                   = GetString(new IntPtr(p + 0x028)); // 0x28 CueName                     ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
