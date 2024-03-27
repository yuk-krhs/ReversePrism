using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 048 Choice                                   0001865AF340 ModelClassType XmlSchemaChoice XmlSchemaChoice XmlSchemaChoice Pointer
    public partial class XmlSchemaSubstitutionGroupV1Compat
    {
        public XmlSchemaChoice?                         Choice                                  { get; set; }

        public static XmlSchemaSubstitutionGroupV1Compat? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlSchemaSubstitutionGroupV1Compat();

            value.Choice                                    = GetObject<XmlSchemaChoice>(new IntPtr(p + 0x048), ReversePrism.DataModels.XmlSchemaChoice.FromPointer); // 0270D7551D08 0x48 Choice                      ( 0001865AF340 ModelClassType XmlSchemaChoice XmlSchemaChoice XmlSchemaChoice Pointer )

            return value;
        }
    }
}
