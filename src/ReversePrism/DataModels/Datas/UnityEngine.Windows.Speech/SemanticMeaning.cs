using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Key                                      ModelPrimitiveType string string string String
    // 018 Values                                   ModelPrimitiveListType string[] string[] List<string> Pointer
    public partial class SemanticMeaning : DataModel
    {
        public string                                   Key                                     { get; set; }
        public List<string>?                            Values                                  { get; set; }

        public static SemanticMeaning? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SemanticMeaning() { Pointer= p0 };

            value.Key                                       = GetString(new IntPtr(p + 0x010)); // 0x10 Key                         ( ModelPrimitiveType string string string String )
            value.Values                                    = GetStringList(new IntPtr(p + 0x018)); // 0x18 Values                      ( ModelPrimitiveListType string[] string[] List<string> Pointer )

            return value;
        }
    }
}
