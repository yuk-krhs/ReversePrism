using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DataSet                                  ModelClassType DataSet DataSet DataSet Pointer
    // 018 List                                     ModelClassType ArrayList ArrayList ArrayList Pointer
    // 020 DefaultNameIndex                         ModelPrimitiveType int int int Int32
    // 028 DelayedAddRangeTables                    ModelClassListType DataTable[] DataTable[] List<DataTable> Pointer
    // 030 OnCollectionChangedDelegate              ModelClassType CollectionChangeEventHandler CollectionChangeEventHandler CollectionChangeEventHandler Pointer
    // 038 OnCollectionChangingDelegate             ModelClassType CollectionChangeEventHandler CollectionChangeEventHandler CollectionChangeEventHandler Pointer
    // 000 s_objectTypeCount                        int IL2CPP_TYPE_I4
    // 040 ObjectID                                 ModelPrimitiveType int int int Int32
    public partial class DataTableCollection : DataModel
    {
        public DataSet?                                 DataSet                                 { get; set; }
        public ArrayList?                               List                                    { get; set; }
        public int                                      DefaultNameIndex                        { get; set; }
        public List<DataTable>?                         DelayedAddRangeTables                   { get; set; }
        public CollectionChangeEventHandler?            OnCollectionChangedDelegate             { get; set; }
        public CollectionChangeEventHandler?            OnCollectionChangingDelegate            { get; set; }
        public int                                      ObjectID                                { get; set; }

        public static DataTableCollection? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DataTableCollection() { Pointer= p0 };

            value.DataSet                                   = GetObject<DataSet>(new IntPtr(p + 0x010), ReversePrism.DataModels.DataSet.FromPointer); // 0x10 DataSet                     ( ModelClassType DataSet DataSet DataSet Pointer )
            value.List                                      = GetObject<ArrayList>(new IntPtr(p + 0x018), ReversePrism.DataModels.ArrayList.FromPointer); // 0x18 List                        ( ModelClassType ArrayList ArrayList ArrayList Pointer )
            value.DefaultNameIndex                          = GetInt32(new IntPtr(p + 0x020)); // 0x20 DefaultNameIndex            ( ModelPrimitiveType int int int Int32 )
            value.DelayedAddRangeTables                     = GetObjectList<DataTable>(new IntPtr(p + 0x028), ReversePrism.DataModels.DataTable.FromPointer); // 0x28 DelayedAddRangeTables       ( ModelClassListType DataTable[] DataTable[] List<DataTable> Pointer )
            value.OnCollectionChangedDelegate               = GetObject<CollectionChangeEventHandler>(new IntPtr(p + 0x030), ReversePrism.DataModels.CollectionChangeEventHandler.FromPointer); // 0x30 OnCollectionChangedDelegate ( ModelClassType CollectionChangeEventHandler CollectionChangeEventHandler CollectionChangeEventHandler Pointer )
            value.OnCollectionChangingDelegate              = GetObject<CollectionChangeEventHandler>(new IntPtr(p + 0x038), ReversePrism.DataModels.CollectionChangeEventHandler.FromPointer); // 0x38 OnCollectionChangingDelegate ( ModelClassType CollectionChangeEventHandler CollectionChangeEventHandler CollectionChangeEventHandler Pointer )
            value.ObjectID                                  = GetInt32(new IntPtr(p + 0x040)); // 0x40 ObjectID                    ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
