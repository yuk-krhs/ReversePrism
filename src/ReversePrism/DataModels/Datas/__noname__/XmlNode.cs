using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 NodeType                                 ModelEnumType XmlNodeType XmlNodeType XmlNodeType Int32
    // 018 Prefix                                   ModelClassType PrefixHandle PrefixHandle PrefixHandle Pointer
    // 020 LocalName                                ModelClassType StringHandle StringHandle StringHandle Pointer
    // 028 Value                                    ModelClassType ValueHandle ValueHandle ValueHandle Pointer
    // 030 Ns                                       ModelClassType Namespace Namespace Namespace Pointer
    // 038 HasValue                                 ModelPrimitiveType bool bool bool Bool
    // 039 CanGetAttribute                          ModelPrimitiveType bool bool bool Bool
    // 03A CanMoveToElement                         ModelPrimitiveType bool bool bool Bool
    // 03C ReadState                                ModelEnumType ReadState ReadState ReadState Int32
    // 040 AttributeTextNode                        ModelClassType XmlAttributeTextNode XmlAttributeTextNode XmlAttributeTextNode Pointer
    // 048 ExitScope                                ModelPrimitiveType bool bool bool Bool
    // 04C DepthDelta                               ModelPrimitiveType int int int Int32
    // 050 IsAtomicValue                            ModelPrimitiveType bool bool bool Bool
    // 051 SkipValue                                ModelPrimitiveType bool bool bool Bool
    // 054 QnameType                                ModelEnumType QNameType QNameType QNameType Int32
    // 058 HasContent                               ModelPrimitiveType bool bool bool Bool
    // 059 IsEmptyElement                           ModelPrimitiveType bool bool bool Bool
    // 05A quoteChar                                char IL2CPP_TYPE_CHAR
    public partial class XmlNode : DataModel
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
            var value   = new XmlNode() { Pointer= p0 };

            value.NodeType                                  = (XmlNodeType)GetInt32(new IntPtr(p + 0x010)); // 0x10 NodeType                    ( ModelEnumType XmlNodeType XmlNodeType XmlNodeType Int32 )
            value.Prefix                                    = GetObject<PrefixHandle>(new IntPtr(p + 0x018), ReversePrism.DataModels.PrefixHandle.FromPointer); // 0x18 Prefix                      ( ModelClassType PrefixHandle PrefixHandle PrefixHandle Pointer )
            value.LocalName                                 = GetObject<StringHandle>(new IntPtr(p + 0x020), ReversePrism.DataModels.StringHandle.FromPointer); // 0x20 LocalName                   ( ModelClassType StringHandle StringHandle StringHandle Pointer )
            value.Value                                     = GetObject<ValueHandle>(new IntPtr(p + 0x028), ReversePrism.DataModels.ValueHandle.FromPointer); // 0x28 Value                       ( ModelClassType ValueHandle ValueHandle ValueHandle Pointer )
            value.Ns                                        = GetObject<Namespace>(new IntPtr(p + 0x030), ReversePrism.DataModels.Namespace.FromPointer); // 0x30 Ns                          ( ModelClassType Namespace Namespace Namespace Pointer )
            value.HasValue                                  = GetBool(new IntPtr(p + 0x038)); // 0x38 HasValue                    ( ModelPrimitiveType bool bool bool Bool )
            value.CanGetAttribute                           = GetBool(new IntPtr(p + 0x039)); // 0x39 CanGetAttribute             ( ModelPrimitiveType bool bool bool Bool )
            value.CanMoveToElement                          = GetBool(new IntPtr(p + 0x03A)); // 0x3A CanMoveToElement            ( ModelPrimitiveType bool bool bool Bool )
            value.ReadState                                 = (ReadState)GetInt32(new IntPtr(p + 0x03C)); // 0x3C ReadState                   ( ModelEnumType ReadState ReadState ReadState Int32 )
            value.AttributeTextNode                         = GetObject<XmlAttributeTextNode>(new IntPtr(p + 0x040), ReversePrism.DataModels.XmlAttributeTextNode.FromPointer); // 0x40 AttributeTextNode           ( ModelClassType XmlAttributeTextNode XmlAttributeTextNode XmlAttributeTextNode Pointer )
            value.ExitScope                                 = GetBool(new IntPtr(p + 0x048)); // 0x48 ExitScope                   ( ModelPrimitiveType bool bool bool Bool )
            value.DepthDelta                                = GetInt32(new IntPtr(p + 0x04C)); // 0x4C DepthDelta                  ( ModelPrimitiveType int int int Int32 )
            value.IsAtomicValue                             = GetBool(new IntPtr(p + 0x050)); // 0x50 IsAtomicValue               ( ModelPrimitiveType bool bool bool Bool )
            value.SkipValue                                 = GetBool(new IntPtr(p + 0x051)); // 0x51 SkipValue                   ( ModelPrimitiveType bool bool bool Bool )
            value.QnameType                                 = (QNameType)GetInt32(new IntPtr(p + 0x054)); // 0x54 QnameType                   ( ModelEnumType QNameType QNameType QNameType Int32 )
            value.HasContent                                = GetBool(new IntPtr(p + 0x058)); // 0x58 HasContent                  ( ModelPrimitiveType bool bool bool Bool )
            value.IsEmptyElement                            = GetBool(new IntPtr(p + 0x059)); // 0x59 IsEmptyElement              ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
