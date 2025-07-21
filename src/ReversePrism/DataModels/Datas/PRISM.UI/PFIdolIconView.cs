using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 1A8 Disposables                              ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 1B0 Index                                    ModelPrimitiveType int int int Int32
    public partial class PFIdolIconView : DataModel
    {
        public CompositeDisposable?                     Disposables                             { get; set; }
        public int                                      Index                                   { get; set; }

        public static PFIdolIconView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PFIdolIconView() { Pointer= p0 };

            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x1A8), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x1A8 Disposables                 ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.Index                                     = GetInt32(new IntPtr(p + 0x1B0)); // 0x1B0 Index                       ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
