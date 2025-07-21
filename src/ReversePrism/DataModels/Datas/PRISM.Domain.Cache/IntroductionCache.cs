using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IntroductionReply                        ModelClassType IExecuteIntroductionReply IExecuteIntroductionReply IExecuteIntroductionReply Pointer
    // 018 IntroductionIndex                        ModelPrimitiveType int int int Int32
    public partial class IntroductionCache : DataModel
    {
        public IExecuteIntroductionReply?               IntroductionReply                       { get; set; }
        public int                                      IntroductionIndex                       { get; set; }

        public static IntroductionCache? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IntroductionCache() { Pointer= p0 };

            value.IntroductionReply                         = GetObject<IExecuteIntroductionReply>(new IntPtr(p + 0x010), ReversePrism.DataModels.IExecuteIntroductionReply.FromPointer); // 0x10 IntroductionReply           ( ModelClassType IExecuteIntroductionReply IExecuteIntroductionReply IExecuteIntroductionReply Pointer )
            value.IntroductionIndex                         = GetInt32(new IntPtr(p + 0x018)); // 0x18 IntroductionIndex           ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
