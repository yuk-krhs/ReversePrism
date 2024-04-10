using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MaxChannels                              0001865F36C0 ModelPrimitiveType int int int Int32
    // 014 MaxSamplingRate                          0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 StreamingFlag                            000186595960 ModelPrimitiveType bool bool bool Bool
    // 01C SoundRendererType                        0001865F36C0 ModelPrimitiveType int int int Int32
    // 020 DecodeLatency                            0001865F36C0 ModelPrimitiveType int int int Int32
    // 028 context                                  <int> IL2CPP_TYPE_I
    public partial class PlayerConfig : DataModel
    {
        public int                                      MaxChannels                             { get; set; }
        public int                                      MaxSamplingRate                         { get; set; }
        public bool                                     StreamingFlag                           { get; set; }
        public int                                      SoundRendererType                       { get; set; }
        public int                                      DecodeLatency                           { get; set; }

        public static PlayerConfig? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PlayerConfig() { Pointer= p0 };

            value.MaxChannels                               = GetInt32(new IntPtr(p + 0x010)); // 02466ACE1BC0 0x10 MaxChannels                 ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.MaxSamplingRate                           = GetInt32(new IntPtr(p + 0x014)); // 02466ACE1BE0 0x14 MaxSamplingRate             ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.StreamingFlag                             = GetBool(new IntPtr(p + 0x018)); // 02466ACE1C00 0x18 StreamingFlag               ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.SoundRendererType                         = GetInt32(new IntPtr(p + 0x01C)); // 02466ACE1C20 0x1C SoundRendererType           ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.DecodeLatency                             = GetInt32(new IntPtr(p + 0x020)); // 02466ACE1C40 0x20 DecodeLatency               ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
