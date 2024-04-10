using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 InspectorUpdater                         0001865F36C0 ModelPrimitiveType int int int Int32
    // 024 UnscaledTime                             0001866656B0 ModelPrimitiveType float float float Single
    // 028 UnscaledDeltaTime                        0001866656B0 ModelPrimitiveType float float float Single
    // 02C Paused                                   000186594D10 ModelPrimitiveType bool bool bool Bool
    // 030 PausedTime                               0001866656B0 ModelPrimitiveType float float float Single
    // 034 DuplicateToDestroy                       000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class DOTweenComponent : DataModel
    {
        public int                                      InspectorUpdater                        { get; set; }
        public float                                    UnscaledTime                            { get; set; }
        public float                                    UnscaledDeltaTime                       { get; set; }
        public bool                                     Paused                                  { get; set; }
        public float                                    PausedTime                              { get; set; }
        public bool                                     DuplicateToDestroy                      { get; set; }

        public static DOTweenComponent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DOTweenComponent() { Pointer= p0 };

            value.InspectorUpdater                          = GetInt32(new IntPtr(p + 0x020)); // 0245A43A99E8 0x20 InspectorUpdater            ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.UnscaledTime                              = GetSingle(new IntPtr(p + 0x024)); // 0245A43A9A08 0x24 UnscaledTime                ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.UnscaledDeltaTime                         = GetSingle(new IntPtr(p + 0x028)); // 0245A43A9A28 0x28 UnscaledDeltaTime           ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.Paused                                    = GetBool(new IntPtr(p + 0x02C)); // 0245A43A9A48 0x2C Paused                      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.PausedTime                                = GetSingle(new IntPtr(p + 0x030)); // 0245A43A9A68 0x30 PausedTime                  ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.DuplicateToDestroy                        = GetBool(new IntPtr(p + 0x034)); // 0245A43A9A88 0x34 DuplicateToDestroy          ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
