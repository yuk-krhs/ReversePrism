using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ResumeView                               ModelClassType IResumeLiveView IResumeLiveView IResumeLiveView Pointer
    // 018 DisposeView                              ModelClassType IDisposeLiveView IDisposeLiveView IDisposeLiveView Pointer
    public partial class ResumeLivePresenter : DataModel
    {
        public IResumeLiveView?                         ResumeView                              { get; set; }
        public IDisposeLiveView?                        DisposeView                             { get; set; }

        public static ResumeLivePresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ResumeLivePresenter() { Pointer= p0 };

            value.ResumeView                                = GetObject<IResumeLiveView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IResumeLiveView.FromPointer); // 0x10 ResumeView                  ( ModelClassType IResumeLiveView IResumeLiveView IResumeLiveView Pointer )
            value.DisposeView                               = GetObject<IDisposeLiveView>(new IntPtr(p + 0x018), ReversePrism.DataModels.IDisposeLiveView.FromPointer); // 0x18 DisposeView                 ( ModelClassType IDisposeLiveView IDisposeLiveView IDisposeLiveView Pointer )

            return value;
        }
    }
}
