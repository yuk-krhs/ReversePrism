using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 START_MARK                               string IL2CPP_TYPE_STRING
    // 000 END_MARK                                 string IL2CPP_TYPE_STRING
    // 000 argCommna                                string IL2CPP_TYPE_STRING
    // 010 ArgCommaSeparator                        000185B81DA0 ModelPrimitiveListType string[] string[] List<string> Pointer
    public partial class SourceReplacer : DataModel
    {
        public List<string>?                            ArgCommaSeparator                       { get; set; }

        public static SourceReplacer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SourceReplacer() { Pointer= p0 };

            value.ArgCommaSeparator                         = GetStringList(new IntPtr(p + 0x010)); // 024664BA5E40 0x10 ArgCommaSeparator           ( 000185B81DA0 ModelPrimitiveListType string[] string[] List<string> Pointer )

            return value;
        }
    }
}
