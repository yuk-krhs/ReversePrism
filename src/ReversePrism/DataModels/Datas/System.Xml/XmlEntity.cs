using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 PublicId                                 ModelPrimitiveType string string string String
    // 020 SystemId                                 ModelPrimitiveType string string string String
    // 028 NotationName                             ModelPrimitiveType string string string String
    // 030 Name                                     ModelPrimitiveType string string string String
    // 038 UnparsedReplacementStr                   ModelPrimitiveType string string string String
    // 040 BaseURI                                  ModelPrimitiveType string string string String
    // 048 LastChild                                ModelClassType XmlLinkedNode XmlLinkedNode XmlLinkedNode Pointer
    // 050 ChildrenFoliating                        ModelPrimitiveType bool bool bool Bool
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

            value.PublicId                                  = GetString(new IntPtr(p + 0x018)); // 0x18 PublicId                    ( ModelPrimitiveType string string string String )
            value.SystemId                                  = GetString(new IntPtr(p + 0x020)); // 0x20 SystemId                    ( ModelPrimitiveType string string string String )
            value.NotationName                              = GetString(new IntPtr(p + 0x028)); // 0x28 NotationName                ( ModelPrimitiveType string string string String )
            value.Name                                      = GetString(new IntPtr(p + 0x030)); // 0x30 Name                        ( ModelPrimitiveType string string string String )
            value.UnparsedReplacementStr                    = GetString(new IntPtr(p + 0x038)); // 0x38 UnparsedReplacementStr      ( ModelPrimitiveType string string string String )
            value.BaseURI                                   = GetString(new IntPtr(p + 0x040)); // 0x40 BaseURI                     ( ModelPrimitiveType string string string String )
            value.LastChild                                 = GetObject<XmlLinkedNode>(new IntPtr(p + 0x048), ReversePrism.DataModels.XmlLinkedNode.FromPointer); // 0x48 LastChild                   ( ModelClassType XmlLinkedNode XmlLinkedNode XmlLinkedNode Pointer )
            value.ChildrenFoliating                         = GetBool(new IntPtr(p + 0x050)); // 0x50 ChildrenFoliating           ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
