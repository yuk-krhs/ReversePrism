using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Enable                                   ModelPrimitiveType bool bool bool Bool
    // 011 Elastic                                  ModelPrimitiveType bool bool bool Bool
    // 014 Duration                                 ModelPrimitiveType float float float Single
    // 018 EasingFunction                           ModelClassType EasingFunction EasingFunction EasingFunction Pointer
    // 020 StartTime                                ModelPrimitiveType float float float Single
    // 024 EndPosition                              ModelPrimitiveType float float float Single
    // 028 OnComplete                               ModelClassType Action Action Action Pointer
    public partial class AutoScrollState : DataModel
    {
        public bool                                     Enable                                  { get; set; }
        public bool                                     Elastic                                 { get; set; }
        public float                                    Duration                                { get; set; }
        public EasingFunction?                          EasingFunction                          { get; set; }
        public float                                    StartTime                               { get; set; }
        public float                                    EndPosition                             { get; set; }
        public Action?                                  OnComplete                              { get; set; }

        public static AutoScrollState? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AutoScrollState() { Pointer= p0 };

            value.Enable                                    = GetBool(new IntPtr(p + 0x010)); // 0x10 Enable                      ( ModelPrimitiveType bool bool bool Bool )
            value.Elastic                                   = GetBool(new IntPtr(p + 0x011)); // 0x11 Elastic                     ( ModelPrimitiveType bool bool bool Bool )
            value.Duration                                  = GetSingle(new IntPtr(p + 0x014)); // 0x14 Duration                    ( ModelPrimitiveType float float float Single )
            value.EasingFunction                            = GetObject<EasingFunction>(new IntPtr(p + 0x018), ReversePrism.DataModels.EasingFunction.FromPointer); // 0x18 EasingFunction              ( ModelClassType EasingFunction EasingFunction EasingFunction Pointer )
            value.StartTime                                 = GetSingle(new IntPtr(p + 0x020)); // 0x20 StartTime                   ( ModelPrimitiveType float float float Single )
            value.EndPosition                               = GetSingle(new IntPtr(p + 0x024)); // 0x24 EndPosition                 ( ModelPrimitiveType float float float Single )
            value.OnComplete                                = GetObject<Action>(new IntPtr(p + 0x028), ReversePrism.DataModels.Action.FromPointer); // 0x28 OnComplete                  ( ModelClassType Action Action Action Pointer )

            return value;
        }
    }
}
