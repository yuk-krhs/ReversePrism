using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Table                                    0001865B8520 ModelClassType DataTable DataTable DataTable Pointer
    // 018 LastFreeRecord                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 01C MinimumCapacity                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 RecordCapacity                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 028 FreeRecordList                           000185CED1B8 ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer
    // 030 Rows                                     000185B79150 ModelClassListType DataRow[] DataRow[] List<DataRow> Pointer
    public partial class RecordManager : DataModel
    {
        public DataTable?                               Table                                   { get; set; }
        public int                                      LastFreeRecord                          { get; set; }
        public int                                      MinimumCapacity                         { get; set; }
        public int                                      RecordCapacity                          { get; set; }
        public List<int>?                               FreeRecordList                          { get; set; }
        public List<DataRow>?                           Rows                                    { get; set; }

        public static RecordManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RecordManager() { Pointer= p0 };

            value.Table                                     = GetObject<DataTable>(new IntPtr(p + 0x010), ReversePrism.DataModels.DataTable.FromPointer); // 0246689593A0 0x10 Table                       ( 0001865B8520 ModelClassType DataTable DataTable DataTable Pointer )
            value.LastFreeRecord                            = GetInt32(new IntPtr(p + 0x018)); // 0246689593C0 0x18 LastFreeRecord              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MinimumCapacity                           = GetInt32(new IntPtr(p + 0x01C)); // 0246689593E0 0x1C MinimumCapacity             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.RecordCapacity                            = GetInt32(new IntPtr(p + 0x020)); // 024668959400 0x20 RecordCapacity              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.FreeRecordList                            = GetInt32List(new IntPtr(p + 0x028)); // 024668959420 0x28 FreeRecordList              ( 000185CED1B8 ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer )
            value.Rows                                      = GetObjectList<DataRow>(new IntPtr(p + 0x030), ReversePrism.DataModels.DataRow.FromPointer); // 024668959440 0x30 Rows                        ( 000185B79150 ModelClassListType DataRow[] DataRow[] List<DataRow> Pointer )

            return value;
        }
    }
}
