using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 068 Items                                    ModelClassType XmlSchemaObjectCollection XmlSchemaObjectCollection XmlSchemaObjectCollection Pointer
    // 070 AttributeGroups                          ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer
    // 078 Types                                    ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer
    // 080 Groups                                   ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer
    public partial class XmlSchemaRedefine : DataModel
    {
        public XmlSchemaObjectCollection?               Items                                   { get; set; }
        public XmlSchemaObjectTable?                    AttributeGroups                         { get; set; }
        public XmlSchemaObjectTable?                    Types                                   { get; set; }
        public XmlSchemaObjectTable?                    Groups                                  { get; set; }

        public static XmlSchemaRedefine? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlSchemaRedefine() { Pointer= p0 };

            value.Items                                     = GetObject<XmlSchemaObjectCollection>(new IntPtr(p + 0x068), ReversePrism.DataModels.XmlSchemaObjectCollection.FromPointer); // 0x68 Items                       ( ModelClassType XmlSchemaObjectCollection XmlSchemaObjectCollection XmlSchemaObjectCollection Pointer )
            value.AttributeGroups                           = GetObject<XmlSchemaObjectTable>(new IntPtr(p + 0x070), ReversePrism.DataModels.XmlSchemaObjectTable.FromPointer); // 0x70 AttributeGroups             ( ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer )
            value.Types                                     = GetObject<XmlSchemaObjectTable>(new IntPtr(p + 0x078), ReversePrism.DataModels.XmlSchemaObjectTable.FromPointer); // 0x78 Types                       ( ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer )
            value.Groups                                    = GetObject<XmlSchemaObjectTable>(new IntPtr(p + 0x080), ReversePrism.DataModels.XmlSchemaObjectTable.FromPointer); // 0x80 Groups                      ( ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer )

            return value;
        }
    }
}
