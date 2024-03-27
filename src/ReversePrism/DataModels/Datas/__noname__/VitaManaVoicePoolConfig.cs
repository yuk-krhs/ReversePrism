using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 NumberOfManaDecoders                     0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class VitaManaVoicePoolConfig
    {
        public int                                      NumberOfManaDecoders                    { get; set; }

        public static VitaManaVoicePoolConfig? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VitaManaVoicePoolConfig();

            value.NumberOfManaDecoders                      = GetInt32(new IntPtr(p + 0x010)); // 0270D117ACC0 0x10 NumberOfManaDecoders        ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
