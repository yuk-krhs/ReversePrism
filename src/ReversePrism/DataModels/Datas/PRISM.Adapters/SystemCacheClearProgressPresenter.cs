using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     ModelClassType ISystemCacheClearProgressView ISystemCacheClearProgressView ISystemCacheClearProgressView Pointer
    public partial class SystemCacheClearProgressPresenter : DataModel
    {
        public ISystemCacheClearProgressView?           View                                    { get; set; }

        public static SystemCacheClearProgressPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SystemCacheClearProgressPresenter() { Pointer= p0 };

            value.View                                      = GetObject<ISystemCacheClearProgressView>(new IntPtr(p + 0x010), ReversePrism.DataModels.ISystemCacheClearProgressView.FromPointer); // 0x10 View                        ( ModelClassType ISystemCacheClearProgressView ISystemCacheClearProgressView ISystemCacheClearProgressView Pointer )

            return value;
        }
    }
}
