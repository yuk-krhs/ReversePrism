using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 RefCount                                 0001865F36C0 ModelPrimitiveType int int int Int32
    // 014 EnabledByInputModule                     000186595960 ModelPrimitiveType bool bool bool Bool
    public partial class InputActionReferenceState
    {
        public int                                      RefCount                                { get; set; }
        public bool                                     EnabledByInputModule                    { get; set; }

        public static InputActionReferenceState? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InputActionReferenceState();

            value.RefCount                                  = GetInt32(new IntPtr(p + 0x010)); // 0270D779DA40 0x10 RefCount                    ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.EnabledByInputModule                      = GetBool(new IntPtr(p + 0x014)); // 0270D779DA60 0x14 EnabledByInputModule        ( 000186595960 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
