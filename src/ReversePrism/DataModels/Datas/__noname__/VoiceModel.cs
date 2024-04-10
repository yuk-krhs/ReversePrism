using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CharaIndex                               0001865F4940 ModelPrimitiveType int int int Int32
    // 014 CharaID                                  0001865F4940 ModelPrimitiveType int int int Int32
    // 018 CueSheet                                 0001866736C0 ModelPrimitiveType string string string String
    public partial class VoiceModel : DataModel
    {
        public int                                      CharaIndex                              { get; set; }
        public int                                      CharaID                                 { get; set; }
        public string                                   CueSheet                                { get; set; }

        public static VoiceModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VoiceModel() { Pointer= p0 };

            value.CharaIndex                                = GetInt32(new IntPtr(p + 0x010)); // 02466A240F88 0x10 CharaIndex                  ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.CharaID                                   = GetInt32(new IntPtr(p + 0x014)); // 02466A240FA8 0x14 CharaID                     ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.CueSheet                                  = GetString(new IntPtr(p + 0x018)); // 02466A240FC8 0x18 CueSheet                    ( 0001866736C0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
