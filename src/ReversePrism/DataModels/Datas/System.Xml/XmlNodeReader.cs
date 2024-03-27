using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ReaderNav                                0001865A39F0 ModelClassType XmlNodeReaderNavigator XmlNodeReaderNavigator XmlNodeReaderNavigator Pointer
    // 018 NodeType                                 0001866BBCE0 ModelEnumType XmlNodeType XmlNodeType XmlNodeType Int32
    // 01C CurDepth                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 ReadState                                00018661DEC0 ModelEnumType ReadState ReadState ReadState Int32
    // 024 FEOF                                     000186594D10 ModelPrimitiveType bool bool bool Bool
    // 025 BResolveEntity                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 026 BStartFromDocument                       000186594D10 ModelPrimitiveType bool bool bool Bool
    // 027 BInReadBinary                            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 028 ReadBinaryHelper                         000186616EF0 ModelClassType ReadContentAsBinaryHelper ReadContentAsBinaryHelper ReadContentAsBinaryHelper Pointer
    public partial class XmlNodeReader
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
            var value   = new XmlNodeReader();

            value.ReaderNav                                 = GetObject<XmlNodeReaderNavigator>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlNodeReaderNavigator.FromPointer); // 0270D7457120 0x10 ReaderNav                   ( 0001865A39F0 ModelClassType XmlNodeReaderNavigator XmlNodeReaderNavigator XmlNodeReaderNavigator Pointer )
            value.NodeType                                  = (XmlNodeType)GetInt32(new IntPtr(p + 0x018)); // 0270D7457140 0x18 NodeType                    ( 0001866BBCE0 ModelEnumType XmlNodeType XmlNodeType XmlNodeType Int32 )
            value.CurDepth                                  = GetInt32(new IntPtr(p + 0x01C)); // 0270D7457160 0x1C CurDepth                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ReadState                                 = (ReadState)GetInt32(new IntPtr(p + 0x020)); // 0270D7457180 0x20 ReadState                   ( 00018661DEC0 ModelEnumType ReadState ReadState ReadState Int32 )
            value.FEOF                                      = GetBool(new IntPtr(p + 0x024)); // 0270D74571A0 0x24 FEOF                        ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.BResolveEntity                            = GetBool(new IntPtr(p + 0x025)); // 0270D74571C0 0x25 BResolveEntity              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.BStartFromDocument                        = GetBool(new IntPtr(p + 0x026)); // 0270D74571E0 0x26 BStartFromDocument          ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.BInReadBinary                             = GetBool(new IntPtr(p + 0x027)); // 0270D7457200 0x27 BInReadBinary               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ReadBinaryHelper                          = GetObject<ReadContentAsBinaryHelper>(new IntPtr(p + 0x028), ReversePrism.DataModels.ReadContentAsBinaryHelper.FromPointer); // 0270D7457220 0x28 ReadBinaryHelper            ( 000186616EF0 ModelClassType ReadContentAsBinaryHelper ReadContentAsBinaryHelper ReadContentAsBinaryHelper Pointer )

            return value;
        }
    }
}
