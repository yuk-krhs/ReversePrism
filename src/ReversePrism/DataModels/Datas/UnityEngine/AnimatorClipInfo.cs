using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_ClipInstanceID                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 014 M_Weight                                 0001866656B0 ModelPrimitiveType float float float Single
    public partial class AnimatorClipInfo
    {
        public int                                      M_ClipInstanceID                        { get; set; }
        public float                                    M_Weight                                { get; set; }

        public static AnimatorClipInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AnimatorClipInfo();

            value.M_ClipInstanceID                          = GetInt32(new IntPtr(p + 0x010)); // 0270022254C8 0x10 M_ClipInstanceID            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_Weight                                  = GetSingle(new IntPtr(p + 0x014)); // 0270022254E8 0x14 M_Weight                    ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
