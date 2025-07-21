using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MaxChannels                              ModelPrimitiveType int int int Int32
    // 014 MaxSamplingRate                          ModelPrimitiveType int int int Int32
    // 018 StreamingFlag                            ModelPrimitiveType bool bool bool Bool
    // 01C SoundRendererType                        ModelPrimitiveType int int int Int32
    // 020 DecodeLatency                            ModelPrimitiveType int int int Int32
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

            value.MaxChannels                               = GetInt32(new IntPtr(p + 0x010)); // 0x10 MaxChannels                 ( ModelPrimitiveType int int int Int32 )
            value.MaxSamplingRate                           = GetInt32(new IntPtr(p + 0x014)); // 0x14 MaxSamplingRate             ( ModelPrimitiveType int int int Int32 )
            value.StreamingFlag                             = GetBool(new IntPtr(p + 0x018)); // 0x18 StreamingFlag               ( ModelPrimitiveType bool bool bool Bool )
            value.SoundRendererType                         = GetInt32(new IntPtr(p + 0x01C)); // 0x1C SoundRendererType           ( ModelPrimitiveType int int int Int32 )
            value.DecodeLatency                             = GetInt32(new IntPtr(p + 0x020)); // 0x20 DecodeLatency               ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
