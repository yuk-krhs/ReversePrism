using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 FloatCharacters                          char[] IL2CPP_TYPE_SZARRAY
    // 010 Expression                               000186672F10 ModelPrimitiveType string string string String
    // 018 Filters                                  000185CF8528 ModelClassListType List`1<PathFilter> List`1<PathFilter> List<PathFilter> Pointer
    // 020 CurrentIndex                             0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class JPath : DataModel
    {
        public string                                   Expression                              { get; set; }
        public List<PathFilter>?                        Filters                                 { get; set; }
        public int                                      CurrentIndex                            { get; set; }

        public static JPath? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JPath() { Pointer= p0 };

            value.Expression                                = GetString(new IntPtr(p + 0x010)); // 0246688839D0 0x10 Expression                  ( 000186672F10 ModelPrimitiveType string string string String )
            value.Filters                                   = GetObjectList<PathFilter>(new IntPtr(p + 0x018), ReversePrism.DataModels.PathFilter.FromPointer); // 0246688839F0 0x18 Filters                     ( 000185CF8528 ModelClassListType List`1<PathFilter> List`1<PathFilter> List<PathFilter> Pointer )
            value.CurrentIndex                              = GetInt32(new IntPtr(p + 0x020)); // 024668883A10 0x20 CurrentIndex                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
