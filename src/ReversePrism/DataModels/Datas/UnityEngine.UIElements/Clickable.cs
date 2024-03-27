using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 clickedWithEventInfo                     Action`1<EventBase> IL2CPP_TYPE_GENERICINST
    // 040 Clicked                                  0001866792B0 ModelClassType Action Action Action Pointer
    // 048 M_Delay                                  0001865F8300 ModelPrimitiveType long long long Int64
    // 050 M_Interval                               0001865F8300 ModelPrimitiveType long long long Int64
    // 058 Active                                   000186594D10 ModelPrimitiveType bool bool bool Bool
    // 05C LastMousePosition                        0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 064 M_ActivePointerId                        0001865F2AF0 ModelPrimitiveType int int int Int32
    // 068 M_AcceptClicksIfDisabled                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 070 M_Repeater                               000186697790 ModelClassType IVisualElementScheduledItem IVisualElementScheduledItem IVisualElementScheduledItem Pointer
    public partial class Clickable
    {
        public Action?                                  Clicked                                 { get; set; }
        public long                                     M_Delay                                 { get; set; }
        public long                                     M_Interval                              { get; set; }
        public bool                                     Active                                  { get; set; }
        public Vector2                                  LastMousePosition                       { get; set; }
        public int                                      M_ActivePointerId                       { get; set; }
        public bool                                     M_AcceptClicksIfDisabled                { get; set; }
        public IVisualElementScheduledItem?             M_Repeater                              { get; set; }

        public static Clickable? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Clickable();

            value.Clicked                                   = GetObject<Action>(new IntPtr(p + 0x040), ReversePrism.DataModels.Action.FromPointer); // 0270066E4510 0x40 Clicked                     ( 0001866792B0 ModelClassType Action Action Action Pointer )
            value.M_Delay                                   = GetInt64(new IntPtr(p + 0x048)); // 0270066E4530 0x48 M_Delay                     ( 0001865F8300 ModelPrimitiveType long long long Int64 )
            value.M_Interval                                = GetInt64(new IntPtr(p + 0x050)); // 0270066E4550 0x50 M_Interval                  ( 0001865F8300 ModelPrimitiveType long long long Int64 )
            value.Active                                    = GetBool(new IntPtr(p + 0x058)); // 0270066E4570 0x58 Active                      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.LastMousePosition                         = (Vector2)GetInt32(new IntPtr(p + 0x05C)); // 0270066E4590 0x5C LastMousePosition           ( 0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.M_ActivePointerId                         = GetInt32(new IntPtr(p + 0x064)); // 0270066E45B0 0x64 M_ActivePointerId           ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_AcceptClicksIfDisabled                  = GetBool(new IntPtr(p + 0x068)); // 0270066E45D0 0x68 M_AcceptClicksIfDisabled    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_Repeater                                = GetObject<IVisualElementScheduledItem>(new IntPtr(p + 0x070), ReversePrism.DataModels.IVisualElementScheduledItem.FromPointer); // 0270066E45F0 0x70 M_Repeater                  ( 000186697790 ModelClassType IVisualElementScheduledItem IVisualElementScheduledItem IVisualElementScheduledItem Pointer )

            return value;
        }
    }
}
