using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 DataSet                                  000186680C90 ModelClassType DataSet DataSet DataSet Pointer
    // 040 Relations                                00018658A840 ModelClassType ArrayList ArrayList ArrayList Pointer
    // 048 DelayLoadingRelations                    000185B78F10 ModelClassListType DataRelation[] DataRelation[] List<DataRelation> Pointer
    public partial class DataSetRelationCollection : DataModel
    {
        public DataSet?                                 DataSet                                 { get; set; }
        public ArrayList?                               Relations                               { get; set; }
        public List<DataRelation>?                      DelayLoadingRelations                   { get; set; }

        public static DataSetRelationCollection? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DataSetRelationCollection() { Pointer= p0 };

            value.DataSet                                   = GetObject<DataSet>(new IntPtr(p + 0x038), ReversePrism.DataModels.DataSet.FromPointer); // 0246689358D0 0x38 DataSet                     ( 000186680C90 ModelClassType DataSet DataSet DataSet Pointer )
            value.Relations                                 = GetObject<ArrayList>(new IntPtr(p + 0x040), ReversePrism.DataModels.ArrayList.FromPointer); // 0246689358F0 0x40 Relations                   ( 00018658A840 ModelClassType ArrayList ArrayList ArrayList Pointer )
            value.DelayLoadingRelations                     = GetObjectList<DataRelation>(new IntPtr(p + 0x048), ReversePrism.DataModels.DataRelation.FromPointer); // 024668935910 0x48 DelayLoadingRelations       ( 000185B78F10 ModelClassListType DataRelation[] DataRelation[] List<DataRelation> Pointer )

            return value;
        }
    }
}
