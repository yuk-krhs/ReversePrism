using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 <Results>k__BackingField                 Dictionary`2<Type, CreateTableResult> IL2CPP_TYPE_GENERICINST
    public partial class CreateTablesResult
    {

        public static CreateTablesResult? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CreateTablesResult();


            return value;
        }
    }
}
