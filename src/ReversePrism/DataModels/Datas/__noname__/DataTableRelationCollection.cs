using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 Table                                    0001865B8520 ModelClassType DataTable DataTable DataTable Pointer
    // 040 Relations                                00018658A840 ModelClassType ArrayList ArrayList ArrayList Pointer
    // 048 FParentCollection                        0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 050 RelationPropertyChanged                  0001865C4430 ModelClassType CollectionChangeEventHandler CollectionChangeEventHandler CollectionChangeEventHandler Pointer
    public partial class DataTableRelationCollection
    {
        public DataTable?                               Table                                   { get; set; }
        public ArrayList?                               Relations                               { get; set; }
        public bool                                     FParentCollection                       { get; set; }
        public CollectionChangeEventHandler?            RelationPropertyChanged                 { get; set; }

        public static DataTableRelationCollection? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DataTableRelationCollection();

            value.Table                                     = GetObject<DataTable>(new IntPtr(p + 0x038), ReversePrism.DataModels.DataTable.FromPointer); // 0270D88D1708 0x38 Table                       ( 0001865B8520 ModelClassType DataTable DataTable DataTable Pointer )
            value.Relations                                 = GetObject<ArrayList>(new IntPtr(p + 0x040), ReversePrism.DataModels.ArrayList.FromPointer); // 0270D88D1728 0x40 Relations                   ( 00018658A840 ModelClassType ArrayList ArrayList ArrayList Pointer )
            value.FParentCollection                         = GetBool(new IntPtr(p + 0x048)); // 0270D88D1748 0x48 FParentCollection           ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.RelationPropertyChanged                   = GetObject<CollectionChangeEventHandler>(new IntPtr(p + 0x050), ReversePrism.DataModels.CollectionChangeEventHandler.FromPointer); // 0270D88D1768 0x50 RelationPropertyChanged     ( 0001865C4430 ModelClassType CollectionChangeEventHandler CollectionChangeEventHandler CollectionChangeEventHandler Pointer )

            return value;
        }
    }
}
