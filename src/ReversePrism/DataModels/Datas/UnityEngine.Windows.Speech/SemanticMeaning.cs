using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Key                                      0001866722E0 ModelPrimitiveType string string string String
    // 018 Values                                   000185B81990 ModelPrimitiveListType string[] string[] List<string> Pointer
    public partial class SemanticMeaning
    {
        public string                                   Key                                     { get; set; }
        public List<string>?                            Values                                  { get; set; }

        public static SemanticMeaning? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SemanticMeaning();

            value.Key                                       = GetString(new IntPtr(p + 0x010)); // 0270068C1530 0x10 Key                         ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Values                                    = GetStringList(new IntPtr(p + 0x018)); // 0270068C1550 0x18 Values                      ( 000185B81990 ModelPrimitiveListType string[] string[] List<string> Pointer )

            return value;
        }
    }
}
