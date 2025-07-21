using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 088 AdvView                                  ModelClassType InGameResultADVView InGameResultADVView InGameResultADVView Pointer
    public partial class LessonSuccessResultConnector : DataModel
    {
        public InGameResultADVView?                     AdvView                                 { get; set; }

        public static LessonSuccessResultConnector? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LessonSuccessResultConnector() { Pointer= p0 };

            value.AdvView                                   = GetObject<InGameResultADVView>(new IntPtr(p + 0x088), ReversePrism.DataModels.InGameResultADVView.FromPointer); // 0x88 AdvView                     ( ModelClassType InGameResultADVView InGameResultADVView InGameResultADVView Pointer )

            return value;
        }
    }
}
