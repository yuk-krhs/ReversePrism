using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TitleCallData                            ModelClassType ITitleCallData ITitleCallData ITitleCallData Pointer
    // 018 IsTitleCallEnabled                       ModelPrimitiveType bool bool bool Bool
    // 019 IsFirstPlay                              ModelPrimitiveType bool bool bool Bool
    public partial class TitleCallPlayer : DataModel
    {
        public ITitleCallData?                          TitleCallData                           { get; set; }
        public bool                                     IsTitleCallEnabled                      { get; set; }
        public bool                                     IsFirstPlay                             { get; set; }

        public static TitleCallPlayer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TitleCallPlayer() { Pointer= p0 };

            value.TitleCallData                             = GetObject<ITitleCallData>(new IntPtr(p + 0x010), ReversePrism.DataModels.ITitleCallData.FromPointer); // 0x10 TitleCallData               ( ModelClassType ITitleCallData ITitleCallData ITitleCallData Pointer )
            value.IsTitleCallEnabled                        = GetBool(new IntPtr(p + 0x018)); // 0x18 IsTitleCallEnabled          ( ModelPrimitiveType bool bool bool Bool )
            value.IsFirstPlay                               = GetBool(new IntPtr(p + 0x019)); // 0x19 IsFirstPlay                 ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
