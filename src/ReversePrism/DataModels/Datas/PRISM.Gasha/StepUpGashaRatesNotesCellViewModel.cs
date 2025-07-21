using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Text                                     ModelPrimitiveType string string string String
    // 018 IsBottom                                 ModelPrimitiveType bool bool bool Bool
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

            value.Text                                      = GetString(new IntPtr(p + 0x010)); // 0x10 Text                        ( ModelPrimitiveType string string string String )
            value.IsBottom                                  = GetBool(new IntPtr(p + 0x018)); // 0x18 IsBottom                    ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
