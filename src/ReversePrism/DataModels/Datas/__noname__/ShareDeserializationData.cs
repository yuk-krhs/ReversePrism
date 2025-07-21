using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BuildId                                  ModelPrimitiveType string string string String
    // 018 Result                                   ModelEnumType ResultCode ResultCode ResultCode Int32
    // 020 ReferenceCount                           ModelPrimitiveType int int int Int32
    // 028 RenderSetupDataList                      ModelClassListType List`1<RenderSetupData> List`1<RenderSetupData> List<RenderSetupData> Pointer
    // 030 ProxyMesh                                ModelClassType VirtualMesh VirtualMesh VirtualMesh Pointer
    // 038 RenderMeshList                           ModelClassListType List`1<VirtualMesh> List`1<VirtualMesh> List<VirtualMesh> Pointer
    // 040 DistanceConstraintData                   ModelClassType ConstraintData ConstraintData ConstraintData Pointer
    // 048 BendingConstraintData                    ModelClassType ConstraintData ConstraintData ConstraintData Pointer
    // 050 InertiaConstraintData                    ModelClassType ConstraintData ConstraintData ConstraintData Pointer
    public partial class ShareDeserializationData : DataModel
    {
        public string                                   BuildId                                 { get; set; }
        public ResultCode                               Result                                  { get; set; }
        public int                                      ReferenceCount                          { get; set; }
        public List<RenderSetupData>?                   RenderSetupDataList                     { get; set; }
        public VirtualMesh?                             ProxyMesh                               { get; set; }
        public List<VirtualMesh>?                       RenderMeshList                          { get; set; }
        public ConstraintData?                          DistanceConstraintData                  { get; set; }
        public ConstraintData?                          BendingConstraintData                   { get; set; }
        public ConstraintData?                          InertiaConstraintData                   { get; set; }

        public static ShareDeserializationData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShareDeserializationData() { Pointer= p0 };

            value.BuildId                                   = GetString(new IntPtr(p + 0x010)); // 0x10 BuildId                     ( ModelPrimitiveType string string string String )
            value.Result                                    = (ResultCode)GetInt32(new IntPtr(p + 0x018)); // 0x18 Result                      ( ModelEnumType ResultCode ResultCode ResultCode Int32 )
            value.ReferenceCount                            = GetInt32(new IntPtr(p + 0x020)); // 0x20 ReferenceCount              ( ModelPrimitiveType int int int Int32 )
            value.RenderSetupDataList                       = GetObjectList<RenderSetupData>(new IntPtr(p + 0x028), ReversePrism.DataModels.RenderSetupData.FromPointer); // 0x28 RenderSetupDataList         ( ModelClassListType List`1<RenderSetupData> List`1<RenderSetupData> List<RenderSetupData> Pointer )
            value.ProxyMesh                                 = GetObject<VirtualMesh>(new IntPtr(p + 0x030), ReversePrism.DataModels.VirtualMesh.FromPointer); // 0x30 ProxyMesh                   ( ModelClassType VirtualMesh VirtualMesh VirtualMesh Pointer )
            value.RenderMeshList                            = GetObjectList<VirtualMesh>(new IntPtr(p + 0x038), ReversePrism.DataModels.VirtualMesh.FromPointer); // 0x38 RenderMeshList              ( ModelClassListType List`1<VirtualMesh> List`1<VirtualMesh> List<VirtualMesh> Pointer )
            value.DistanceConstraintData                    = GetObject<ConstraintData>(new IntPtr(p + 0x040), ReversePrism.DataModels.ConstraintData.FromPointer); // 0x40 DistanceConstraintData      ( ModelClassType ConstraintData ConstraintData ConstraintData Pointer )
            value.BendingConstraintData                     = GetObject<ConstraintData>(new IntPtr(p + 0x048), ReversePrism.DataModels.ConstraintData.FromPointer); // 0x48 BendingConstraintData       ( ModelClassType ConstraintData ConstraintData ConstraintData Pointer )
            value.InertiaConstraintData                     = GetObject<ConstraintData>(new IntPtr(p + 0x050), ReversePrism.DataModels.ConstraintData.FromPointer); // 0x50 InertiaConstraintData       ( ModelClassType ConstraintData ConstraintData ConstraintData Pointer )

            return value;
        }
    }
}
