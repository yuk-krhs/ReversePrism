using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 customPopup                              AssetCollection`1<PopupContentBase> IL2CPP_TYPE_GENERICINST
    // 028 View                                     00018653FF20 ModelClassType SpecialLessonResultView SpecialLessonResultView SpecialLessonResultView Pointer
    // 030 AdvView                                  0001866D8520 ModelClassType InGameResultADVView InGameResultADVView InGameResultADVView Pointer
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

            value.View                                      = GetObject<SpecialLessonResultView>(new IntPtr(p + 0x028), ReversePrism.DataModels.SpecialLessonResultView.FromPointer); // 02466B6B5650 0x28 View                        ( 00018653FF20 ModelClassType SpecialLessonResultView SpecialLessonResultView SpecialLessonResultView Pointer )
            value.AdvView                                   = GetObject<InGameResultADVView>(new IntPtr(p + 0x030), ReversePrism.DataModels.InGameResultADVView.FromPointer); // 02466B6B5670 0x30 AdvView                     ( 0001866D8520 ModelClassType InGameResultADVView InGameResultADVView InGameResultADVView Pointer )

            return value;
        }
    }
}
