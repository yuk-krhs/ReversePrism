using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_Factories                              Dictionary`2<string, List`1<IUxmlFactory>> IL2CPP_TYPE_GENERICINST
    // 008 s_MovedTypesFactories                    Dictionary`2<string, List`1<IUxmlFactory>> IL2CPP_TYPE_GENERICINST
    public partial class VisualElementFactoryRegistry
    {

        public static VisualElementFactoryRegistry? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VisualElementFactoryRegistry();


            return value;
        }
    }
}
