using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Attribute                                000186711810 ModelEnumType Attribute Attribute Attribute Int32
    // 028 StartIndex                               0001865F36C0 ModelPrimitiveType int int int Int32
    // 02C Length                                   0001865F36C0 ModelPrimitiveType int int int Int32
    // 030 onClick                                  Action`1<Attribute> IL2CPP_TYPE_GENERICINST
    // 038 Rects                                    000185D00628 ModelEnumListType List`1<Rect> List`1<Rect> List<Rect> Pointer
    public partial class ClickableEntry
    {
        public Attribute                                Attribute                               { get; set; }
        public int                                      StartIndex                              { get; set; }
        public int                                      Length                                  { get; set; }
        public List<Rect>?                              Rects                                   { get; set; }

        public static ClickableEntry? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ClickableEntry();

            value.Attribute                                 = (Attribute)GetInt32(new IntPtr(p + 0x010)); // 0270D4B1B5D8 0x10 Attribute                   ( 000186711810 ModelEnumType Attribute Attribute Attribute Int32 )
            value.StartIndex                                = GetInt32(new IntPtr(p + 0x028)); // 0270D4B1B5F8 0x28 StartIndex                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Length                                    = GetInt32(new IntPtr(p + 0x02C)); // 0270D4B1B618 0x2C Length                      ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Rects                                     = GetEnumList<Rect>(new IntPtr(p + 0x038)); // 0270D4B1B658 0x38 Rects                       ( 000185D00628 ModelEnumListType List`1<Rect> List`1<Rect> List<Rect> Pointer )

            return value;
        }
    }
}
