using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TextColor                                0001865ABA40 ModelEnumType Color Color Color Int32
    // 020 Disposables                              0001865F38F0 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 028 colorFormatter                           Utf8PreparedFormat`2<string, string> IL2CPP_TYPE_GENERICINST
    // 030 TimeText                                 000186671910 ModelPrimitiveType string string string String
    public partial class TimeReader
    {
        public Color                                    TextColor                               { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }
        public string                                   TimeText                                { get; set; }

        public static TimeReader? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TimeReader();

            value.TextColor                                 = (Color)GetInt32(new IntPtr(p + 0x010)); // 027003CA5F98 0x10 TextColor                   ( 0001865ABA40 ModelEnumType Color Color Color Int32 )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x020), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 027003CA5FB8 0x20 Disposables                 ( 0001865F38F0 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.TimeText                                  = GetString(new IntPtr(p + 0x030)); // 027003CA5FF8 0x30 TimeText                    ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
