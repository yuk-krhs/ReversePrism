using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 Res                                      000186671910 ModelPrimitiveType string string string String
    // 098 Args                                     000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 0A0 LineNumber                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 0A4 LinePosition                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 0A8 SourceUri                                000186671910 ModelPrimitiveType string string string String
    // 0B0 Message                                  000186671910 ModelPrimitiveType string string string String
    public partial class XmlException : DataModel
    {
        public string                                   Res                                     { get; set; }
        public List<string>?                            Args                                    { get; set; }
        public int                                      LineNumber                              { get; set; }
        public int                                      LinePosition                            { get; set; }
        public string                                   SourceUri                               { get; set; }
        public string                                   Message                                 { get; set; }

        public static XmlException? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlException() { Pointer= p0 };

            value.Res                                       = GetString(new IntPtr(p + 0x090)); // 0245A4D1F198 0x90 Res                         ( 000186671910 ModelPrimitiveType string string string String )
            value.Args                                      = GetStringList(new IntPtr(p + 0x098)); // 0245A4D1F1B8 0x98 Args                        ( 000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.LineNumber                                = GetInt32(new IntPtr(p + 0x0A0)); // 0245A4D1F1D8 0xA0 LineNumber                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.LinePosition                              = GetInt32(new IntPtr(p + 0x0A4)); // 0245A4D1F1F8 0xA4 LinePosition                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.SourceUri                                 = GetString(new IntPtr(p + 0x0A8)); // 0245A4D1F218 0xA8 SourceUri                   ( 000186671910 ModelPrimitiveType string string string String )
            value.Message                                   = GetString(new IntPtr(p + 0x0B0)); // 0245A4D1F238 0xB0 Message                     ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
