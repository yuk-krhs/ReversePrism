using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 M_Start                                  0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 044 M_Active                                 000186595480 ModelPrimitiveType bool bool bool Bool
    // 048 M_SplitView                              0001866CF720 ModelClassType TwoPaneSplitView TwoPaneSplitView TwoPaneSplitView Pointer
    // 050 M_Direction                              0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class TwoPaneSplitViewResizer : DataModel
    {
        public Vector3                                  M_Start                                 { get; set; }
        public bool                                     M_Active                                { get; set; }
        public TwoPaneSplitView?                        M_SplitView                             { get; set; }
        public int                                      M_Direction                             { get; set; }

        public static TwoPaneSplitViewResizer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TwoPaneSplitViewResizer() { Pointer= p0 };

            value.M_Start                                   = (Vector3)GetInt32(new IntPtr(p + 0x038)); // 0245A6705388 0x38 M_Start                     ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_Active                                  = GetBool(new IntPtr(p + 0x044)); // 0245A67053A8 0x44 M_Active                    ( 000186595480 ModelPrimitiveType bool bool bool Bool )
            value.M_SplitView                               = GetObject<TwoPaneSplitView>(new IntPtr(p + 0x048), ReversePrism.DataModels.TwoPaneSplitView.FromPointer); // 0245A67053C8 0x48 M_SplitView                 ( 0001866CF720 ModelClassType TwoPaneSplitView TwoPaneSplitView TwoPaneSplitView Pointer )
            value.M_Direction                               = GetInt32(new IntPtr(p + 0x050)); // 0245A67053E8 0x50 M_Direction                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
