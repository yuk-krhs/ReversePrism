using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MeshId                                   000186603550 ModelEnumType MeshId MeshId MeshId Int32
    // 020 Mesh                                     000186610E60 ModelClassType Mesh Mesh Mesh Pointer
    // 028 MeshCollider                             000186600D90 ModelClassType MeshCollider MeshCollider MeshCollider Pointer
    // 030 Status                                   000186602460 ModelEnumType MeshGenerationStatus MeshGenerationStatus MeshGenerationStatus Int32
    // 034 Attributes                               000186605740 ModelEnumType MeshVertexAttributes MeshVertexAttributes MeshVertexAttributes Int32
    // 038 Timestamp                                00018669C270 ModelPrimitiveType ulong ulong ulong UInt64
    // 040 Position                                 0001866AC430 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 04C Rotation                                 00018664A570 ModelEnumType Quaternion Quaternion Quaternion Int32
    // 05C Scale                                    0001866AC430 ModelEnumType Vector3 Vector3 Vector3 Int32
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

            value.MeshId                                    = (MeshId)GetInt32(new IntPtr(p + 0x010)); // 0245A2104330 0x10 MeshId                      ( 000186603550 ModelEnumType MeshId MeshId MeshId Int32 )
            value.Mesh                                      = GetObject<Mesh>(new IntPtr(p + 0x020), ReversePrism.DataModels.Mesh.FromPointer); // 0245A2104350 0x20 Mesh                        ( 000186610E60 ModelClassType Mesh Mesh Mesh Pointer )
            value.MeshCollider                              = GetObject<MeshCollider>(new IntPtr(p + 0x028), ReversePrism.DataModels.MeshCollider.FromPointer); // 0245A2104370 0x28 MeshCollider                ( 000186600D90 ModelClassType MeshCollider MeshCollider MeshCollider Pointer )
            value.Status                                    = (MeshGenerationStatus)GetInt32(new IntPtr(p + 0x030)); // 0245A2104390 0x30 Status                      ( 000186602460 ModelEnumType MeshGenerationStatus MeshGenerationStatus MeshGenerationStatus Int32 )
            value.Attributes                                = (MeshVertexAttributes)GetInt32(new IntPtr(p + 0x034)); // 0245A21043B0 0x34 Attributes                  ( 000186605740 ModelEnumType MeshVertexAttributes MeshVertexAttributes MeshVertexAttributes Int32 )
            value.Timestamp                                 = GetUInt64(new IntPtr(p + 0x038)); // 0245A21043D0 0x38 Timestamp                   ( 00018669C270 ModelPrimitiveType ulong ulong ulong UInt64 )
            value.Position                                  = (Vector3)GetInt32(new IntPtr(p + 0x040)); // 0245A21043F0 0x40 Position                    ( 0001866AC430 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.Rotation                                  = (Quaternion)GetInt32(new IntPtr(p + 0x04C)); // 0245A2104410 0x4C Rotation                    ( 00018664A570 ModelEnumType Quaternion Quaternion Quaternion Int32 )
            value.Scale                                     = (Vector3)GetInt32(new IntPtr(p + 0x05C)); // 0245A2104430 0x5C Scale                       ( 0001866AC430 ModelEnumType Vector3 Vector3 Vector3 Int32 )

            return value;
        }
    }
}
