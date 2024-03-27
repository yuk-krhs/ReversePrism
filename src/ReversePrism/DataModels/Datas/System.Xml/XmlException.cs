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
    public partial class XmlException
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
            var value   = new XmlException();

            value.Res                                       = GetString(new IntPtr(p + 0x090)); // 027004CE2C10 0x90 Res                         ( 000186671910 ModelPrimitiveType string string string String )
            value.Args                                      = GetStringList(new IntPtr(p + 0x098)); // 027004CE2C30 0x98 Args                        ( 000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.LineNumber                                = GetInt32(new IntPtr(p + 0x0A0)); // 027004CE2C50 0xA0 LineNumber                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.LinePosition                              = GetInt32(new IntPtr(p + 0x0A4)); // 027004CE2C70 0xA4 LinePosition                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.SourceUri                                 = GetString(new IntPtr(p + 0x0A8)); // 027004CE2C90 0xA8 SourceUri                   ( 000186671910 ModelPrimitiveType string string string String )
            value.Message                                   = GetString(new IntPtr(p + 0x0B0)); // 027004CE2CB0 0xB0 Message                     ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
