using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CacheFinishSpecialLessonReply            0001865143A0 ModelClassType IFinishSpecialLessonReply IFinishSpecialLessonReply IFinishSpecialLessonReply Pointer
    public partial class FinishSpecialLessonModel
    {
        public IFinishSpecialLessonReply?               CacheFinishSpecialLessonReply           { get; set; }

        public static FinishSpecialLessonModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FinishSpecialLessonModel();

            value.CacheFinishSpecialLessonReply             = GetObject<IFinishSpecialLessonReply>(new IntPtr(p + 0x010), ReversePrism.DataModels.IFinishSpecialLessonReply.FromPointer); // 0270D65BC3E0 0x10 CacheFinishSpecialLessonReply ( 0001865143A0 ModelClassType IFinishSpecialLessonReply IFinishSpecialLessonReply IFinishSpecialLessonReply Pointer )

            return value;
        }
    }
}
