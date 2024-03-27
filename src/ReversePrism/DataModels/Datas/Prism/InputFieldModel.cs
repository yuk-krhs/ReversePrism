using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CharacterLimit                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 014 InputOverCount                           0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class InputFieldModel
    {
        public int                                      CharacterLimit                          { get; set; }
        public int                                      InputOverCount                          { get; set; }

        public static InputFieldModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InputFieldModel();

            value.CharacterLimit                            = GetInt32(new IntPtr(p + 0x010)); // 0270D4C81588 0x10 CharacterLimit              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.InputOverCount                            = GetInt32(new IntPtr(p + 0x014)); // 0270D4C815A8 0x14 InputOverCount              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
