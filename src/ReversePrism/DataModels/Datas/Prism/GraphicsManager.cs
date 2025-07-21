using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DisplayBufferScale                       ModelPrimitiveType float float float Single
    // 014 ShadowType                               ModelEnumType ShadowType ShadowType ShadowType Int32
    // 018 NoPostProcess                            ModelPrimitiveType bool bool bool Bool
    public partial class GraphicsManager : DataModel
    {
        public float                                    DisplayBufferScale                      { get; set; }
        public ShadowType                               ShadowType                              { get; set; }
        public bool                                     NoPostProcess                           { get; set; }

        public static GraphicsManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GraphicsManager() { Pointer= p0 };

            value.DisplayBufferScale                        = GetSingle(new IntPtr(p + 0x010)); // 0x10 DisplayBufferScale          ( ModelPrimitiveType float float float Single )
            value.ShadowType                                = (ShadowType)GetInt32(new IntPtr(p + 0x014)); // 0x14 ShadowType                  ( ModelEnumType ShadowType ShadowType ShadowType Int32 )
            value.NoPostProcess                             = GetBool(new IntPtr(p + 0x018)); // 0x18 NoPostProcess               ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
