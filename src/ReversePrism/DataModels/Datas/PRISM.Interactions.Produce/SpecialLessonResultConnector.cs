using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 AdvView                                  0001866D8520 ModelClassType InGameResultADVView InGameResultADVView InGameResultADVView Pointer
    public partial class SpecialLessonResultConnector : DataModel
    {
        public InGameResultADVView?                     AdvView                                 { get; set; }

        public static SpecialLessonResultConnector? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SpecialLessonResultConnector() { Pointer= p0 };

            value.AdvView                                   = GetObject<InGameResultADVView>(new IntPtr(p + 0x090), ReversePrism.DataModels.InGameResultADVView.FromPointer); // 02466A260D18 0x90 AdvView                     ( 0001866D8520 ModelClassType InGameResultADVView InGameResultADVView InGameResultADVView Pointer )

            return value;
        }
    }
}
