using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 FastSlowView                             ModelClassType JudgeFastSlowView JudgeFastSlowView JudgeFastSlowView Pointer
    // 028 Sequence                                 ModelClassType Sequence Sequence Sequence Pointer
    public partial class JudgementLagView : DataModel
    {
        public JudgeFastSlowView?                       FastSlowView                            { get; set; }
        public Sequence?                                Sequence                                { get; set; }

        public static JudgementLagView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JudgementLagView() { Pointer= p0 };

            value.FastSlowView                              = GetObject<JudgeFastSlowView>(new IntPtr(p + 0x020), ReversePrism.DataModels.JudgeFastSlowView.FromPointer); // 0x20 FastSlowView                ( ModelClassType JudgeFastSlowView JudgeFastSlowView JudgeFastSlowView Pointer )
            value.Sequence                                  = GetObject<Sequence>(new IntPtr(p + 0x028), ReversePrism.DataModels.Sequence.FromPointer); // 0x28 Sequence                    ( ModelClassType Sequence Sequence Sequence Pointer )

            return value;
        }
    }
}
