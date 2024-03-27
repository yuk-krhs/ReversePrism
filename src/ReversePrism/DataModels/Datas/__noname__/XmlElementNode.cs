using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 EndElementNode                           00018672CC00 ModelClassType XmlEndElementNode XmlEndElementNode XmlEndElementNode Pointer
    // 068 BufferOffset                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 06C NameOffset                               0001865F36C0 ModelPrimitiveType int int int Int32
    // 070 NameLength                               0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class XmlElementNode
    {
        public XmlEndElementNode?                       EndElementNode                          { get; set; }
        public int                                      BufferOffset                            { get; set; }
        public int                                      NameOffset                              { get; set; }
        public int                                      NameLength                              { get; set; }

        public static XmlElementNode? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlElementNode();

            value.EndElementNode                            = GetObject<XmlEndElementNode>(new IntPtr(p + 0x060), ReversePrism.DataModels.XmlEndElementNode.FromPointer); // 027004C56230 0x60 EndElementNode              ( 00018672CC00 ModelClassType XmlEndElementNode XmlEndElementNode XmlEndElementNode Pointer )
            value.BufferOffset                              = GetInt32(new IntPtr(p + 0x068)); // 027004C56250 0x68 BufferOffset                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.NameOffset                                = GetInt32(new IntPtr(p + 0x06C)); // 027004C56270 0x6C NameOffset                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.NameLength                                = GetInt32(new IntPtr(p + 0x070)); // 027004C56290 0x70 NameLength                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
