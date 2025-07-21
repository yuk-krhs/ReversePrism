using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 StartCharIdx                             ModelPrimitiveType int int int Int32
    // 014 Height                                   ModelPrimitiveType int int int Int32
    // 018 TopY                                     ModelPrimitiveType float float float Single
    // 01C Leading                                  ModelPrimitiveType float float float Single
    public partial class UILineInfo : DataModel
    {
        public int                                      StartCharIdx                            { get; set; }
        public int                                      Height                                  { get; set; }
        public float                                    TopY                                    { get; set; }
        public float                                    Leading                                 { get; set; }

        public static UILineInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UILineInfo() { Pointer= p0 };

            value.StartCharIdx                              = GetInt32(new IntPtr(p + 0x010)); // 0x10 StartCharIdx                ( ModelPrimitiveType int int int Int32 )
            value.Height                                    = GetInt32(new IntPtr(p + 0x014)); // 0x14 Height                      ( ModelPrimitiveType int int int Int32 )
            value.TopY                                      = GetSingle(new IntPtr(p + 0x018)); // 0x18 TopY                        ( ModelPrimitiveType float float float Single )
            value.Leading                                   = GetSingle(new IntPtr(p + 0x01C)); // 0x1C Leading                     ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
