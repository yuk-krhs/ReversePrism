using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 070 AuditionPanel                            00018671B890 ModelClassType AuditionPanel AuditionPanel AuditionPanel Pointer
    // 078 AuditionModel                            00018671B110 ModelClassType AuditionModel AuditionModel AuditionModel Pointer
    // 080 CacheLessonAuditionSource                00018651C520 ModelClassType LessonAudition LessonAudition LessonAudition Pointer
    public partial class AuditionPresenter
    {
        public AuditionPanel?                           AuditionPanel                           { get; set; }
        public AuditionModel?                           AuditionModel                           { get; set; }
        public LessonAudition?                          CacheLessonAuditionSource               { get; set; }

        public static AuditionPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AuditionPresenter();

            value.AuditionPanel                             = GetObject<AuditionPanel>(new IntPtr(p + 0x070), ReversePrism.DataModels.AuditionPanel.FromPointer); // 0270D59AC798 0x70 AuditionPanel               ( 00018671B890 ModelClassType AuditionPanel AuditionPanel AuditionPanel Pointer )
            value.AuditionModel                             = GetObject<AuditionModel>(new IntPtr(p + 0x078), ReversePrism.DataModels.AuditionModel.FromPointer); // 0270D59AC7B8 0x78 AuditionModel               ( 00018671B110 ModelClassType AuditionModel AuditionModel AuditionModel Pointer )
            value.CacheLessonAuditionSource                 = GetObject<LessonAudition>(new IntPtr(p + 0x080), ReversePrism.DataModels.LessonAudition.FromPointer); // 0270D59AC7D8 0x80 CacheLessonAuditionSource   ( 00018651C520 ModelClassType LessonAudition LessonAudition LessonAudition Pointer )

            return value;
        }
    }
}
