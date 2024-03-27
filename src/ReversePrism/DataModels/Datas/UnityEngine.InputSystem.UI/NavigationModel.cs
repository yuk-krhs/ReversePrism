using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Move                                     0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 018 ConsecutiveMoveCount                     0001865F36C0 ModelPrimitiveType int int int Int32
    // 01C LastMoveDirection                        000186654EB0 ModelEnumType MoveDirection MoveDirection MoveDirection Int32
    // 020 LastMoveTime                             000186666050 ModelPrimitiveType float float float Single
    // 028 EventData                                000186731B70 ModelClassType AxisEventData AxisEventData AxisEventData Pointer
    public partial class NavigationModel
    {
        public Vector2                                  Move                                    { get; set; }
        public int                                      ConsecutiveMoveCount                    { get; set; }
        public MoveDirection                            LastMoveDirection                       { get; set; }
        public float                                    LastMoveTime                            { get; set; }
        public AxisEventData?                           EventData                               { get; set; }

        public static NavigationModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NavigationModel();

            value.Move                                      = (Vector2)GetInt32(new IntPtr(p + 0x010)); // 0270D7726308 0x10 Move                        ( 0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.ConsecutiveMoveCount                      = GetInt32(new IntPtr(p + 0x018)); // 0270D7726328 0x18 ConsecutiveMoveCount        ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.LastMoveDirection                         = (MoveDirection)GetInt32(new IntPtr(p + 0x01C)); // 0270D7726348 0x1C LastMoveDirection           ( 000186654EB0 ModelEnumType MoveDirection MoveDirection MoveDirection Int32 )
            value.LastMoveTime                              = GetSingle(new IntPtr(p + 0x020)); // 0270D7726368 0x20 LastMoveTime                ( 000186666050 ModelPrimitiveType float float float Single )
            value.EventData                                 = GetObject<AxisEventData>(new IntPtr(p + 0x028), ReversePrism.DataModels.AxisEventData.FromPointer); // 0270D7726388 0x28 EventData                   ( 000186731B70 ModelClassType AxisEventData AxisEventData AxisEventData Pointer )

            return value;
        }
    }
}
