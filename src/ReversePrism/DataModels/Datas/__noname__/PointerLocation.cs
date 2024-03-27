using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Position                                 0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 018 Panel                                    0001865D1890 ModelClassType IPanel IPanel IPanel Pointer
    // 020 Flags                                    000186582860 ModelEnumType LocationFlag LocationFlag LocationFlag Int32
    public partial class PointerLocation
    {
        public Vector2                                  Position                                { get; set; }
        public IPanel?                                  Panel                                   { get; set; }
        public LocationFlag                             Flags                                   { get; set; }

        public static PointerLocation? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PointerLocation();

            value.Position                                  = (Vector2)GetInt32(new IntPtr(p + 0x010)); // 0270067AB128 0x10 Position                    ( 0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.Panel                                     = GetObject<IPanel>(new IntPtr(p + 0x018), ReversePrism.DataModels.IPanel.FromPointer); // 0270067AB148 0x18 Panel                       ( 0001865D1890 ModelClassType IPanel IPanel IPanel Pointer )
            value.Flags                                     = (LocationFlag)GetInt32(new IntPtr(p + 0x020)); // 0270067AB168 0x20 Flags                       ( 000186582860 ModelEnumType LocationFlag LocationFlag LocationFlag Int32 )

            return value;
        }
    }
}
