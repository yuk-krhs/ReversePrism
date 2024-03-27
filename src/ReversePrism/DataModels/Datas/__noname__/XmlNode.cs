using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 NodeType                                 0001866BBCE0 ModelEnumType XmlNodeType XmlNodeType XmlNodeType Int32
    // 018 Prefix                                   000186775C20 ModelClassType PrefixHandle PrefixHandle PrefixHandle Pointer
    // 020 LocalName                                0001865BFE90 ModelClassType StringHandle StringHandle StringHandle Pointer
    // 028 Value                                    000186769240 ModelClassType ValueHandle ValueHandle ValueHandle Pointer
    // 030 Ns                                       000186729060 ModelClassType Namespace Namespace Namespace Pointer
    // 038 HasValue                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 039 CanGetAttribute                          000186594D10 ModelPrimitiveType bool bool bool Bool
    // 03A CanMoveToElement                         000186594D10 ModelPrimitiveType bool bool bool Bool
    // 03C ReadState                                00018661DEC0 ModelEnumType ReadState ReadState ReadState Int32
    // 040 AttributeTextNode                        00018672AB90 ModelClassType XmlAttributeTextNode XmlAttributeTextNode XmlAttributeTextNode Pointer
    // 048 ExitScope                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 04C DepthDelta                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 050 IsAtomicValue                            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 051 SkipValue                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 054 QnameType                                000186729C00 ModelEnumType QNameType QNameType QNameType Int32
    // 058 HasContent                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 059 IsEmptyElement                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 05A quoteChar                                char IL2CPP_TYPE_CHAR
    public partial class XmlNode
    {
        public XmlNodeType                              NodeType                                { get; set; }
        public PrefixHandle?                            Prefix                                  { get; set; }
        public StringHandle?                            LocalName                               { get; set; }
        public ValueHandle?                             Value                                   { get; set; }
        public Namespace?                               Ns                                      { get; set; }
        public bool                                     HasValue                                { get; set; }
        public bool                                     CanGetAttribute                         { get; set; }
        public bool                                     CanMoveToElement                        { get; set; }
        public ReadState                                ReadState                               { get; set; }
        public XmlAttributeTextNode?                    AttributeTextNode                       { get; set; }
        public bool                                     ExitScope                               { get; set; }
        public int                                      DepthDelta                              { get; set; }
        public bool                                     IsAtomicValue                           { get; set; }
        public bool                                     SkipValue                               { get; set; }
        public QNameType                                QnameType                               { get; set; }
        public bool                                     HasContent                              { get; set; }
        public bool                                     IsEmptyElement                          { get; set; }

        public static XmlNode? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlNode();

            value.NodeType                                  = (XmlNodeType)GetInt32(new IntPtr(p + 0x010)); // 027004C519A0 0x10 NodeType                    ( 0001866BBCE0 ModelEnumType XmlNodeType XmlNodeType XmlNodeType Int32 )
            value.Prefix                                    = GetObject<PrefixHandle>(new IntPtr(p + 0x018), ReversePrism.DataModels.PrefixHandle.FromPointer); // 027004C519C0 0x18 Prefix                      ( 000186775C20 ModelClassType PrefixHandle PrefixHandle PrefixHandle Pointer )
            value.LocalName                                 = GetObject<StringHandle>(new IntPtr(p + 0x020), ReversePrism.DataModels.StringHandle.FromPointer); // 027004C519E0 0x20 LocalName                   ( 0001865BFE90 ModelClassType StringHandle StringHandle StringHandle Pointer )
            value.Value                                     = GetObject<ValueHandle>(new IntPtr(p + 0x028), ReversePrism.DataModels.ValueHandle.FromPointer); // 027004C51A00 0x28 Value                       ( 000186769240 ModelClassType ValueHandle ValueHandle ValueHandle Pointer )
            value.Ns                                        = GetObject<Namespace>(new IntPtr(p + 0x030), ReversePrism.DataModels.Namespace.FromPointer); // 027004C51A20 0x30 Ns                          ( 000186729060 ModelClassType Namespace Namespace Namespace Pointer )
            value.HasValue                                  = GetBool(new IntPtr(p + 0x038)); // 027004C51A40 0x38 HasValue                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.CanGetAttribute                           = GetBool(new IntPtr(p + 0x039)); // 027004C51A60 0x39 CanGetAttribute             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.CanMoveToElement                          = GetBool(new IntPtr(p + 0x03A)); // 027004C51A80 0x3A CanMoveToElement            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ReadState                                 = (ReadState)GetInt32(new IntPtr(p + 0x03C)); // 027004C51AA0 0x3C ReadState                   ( 00018661DEC0 ModelEnumType ReadState ReadState ReadState Int32 )
            value.AttributeTextNode                         = GetObject<XmlAttributeTextNode>(new IntPtr(p + 0x040), ReversePrism.DataModels.XmlAttributeTextNode.FromPointer); // 027004C51AC0 0x40 AttributeTextNode           ( 00018672AB90 ModelClassType XmlAttributeTextNode XmlAttributeTextNode XmlAttributeTextNode Pointer )
            value.ExitScope                                 = GetBool(new IntPtr(p + 0x048)); // 027004C51AE0 0x48 ExitScope                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.DepthDelta                                = GetInt32(new IntPtr(p + 0x04C)); // 027004C51B00 0x4C DepthDelta                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IsAtomicValue                             = GetBool(new IntPtr(p + 0x050)); // 027004C51B20 0x50 IsAtomicValue               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.SkipValue                                 = GetBool(new IntPtr(p + 0x051)); // 027004C51B40 0x51 SkipValue                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.QnameType                                 = (QNameType)GetInt32(new IntPtr(p + 0x054)); // 027004C51B60 0x54 QnameType                   ( 000186729C00 ModelEnumType QNameType QNameType QNameType Int32 )
            value.HasContent                                = GetBool(new IntPtr(p + 0x058)); // 027004C51B80 0x58 HasContent                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsEmptyElement                            = GetBool(new IntPtr(p + 0x059)); // 027004C51BA0 0x59 IsEmptyElement              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
