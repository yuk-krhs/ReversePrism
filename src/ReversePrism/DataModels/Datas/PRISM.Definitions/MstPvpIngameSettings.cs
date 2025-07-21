using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SongId                                   ModelPrimitiveType string string string String
    // 018 SectionFrame1                            ModelPrimitiveType int int int Int32
    // 01C SectionFrame2                            ModelPrimitiveType int int int Int32
    public partial class MstPvpIngameSettings : DataModel
    {
        public string                                   SongId                                  { get; set; }
        public int                                      SectionFrame1                           { get; set; }
        public int                                      SectionFrame2                           { get; set; }

        public static MstPvpIngameSettings? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstPvpIngameSettings() { Pointer= p0 };

            value.SongId                                    = GetString(new IntPtr(p + 0x010)); // 0x10 SongId                      ( ModelPrimitiveType string string string String )
            value.SectionFrame1                             = GetInt32(new IntPtr(p + 0x018)); // 0x18 SectionFrame1               ( ModelPrimitiveType int int int Int32 )
            value.SectionFrame2                             = GetInt32(new IntPtr(p + 0x01C)); // 0x1C SectionFrame2               ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
