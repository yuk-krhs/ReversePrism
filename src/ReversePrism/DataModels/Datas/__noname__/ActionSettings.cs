using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Action                                 ModelEnumType Mode Mode Mode Int32
    // 018 M_Target                                 ModelClassType Object Object Object Pointer
    // 020 M_BoostAmount                            ModelPrimitiveType int int int Int32
    // 024 M_StartTime                              ModelPrimitiveType float float float Single
    // 028 M_Mode                                   ModelEnumType TimeMode TimeMode TimeMode Int32
    // 030 M_Event                                  ModelClassType TriggerEvent TriggerEvent TriggerEvent Pointer
    public partial class ActionSettings : DataModel
    {
        public Mode                                     M_Action                                { get; set; }
        public Object?                                  M_Target                                { get; set; }
        public int                                      M_BoostAmount                           { get; set; }
        public float                                    M_StartTime                             { get; set; }
        public TimeMode                                 M_Mode                                  { get; set; }
        public TriggerEvent?                            M_Event                                 { get; set; }

        public static ActionSettings? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ActionSettings() { Pointer= p0 };

            value.M_Action                                  = (Mode)GetInt32(new IntPtr(p + 0x010)); // 0x10 M_Action                    ( ModelEnumType Mode Mode Mode Int32 )
            value.M_Target                                  = GetObject<Object>(new IntPtr(p + 0x018), ReversePrism.DataModels.Object.FromPointer); // 0x18 M_Target                    ( ModelClassType Object Object Object Pointer )
            value.M_BoostAmount                             = GetInt32(new IntPtr(p + 0x020)); // 0x20 M_BoostAmount               ( ModelPrimitiveType int int int Int32 )
            value.M_StartTime                               = GetSingle(new IntPtr(p + 0x024)); // 0x24 M_StartTime                 ( ModelPrimitiveType float float float Single )
            value.M_Mode                                    = (TimeMode)GetInt32(new IntPtr(p + 0x028)); // 0x28 M_Mode                      ( ModelEnumType TimeMode TimeMode TimeMode Int32 )
            value.M_Event                                   = GetObject<TriggerEvent>(new IntPtr(p + 0x030), ReversePrism.DataModels.TriggerEvent.FromPointer); // 0x30 M_Event                     ( ModelClassType TriggerEvent TriggerEvent TriggerEvent Pointer )

            return value;
        }
    }
}
