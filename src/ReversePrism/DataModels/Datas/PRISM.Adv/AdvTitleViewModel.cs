using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MainTitle                                ModelPrimitiveType string string string String
    // 018 SubTitle                                 ModelPrimitiveType string string string String
    // 020 IsStoryTitle                             ModelPrimitiveType bool bool bool Bool
    public partial class AdvTitleViewModel : DataModel
    {
        public string                                   MainTitle                               { get; set; }
        public string                                   SubTitle                                { get; set; }
        public bool                                     IsStoryTitle                            { get; set; }

        public static AdvTitleViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AdvTitleViewModel() { Pointer= p0 };

            value.MainTitle                                 = GetString(new IntPtr(p + 0x010)); // 0x10 MainTitle                   ( ModelPrimitiveType string string string String )
            value.SubTitle                                  = GetString(new IntPtr(p + 0x018)); // 0x18 SubTitle                    ( ModelPrimitiveType string string string String )
            value.IsStoryTitle                              = GetBool(new IntPtr(p + 0x020)); // 0x20 IsStoryTitle                ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
