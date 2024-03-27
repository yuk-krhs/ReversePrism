using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 InspectedType                            000186693B90 ModelClassType Type Type Type Pointer
    // 018 AllowAutoCreate                          000186596AF0 ModelPrimitiveType bool bool bool Bool
    public partial class TrackClipTypeAttribute
    {
        public Type?                                    InspectedType                           { get; set; }
        public bool                                     AllowAutoCreate                         { get; set; }

        public static TrackClipTypeAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TrackClipTypeAttribute();

            value.InspectedType                             = GetObject<Type>(new IntPtr(p + 0x010), ReversePrism.DataModels.Type.FromPointer); // 0270DB2A46A0 0x10 InspectedType               ( 000186693B90 ModelClassType Type Type Type Pointer )
            value.AllowAutoCreate                           = GetBool(new IntPtr(p + 0x018)); // 0270DB2A46C0 0x18 AllowAutoCreate             ( 000186596AF0 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
