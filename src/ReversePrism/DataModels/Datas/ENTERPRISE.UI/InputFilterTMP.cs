using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Prohibits                                ModelEnumType ProhibitFlags ProhibitFlags ProhibitFlags Int32
    // 020 Database                                 ModelClassType InputFilterDatabase InputFilterDatabase InputFilterDatabase Pointer
    // 028 CharacterFilter                          ModelClassType InputFilter InputFilter InputFilter Pointer
    // 030 CharacterLimit                           ModelPrimitiveType int int int Int32
    public partial class InputFilterTMP : DataModel
    {
        public ProhibitFlags                            Prohibits                               { get; set; }
        public InputFilterDatabase?                     Database                                { get; set; }
        public InputFilter?                             CharacterFilter                         { get; set; }
        public int                                      CharacterLimit                          { get; set; }

        public static InputFilterTMP? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InputFilterTMP() { Pointer= p0 };

            value.Prohibits                                 = (ProhibitFlags)GetInt32(new IntPtr(p + 0x018)); // 0x18 Prohibits                   ( ModelEnumType ProhibitFlags ProhibitFlags ProhibitFlags Int32 )
            value.Database                                  = GetObject<InputFilterDatabase>(new IntPtr(p + 0x020), ReversePrism.DataModels.InputFilterDatabase.FromPointer); // 0x20 Database                    ( ModelClassType InputFilterDatabase InputFilterDatabase InputFilterDatabase Pointer )
            value.CharacterFilter                           = GetObject<InputFilter>(new IntPtr(p + 0x028), ReversePrism.DataModels.InputFilter.FromPointer); // 0x28 CharacterFilter             ( ModelClassType InputFilter InputFilter InputFilter Pointer )
            value.CharacterLimit                            = GetInt32(new IntPtr(p + 0x030)); // 0x30 CharacterLimit              ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
