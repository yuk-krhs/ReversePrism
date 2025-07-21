using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TextColor                                ModelEnumType Color Color Color Int32
    // 020 Disposables                              ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 028 colorFormatter                           Utf8PreparedFormat`2<string, string> IL2CPP_TYPE_GENERICINST
    // 030 TimeText                                 ModelPrimitiveType string string string String
    public partial class TimeReader : DataModel
    {
        public Color                                    TextColor                               { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }
        public string                                   TimeText                                { get; set; }

        public static TimeReader? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TimeReader() { Pointer= p0 };

            value.TextColor                                 = (Color)GetInt32(new IntPtr(p + 0x010)); // 0x10 TextColor                   ( ModelEnumType Color Color Color Int32 )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x020), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x20 Disposables                 ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.TimeText                                  = GetString(new IntPtr(p + 0x030)); // 0x30 TimeText                    ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
