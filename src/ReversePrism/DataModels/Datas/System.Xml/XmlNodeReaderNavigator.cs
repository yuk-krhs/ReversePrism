using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CurNode                                  0001866BB0D0 ModelClassType XmlNode XmlNode XmlNode Pointer
    // 018 ElemNode                                 0001866BB0D0 ModelClassType XmlNode XmlNode XmlNode Pointer
    // 020 LogNode                                  0001866BB0D0 ModelClassType XmlNode XmlNode XmlNode Pointer
    // 028 AttrIndex                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 02C LogAttrIndex                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 030 NameTable                                0001865A0930 ModelClassType XmlNameTable XmlNameTable XmlNameTable Pointer
    // 038 Doc                                      000186595990 ModelClassType XmlDocument XmlDocument XmlDocument Pointer
    // 040 NAttrInd                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 044 NDeclarationAttrCount                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 048 NDocTypeAttrCount                        0001865F2AF0 ModelPrimitiveType int int int Int32
    // 04C NLogLevel                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 050 NLogAttrInd                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 054 BLogOnAttrVal                            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 055 BCreatedOnAttribute                      000186594D10 ModelPrimitiveType bool bool bool Bool
    // 058 DecNodeAttributes                        000185CC7948 ModelEnumListType VirtualAttribute[] VirtualAttribute[] List<VirtualAttribute> Pointer
    // 060 DocTypeNodeAttributes                    000185CC7948 ModelEnumListType VirtualAttribute[] VirtualAttribute[] List<VirtualAttribute> Pointer
    // 068 BOnAttrVal                               000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class XmlNodeReaderNavigator : DataModel
    {
        public XmlNode?                                 CurNode                                 { get; set; }
        public XmlNode?                                 ElemNode                                { get; set; }
        public XmlNode?                                 LogNode                                 { get; set; }
        public int                                      AttrIndex                               { get; set; }
        public int                                      LogAttrIndex                            { get; set; }
        public XmlNameTable?                            NameTable                               { get; set; }
        public XmlDocument?                             Doc                                     { get; set; }
        public int                                      NAttrInd                                { get; set; }
        public int                                      NDeclarationAttrCount                   { get; set; }
        public int                                      NDocTypeAttrCount                       { get; set; }
        public int                                      NLogLevel                               { get; set; }
        public int                                      NLogAttrInd                             { get; set; }
        public bool                                     BLogOnAttrVal                           { get; set; }
        public bool                                     BCreatedOnAttribute                     { get; set; }
        public List<VirtualAttribute>?                  DecNodeAttributes                       { get; set; }
        public List<VirtualAttribute>?                  DocTypeNodeAttributes                   { get; set; }
        public bool                                     BOnAttrVal                              { get; set; }

        public static XmlNodeReaderNavigator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlNodeReaderNavigator() { Pointer= p0 };

            value.CurNode                                   = GetObject<XmlNode>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlNode.FromPointer); // 0246674B5700 0x10 CurNode                     ( 0001866BB0D0 ModelClassType XmlNode XmlNode XmlNode Pointer )
            value.ElemNode                                  = GetObject<XmlNode>(new IntPtr(p + 0x018), ReversePrism.DataModels.XmlNode.FromPointer); // 0246674B5720 0x18 ElemNode                    ( 0001866BB0D0 ModelClassType XmlNode XmlNode XmlNode Pointer )
            value.LogNode                                   = GetObject<XmlNode>(new IntPtr(p + 0x020), ReversePrism.DataModels.XmlNode.FromPointer); // 0246674B5740 0x20 LogNode                     ( 0001866BB0D0 ModelClassType XmlNode XmlNode XmlNode Pointer )
            value.AttrIndex                                 = GetInt32(new IntPtr(p + 0x028)); // 0246674B5760 0x28 AttrIndex                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.LogAttrIndex                              = GetInt32(new IntPtr(p + 0x02C)); // 0246674B5780 0x2C LogAttrIndex                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.NameTable                                 = GetObject<XmlNameTable>(new IntPtr(p + 0x030), ReversePrism.DataModels.XmlNameTable.FromPointer); // 0246674B57A0 0x30 NameTable                   ( 0001865A0930 ModelClassType XmlNameTable XmlNameTable XmlNameTable Pointer )
            value.Doc                                       = GetObject<XmlDocument>(new IntPtr(p + 0x038), ReversePrism.DataModels.XmlDocument.FromPointer); // 0246674B57C0 0x38 Doc                         ( 000186595990 ModelClassType XmlDocument XmlDocument XmlDocument Pointer )
            value.NAttrInd                                  = GetInt32(new IntPtr(p + 0x040)); // 0246674B57E0 0x40 NAttrInd                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.NDeclarationAttrCount                     = GetInt32(new IntPtr(p + 0x044)); // 0246674B5800 0x44 NDeclarationAttrCount       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.NDocTypeAttrCount                         = GetInt32(new IntPtr(p + 0x048)); // 0246674B5820 0x48 NDocTypeAttrCount           ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.NLogLevel                                 = GetInt32(new IntPtr(p + 0x04C)); // 0246674B5840 0x4C NLogLevel                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.NLogAttrInd                               = GetInt32(new IntPtr(p + 0x050)); // 0246674B5860 0x50 NLogAttrInd                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.BLogOnAttrVal                             = GetBool(new IntPtr(p + 0x054)); // 0246674B5880 0x54 BLogOnAttrVal               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.BCreatedOnAttribute                       = GetBool(new IntPtr(p + 0x055)); // 0246674B58A0 0x55 BCreatedOnAttribute         ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.DecNodeAttributes                         = GetEnumList<VirtualAttribute>(new IntPtr(p + 0x058)); // 0246674B58C0 0x58 DecNodeAttributes           ( 000185CC7948 ModelEnumListType VirtualAttribute[] VirtualAttribute[] List<VirtualAttribute> Pointer )
            value.DocTypeNodeAttributes                     = GetEnumList<VirtualAttribute>(new IntPtr(p + 0x060)); // 0246674B58E0 0x60 DocTypeNodeAttributes       ( 000185CC7948 ModelEnumListType VirtualAttribute[] VirtualAttribute[] List<VirtualAttribute> Pointer )
            value.BOnAttrVal                                = GetBool(new IntPtr(p + 0x068)); // 0246674B5900 0x68 BOnAttrVal                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
