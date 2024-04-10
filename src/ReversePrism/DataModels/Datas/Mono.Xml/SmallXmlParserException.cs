using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 Line                                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 094 Column                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class SmallXmlParserException : DataModel
    {
        public int                                      Line                                    { get; set; }
        public int                                      Column                                  { get; set; }

        public static SmallXmlParserException? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SmallXmlParserException() { Pointer= p0 };

            value.Line                                      = GetInt32(new IntPtr(p + 0x090)); // 0246669AAC88 0x90 Line                        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Column                                    = GetInt32(new IntPtr(p + 0x094)); // 0246669AACA8 0x94 Column                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
