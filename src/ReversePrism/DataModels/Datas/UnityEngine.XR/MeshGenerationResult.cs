using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MeshId                                   ModelEnumType MeshId MeshId MeshId Int32
    // 020 Mesh                                     ModelClassType Mesh Mesh Mesh Pointer
    // 028 MeshCollider                             ModelClassType MeshCollider MeshCollider MeshCollider Pointer
    // 030 Status                                   ModelEnumType MeshGenerationStatus MeshGenerationStatus MeshGenerationStatus Int32
    // 034 Attributes                               ModelEnumType MeshVertexAttributes MeshVertexAttributes MeshVertexAttributes Int32
    // 038 Timestamp                                ModelPrimitiveType ulong ulong ulong UInt64
    // 040 Position                                 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 04C Rotation                                 ModelEnumType Quaternion Quaternion Quaternion Int32
    // 05C Scale                                    ModelEnumType Vector3 Vector3 Vector3 Int32
    public partial class MeshGenerationResult : DataModel
    {
        public MeshId                                   MeshId                                  { get; set; }
        public Mesh?                                    Mesh                                    { get; set; }
        public MeshCollider?                            MeshCollider                            { get; set; }
        public MeshGenerationStatus                     Status                                  { get; set; }
        public MeshVertexAttributes                     Attributes                              { get; set; }
        public ulong                                    Timestamp                               { get; set; }
        public Vector3                                  Position                                { get; set; }
        public Quaternion                               Rotation                                { get; set; }
        public Vector3                                  Scale                                   { get; set; }

        public static MeshGenerationResult? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MeshGenerationResult() { Pointer= p0 };

            value.MeshId                                    = (MeshId)GetInt32(new IntPtr(p + 0x010)); // 0x10 MeshId                      ( ModelEnumType MeshId MeshId MeshId Int32 )
            value.Mesh                                      = GetObject<Mesh>(new IntPtr(p + 0x020), ReversePrism.DataModels.Mesh.FromPointer); // 0x20 Mesh                        ( ModelClassType Mesh Mesh Mesh Pointer )
            value.MeshCollider                              = GetObject<MeshCollider>(new IntPtr(p + 0x028), ReversePrism.DataModels.MeshCollider.FromPointer); // 0x28 MeshCollider                ( ModelClassType MeshCollider MeshCollider MeshCollider Pointer )
            value.Status                                    = (MeshGenerationStatus)GetInt32(new IntPtr(p + 0x030)); // 0x30 Status                      ( ModelEnumType MeshGenerationStatus MeshGenerationStatus MeshGenerationStatus Int32 )
            value.Attributes                                = (MeshVertexAttributes)GetInt32(new IntPtr(p + 0x034)); // 0x34 Attributes                  ( ModelEnumType MeshVertexAttributes MeshVertexAttributes MeshVertexAttributes Int32 )
            value.Timestamp                                 = GetUInt64(new IntPtr(p + 0x038)); // 0x38 Timestamp                   ( ModelPrimitiveType ulong ulong ulong UInt64 )
            value.Position                                  = (Vector3)GetInt32(new IntPtr(p + 0x040)); // 0x40 Position                    ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.Rotation                                  = (Quaternion)GetInt32(new IntPtr(p + 0x04C)); // 0x4C Rotation                    ( ModelEnumType Quaternion Quaternion Quaternion Int32 )
            value.Scale                                     = (Vector3)GetInt32(new IntPtr(p + 0x05C)); // 0x5C Scale                       ( ModelEnumType Vector3 Vector3 Vector3 Int32 )

            return value;
        }
    }
}
