using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 DataSet                                  ModelClassType DataSet DataSet DataSet Pointer
    // 040 Relations                                ModelClassType ArrayList ArrayList ArrayList Pointer
    // 048 DelayLoadingRelations                    ModelClassListType DataRelation[] DataRelation[] List<DataRelation> Pointer
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

            value.DataSet                                   = GetObject<DataSet>(new IntPtr(p + 0x038), ReversePrism.DataModels.DataSet.FromPointer); // 0x38 DataSet                     ( ModelClassType DataSet DataSet DataSet Pointer )
            value.Relations                                 = GetObject<ArrayList>(new IntPtr(p + 0x040), ReversePrism.DataModels.ArrayList.FromPointer); // 0x40 Relations                   ( ModelClassType ArrayList ArrayList ArrayList Pointer )
            value.DelayLoadingRelations                     = GetObjectList<DataRelation>(new IntPtr(p + 0x048), ReversePrism.DataModels.DataRelation.FromPointer); // 0x48 DelayLoadingRelations       ( ModelClassListType DataRelation[] DataRelation[] List<DataRelation> Pointer )

            return value;
        }
    }
}
