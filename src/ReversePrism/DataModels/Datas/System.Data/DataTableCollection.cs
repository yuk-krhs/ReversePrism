using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DataSet                                  000186680C90 ModelClassType DataSet DataSet DataSet Pointer
    // 018 List                                     00018658A840 ModelClassType ArrayList ArrayList ArrayList Pointer
    // 020 DefaultNameIndex                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 028 DelayedAddRangeTables                    000185B79420 ModelClassListType DataTable[] DataTable[] List<DataTable> Pointer
    // 030 OnCollectionChangedDelegate              0001865C4430 ModelClassType CollectionChangeEventHandler CollectionChangeEventHandler CollectionChangeEventHandler Pointer
    // 038 OnCollectionChangingDelegate             0001865C4430 ModelClassType CollectionChangeEventHandler CollectionChangeEventHandler CollectionChangeEventHandler Pointer
    // 000 s_objectTypeCount                        int IL2CPP_TYPE_I4
    // 040 ObjectID                                 0001865F4260 ModelPrimitiveType int int int Int32
    public partial class DataTableCollection
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
            var value   = new DataTableCollection();

            value.DataSet                                   = GetObject<DataSet>(new IntPtr(p + 0x010), ReversePrism.DataModels.DataSet.FromPointer); // 0270D88DC308 0x10 DataSet                     ( 000186680C90 ModelClassType DataSet DataSet DataSet Pointer )
            value.List                                      = GetObject<ArrayList>(new IntPtr(p + 0x018), ReversePrism.DataModels.ArrayList.FromPointer); // 0270D88DC328 0x18 List                        ( 00018658A840 ModelClassType ArrayList ArrayList ArrayList Pointer )
            value.DefaultNameIndex                          = GetInt32(new IntPtr(p + 0x020)); // 0270D88DC348 0x20 DefaultNameIndex            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.DelayedAddRangeTables                     = GetObjectList<DataTable>(new IntPtr(p + 0x028), ReversePrism.DataModels.DataTable.FromPointer); // 0270D88DC368 0x28 DelayedAddRangeTables       ( 000185B79420 ModelClassListType DataTable[] DataTable[] List<DataTable> Pointer )
            value.OnCollectionChangedDelegate               = GetObject<CollectionChangeEventHandler>(new IntPtr(p + 0x030), ReversePrism.DataModels.CollectionChangeEventHandler.FromPointer); // 0270D88DC388 0x30 OnCollectionChangedDelegate ( 0001865C4430 ModelClassType CollectionChangeEventHandler CollectionChangeEventHandler CollectionChangeEventHandler Pointer )
            value.OnCollectionChangingDelegate              = GetObject<CollectionChangeEventHandler>(new IntPtr(p + 0x038), ReversePrism.DataModels.CollectionChangeEventHandler.FromPointer); // 0270D88DC3A8 0x38 OnCollectionChangingDelegate ( 0001865C4430 ModelClassType CollectionChangeEventHandler CollectionChangeEventHandler CollectionChangeEventHandler Pointer )
            value.ObjectID                                  = GetInt32(new IntPtr(p + 0x040)); // 0270D88DC3E8 0x40 ObjectID                    ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
