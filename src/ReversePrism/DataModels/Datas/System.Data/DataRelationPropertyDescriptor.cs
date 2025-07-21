using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 088 Relation                                 ModelClassType DataRelation DataRelation DataRelation Pointer
    public partial class DataRelationPropertyDescriptor : DataModel
    {
        public DataRelation?                            Relation                                { get; set; }

        public static DataRelationPropertyDescriptor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DataRelationPropertyDescriptor() { Pointer= p0 };

            value.Relation                                  = GetObject<DataRelation>(new IntPtr(p + 0x088), ReversePrism.DataModels.DataRelation.FromPointer); // 0x88 Relation                    ( ModelClassType DataRelation DataRelation DataRelation Pointer )

            return value;
        }
    }
}
