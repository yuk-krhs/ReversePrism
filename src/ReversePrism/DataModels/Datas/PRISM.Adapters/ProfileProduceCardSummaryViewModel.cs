using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Status                                   00018668EC70 ModelClassType IUserProfileProduceCardSummaryStatus IUserProfileProduceCardSummaryStatus IUserProfileProduceCardSummaryStatus Pointer
    // 018 Title                                    000186671910 ModelPrimitiveType string string string String
    public partial class ProfileProduceCardSummaryViewModel : DataModel
    {
        public IUserProfileProduceCardSummaryStatus?    Status                                  { get; set; }
        public string                                   Title                                   { get; set; }

        public static ProfileProduceCardSummaryViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfileProduceCardSummaryViewModel() { Pointer= p0 };

            value.Status                                    = GetObject<IUserProfileProduceCardSummaryStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IUserProfileProduceCardSummaryStatus.FromPointer); // 0246666DAF28 0x10 Status                      ( 00018668EC70 ModelClassType IUserProfileProduceCardSummaryStatus IUserProfileProduceCardSummaryStatus IUserProfileProduceCardSummaryStatus Pointer )
            value.Title                                     = GetString(new IntPtr(p + 0x018)); // 0246666DAF48 0x18 Title                       ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
