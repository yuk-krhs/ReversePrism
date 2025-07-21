using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 LessonExecModel                          ModelClassType LessonAutoExecModel LessonAutoExecModel LessonAutoExecModel Pointer
    // 018 SpecialLessonExecModel                   ModelClassType SpecialLessonAutoExecModel SpecialLessonAutoExecModel SpecialLessonAutoExecModel Pointer
    // 020 AuditionExecModel                        ModelClassType AuditionAutoExecModel AuditionAutoExecModel AuditionAutoExecModel Pointer
    public partial class ProduceInGameAutoExecModel : DataModel
    {
        public LessonAutoExecModel?                     LessonExecModel                         { get; set; }
        public SpecialLessonAutoExecModel?              SpecialLessonExecModel                  { get; set; }
        public AuditionAutoExecModel?                   AuditionExecModel                       { get; set; }

        public static ProduceInGameAutoExecModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceInGameAutoExecModel() { Pointer= p0 };

            value.LessonExecModel                           = GetObject<LessonAutoExecModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.LessonAutoExecModel.FromPointer); // 0x10 LessonExecModel             ( ModelClassType LessonAutoExecModel LessonAutoExecModel LessonAutoExecModel Pointer )
            value.SpecialLessonExecModel                    = GetObject<SpecialLessonAutoExecModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.SpecialLessonAutoExecModel.FromPointer); // 0x18 SpecialLessonExecModel      ( ModelClassType SpecialLessonAutoExecModel SpecialLessonAutoExecModel SpecialLessonAutoExecModel Pointer )
            value.AuditionExecModel                         = GetObject<AuditionAutoExecModel>(new IntPtr(p + 0x020), ReversePrism.DataModels.AuditionAutoExecModel.FromPointer); // 0x20 AuditionExecModel           ( ModelClassType AuditionAutoExecModel AuditionAutoExecModel AuditionAutoExecModel Pointer )

            return value;
        }
    }
}
