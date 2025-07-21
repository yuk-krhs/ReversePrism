using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Version                                  ModelPrimitiveType int int int Int32
    // 018 BuildId                                  ModelPrimitiveType string string string String
    // 020 BuildResult                              ModelEnumType ResultCode ResultCode ResultCode Int32
    // 028 BuildScale                               ModelEnumType Vector3 Vector3 Vector3 Int32
    // 038 RenderSetupDataList                      ModelClassListType List`1<ShareSerializationData> List`1<ShareSerializationData> List<ShareSerializationData> Pointer
    // 040 ProxyMesh                                ModelClassType ShareSerializationData ShareSerializationData ShareSerializationData Pointer
    // 048 RenderMeshList                           ModelClassListType List`1<ShareSerializationData> List`1<ShareSerializationData> List<ShareSerializationData> Pointer
    // 050 DistanceConstraintData                   ModelClassType ConstraintData ConstraintData ConstraintData Pointer
    // 058 BendingConstraintData                    ModelClassType ConstraintData ConstraintData ConstraintData Pointer
    // 060 InertiaConstraintData                    ModelClassType ConstraintData ConstraintData ConstraintData Pointer
    public partial class SharePreBuildData : DataModel
    {
        public int                                      Version                                 { get; set; }
        public string                                   BuildId                                 { get; set; }
        public ResultCode                               BuildResult                             { get; set; }
        public Vector3                                  BuildScale                              { get; set; }
        public List<ShareSerializationData>?            RenderSetupDataList                     { get; set; }
        public ShareSerializationData?                  ProxyMesh                               { get; set; }
        public List<ShareSerializationData>?            RenderMeshList                          { get; set; }
        public ConstraintData?                          DistanceConstraintData                  { get; set; }
        public ConstraintData?                          BendingConstraintData                   { get; set; }
        public ConstraintData?                          InertiaConstraintData                   { get; set; }

        public static SharePreBuildData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SharePreBuildData() { Pointer= p0 };

            value.Version                                   = GetInt32(new IntPtr(p + 0x010)); // 0x10 Version                     ( ModelPrimitiveType int int int Int32 )
            value.BuildId                                   = GetString(new IntPtr(p + 0x018)); // 0x18 BuildId                     ( ModelPrimitiveType string string string String )
            value.BuildResult                               = (ResultCode)GetInt32(new IntPtr(p + 0x020)); // 0x20 BuildResult                 ( ModelEnumType ResultCode ResultCode ResultCode Int32 )
            value.BuildScale                                = (Vector3)GetInt32(new IntPtr(p + 0x028)); // 0x28 BuildScale                  ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.RenderSetupDataList                       = GetObjectList<ShareSerializationData>(new IntPtr(p + 0x038), ReversePrism.DataModels.ShareSerializationData.FromPointer); // 0x38 RenderSetupDataList         ( ModelClassListType List`1<ShareSerializationData> List`1<ShareSerializationData> List<ShareSerializationData> Pointer )
            value.ProxyMesh                                 = GetObject<ShareSerializationData>(new IntPtr(p + 0x040), ReversePrism.DataModels.ShareSerializationData.FromPointer); // 0x40 ProxyMesh                   ( ModelClassType ShareSerializationData ShareSerializationData ShareSerializationData Pointer )
            value.RenderMeshList                            = GetObjectList<ShareSerializationData>(new IntPtr(p + 0x048), ReversePrism.DataModels.ShareSerializationData.FromPointer); // 0x48 RenderMeshList              ( ModelClassListType List`1<ShareSerializationData> List`1<ShareSerializationData> List<ShareSerializationData> Pointer )
            value.DistanceConstraintData                    = GetObject<ConstraintData>(new IntPtr(p + 0x050), ReversePrism.DataModels.ConstraintData.FromPointer); // 0x50 DistanceConstraintData      ( ModelClassType ConstraintData ConstraintData ConstraintData Pointer )
            value.BendingConstraintData                     = GetObject<ConstraintData>(new IntPtr(p + 0x058), ReversePrism.DataModels.ConstraintData.FromPointer); // 0x58 BendingConstraintData       ( ModelClassType ConstraintData ConstraintData ConstraintData Pointer )
            value.InertiaConstraintData                     = GetObject<ConstraintData>(new IntPtr(p + 0x060), ReversePrism.DataModels.ConstraintData.FromPointer); // 0x60 InertiaConstraintData       ( ModelClassType ConstraintData ConstraintData ConstraintData Pointer )

            return value;
        }
    }
}
