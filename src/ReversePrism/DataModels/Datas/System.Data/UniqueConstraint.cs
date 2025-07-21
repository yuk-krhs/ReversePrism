using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 Key                                      ModelEnumType DataKey DataKey DataKey Int32
    // 040 ConstraintIndex                          ModelClassType Index Index Index Pointer
    // 048 BPrimaryKey                              ModelPrimitiveType bool bool bool Bool
    // 050 ConstraintName                           ModelPrimitiveType string string string String
    // 058 ColumnNames                              ModelPrimitiveListType string[] string[] List<string> Pointer
    public partial class UniqueConstraint : DataModel
    {
        public DataKey                                  Key                                     { get; set; }
        public Index?                                   ConstraintIndex                         { get; set; }
        public bool                                     BPrimaryKey                             { get; set; }
        public string                                   ConstraintName                          { get; set; }
        public List<string>?                            ColumnNames                             { get; set; }

        public static UniqueConstraint? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UniqueConstraint() { Pointer= p0 };

            value.Key                                       = (DataKey)GetInt32(new IntPtr(p + 0x038)); // 0x38 Key                         ( ModelEnumType DataKey DataKey DataKey Int32 )
            value.ConstraintIndex                           = GetObject<Index>(new IntPtr(p + 0x040), ReversePrism.DataModels.Index.FromPointer); // 0x40 ConstraintIndex             ( ModelClassType Index Index Index Pointer )
            value.BPrimaryKey                               = GetBool(new IntPtr(p + 0x048)); // 0x48 BPrimaryKey                 ( ModelPrimitiveType bool bool bool Bool )
            value.ConstraintName                            = GetString(new IntPtr(p + 0x050)); // 0x50 ConstraintName              ( ModelPrimitiveType string string string String )
            value.ColumnNames                               = GetStringList(new IntPtr(p + 0x058)); // 0x58 ColumnNames                 ( ModelPrimitiveListType string[] string[] List<string> Pointer )

            return value;
        }
    }
}
