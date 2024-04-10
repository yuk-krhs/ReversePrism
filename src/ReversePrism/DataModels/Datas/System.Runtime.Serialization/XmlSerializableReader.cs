using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 XmlReader                                0001865AA5B0 ModelClassType XmlReaderDelegator XmlReaderDelegator XmlReaderDelegator Pointer
    // 018 StartDepth                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 01C IsRootEmptyElement                       000186594D10 ModelPrimitiveType bool bool bool Bool
    // 020 InnerReader                              0001865A9BB0 ModelClassType XmlReader XmlReader XmlReader Pointer
    public partial class XmlSerializableReader : DataModel
    {
        public XmlReaderDelegator?                      XmlReader                               { get; set; }
        public int                                      StartDepth                              { get; set; }
        public bool                                     IsRootEmptyElement                      { get; set; }
        public XmlReader?                               InnerReader                             { get; set; }

        public static XmlSerializableReader? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlSerializableReader() { Pointer= p0 };

            value.XmlReader                                 = GetObject<XmlReaderDelegator>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlReaderDelegator.FromPointer); // 024667DD8A58 0x10 XmlReader                   ( 0001865AA5B0 ModelClassType XmlReaderDelegator XmlReaderDelegator XmlReaderDelegator Pointer )
            value.StartDepth                                = GetInt32(new IntPtr(p + 0x018)); // 024667DD8A78 0x18 StartDepth                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IsRootEmptyElement                        = GetBool(new IntPtr(p + 0x01C)); // 024667DD8A98 0x1C IsRootEmptyElement          ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.InnerReader                               = GetObject<XmlReader>(new IntPtr(p + 0x020), ReversePrism.DataModels.XmlReader.FromPointer); // 024667DD8AB8 0x20 InnerReader                 ( 0001865A9BB0 ModelClassType XmlReader XmlReader XmlReader Pointer )

            return value;
        }
    }
}
