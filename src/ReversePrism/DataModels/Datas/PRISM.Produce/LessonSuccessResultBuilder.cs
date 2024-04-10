using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 customPopup                              AssetCollection`1<PopupContentBase> IL2CPP_TYPE_GENERICINST
    // 028 View                                     00018651FA80 ModelClassType LessonSuccessResultView LessonSuccessResultView LessonSuccessResultView Pointer
    // 030 AdvView                                  0001866D8520 ModelClassType InGameResultADVView InGameResultADVView InGameResultADVView Pointer
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

            value.View                                      = GetObject<LessonSuccessResultView>(new IntPtr(p + 0x028), ReversePrism.DataModels.LessonSuccessResultView.FromPointer); // 02466B6B3990 0x28 View                        ( 00018651FA80 ModelClassType LessonSuccessResultView LessonSuccessResultView LessonSuccessResultView Pointer )
            value.AdvView                                   = GetObject<InGameResultADVView>(new IntPtr(p + 0x030), ReversePrism.DataModels.InGameResultADVView.FromPointer); // 02466B6B39B0 0x30 AdvView                     ( 0001866D8520 ModelClassType InGameResultADVView InGameResultADVView InGameResultADVView Pointer )

            return value;
        }
    }
}
