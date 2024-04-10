using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_argsMap                                000185B7D3F0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 018 M_originalSize                           0001865F2F90 ModelPrimitiveType int int int Int32
    // 01C M_isParamArray                           000186595210 ModelPrimitiveType bool bool bool Bool
    public partial class BinderState : DataModel
    {
        public List<int>?                               M_argsMap                               { get; set; }
        public int                                      M_originalSize                          { get; set; }
        public bool                                     M_isParamArray                          { get; set; }

        public static BinderState? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BinderState() { Pointer= p0 };

            value.M_argsMap                                 = GetInt32List(new IntPtr(p + 0x010)); // 0245A4211798 0x10 M_argsMap                   ( 000185B7D3F0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.M_originalSize                            = GetInt32(new IntPtr(p + 0x018)); // 0245A42117B8 0x18 M_originalSize              ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.M_isParamArray                            = GetBool(new IntPtr(p + 0x01C)); // 0245A42117D8 0x1C M_isParamArray              ( 000186595210 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
