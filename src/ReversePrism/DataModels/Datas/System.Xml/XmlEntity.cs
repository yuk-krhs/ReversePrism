using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 PublicId                                 000186671910 ModelPrimitiveType string string string String
    // 020 SystemId                                 000186671910 ModelPrimitiveType string string string String
    // 028 NotationName                             000186671910 ModelPrimitiveType string string string String
    // 030 Name                                     000186671910 ModelPrimitiveType string string string String
    // 038 UnparsedReplacementStr                   000186671910 ModelPrimitiveType string string string String
    // 040 BaseURI                                  000186671910 ModelPrimitiveType string string string String
    // 048 LastChild                                00018659E450 ModelClassType XmlLinkedNode XmlLinkedNode XmlLinkedNode Pointer
    // 050 ChildrenFoliating                        000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class XmlEntity : DataModel
    {
        public string                                   PublicId                                { get; set; }
        public string                                   SystemId                                { get; set; }
        public string                                   NotationName                            { get; set; }
        public string                                   Name                                    { get; set; }
        public string                                   UnparsedReplacementStr                  { get; set; }
        public string                                   BaseURI                                 { get; set; }
        public XmlLinkedNode?                           LastChild                               { get; set; }
        public bool                                     ChildrenFoliating                       { get; set; }

        public static XmlEntity? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlEntity() { Pointer= p0 };

            value.PublicId                                  = GetString(new IntPtr(p + 0x018)); // 0246674B3B08 0x18 PublicId                    ( 000186671910 ModelPrimitiveType string string string String )
            value.SystemId                                  = GetString(new IntPtr(p + 0x020)); // 0246674B3B28 0x20 SystemId                    ( 000186671910 ModelPrimitiveType string string string String )
            value.NotationName                              = GetString(new IntPtr(p + 0x028)); // 0246674B3B48 0x28 NotationName                ( 000186671910 ModelPrimitiveType string string string String )
            value.Name                                      = GetString(new IntPtr(p + 0x030)); // 0246674B3B68 0x30 Name                        ( 000186671910 ModelPrimitiveType string string string String )
            value.UnparsedReplacementStr                    = GetString(new IntPtr(p + 0x038)); // 0246674B3B88 0x38 UnparsedReplacementStr      ( 000186671910 ModelPrimitiveType string string string String )
            value.BaseURI                                   = GetString(new IntPtr(p + 0x040)); // 0246674B3BA8 0x40 BaseURI                     ( 000186671910 ModelPrimitiveType string string string String )
            value.LastChild                                 = GetObject<XmlLinkedNode>(new IntPtr(p + 0x048), ReversePrism.DataModels.XmlLinkedNode.FromPointer); // 0246674B3BC8 0x48 LastChild                   ( 00018659E450 ModelClassType XmlLinkedNode XmlLinkedNode XmlLinkedNode Pointer )
            value.ChildrenFoliating                         = GetBool(new IntPtr(p + 0x050)); // 0246674B3BE8 0x50 ChildrenFoliating           ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
