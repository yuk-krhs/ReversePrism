using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Table                                    ModelClassType DataTable DataTable DataTable Pointer
    // 018 List                                     ModelClassType ArrayList ArrayList ArrayList Pointer
    // 020 DefaultNameIndex                         ModelPrimitiveType int int int Int32
    // 028 OnCollectionChanged                      ModelClassType CollectionChangeEventHandler CollectionChangeEventHandler CollectionChangeEventHandler Pointer
    // 030 DelayLoadingConstraints                  ModelClassListType Constraint[] Constraint[] List<Constraint> Pointer
    // 038 FLoadForeignKeyConstraintsOnly           ModelPrimitiveType bool bool bool Bool
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

            value.Table                                     = GetObject<DataTable>(new IntPtr(p + 0x010), ReversePrism.DataModels.DataTable.FromPointer); // 0x10 Table                       ( ModelClassType DataTable DataTable DataTable Pointer )
            value.List                                      = GetObject<ArrayList>(new IntPtr(p + 0x018), ReversePrism.DataModels.ArrayList.FromPointer); // 0x18 List                        ( ModelClassType ArrayList ArrayList ArrayList Pointer )
            value.DefaultNameIndex                          = GetInt32(new IntPtr(p + 0x020)); // 0x20 DefaultNameIndex            ( ModelPrimitiveType int int int Int32 )
            value.OnCollectionChanged                       = GetObject<CollectionChangeEventHandler>(new IntPtr(p + 0x028), ReversePrism.DataModels.CollectionChangeEventHandler.FromPointer); // 0x28 OnCollectionChanged         ( ModelClassType CollectionChangeEventHandler CollectionChangeEventHandler CollectionChangeEventHandler Pointer )
            value.DelayLoadingConstraints                   = GetObjectList<Constraint>(new IntPtr(p + 0x030), ReversePrism.DataModels.Constraint.FromPointer); // 0x30 DelayLoadingConstraints     ( ModelClassListType Constraint[] Constraint[] List<Constraint> Pointer )
            value.FLoadForeignKeyConstraintsOnly            = GetBool(new IntPtr(p + 0x038)); // 0x38 FLoadForeignKeyConstraintsOnly ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
