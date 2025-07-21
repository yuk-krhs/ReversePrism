using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 EndElementNode                           ModelClassType XmlEndElementNode XmlEndElementNode XmlEndElementNode Pointer
    // 068 BufferOffset                             ModelPrimitiveType int int int Int32
    // 06C NameOffset                               ModelPrimitiveType int int int Int32
    // 070 NameLength                               ModelPrimitiveType int int int Int32
    public partial class XmlElementNode : DataModel
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
            var value   = new XmlElementNode() { Pointer= p0 };

            value.EndElementNode                            = GetObject<XmlEndElementNode>(new IntPtr(p + 0x060), ReversePrism.DataModels.XmlEndElementNode.FromPointer); // 0x60 EndElementNode              ( ModelClassType XmlEndElementNode XmlEndElementNode XmlEndElementNode Pointer )
            value.BufferOffset                              = GetInt32(new IntPtr(p + 0x068)); // 0x68 BufferOffset                ( ModelPrimitiveType int int int Int32 )
            value.NameOffset                                = GetInt32(new IntPtr(p + 0x06C)); // 0x6C NameOffset                  ( ModelPrimitiveType int int int Int32 )
            value.NameLength                                = GetInt32(new IntPtr(p + 0x070)); // 0x70 NameLength                  ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
