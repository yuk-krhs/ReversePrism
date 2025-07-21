using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CharacterLimit                           ModelPrimitiveType int int int Int32
    // 014 InputOverCount                           ModelPrimitiveType int int int Int32
    public partial class InputFieldModel : DataModel
    {
        public int                                      CharacterLimit                          { get; set; }
        public int                                      InputOverCount                          { get; set; }

        public static InputFieldModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InputFieldModel() { Pointer= p0 };

            value.CharacterLimit                            = GetInt32(new IntPtr(p + 0x010)); // 0x10 CharacterLimit              ( ModelPrimitiveType int int int Int32 )
            value.InputOverCount                            = GetInt32(new IntPtr(p + 0x014)); // 0x14 InputOverCount              ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
