using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 NumChannels                              000186699040 ModelPrimitiveType uint uint uint UInt32
    // 038 SampleProcessFunc                        00018655FDB0 ModelClassType SampleProcessFunc SampleProcessFunc SampleProcessFunc Pointer
    public partial class CriLipsSampler
    {
        public uint                                     NumChannels                             { get; set; }
        public SampleProcessFunc?                       SampleProcessFunc                       { get; set; }

        public static CriLipsSampler? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CriLipsSampler();

            value.NumChannels                               = GetUInt32(new IntPtr(p + 0x030)); // 0270DBBA3C00 0x30 NumChannels                 ( 000186699040 ModelPrimitiveType uint uint uint UInt32 )
            value.SampleProcessFunc                         = GetObject<SampleProcessFunc>(new IntPtr(p + 0x038), ReversePrism.DataModels.SampleProcessFunc.FromPointer); // 0270DBBA3C20 0x38 SampleProcessFunc           ( 00018655FDB0 ModelClassType SampleProcessFunc SampleProcessFunc SampleProcessFunc Pointer )

            return value;
        }
    }
}
