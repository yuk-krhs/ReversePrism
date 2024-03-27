using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CurrentOffset                            00018660D8C0 ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    // 050 MousePosition                            0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 058 CurrentWorldClip                         00018664F620 ModelEnumType Rect Rect Rect Int32
    // 068 RepaintEvent                             00018674CC10 ModelClassType Event Event Event Pointer
    public partial class RepaintData
    {
        public Matrix4x4                                CurrentOffset                           { get; set; }
        public Vector2                                  MousePosition                           { get; set; }
        public Rect                                     CurrentWorldClip                        { get; set; }
        public Event?                                   RepaintEvent                            { get; set; }

        public static RepaintData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RepaintData();

            value.CurrentOffset                             = (Matrix4x4)GetInt32(new IntPtr(p + 0x010)); // 0270067DFB48 0x10 CurrentOffset               ( 00018660D8C0 ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )
            value.MousePosition                             = (Vector2)GetInt32(new IntPtr(p + 0x050)); // 0270067DFB68 0x50 MousePosition               ( 0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.CurrentWorldClip                          = (Rect)GetInt32(new IntPtr(p + 0x058)); // 0270067DFB88 0x58 CurrentWorldClip            ( 00018664F620 ModelEnumType Rect Rect Rect Int32 )
            value.RepaintEvent                              = GetObject<Event>(new IntPtr(p + 0x068), ReversePrism.DataModels.Event.FromPointer); // 0270067DFBA8 0x68 RepaintEvent                ( 00018674CC10 ModelClassType Event Event Event Pointer )

            return value;
        }
    }
}
