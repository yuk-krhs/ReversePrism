using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Move                                     ModelEnumType Vector2 Vector2 Vector2 Int32
    // 018 ConsecutiveMoveCount                     ModelPrimitiveType int int int Int32
    // 01C LastMoveDirection                        ModelEnumType MoveDirection MoveDirection MoveDirection Int32
    // 020 LastMoveTime                             ModelPrimitiveType float float float Single
    // 028 EventData                                ModelClassType AxisEventData AxisEventData AxisEventData Pointer
    public partial class NavigationModel : DataModel
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
            var value   = new NavigationModel() { Pointer= p0 };

            value.Move                                      = (Vector2)GetInt32(new IntPtr(p + 0x010)); // 0x10 Move                        ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.ConsecutiveMoveCount                      = GetInt32(new IntPtr(p + 0x018)); // 0x18 ConsecutiveMoveCount        ( ModelPrimitiveType int int int Int32 )
            value.LastMoveDirection                         = (MoveDirection)GetInt32(new IntPtr(p + 0x01C)); // 0x1C LastMoveDirection           ( ModelEnumType MoveDirection MoveDirection MoveDirection Int32 )
            value.LastMoveTime                              = GetSingle(new IntPtr(p + 0x020)); // 0x20 LastMoveTime                ( ModelPrimitiveType float float float Single )
            value.EventData                                 = GetObject<AxisEventData>(new IntPtr(p + 0x028), ReversePrism.DataModels.AxisEventData.FromPointer); // 0x28 EventData                   ( ModelClassType AxisEventData AxisEventData AxisEventData Pointer )

            return value;
        }
    }
}
