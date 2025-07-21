using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Table                                    ModelClassType DataTable DataTable DataTable Pointer
    // 018 Constraint                               ModelClassType XmlSchemaIdentityConstraint XmlSchemaIdentityConstraint XmlSchemaIdentityConstraint Pointer
    public partial class ConstraintTable : DataModel
    {
        public DataTable?                               Table                                   { get; set; }
        public XmlSchemaIdentityConstraint?             Constraint                              { get; set; }

        public static ConstraintTable? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ConstraintTable() { Pointer= p0 };

            value.Table                                     = GetObject<DataTable>(new IntPtr(p + 0x010), ReversePrism.DataModels.DataTable.FromPointer); // 0x10 Table                       ( ModelClassType DataTable DataTable DataTable Pointer )
            value.Constraint                                = GetObject<XmlSchemaIdentityConstraint>(new IntPtr(p + 0x018), ReversePrism.DataModels.XmlSchemaIdentityConstraint.FromPointer); // 0x18 Constraint                  ( ModelClassType XmlSchemaIdentityConstraint XmlSchemaIdentityConstraint XmlSchemaIdentityConstraint Pointer )

            return value;
        }
    }
}
