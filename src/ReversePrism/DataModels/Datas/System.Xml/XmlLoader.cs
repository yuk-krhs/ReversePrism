using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Doc                                      000186595990 ModelClassType XmlDocument XmlDocument XmlDocument Pointer
    // 018 Reader                                   0001865A9BB0 ModelClassType XmlReader XmlReader XmlReader Pointer
    // 020 PreserveWhitespace                       000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class XmlLoader : DataModel
    {
        public XmlDocument?                             Doc                                     { get; set; }
        public XmlReader?                               Reader                                  { get; set; }
        public bool                                     PreserveWhitespace                      { get; set; }

        public static XmlLoader? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlLoader() { Pointer= p0 };

            value.Doc                                       = GetObject<XmlDocument>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlDocument.FromPointer); // 0246674B3F18 0x10 Doc                         ( 000186595990 ModelClassType XmlDocument XmlDocument XmlDocument Pointer )
            value.Reader                                    = GetObject<XmlReader>(new IntPtr(p + 0x018), ReversePrism.DataModels.XmlReader.FromPointer); // 0246674B3F38 0x18 Reader                      ( 0001865A9BB0 ModelClassType XmlReader XmlReader XmlReader Pointer )
            value.PreserveWhitespace                        = GetBool(new IntPtr(p + 0x020)); // 0246674B3F58 0x20 PreserveWhitespace          ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
