using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Disposables                              0001865F38F0 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 018 TimeReader                               000186668660 ModelClassType TimeReader TimeReader TimeReader Pointer
    // 020 Mapping                                  00018671AEE0 ModelClassType ICategoryMapping ICategoryMapping ICategoryMapping Pointer
    // 028 messsageFormatter                        Utf8PreparedFormat`3<string, string, string> IL2CPP_TYPE_GENERICINST
    public partial class MessageFormatter
    {
        public CompositeDisposable?                     Disposables                             { get; set; }
        public TimeReader?                              TimeReader                              { get; set; }
        public ICategoryMapping?                        Mapping                                 { get; set; }

        public static MessageFormatter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MessageFormatter();

            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x010), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 027003C9D930 0x10 Disposables                 ( 0001865F38F0 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.TimeReader                                = GetObject<TimeReader>(new IntPtr(p + 0x018), ReversePrism.DataModels.TimeReader.FromPointer); // 027003C9D950 0x18 TimeReader                  ( 000186668660 ModelClassType TimeReader TimeReader TimeReader Pointer )
            value.Mapping                                   = GetObject<ICategoryMapping>(new IntPtr(p + 0x020), ReversePrism.DataModels.ICategoryMapping.FromPointer); // 027003C9D970 0x20 Mapping                     ( 00018671AEE0 ModelClassType ICategoryMapping ICategoryMapping ICategoryMapping Pointer )

            return value;
        }
    }
}
