using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 Values                                   000185B78CA0 ModelPrimitiveListType bool[] bool[] List<bool> Pointer
    public partial class BooleanStorage : DataModel
    {
        public List<bool>?                              Values                                  { get; set; }

        public static BooleanStorage? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BooleanStorage() { Pointer= p0 };

            value.Values                                    = GetBoolList(new IntPtr(p + 0x050)); // 024668A11EE0 0x50 Values                      ( 000185B78CA0 ModelPrimitiveListType bool[] bool[] List<bool> Pointer )

            return value;
        }
    }
}
