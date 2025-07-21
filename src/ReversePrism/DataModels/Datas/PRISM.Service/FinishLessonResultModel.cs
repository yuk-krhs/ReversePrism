using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CacheFinishLessonResultReply             ModelClassType IFinishLessonResultReply IFinishLessonResultReply IFinishLessonResultReply Pointer
    public partial class FinishLessonResultModel : DataModel
    {
        public IFinishLessonResultReply?                CacheFinishLessonResultReply            { get; set; }

        public static FinishLessonResultModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FinishLessonResultModel() { Pointer= p0 };

            value.CacheFinishLessonResultReply              = GetObject<IFinishLessonResultReply>(new IntPtr(p + 0x010), ReversePrism.DataModels.IFinishLessonResultReply.FromPointer); // 0x10 CacheFinishLessonResultReply ( ModelClassType IFinishLessonResultReply IFinishLessonResultReply IFinishLessonResultReply Pointer )

            return value;
        }
    }
}
