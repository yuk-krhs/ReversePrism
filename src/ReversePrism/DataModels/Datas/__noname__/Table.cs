using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 IsReadOnly                               ModelPrimitiveType bool bool bool Bool
    // 058 M_Header                                 ModelPrimitiveListType bool[] bool[] List<bool> Pointer
    public partial class Table : DataModel
    {
        public bool                                     IsReadOnly                              { get; set; }
        public List<bool>?                              M_Header                                { get; set; }

        public static Table? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Table() { Pointer= p0 };

            value.IsReadOnly                                = GetBool(new IntPtr(p + 0x050)); // 0x50 IsReadOnly                  ( ModelPrimitiveType bool bool bool Bool )
            value.M_Header                                  = GetBoolList(new IntPtr(p + 0x058)); // 0x58 M_Header                    ( ModelPrimitiveListType bool[] bool[] List<bool> Pointer )

            return value;
        }
    }
}
