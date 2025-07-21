using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Pause                                    ModelPrimitiveType bool bool bool Bool
    // 014 Volume                                   ModelPrimitiveType float float float Single
    // 018 StartTime                                ModelPrimitiveType int int int Int32
    // 01C IsLoop                                   ModelPrimitiveType bool bool bool Bool
    // 020 FadeInTime                               ModelPrimitiveType int int int Int32
    // 024 FadeOutTime                              ModelPrimitiveType int int int Int32
    // 000 Default                                  PlayParameters IL2CPP_TYPE_CLASS
    public partial class PlayParameters : DataModel
    {
        public bool                                     Pause                                   { get; set; }
        public float                                    Volume                                  { get; set; }
        public int                                      StartTime                               { get; set; }
        public bool                                     IsLoop                                  { get; set; }
        public int                                      FadeInTime                              { get; set; }
        public int                                      FadeOutTime                             { get; set; }

        public static PlayParameters? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PlayParameters() { Pointer= p0 };

            value.Pause                                     = GetBool(new IntPtr(p + 0x010)); // 0x10 Pause                       ( ModelPrimitiveType bool bool bool Bool )
            value.Volume                                    = GetSingle(new IntPtr(p + 0x014)); // 0x14 Volume                      ( ModelPrimitiveType float float float Single )
            value.StartTime                                 = GetInt32(new IntPtr(p + 0x018)); // 0x18 StartTime                   ( ModelPrimitiveType int int int Int32 )
            value.IsLoop                                    = GetBool(new IntPtr(p + 0x01C)); // 0x1C IsLoop                      ( ModelPrimitiveType bool bool bool Bool )
            value.FadeInTime                                = GetInt32(new IntPtr(p + 0x020)); // 0x20 FadeInTime                  ( ModelPrimitiveType int int int Int32 )
            value.FadeOutTime                               = GetInt32(new IntPtr(p + 0x024)); // 0x24 FadeOutTime                 ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
