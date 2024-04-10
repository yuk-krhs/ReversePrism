using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Table                                    0001865B8520 ModelClassType DataTable DataTable DataTable Pointer
    // 018 List                                     00018658A840 ModelClassType ArrayList ArrayList ArrayList Pointer
    // 020 DefaultNameIndex                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 028 OnCollectionChanged                      0001865C4430 ModelClassType CollectionChangeEventHandler CollectionChangeEventHandler CollectionChangeEventHandler Pointer
    // 030 DelayLoadingConstraints                  000185B769E0 ModelClassListType Constraint[] Constraint[] List<Constraint> Pointer
    // 038 FLoadForeignKeyConstraintsOnly           000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class ConstraintCollection : DataModel
    {
        public DataTable?                               Table                                   { get; set; }
        public ArrayList?                               List                                    { get; set; }
        public int                                      DefaultNameIndex                        { get; set; }
        public CollectionChangeEventHandler?            OnCollectionChanged                     { get; set; }
        public List<Constraint>?                        DelayLoadingConstraints                 { get; set; }
        public bool                                     FLoadForeignKeyConstraintsOnly          { get; set; }

        public static ConstraintCollection? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ConstraintCollection() { Pointer= p0 };

            value.Table                                     = GetObject<DataTable>(new IntPtr(p + 0x010), ReversePrism.DataModels.DataTable.FromPointer); // 0246688FD490 0x10 Table                       ( 0001865B8520 ModelClassType DataTable DataTable DataTable Pointer )
            value.List                                      = GetObject<ArrayList>(new IntPtr(p + 0x018), ReversePrism.DataModels.ArrayList.FromPointer); // 0246688FD4B0 0x18 List                        ( 00018658A840 ModelClassType ArrayList ArrayList ArrayList Pointer )
            value.DefaultNameIndex                          = GetInt32(new IntPtr(p + 0x020)); // 0246688FD4D0 0x20 DefaultNameIndex            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.OnCollectionChanged                       = GetObject<CollectionChangeEventHandler>(new IntPtr(p + 0x028), ReversePrism.DataModels.CollectionChangeEventHandler.FromPointer); // 0246688FD4F0 0x28 OnCollectionChanged         ( 0001865C4430 ModelClassType CollectionChangeEventHandler CollectionChangeEventHandler CollectionChangeEventHandler Pointer )
            value.DelayLoadingConstraints                   = GetObjectList<Constraint>(new IntPtr(p + 0x030), ReversePrism.DataModels.Constraint.FromPointer); // 0246688FD510 0x30 DelayLoadingConstraints     ( 000185B769E0 ModelClassListType Constraint[] Constraint[] List<Constraint> Pointer )
            value.FLoadForeignKeyConstraintsOnly            = GetBool(new IntPtr(p + 0x038)); // 0246688FD530 0x38 FLoadForeignKeyConstraintsOnly ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
