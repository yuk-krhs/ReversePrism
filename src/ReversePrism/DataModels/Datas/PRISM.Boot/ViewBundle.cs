using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TypeName                                 ModelPrimitiveType string string string String
    // 018 Reference                                ModelPrimitiveType string string string String
    // 020 Tags                                     ModelPrimitiveListType string[] string[] List<string> Pointer
    public partial class ViewBundle : DataModel
    {
        public string                                   TypeName                                { get; set; }
        public string                                   Reference                               { get; set; }
        public List<string>?                            Tags                                    { get; set; }

        public static ViewBundle? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ViewBundle() { Pointer= p0 };

            value.TypeName                                  = GetString(new IntPtr(p + 0x010)); // 0x10 TypeName                    ( ModelPrimitiveType string string string String )
            value.Reference                                 = GetString(new IntPtr(p + 0x018)); // 0x18 Reference                   ( ModelPrimitiveType string string string String )
            value.Tags                                      = GetStringList(new IntPtr(p + 0x020)); // 0x20 Tags                        ( ModelPrimitiveListType string[] string[] List<string> Pointer )

            return value;
        }
    }
}
