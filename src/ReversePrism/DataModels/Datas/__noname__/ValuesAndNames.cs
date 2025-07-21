using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Values                                   ModelPrimitiveListType ulong[] ulong[] List<ulong> Pointer
    // 018 Names                                    ModelPrimitiveListType string[] string[] List<string> Pointer
    public partial class ValuesAndNames : DataModel
    {
        public List<ulong>?                             Values                                  { get; set; }
        public List<string>?                            Names                                   { get; set; }

        public static ValuesAndNames? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ValuesAndNames() { Pointer= p0 };

            value.Values                                    = GetUInt64List(new IntPtr(p + 0x010)); // 0x10 Values                      ( ModelPrimitiveListType ulong[] ulong[] List<ulong> Pointer )
            value.Names                                     = GetStringList(new IntPtr(p + 0x018)); // 0x18 Names                       ( ModelPrimitiveListType string[] string[] List<string> Pointer )

            return value;
        }
    }
}
