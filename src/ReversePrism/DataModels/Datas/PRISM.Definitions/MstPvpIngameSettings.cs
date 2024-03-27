using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SongId                                   000186672F10 ModelPrimitiveType string string string String
    // 018 SectionFrame1                            0001865F4260 ModelPrimitiveType int int int Int32
    // 01C SectionFrame2                            0001865F4260 ModelPrimitiveType int int int Int32
    public partial class MstPvpIngameSettings
    {
        public string                                   SongId                                  { get; set; }
        public int                                      SectionFrame1                           { get; set; }
        public int                                      SectionFrame2                           { get; set; }

        public static MstPvpIngameSettings? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstPvpIngameSettings();

            value.SongId                                    = GetString(new IntPtr(p + 0x010)); // 0270045A7E48 0x10 SongId                      ( 000186672F10 ModelPrimitiveType string string string String )
            value.SectionFrame1                             = GetInt32(new IntPtr(p + 0x018)); // 0270045A7E68 0x18 SectionFrame1               ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.SectionFrame2                             = GetInt32(new IntPtr(p + 0x01C)); // 0270045A7E88 0x1C SectionFrame2               ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
