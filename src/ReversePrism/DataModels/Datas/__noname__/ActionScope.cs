using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Stack                                    ModelClassType SceneStack SceneStack SceneStack Pointer
    public partial class ActionScope : DataModel
    {
        public SceneStack?                              Stack                                   { get; set; }

        public static ActionScope? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ActionScope() { Pointer= p0 };

            value.Stack                                     = GetObject<SceneStack>(new IntPtr(p + 0x010), ReversePrism.DataModels.SceneStack.FromPointer); // 0x10 Stack                       ( ModelClassType SceneStack SceneStack SceneStack Pointer )

            return value;
        }
    }
}
