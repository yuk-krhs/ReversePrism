using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TwestaArticleStatus                      000186684330 ModelClassType ITwestaArticleStatus ITwestaArticleStatus ITwestaArticleStatus Pointer
    public partial class TwestaDetailParameter : DataModel
    {
        public ITwestaArticleStatus?                    TwestaArticleStatus                     { get; set; }

        public static TwestaDetailParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TwestaDetailParameter() { Pointer= p0 };

            value.TwestaArticleStatus                       = GetObject<ITwestaArticleStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.ITwestaArticleStatus.FromPointer); // 024666948318 0x10 TwestaArticleStatus         ( 000186684330 ModelClassType ITwestaArticleStatus ITwestaArticleStatus ITwestaArticleStatus Pointer )

            return value;
        }
    }
}
