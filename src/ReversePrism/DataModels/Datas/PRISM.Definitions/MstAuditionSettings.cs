using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SongId                                   000186672F10 ModelPrimitiveType string string string String
    // 018 StageZ                                   0001865F4260 ModelPrimitiveType int int int Int32
    // 01C DelayFrame                               0001865F4260 ModelPrimitiveType int int int Int32
    public partial class MstAuditionSettings
    {
        public string                                   SongId                                  { get; set; }
        public int                                      StageZ                                  { get; set; }
        public int                                      DelayFrame                              { get; set; }

        public static MstAuditionSettings? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstAuditionSettings();

            value.SongId                                    = GetString(new IntPtr(p + 0x010)); // 02700459CB68 0x10 SongId                      ( 000186672F10 ModelPrimitiveType string string string String )
            value.StageZ                                    = GetInt32(new IntPtr(p + 0x018)); // 02700459CB88 0x18 StageZ                      ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.DelayFrame                                = GetInt32(new IntPtr(p + 0x01C)); // 02700459CBA8 0x1C DelayFrame                  ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
