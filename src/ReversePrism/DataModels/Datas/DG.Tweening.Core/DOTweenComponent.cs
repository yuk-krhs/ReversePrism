using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 InspectorUpdater                         ModelPrimitiveType int int int Int32
    // 024 UnscaledTime                             ModelPrimitiveType float float float Single
    // 028 UnscaledDeltaTime                        ModelPrimitiveType float float float Single
    // 02C Paused                                   ModelPrimitiveType bool bool bool Bool
    // 030 PausedTime                               ModelPrimitiveType float float float Single
    // 034 DuplicateToDestroy                       ModelPrimitiveType bool bool bool Bool
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

            value.InspectorUpdater                          = GetInt32(new IntPtr(p + 0x020)); // 0x20 InspectorUpdater            ( ModelPrimitiveType int int int Int32 )
            value.UnscaledTime                              = GetSingle(new IntPtr(p + 0x024)); // 0x24 UnscaledTime                ( ModelPrimitiveType float float float Single )
            value.UnscaledDeltaTime                         = GetSingle(new IntPtr(p + 0x028)); // 0x28 UnscaledDeltaTime           ( ModelPrimitiveType float float float Single )
            value.Paused                                    = GetBool(new IntPtr(p + 0x02C)); // 0x2C Paused                      ( ModelPrimitiveType bool bool bool Bool )
            value.PausedTime                                = GetSingle(new IntPtr(p + 0x030)); // 0x30 PausedTime                  ( ModelPrimitiveType float float float Single )
            value.DuplicateToDestroy                        = GetBool(new IntPtr(p + 0x034)); // 0x34 DuplicateToDestroy          ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
