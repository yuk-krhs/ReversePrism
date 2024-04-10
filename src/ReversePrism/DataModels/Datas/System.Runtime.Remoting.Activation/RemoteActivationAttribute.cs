using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ContextProperties                        000186591B20 ModelClassType IList IList IList Pointer
    public partial class RemoteActivationAttribute : DataModel
    {
        public IList?                                   ContextProperties                       { get; set; }

        public static RemoteActivationAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RemoteActivationAttribute() { Pointer= p0 };

            value.ContextProperties                         = GetObject<IList>(new IntPtr(p + 0x010), ReversePrism.DataModels.IList.FromPointer); // 024666C5EB30 0x10 ContextProperties           ( 000186591B20 ModelClassType IList IList IList Pointer )

            return value;
        }
    }
}
