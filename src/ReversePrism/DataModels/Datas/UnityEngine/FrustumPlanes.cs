using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Left                                     000186666050 ModelPrimitiveType float float float Single
    // 014 Right                                    000186666050 ModelPrimitiveType float float float Single
    // 018 Bottom                                   000186666050 ModelPrimitiveType float float float Single
    // 01C Top                                      000186666050 ModelPrimitiveType float float float Single
    // 020 ZNear                                    000186666050 ModelPrimitiveType float float float Single
    // 024 ZFar                                     000186666050 ModelPrimitiveType float float float Single
    public partial class FrustumPlanes
    {
        public float                                    Left                                    { get; set; }
        public float                                    Right                                   { get; set; }
        public float                                    Bottom                                  { get; set; }
        public float                                    Top                                     { get; set; }
        public float                                    ZNear                                   { get; set; }
        public float                                    ZFar                                    { get; set; }

        public static FrustumPlanes? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FrustumPlanes();

            value.Left                                      = GetSingle(new IntPtr(p + 0x010)); // 0270068B1838 0x10 Left                        ( 000186666050 ModelPrimitiveType float float float Single )
            value.Right                                     = GetSingle(new IntPtr(p + 0x014)); // 0270068B1858 0x14 Right                       ( 000186666050 ModelPrimitiveType float float float Single )
            value.Bottom                                    = GetSingle(new IntPtr(p + 0x018)); // 0270068B1878 0x18 Bottom                      ( 000186666050 ModelPrimitiveType float float float Single )
            value.Top                                       = GetSingle(new IntPtr(p + 0x01C)); // 0270068B1898 0x1C Top                         ( 000186666050 ModelPrimitiveType float float float Single )
            value.ZNear                                     = GetSingle(new IntPtr(p + 0x020)); // 0270068B18B8 0x20 ZNear                       ( 000186666050 ModelPrimitiveType float float float Single )
            value.ZFar                                      = GetSingle(new IntPtr(p + 0x024)); // 0270068B18D8 0x24 ZFar                        ( 000186666050 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
