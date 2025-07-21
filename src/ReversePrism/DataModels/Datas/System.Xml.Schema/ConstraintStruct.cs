using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Constraint                               ModelClassType CompiledIdentityConstraint CompiledIdentityConstraint CompiledIdentityConstraint Pointer
    // 018 AxisSelector                             ModelClassType SelectorActiveAxis SelectorActiveAxis SelectorActiveAxis Pointer
    // 020 AxisFields                               ModelClassType ArrayList ArrayList ArrayList Pointer
    // 028 QualifiedTable                           ModelClassType Hashtable Hashtable Hashtable Pointer
    // 030 KeyrefTable                              ModelClassType Hashtable Hashtable Hashtable Pointer
    // 038 TableDim                                 ModelPrimitiveType int int int Int32
    public partial class ConstraintStruct : DataModel
    {
        public CompiledIdentityConstraint?              Constraint                              { get; set; }
        public SelectorActiveAxis?                      AxisSelector                            { get; set; }
        public ArrayList?                               AxisFields                              { get; set; }
        public Hashtable?                               QualifiedTable                          { get; set; }
        public Hashtable?                               KeyrefTable                             { get; set; }
        public int                                      TableDim                                { get; set; }

        public static ConstraintStruct? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ConstraintStruct() { Pointer= p0 };

            value.Constraint                                = GetObject<CompiledIdentityConstraint>(new IntPtr(p + 0x010), ReversePrism.DataModels.CompiledIdentityConstraint.FromPointer); // 0x10 Constraint                  ( ModelClassType CompiledIdentityConstraint CompiledIdentityConstraint CompiledIdentityConstraint Pointer )
            value.AxisSelector                              = GetObject<SelectorActiveAxis>(new IntPtr(p + 0x018), ReversePrism.DataModels.SelectorActiveAxis.FromPointer); // 0x18 AxisSelector                ( ModelClassType SelectorActiveAxis SelectorActiveAxis SelectorActiveAxis Pointer )
            value.AxisFields                                = GetObject<ArrayList>(new IntPtr(p + 0x020), ReversePrism.DataModels.ArrayList.FromPointer); // 0x20 AxisFields                  ( ModelClassType ArrayList ArrayList ArrayList Pointer )
            value.QualifiedTable                            = GetObject<Hashtable>(new IntPtr(p + 0x028), ReversePrism.DataModels.Hashtable.FromPointer); // 0x28 QualifiedTable              ( ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.KeyrefTable                               = GetObject<Hashtable>(new IntPtr(p + 0x030), ReversePrism.DataModels.Hashtable.FromPointer); // 0x30 KeyrefTable                 ( ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.TableDim                                  = GetInt32(new IntPtr(p + 0x038)); // 0x38 TableDim                    ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
