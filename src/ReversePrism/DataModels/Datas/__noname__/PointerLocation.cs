using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Position                                 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 018 Panel                                    ModelClassType IPanel IPanel IPanel Pointer
    // 020 Flags                                    ModelEnumType LocationFlag LocationFlag LocationFlag Int32
    public partial class PointerLocation : DataModel
    {
        public Vector2                                  Position                                { get; set; }
        public IPanel?                                  Panel                                   { get; set; }
        public LocationFlag                             Flags                                   { get; set; }

        public static PointerLocation? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PointerLocation() { Pointer= p0 };

            value.Position                                  = (Vector2)GetInt32(new IntPtr(p + 0x010)); // 0x10 Position                    ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.Panel                                     = GetObject<IPanel>(new IntPtr(p + 0x018), ReversePrism.DataModels.IPanel.FromPointer); // 0x18 Panel                       ( ModelClassType IPanel IPanel IPanel Pointer )
            value.Flags                                     = (LocationFlag)GetInt32(new IntPtr(p + 0x020)); // 0x20 Flags                       ( ModelEnumType LocationFlag LocationFlag LocationFlag Int32 )

            return value;
        }
    }
}
