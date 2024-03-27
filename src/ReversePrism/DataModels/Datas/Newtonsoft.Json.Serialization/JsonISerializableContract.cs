using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 0C0 <ISerializableCreator>k__BackingField    ObjectConstructor`1<<object>> IL2CPP_TYPE_GENERICINST
    public partial class JsonISerializableContract
    {

        public static JsonISerializableContract? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JsonISerializableContract();


            return value;
        }
    }
}
