using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 View                                     ModelClassType SpecialLessonResultView SpecialLessonResultView SpecialLessonResultView Pointer
    // 028 AdvView                                  ModelClassType InGameResultADVView InGameResultADVView InGameResultADVView Pointer
    public partial class SpecialLessonResultBuilder : DataModel
    {
        public SpecialLessonResultView?                 View                                    { get; set; }
        public InGameResultADVView?                     AdvView                                 { get; set; }

        public static SpecialLessonResultBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SpecialLessonResultBuilder() { Pointer= p0 };

            value.View                                      = GetObject<SpecialLessonResultView>(new IntPtr(p + 0x020), ReversePrism.DataModels.SpecialLessonResultView.FromPointer); // 0x20 View                        ( ModelClassType SpecialLessonResultView SpecialLessonResultView SpecialLessonResultView Pointer )
            value.AdvView                                   = GetObject<InGameResultADVView>(new IntPtr(p + 0x028), ReversePrism.DataModels.InGameResultADVView.FromPointer); // 0x28 AdvView                     ( ModelClassType InGameResultADVView InGameResultADVView InGameResultADVView Pointer )

            return value;
        }
    }
}
