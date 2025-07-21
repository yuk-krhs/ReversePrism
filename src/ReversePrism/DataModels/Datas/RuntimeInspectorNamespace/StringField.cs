using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 080 Input                                    ModelClassType BoundInputField BoundInputField BoundInputField Pointer
    // 088 M_setterMode                             ModelEnumType Mode Mode Mode Int32
    // 08C LineCount                                ModelPrimitiveType int int int Int32
    public partial class StringField : DataModel
    {
        public BoundInputField?                         Input                                   { get; set; }
        public Mode                                     M_setterMode                            { get; set; }
        public int                                      LineCount                               { get; set; }

        public static StringField? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StringField() { Pointer= p0 };

            value.Input                                     = GetObject<BoundInputField>(new IntPtr(p + 0x080), ReversePrism.DataModels.BoundInputField.FromPointer); // 0x80 Input                       ( ModelClassType BoundInputField BoundInputField BoundInputField Pointer )
            value.M_setterMode                              = (Mode)GetInt32(new IntPtr(p + 0x088)); // 0x88 M_setterMode                ( ModelEnumType Mode Mode Mode Int32 )
            value.LineCount                                 = GetInt32(new IntPtr(p + 0x08C)); // 0x8C LineCount                   ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
