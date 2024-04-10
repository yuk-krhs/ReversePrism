using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BodyAnimName                             0001866722E0 ModelPrimitiveType string string string String
    // 018 OffsetFrame                              0001865F36C0 ModelPrimitiveType int int int Int32
    // 020 AddtiveAnimation                         0001866B1E00 ModelClassType Animation Animation Animation Pointer
    // 028 ClipName                                 000186674520 ModelPrimitiveType string string string String
    // 030 ClipIndex                                0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class AdditiveAnimationData : DataModel
    {
        public string                                   BodyAnimName                            { get; set; }
        public int                                      OffsetFrame                             { get; set; }
        public Animation?                               AddtiveAnimation                        { get; set; }
        public string                                   ClipName                                { get; set; }
        public int                                      ClipIndex                               { get; set; }

        public static AdditiveAnimationData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AdditiveAnimationData() { Pointer= p0 };

            value.BodyAnimName                              = GetString(new IntPtr(p + 0x010)); // 0245A69CEE70 0x10 BodyAnimName                ( 0001866722E0 ModelPrimitiveType string string string String )
            value.OffsetFrame                               = GetInt32(new IntPtr(p + 0x018)); // 0245A69CEE90 0x18 OffsetFrame                 ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.AddtiveAnimation                          = GetObject<Animation>(new IntPtr(p + 0x020), ReversePrism.DataModels.Animation.FromPointer); // 0245A69CEEB0 0x20 AddtiveAnimation            ( 0001866B1E00 ModelClassType Animation Animation Animation Pointer )
            value.ClipName                                  = GetString(new IntPtr(p + 0x028)); // 0245A69CEED0 0x28 ClipName                    ( 000186674520 ModelPrimitiveType string string string String )
            value.ClipIndex                                 = GetInt32(new IntPtr(p + 0x030)); // 0245A69CEEF0 0x30 ClipIndex                   ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
