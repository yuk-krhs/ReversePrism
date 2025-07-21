using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 080 AuditionPanel                            ModelClassType AuditionPanel AuditionPanel AuditionPanel Pointer
    // 088 AuditionModel                            ModelClassType AuditionModel AuditionModel AuditionModel Pointer
    // 090 CacheLessonAuditionSource                ModelClassType LessonAudition LessonAudition LessonAudition Pointer
    public partial class AuditionPresenter : DataModel
    {
        public AuditionPanel?                           AuditionPanel                           { get; set; }
        public AuditionModel?                           AuditionModel                           { get; set; }
        public LessonAudition?                          CacheLessonAuditionSource               { get; set; }

        public static AuditionPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AuditionPresenter() { Pointer= p0 };

            value.AuditionPanel                             = GetObject<AuditionPanel>(new IntPtr(p + 0x080), ReversePrism.DataModels.AuditionPanel.FromPointer); // 0x80 AuditionPanel               ( ModelClassType AuditionPanel AuditionPanel AuditionPanel Pointer )
            value.AuditionModel                             = GetObject<AuditionModel>(new IntPtr(p + 0x088), ReversePrism.DataModels.AuditionModel.FromPointer); // 0x88 AuditionModel               ( ModelClassType AuditionModel AuditionModel AuditionModel Pointer )
            value.CacheLessonAuditionSource                 = GetObject<LessonAudition>(new IntPtr(p + 0x090), ReversePrism.DataModels.LessonAudition.FromPointer); // 0x90 CacheLessonAuditionSource   ( ModelClassType LessonAudition LessonAudition LessonAudition Pointer )

            return value;
        }
    }
}
