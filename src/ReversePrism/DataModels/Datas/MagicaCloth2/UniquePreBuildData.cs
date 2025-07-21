using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Version                                  ModelPrimitiveType int int int Int32
    // 014 BuildResult                              ModelEnumType ResultCode ResultCode ResultCode Int32
    // 020 RenderSetupDataList                      ModelClassListType List`1<UniqueSerializationData> List`1<UniqueSerializationData> List<UniqueSerializationData> Pointer
    // 028 ProxyMesh                                ModelClassType UniqueSerializationData UniqueSerializationData UniqueSerializationData Pointer
    // 030 RenderMeshList                           ModelClassListType List`1<UniqueSerializationData> List`1<UniqueSerializationData> List<UniqueSerializationData> Pointer
    public partial class UniquePreBuildData : DataModel
    {
        public int                                      Version                                 { get; set; }
        public ResultCode                               BuildResult                             { get; set; }
        public List<UniqueSerializationData>?           RenderSetupDataList                     { get; set; }
        public UniqueSerializationData?                 ProxyMesh                               { get; set; }
        public List<UniqueSerializationData>?           RenderMeshList                          { get; set; }

        public static UniquePreBuildData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UniquePreBuildData() { Pointer= p0 };

            value.Version                                   = GetInt32(new IntPtr(p + 0x010)); // 0x10 Version                     ( ModelPrimitiveType int int int Int32 )
            value.BuildResult                               = (ResultCode)GetInt32(new IntPtr(p + 0x014)); // 0x14 BuildResult                 ( ModelEnumType ResultCode ResultCode ResultCode Int32 )
            value.RenderSetupDataList                       = GetObjectList<UniqueSerializationData>(new IntPtr(p + 0x020), ReversePrism.DataModels.UniqueSerializationData.FromPointer); // 0x20 RenderSetupDataList         ( ModelClassListType List`1<UniqueSerializationData> List`1<UniqueSerializationData> List<UniqueSerializationData> Pointer )
            value.ProxyMesh                                 = GetObject<UniqueSerializationData>(new IntPtr(p + 0x028), ReversePrism.DataModels.UniqueSerializationData.FromPointer); // 0x28 ProxyMesh                   ( ModelClassType UniqueSerializationData UniqueSerializationData UniqueSerializationData Pointer )
            value.RenderMeshList                            = GetObjectList<UniqueSerializationData>(new IntPtr(p + 0x030), ReversePrism.DataModels.UniqueSerializationData.FromPointer); // 0x30 RenderMeshList              ( ModelClassListType List`1<UniqueSerializationData> List`1<UniqueSerializationData> List<UniqueSerializationData> Pointer )

            return value;
        }
    }
}
