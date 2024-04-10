using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SampleRate                               0001865F36C0 ModelPrimitiveType int int int Int32
    // 014 ChannelCount                             0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class AudioFormat : DataModel
    {
        public int                                      SampleRate                              { get; set; }
        public int                                      ChannelCount                            { get; set; }

        public static AudioFormat? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AudioFormat() { Pointer= p0 };

            value.SampleRate                                = GetInt32(new IntPtr(p + 0x010)); // 02466BE3F538 0x10 SampleRate                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.ChannelCount                              = GetInt32(new IntPtr(p + 0x014)); // 02466BE3F558 0x14 ChannelCount                ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
