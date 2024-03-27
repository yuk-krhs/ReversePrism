using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Enable                                   000186595960 ModelPrimitiveType bool bool bool Bool
    // 011 Elastic                                  000186595960 ModelPrimitiveType bool bool bool Bool
    // 014 Duration                                 000186666050 ModelPrimitiveType float float float Single
    // 018 EasingFunction                           00018671A030 ModelClassType EasingFunction EasingFunction EasingFunction Pointer
    // 020 StartTime                                000186666050 ModelPrimitiveType float float float Single
    // 024 EndPosition                              000186666050 ModelPrimitiveType float float float Single
    // 028 OnComplete                               000186679A00 ModelClassType Action Action Action Pointer
    public partial class AutoScrollState
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
            var value   = new AutoScrollState();

            value.Enable                                    = GetBool(new IntPtr(p + 0x010)); // 0270DBCA4BC8 0x10 Enable                      ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.Elastic                                   = GetBool(new IntPtr(p + 0x011)); // 0270DBCA4BE8 0x11 Elastic                     ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.Duration                                  = GetSingle(new IntPtr(p + 0x014)); // 0270DBCA4C08 0x14 Duration                    ( 000186666050 ModelPrimitiveType float float float Single )
            value.EasingFunction                            = GetObject<EasingFunction>(new IntPtr(p + 0x018), ReversePrism.DataModels.EasingFunction.FromPointer); // 0270DBCA4C28 0x18 EasingFunction              ( 00018671A030 ModelClassType EasingFunction EasingFunction EasingFunction Pointer )
            value.StartTime                                 = GetSingle(new IntPtr(p + 0x020)); // 0270DBCA4C48 0x20 StartTime                   ( 000186666050 ModelPrimitiveType float float float Single )
            value.EndPosition                               = GetSingle(new IntPtr(p + 0x024)); // 0270DBCA4C68 0x24 EndPosition                 ( 000186666050 ModelPrimitiveType float float float Single )
            value.OnComplete                                = GetObject<Action>(new IntPtr(p + 0x028), ReversePrism.DataModels.Action.FromPointer); // 0270DBCA4C88 0x28 OnComplete                  ( 000186679A00 ModelClassType Action Action Action Pointer )

            return value;
        }
    }
}
