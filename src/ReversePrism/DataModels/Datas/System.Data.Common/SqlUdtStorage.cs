using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 _values                                  <object>[] IL2CPP_TYPE_SZARRAY
    // 058 ImplementsIXmlSerializable               ModelPrimitiveType bool bool bool Bool
    // 059 ImplementsIComparable                    ModelPrimitiveType bool bool bool Bool
    // 000 s_typeToNull                             ConcurrentDictionary`2<Type, <object>> IL2CPP_TYPE_GENERICINST
    public partial class SqlUdtStorage : DataModel
    {
        public bool                                     ImplementsIXmlSerializable              { get; set; }
        public bool                                     ImplementsIComparable                   { get; set; }

        public static SqlUdtStorage? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SqlUdtStorage() { Pointer= p0 };

            value.ImplementsIXmlSerializable                = GetBool(new IntPtr(p + 0x058)); // 0x58 ImplementsIXmlSerializable  ( ModelPrimitiveType bool bool bool Bool )
            value.ImplementsIComparable                     = GetBool(new IntPtr(p + 0x059)); // 0x59 ImplementsIComparable       ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
