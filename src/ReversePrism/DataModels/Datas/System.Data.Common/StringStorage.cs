using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 Values                                   ModelPrimitiveListType string[] string[] List<string> Pointer
    public partial class StringStorage : DataModel
    {
        public List<string>?                            Values                                  { get; set; }

        public static StringStorage? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StringStorage() { Pointer= p0 };

            value.Values                                    = GetStringList(new IntPtr(p + 0x050)); // 0x50 Values                      ( ModelPrimitiveListType string[] string[] List<string> Pointer )

            return value;
        }
    }
}
