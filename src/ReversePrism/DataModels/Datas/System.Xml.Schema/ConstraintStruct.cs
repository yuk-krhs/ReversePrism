using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Constraint                               0001865EFB90 ModelClassType CompiledIdentityConstraint CompiledIdentityConstraint CompiledIdentityConstraint Pointer
    // 018 AxisSelector                             0001867223C0 ModelClassType SelectorActiveAxis SelectorActiveAxis SelectorActiveAxis Pointer
    // 020 AxisFields                               00018658A320 ModelClassType ArrayList ArrayList ArrayList Pointer
    // 028 QualifiedTable                           0001865DE5A0 ModelClassType Hashtable Hashtable Hashtable Pointer
    // 030 KeyrefTable                              0001865DE5A0 ModelClassType Hashtable Hashtable Hashtable Pointer
    // 038 TableDim                                 0001865F2AF0 ModelPrimitiveType int int int Int32
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

            value.Constraint                                = GetObject<CompiledIdentityConstraint>(new IntPtr(p + 0x010), ReversePrism.DataModels.CompiledIdentityConstraint.FromPointer); // 024667559CC8 0x10 Constraint                  ( 0001865EFB90 ModelClassType CompiledIdentityConstraint CompiledIdentityConstraint CompiledIdentityConstraint Pointer )
            value.AxisSelector                              = GetObject<SelectorActiveAxis>(new IntPtr(p + 0x018), ReversePrism.DataModels.SelectorActiveAxis.FromPointer); // 024667559CE8 0x18 AxisSelector                ( 0001867223C0 ModelClassType SelectorActiveAxis SelectorActiveAxis SelectorActiveAxis Pointer )
            value.AxisFields                                = GetObject<ArrayList>(new IntPtr(p + 0x020), ReversePrism.DataModels.ArrayList.FromPointer); // 024667559D08 0x20 AxisFields                  ( 00018658A320 ModelClassType ArrayList ArrayList ArrayList Pointer )
            value.QualifiedTable                            = GetObject<Hashtable>(new IntPtr(p + 0x028), ReversePrism.DataModels.Hashtable.FromPointer); // 024667559D28 0x28 QualifiedTable              ( 0001865DE5A0 ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.KeyrefTable                               = GetObject<Hashtable>(new IntPtr(p + 0x030), ReversePrism.DataModels.Hashtable.FromPointer); // 024667559D48 0x30 KeyrefTable                 ( 0001865DE5A0 ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.TableDim                                  = GetInt32(new IntPtr(p + 0x038)); // 024667559D68 0x38 TableDim                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
