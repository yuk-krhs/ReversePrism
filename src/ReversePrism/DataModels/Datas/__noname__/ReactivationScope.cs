using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Stack                                    0001866CFFD0 ModelClassType SceneStack SceneStack SceneStack Pointer
    public partial class ReactivationScope
    {
        public SceneStack?                              Stack                                   { get; set; }

        public static ReactivationScope? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ReactivationScope();

            value.Stack                                     = GetObject<SceneStack>(new IntPtr(p + 0x010), ReversePrism.DataModels.SceneStack.FromPointer); // 0270DB6B1E48 0x10 Stack                       ( 0001866CFFD0 ModelClassType SceneStack SceneStack SceneStack Pointer )

            return value;
        }
    }
}
