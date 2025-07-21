using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BodyAnimName                             ModelPrimitiveType string string string String
    // 018 OffsetFrame                              ModelPrimitiveType int int int Int32
    // 020 AddtiveAnimation                         ModelClassType Animation Animation Animation Pointer
    // 028 ClipName                                 ModelPrimitiveType string string string String
    // 030 ClipIndex                                ModelPrimitiveType int int int Int32
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

            value.BodyAnimName                              = GetString(new IntPtr(p + 0x010)); // 0x10 BodyAnimName                ( ModelPrimitiveType string string string String )
            value.OffsetFrame                               = GetInt32(new IntPtr(p + 0x018)); // 0x18 OffsetFrame                 ( ModelPrimitiveType int int int Int32 )
            value.AddtiveAnimation                          = GetObject<Animation>(new IntPtr(p + 0x020), ReversePrism.DataModels.Animation.FromPointer); // 0x20 AddtiveAnimation            ( ModelClassType Animation Animation Animation Pointer )
            value.ClipName                                  = GetString(new IntPtr(p + 0x028)); // 0x28 ClipName                    ( ModelPrimitiveType string string string String )
            value.ClipIndex                                 = GetInt32(new IntPtr(p + 0x030)); // 0x30 ClipIndex                   ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
