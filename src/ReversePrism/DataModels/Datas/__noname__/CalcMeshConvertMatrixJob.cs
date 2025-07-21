using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 mappingDataArray                         NativeArray`1<MappingData> IL2CPP_TYPE_GENERICINST
    // 020 teamDataArray                            NativeArray`1<TeamData> IL2CPP_TYPE_GENERICINST
    // 030 transformPositionArray                   NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 040 transformRotationArray                   NativeArray`1<quaternion> IL2CPP_TYPE_GENERICINST
    // 050 transformScaleArray                      NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 060 transformInverseRotationArray            NativeArray`1<quaternion> IL2CPP_TYPE_GENERICINST
    public partial class CalcMeshConvertMatrixJob : DataModel
    {

        public static CalcMeshConvertMatrixJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CalcMeshConvertMatrixJob() { Pointer= p0 };


            return value;
        }
    }
}
