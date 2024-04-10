using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TargetPlatform                           000186672F10 ModelPrimitiveType string string string String
    // 018 TitleService                             000186676DA0 ModelClassType TitleAnnounceService TitleAnnounceService TitleAnnounceService Pointer
    public partial class AnnounceServiceForTitle : DataModel
    {
        public string                                   TargetPlatform                          { get; set; }
        public TitleAnnounceService?                    TitleService                            { get; set; }

        public static AnnounceServiceForTitle? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AnnounceServiceForTitle() { Pointer= p0 };

            value.TargetPlatform                            = GetString(new IntPtr(p + 0x010)); // 0245A71C0148 0x10 TargetPlatform              ( 000186672F10 ModelPrimitiveType string string string String )
            value.TitleService                              = GetObject<TitleAnnounceService>(new IntPtr(p + 0x018), ReversePrism.DataModels.TitleAnnounceService.FromPointer); // 0245A71C0168 0x18 TitleService                ( 000186676DA0 ModelClassType TitleAnnounceService TitleAnnounceService TitleAnnounceService Pointer )

            return value;
        }
    }
}
