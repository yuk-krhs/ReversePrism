using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UpdateIndex                              ModelPrimitiveType int int int Int32
    // 018 teamDataArray                            NativeArray`1<TeamData> IL2CPP_TYPE_GENERICINST
    // 028 jobColliderCounter                       NativeReference`1<int> IL2CPP_TYPE_GENERICINST
    // 038 jobColliderIndexList                     NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    public partial class CreateUpdatecolliderListJob : DataModel
    {
        public int                                      UpdateIndex                             { get; set; }

        public static CreateUpdatecolliderListJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CreateUpdatecolliderListJob() { Pointer= p0 };

            value.UpdateIndex                               = GetInt32(new IntPtr(p + 0x010)); // 0x10 UpdateIndex                 ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
