using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CacheStartLessonReply                    00018664F290 ModelClassType IStartLessonReply IStartLessonReply IStartLessonReply Pointer
    public partial class StartLessonModel
    {
        public IStartLessonReply?                       CacheStartLessonReply                   { get; set; }

        public static StartLessonModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StartLessonModel();

            value.CacheStartLessonReply                     = GetObject<IStartLessonReply>(new IntPtr(p + 0x010), ReversePrism.DataModels.IStartLessonReply.FromPointer); // 0270D65D6CA0 0x10 CacheStartLessonReply       ( 00018664F290 ModelClassType IStartLessonReply IStartLessonReply IStartLessonReply Pointer )

            return value;
        }
    }
}
