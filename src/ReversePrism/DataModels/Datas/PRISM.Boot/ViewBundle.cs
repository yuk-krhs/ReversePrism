using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TypeName                                 0001866722E0 ModelPrimitiveType string string string String
    // 018 Reference                                0001866722E0 ModelPrimitiveType string string string String
    // 020 Tags                                     000185B81990 ModelPrimitiveListType string[] string[] List<string> Pointer
    public partial class ViewBundle
    {
        public string                                   TypeName                                { get; set; }
        public string                                   Reference                               { get; set; }
        public List<string>?                            Tags                                    { get; set; }

        public static ViewBundle? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ViewBundle();

            value.TypeName                                  = GetString(new IntPtr(p + 0x010)); // 0270D0A4E870 0x10 TypeName                    ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Reference                                 = GetString(new IntPtr(p + 0x018)); // 0270D0A4E890 0x18 Reference                   ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Tags                                      = GetStringList(new IntPtr(p + 0x020)); // 0270D0A4E8B0 0x20 Tags                        ( 000185B81990 ModelPrimitiveListType string[] string[] List<string> Pointer )

            return value;
        }
    }
}
