using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 __ServiceName                            string IL2CPP_TYPE_STRING
    // 008 __Marshaller_api_ExecuteIntroductionArgs Marshaller`1<ExecuteIntroductionArgs> IL2CPP_TYPE_GENERICINST
    // 010 __Marshaller_api_ExecuteIntroductionReply Marshaller`1<ExecuteIntroductionReply> IL2CPP_TYPE_GENERICINST
    // 018 __Method_ExecuteIntroduction             Method`2<ExecuteIntroductionArgs, ExecuteIntroductionReply> IL2CPP_TYPE_GENERICINST
    public partial class IntroductionService : DataModel
    {

        public static IntroductionService? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IntroductionService() { Pointer= p0 };


            return value;
        }
    }
}
