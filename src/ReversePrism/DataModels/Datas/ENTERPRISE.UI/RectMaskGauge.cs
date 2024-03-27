using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Mask                                     00018662E8B0 ModelClassType RectMask2D RectMask2D RectMask2D Pointer
    // 028 Direction                                000186540C80 ModelEnumType Direction Direction Direction Int32
    // 02C FillAmount                               0001866656B0 ModelPrimitiveType float float float Single
    public partial class RectMaskGauge
    {
        public RectMask2D?                              Mask                                    { get; set; }
        public Direction                                Direction                               { get; set; }
        public float                                    FillAmount                              { get; set; }

        public static RectMaskGauge? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RectMaskGauge();

            value.Mask                                      = GetObject<RectMask2D>(new IntPtr(p + 0x020), ReversePrism.DataModels.RectMask2D.FromPointer); // 0270D0ABA658 0x20 Mask                        ( 00018662E8B0 ModelClassType RectMask2D RectMask2D RectMask2D Pointer )
            value.Direction                                 = (Direction)GetInt32(new IntPtr(p + 0x028)); // 0270D0ABA678 0x28 Direction                   ( 000186540C80 ModelEnumType Direction Direction Direction Int32 )
            value.FillAmount                                = GetSingle(new IntPtr(p + 0x02C)); // 0270D0ABA698 0x2C FillAmount                  ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
