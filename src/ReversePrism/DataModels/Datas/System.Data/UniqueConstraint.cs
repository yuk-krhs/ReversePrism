using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 Key                                      00018667AF10 ModelEnumType DataKey DataKey DataKey Int32
    // 040 ConstraintIndex                          0001866DFE20 ModelClassType Index Index Index Pointer
    // 048 BPrimaryKey                              000186595210 ModelPrimitiveType bool bool bool Bool
    // 050 ConstraintName                           000186671BA0 ModelPrimitiveType string string string String
    // 058 ColumnNames                              000185B81660 ModelPrimitiveListType string[] string[] List<string> Pointer
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

            value.Key                                       = (DataKey)GetInt32(new IntPtr(p + 0x038)); // 024668900170 0x38 Key                         ( 00018667AF10 ModelEnumType DataKey DataKey DataKey Int32 )
            value.ConstraintIndex                           = GetObject<Index>(new IntPtr(p + 0x040), ReversePrism.DataModels.Index.FromPointer); // 024668900190 0x40 ConstraintIndex             ( 0001866DFE20 ModelClassType Index Index Index Pointer )
            value.BPrimaryKey                               = GetBool(new IntPtr(p + 0x048)); // 0246689001B0 0x48 BPrimaryKey                 ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.ConstraintName                            = GetString(new IntPtr(p + 0x050)); // 0246689001D0 0x50 ConstraintName              ( 000186671BA0 ModelPrimitiveType string string string String )
            value.ColumnNames                               = GetStringList(new IntPtr(p + 0x058)); // 0246689001F0 0x58 ColumnNames                 ( 000185B81660 ModelPrimitiveListType string[] string[] List<string> Pointer )

            return value;
        }
    }
}
