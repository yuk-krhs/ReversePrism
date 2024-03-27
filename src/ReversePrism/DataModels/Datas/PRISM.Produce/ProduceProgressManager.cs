using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 ScenarioKey                              string IL2CPP_TYPE_STRING
    // 000 RemainingTurnKey                         string IL2CPP_TYPE_STRING
    // 000 ClearedScenarioKey                       string IL2CPP_TYPE_STRING
    public partial class ProduceProgressManager
    {

        public static ProduceProgressManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceProgressManager();


            return value;
        }
    }
}
