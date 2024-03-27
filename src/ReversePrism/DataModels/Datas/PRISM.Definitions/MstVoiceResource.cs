using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       0001865F4260 ModelPrimitiveType int int int Int32
    // 018 CueSheetName                             000186672F10 ModelPrimitiveType string string string String
    // 020 CueName                                  000186672F10 ModelPrimitiveType string string string String
    public partial class MstVoiceResource
    {
        public int                                      Id                                      { get; set; }
        public string                                   CueSheetName                            { get; set; }
        public string                                   CueName                                 { get; set; }

        public static MstVoiceResource? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstVoiceResource();

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 02700465D1A0 0x10 Id                          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.CueSheetName                              = GetString(new IntPtr(p + 0x018)); // 02700465D1C0 0x18 CueSheetName                ( 000186672F10 ModelPrimitiveType string string string String )
            value.CueName                                   = GetString(new IntPtr(p + 0x020)); // 02700465D1E0 0x20 CueName                     ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
