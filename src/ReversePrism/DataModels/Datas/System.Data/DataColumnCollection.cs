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
    // 028 DelayedAddRangeColumns                   ModelClassListType DataColumn[] DataColumn[] List<DataColumn> Pointer
    // 030 _columnFromName                          Dictionary`2<string, DataColumn> IL2CPP_TYPE_GENERICINST
    // 038 FInClear                                 ModelPrimitiveType bool bool bool Bool
    // 040 ColumnsImplementingIChangeTracking       ModelClassListType DataColumn[] DataColumn[] List<DataColumn> Pointer
    // 048 NColumnsImplementingIChangeTracking      ModelPrimitiveType int int int Int32
    // 04C NColumnsImplementingIRevertibleChangeTracking ModelPrimitiveType int int int Int32
    // 050 CollectionChanged                        ModelClassType CollectionChangeEventHandler CollectionChangeEventHandler CollectionChangeEventHandler Pointer
    // 058 CollectionChanging                       ModelClassType CollectionChangeEventHandler CollectionChangeEventHandler CollectionChangeEventHandler Pointer
    // 060 ColumnPropertyChanged                    ModelClassType CollectionChangeEventHandler CollectionChangeEventHandler CollectionChangeEventHandler Pointer
    public partial class DataColumnCollection : DataModel
    {
        public DataTable?                               Table                                   { get; set; }
        public ArrayList?                               List                                    { get; set; }
        public int                                      DefaultNameIndex                        { get; set; }
        public List<DataColumn>?                        DelayedAddRangeColumns                  { get; set; }
        public bool                                     FInClear                                { get; set; }
        public List<DataColumn>?                        ColumnsImplementingIChangeTracking      { get; set; }
        public int                                      NColumnsImplementingIChangeTracking     { get; set; }
        public int                                      NColumnsImplementingIRevertibleChangeTracking { get; set; }
        public CollectionChangeEventHandler?            CollectionChanged                       { get; set; }
        public CollectionChangeEventHandler?            CollectionChanging                      { get; set; }
        public CollectionChangeEventHandler?            ColumnPropertyChanged                   { get; set; }

        public static DataColumnCollection? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DataColumnCollection() { Pointer= p0 };

            value.Table                                     = GetObject<DataTable>(new IntPtr(p + 0x010), ReversePrism.DataModels.DataTable.FromPointer); // 0x10 Table                       ( ModelClassType DataTable DataTable DataTable Pointer )
            value.List                                      = GetObject<ArrayList>(new IntPtr(p + 0x018), ReversePrism.DataModels.ArrayList.FromPointer); // 0x18 List                        ( ModelClassType ArrayList ArrayList ArrayList Pointer )
            value.DefaultNameIndex                          = GetInt32(new IntPtr(p + 0x020)); // 0x20 DefaultNameIndex            ( ModelPrimitiveType int int int Int32 )
            value.DelayedAddRangeColumns                    = GetObjectList<DataColumn>(new IntPtr(p + 0x028), ReversePrism.DataModels.DataColumn.FromPointer); // 0x28 DelayedAddRangeColumns      ( ModelClassListType DataColumn[] DataColumn[] List<DataColumn> Pointer )
            value.FInClear                                  = GetBool(new IntPtr(p + 0x038)); // 0x38 FInClear                    ( ModelPrimitiveType bool bool bool Bool )
            value.ColumnsImplementingIChangeTracking        = GetObjectList<DataColumn>(new IntPtr(p + 0x040), ReversePrism.DataModels.DataColumn.FromPointer); // 0x40 ColumnsImplementingIChangeTracking ( ModelClassListType DataColumn[] DataColumn[] List<DataColumn> Pointer )
            value.NColumnsImplementingIChangeTracking       = GetInt32(new IntPtr(p + 0x048)); // 0x48 NColumnsImplementingIChangeTracking ( ModelPrimitiveType int int int Int32 )
            value.NColumnsImplementingIRevertibleChangeTracking = GetInt32(new IntPtr(p + 0x04C)); // 0x4C NColumnsImplementingIRevertibleChangeTracking ( ModelPrimitiveType int int int Int32 )
            value.CollectionChanged                         = GetObject<CollectionChangeEventHandler>(new IntPtr(p + 0x050), ReversePrism.DataModels.CollectionChangeEventHandler.FromPointer); // 0x50 CollectionChanged           ( ModelClassType CollectionChangeEventHandler CollectionChangeEventHandler CollectionChangeEventHandler Pointer )
            value.CollectionChanging                        = GetObject<CollectionChangeEventHandler>(new IntPtr(p + 0x058), ReversePrism.DataModels.CollectionChangeEventHandler.FromPointer); // 0x58 CollectionChanging          ( ModelClassType CollectionChangeEventHandler CollectionChangeEventHandler CollectionChangeEventHandler Pointer )
            value.ColumnPropertyChanged                     = GetObject<CollectionChangeEventHandler>(new IntPtr(p + 0x060), ReversePrism.DataModels.CollectionChangeEventHandler.FromPointer); // 0x60 ColumnPropertyChanged       ( ModelClassType CollectionChangeEventHandler CollectionChangeEventHandler CollectionChangeEventHandler Pointer )

            return value;
        }
    }
}
