using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CacheStartSpecialLessonReply             000186655C10 ModelClassType IStartSpecialLessonReply IStartSpecialLessonReply IStartSpecialLessonReply Pointer
    public partial class StartSpecialLessonModel
    {
        public IStartSpecialLessonReply?                CacheStartSpecialLessonReply            { get; set; }

        public static StartSpecialLessonModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StartSpecialLessonModel();

            value.CacheStartSpecialLessonReply              = GetObject<IStartSpecialLessonReply>(new IntPtr(p + 0x010), ReversePrism.DataModels.IStartSpecialLessonReply.FromPointer); // 0270D65DC9B8 0x10 CacheStartSpecialLessonReply ( 000186655C10 ModelClassType IStartSpecialLessonReply IStartSpecialLessonReply IStartSpecialLessonReply Pointer )

            return value;
        }
    }
}
