using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PopupName                                000186671910 ModelPrimitiveType string string string String
    // 018 Index                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class SetPopupButtonTargetSequence : DataModel
    {
        public string                                   PopupName                               { get; set; }
        public int                                      Index                                   { get; set; }

        public static SetPopupButtonTargetSequence? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SetPopupButtonTargetSequence() { Pointer= p0 };

            value.PopupName                                 = GetString(new IntPtr(p + 0x010)); // 02466BCA8440 0x10 PopupName                   ( 000186671910 ModelPrimitiveType string string string String )
            value.Index                                     = GetInt32(new IntPtr(p + 0x018)); // 02466BCA8460 0x18 Index                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
