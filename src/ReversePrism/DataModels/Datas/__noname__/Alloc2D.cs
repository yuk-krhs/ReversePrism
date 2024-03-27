using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Rect                                     000186651230 ModelEnumType RectInt RectInt RectInt Int32
    // 020 Row                                      000186698AB0 ModelClassType Row Row Row Pointer
    // 028 Alloc                                    0001865866A0 ModelEnumType Alloc Alloc Alloc Int32
    public partial class Alloc2D
    {
        public RectInt                                  Rect                                    { get; set; }
        public Row?                                     Row                                     { get; set; }
        public Alloc                                    Alloc                                   { get; set; }

        public static Alloc2D? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Alloc2D();

            value.Rect                                      = (RectInt)GetInt32(new IntPtr(p + 0x010)); // 0270066DFE98 0x10 Rect                        ( 000186651230 ModelEnumType RectInt RectInt RectInt Int32 )
            value.Row                                       = GetObject<Row>(new IntPtr(p + 0x020), ReversePrism.DataModels.Row.FromPointer); // 0270066DFEB8 0x20 Row                         ( 000186698AB0 ModelClassType Row Row Row Pointer )
            value.Alloc                                     = (Alloc)GetInt32(new IntPtr(p + 0x028)); // 0270066DFED8 0x28 Alloc                       ( 0001865866A0 ModelEnumType Alloc Alloc Alloc Int32 )

            return value;
        }
    }
}
