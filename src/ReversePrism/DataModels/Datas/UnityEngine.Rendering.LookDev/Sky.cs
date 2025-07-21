using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Cubemap                                  ModelClassType Cubemap Cubemap Cubemap Pointer
    // 018 LongitudeOffset                          ModelPrimitiveType float float float Single
    // 01C Exposure                                 ModelPrimitiveType float float float Single
    public partial class Sky : DataModel
    {
        public Cubemap?                                 Cubemap                                 { get; set; }
        public float                                    LongitudeOffset                         { get; set; }
        public float                                    Exposure                                { get; set; }

        public static Sky? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Sky() { Pointer= p0 };

            value.Cubemap                                   = GetObject<Cubemap>(new IntPtr(p + 0x010), ReversePrism.DataModels.Cubemap.FromPointer); // 0x10 Cubemap                     ( ModelClassType Cubemap Cubemap Cubemap Pointer )
            value.LongitudeOffset                           = GetSingle(new IntPtr(p + 0x018)); // 0x18 LongitudeOffset             ( ModelPrimitiveType float float float Single )
            value.Exposure                                  = GetSingle(new IntPtr(p + 0x01C)); // 0x1C Exposure                    ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
