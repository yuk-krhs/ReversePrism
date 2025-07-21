using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Type                                     ModelClassType Type Type Type Pointer
    // 018 Flags                                    ModelEnumType TrackBindingFlags TrackBindingFlags TrackBindingFlags Int32
    public partial class TrackBindingTypeAttribute : DataModel
    {
        public Type?                                    Type                                    { get; set; }
        public TrackBindingFlags                        Flags                                   { get; set; }

        public static TrackBindingTypeAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TrackBindingTypeAttribute() { Pointer= p0 };

            value.Type                                      = GetObject<Type>(new IntPtr(p + 0x010), ReversePrism.DataModels.Type.FromPointer); // 0x10 Type                        ( ModelClassType Type Type Type Pointer )
            value.Flags                                     = (TrackBindingFlags)GetInt32(new IntPtr(p + 0x018)); // 0x18 Flags                       ( ModelEnumType TrackBindingFlags TrackBindingFlags TrackBindingFlags Int32 )

            return value;
        }
    }
}
