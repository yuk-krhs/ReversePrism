using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Text                                     000186672F10 ModelPrimitiveType string string string String
    // 018 IsBottom                                 0001865965D0 ModelPrimitiveType bool bool bool Bool
    public partial class StepUpGashaRatesNotesCellViewModel : DataModel
    {
        public string                                   Text                                    { get; set; }
        public bool                                     IsBottom                                { get; set; }

        public static StepUpGashaRatesNotesCellViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StepUpGashaRatesNotesCellViewModel() { Pointer= p0 };

            value.Text                                      = GetString(new IntPtr(p + 0x010)); // 024665458C88 0x10 Text                        ( 000186672F10 ModelPrimitiveType string string string String )
            value.IsBottom                                  = GetBool(new IntPtr(p + 0x018)); // 024665458CA8 0x18 IsBottom                    ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
