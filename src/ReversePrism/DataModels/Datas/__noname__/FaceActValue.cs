using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Hangle                                   000186666050 ModelPrimitiveType float float float Single
    // 014 Vangle                                   000186666050 ModelPrimitiveType float float float Single
    // 018 Rangle                                   000186666050 ModelPrimitiveType float float float Single
    // 01C Close                                    000186666050 ModelPrimitiveType float float float Single
    // 020 CloseSmile                               000186666050 ModelPrimitiveType float float float Single
    public partial class FaceActValue : DataModel
    {
        public float                                    Hangle                                  { get; set; }
        public float                                    Vangle                                  { get; set; }
        public float                                    Rangle                                  { get; set; }
        public float                                    Close                                   { get; set; }
        public float                                    CloseSmile                              { get; set; }

        public static FaceActValue? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FaceActValue() { Pointer= p0 };

            value.Hangle                                    = GetSingle(new IntPtr(p + 0x010)); // 0245A6A63988 0x10 Hangle                      ( 000186666050 ModelPrimitiveType float float float Single )
            value.Vangle                                    = GetSingle(new IntPtr(p + 0x014)); // 0245A6A639A8 0x14 Vangle                      ( 000186666050 ModelPrimitiveType float float float Single )
            value.Rangle                                    = GetSingle(new IntPtr(p + 0x018)); // 0245A6A639C8 0x18 Rangle                      ( 000186666050 ModelPrimitiveType float float float Single )
            value.Close                                     = GetSingle(new IntPtr(p + 0x01C)); // 0245A6A639E8 0x1C Close                       ( 000186666050 ModelPrimitiveType float float float Single )
            value.CloseSmile                                = GetSingle(new IntPtr(p + 0x020)); // 0245A6A63A08 0x20 CloseSmile                  ( 000186666050 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
