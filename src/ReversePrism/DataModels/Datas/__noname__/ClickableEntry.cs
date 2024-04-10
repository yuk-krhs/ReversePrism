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
    public partial class ClickableEntry : DataModel
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
            var value   = new ClickableEntry() { Pointer= p0 };

            value.Attribute                                 = (Attribute)GetInt32(new IntPtr(p + 0x010)); // 024664B85B70 0x10 Attribute                   ( 000186711810 ModelEnumType Attribute Attribute Attribute Int32 )
            value.StartIndex                                = GetInt32(new IntPtr(p + 0x028)); // 024664B85B90 0x28 StartIndex                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Length                                    = GetInt32(new IntPtr(p + 0x02C)); // 024664B85BB0 0x2C Length                      ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Rects                                     = GetEnumList<Rect>(new IntPtr(p + 0x038)); // 024664B85BF0 0x38 Rects                       ( 000185D00628 ModelEnumListType List`1<Rect> List`1<Rect> List<Rect> Pointer )

            return value;
        }
    }
}
