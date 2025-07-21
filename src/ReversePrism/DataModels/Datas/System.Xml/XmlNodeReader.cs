using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ReaderNav                                ModelClassType XmlNodeReaderNavigator XmlNodeReaderNavigator XmlNodeReaderNavigator Pointer
    // 018 NodeType                                 ModelEnumType XmlNodeType XmlNodeType XmlNodeType Int32
    // 01C CurDepth                                 ModelPrimitiveType int int int Int32
    // 020 ReadState                                ModelEnumType ReadState ReadState ReadState Int32
    // 024 FEOF                                     ModelPrimitiveType bool bool bool Bool
    // 025 BResolveEntity                           ModelPrimitiveType bool bool bool Bool
    // 026 BStartFromDocument                       ModelPrimitiveType bool bool bool Bool
    // 027 BInReadBinary                            ModelPrimitiveType bool bool bool Bool
    // 028 ReadBinaryHelper                         ModelClassType ReadContentAsBinaryHelper ReadContentAsBinaryHelper ReadContentAsBinaryHelper Pointer
    public partial class XmlNodeReader : DataModel
    {
        public XmlNodeReaderNavigator?                  ReaderNav                               { get; set; }
        public XmlNodeType                              NodeType                                { get; set; }
        public int                                      CurDepth                                { get; set; }
        public ReadState                                ReadState                               { get; set; }
        public bool                                     FEOF                                    { get; set; }
        public bool                                     BResolveEntity                          { get; set; }
        public bool                                     BStartFromDocument                      { get; set; }
        public bool                                     BInReadBinary                           { get; set; }
        public ReadContentAsBinaryHelper?               ReadBinaryHelper                        { get; set; }

        public static XmlNodeReader? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlNodeReader() { Pointer= p0 };

            value.ReaderNav                                 = GetObject<XmlNodeReaderNavigator>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlNodeReaderNavigator.FromPointer); // 0x10 ReaderNav                   ( ModelClassType XmlNodeReaderNavigator XmlNodeReaderNavigator XmlNodeReaderNavigator Pointer )
            value.NodeType                                  = (XmlNodeType)GetInt32(new IntPtr(p + 0x018)); // 0x18 NodeType                    ( ModelEnumType XmlNodeType XmlNodeType XmlNodeType Int32 )
            value.CurDepth                                  = GetInt32(new IntPtr(p + 0x01C)); // 0x1C CurDepth                    ( ModelPrimitiveType int int int Int32 )
            value.ReadState                                 = (ReadState)GetInt32(new IntPtr(p + 0x020)); // 0x20 ReadState                   ( ModelEnumType ReadState ReadState ReadState Int32 )
            value.FEOF                                      = GetBool(new IntPtr(p + 0x024)); // 0x24 FEOF                        ( ModelPrimitiveType bool bool bool Bool )
            value.BResolveEntity                            = GetBool(new IntPtr(p + 0x025)); // 0x25 BResolveEntity              ( ModelPrimitiveType bool bool bool Bool )
            value.BStartFromDocument                        = GetBool(new IntPtr(p + 0x026)); // 0x26 BStartFromDocument          ( ModelPrimitiveType bool bool bool Bool )
            value.BInReadBinary                             = GetBool(new IntPtr(p + 0x027)); // 0x27 BInReadBinary               ( ModelPrimitiveType bool bool bool Bool )
            value.ReadBinaryHelper                          = GetObject<ReadContentAsBinaryHelper>(new IntPtr(p + 0x028), ReversePrism.DataModels.ReadContentAsBinaryHelper.FromPointer); // 0x28 ReadBinaryHelper            ( ModelClassType ReadContentAsBinaryHelper ReadContentAsBinaryHelper ReadContentAsBinaryHelper Pointer )

            return value;
        }
    }
}
