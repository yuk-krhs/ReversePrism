using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 View                                     ModelClassType LessonSuccessResultView LessonSuccessResultView LessonSuccessResultView Pointer
    // 028 AdvView                                  ModelClassType InGameResultADVView InGameResultADVView InGameResultADVView Pointer
    public partial class LessonSuccessResultBuilder : DataModel
    {
        public LessonSuccessResultView?                 View                                    { get; set; }
        public InGameResultADVView?                     AdvView                                 { get; set; }

        public static LessonSuccessResultBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LessonSuccessResultBuilder() { Pointer= p0 };

            value.View                                      = GetObject<LessonSuccessResultView>(new IntPtr(p + 0x020), ReversePrism.DataModels.LessonSuccessResultView.FromPointer); // 0x20 View                        ( ModelClassType LessonSuccessResultView LessonSuccessResultView LessonSuccessResultView Pointer )
            value.AdvView                                   = GetObject<InGameResultADVView>(new IntPtr(p + 0x028), ReversePrism.DataModels.InGameResultADVView.FromPointer); // 0x28 AdvView                     ( ModelClassType InGameResultADVView InGameResultADVView InGameResultADVView Pointer )

            return value;
        }
    }
}
