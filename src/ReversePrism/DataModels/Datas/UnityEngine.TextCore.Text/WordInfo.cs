using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 FirstCharacterIndex                      0001865F36C0 ModelPrimitiveType int int int Int32
    // 014 LastCharacterIndex                       0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 CharacterCount                           0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class WordInfo
    {
        public int                                      FirstCharacterIndex                     { get; set; }
        public int                                      LastCharacterIndex                      { get; set; }
        public int                                      CharacterCount                          { get; set; }

        public static WordInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WordInfo();

            value.FirstCharacterIndex                       = GetInt32(new IntPtr(p + 0x010)); // 0270068F9788 0x10 FirstCharacterIndex         ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.LastCharacterIndex                        = GetInt32(new IntPtr(p + 0x014)); // 0270068F97A8 0x14 LastCharacterIndex          ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.CharacterCount                            = GetInt32(new IntPtr(p + 0x018)); // 0270068F97C8 0x18 CharacterCount              ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
