using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MainTitle                                000186672F10 ModelPrimitiveType string string string String
    // 018 SubTitle                                 000186672F10 ModelPrimitiveType string string string String
    // 020 IsStoryTitle                             0001865965D0 ModelPrimitiveType bool bool bool Bool
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

            value.MainTitle                                 = GetString(new IntPtr(p + 0x010)); // 024665E43308 0x10 MainTitle                   ( 000186672F10 ModelPrimitiveType string string string String )
            value.SubTitle                                  = GetString(new IntPtr(p + 0x018)); // 024665E43328 0x18 SubTitle                    ( 000186672F10 ModelPrimitiveType string string string String )
            value.IsStoryTitle                              = GetBool(new IntPtr(p + 0x020)); // 024665E43348 0x20 IsStoryTitle                ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
