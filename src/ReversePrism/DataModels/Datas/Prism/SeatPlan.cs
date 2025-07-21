using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 seatPlans                                SeatPlan[] IL2CPP_TYPE_SZARRAY
    // 020 IsleXScale                               ModelPrimitiveType float float float Single
    // 024 IsleZScale                               ModelPrimitiveType float float float Single
    // 028 NYokos                                   ModelPrimitiveType string string string String
    // 030 NTates                                   ModelPrimitiveType string string string String
    // 038 N_yokoList                               ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer
    // 040 N_tateList                               ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer
    // 048 NQuad                                    ModelPrimitiveType int int int Int32
    // 04C ShowMarkers                              ModelPrimitiveType bool bool bool Bool
    // 050 LookAt                                   ModelClassType Transform Transform Transform Pointer
    // 058 Cyabases                                 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 060 Sqs                                      ModelClassListType SeatQuad[] SeatQuad[] List<SeatQuad> Pointer
    // 000 MAXMAN                                   int IL2CPP_TYPE_I4
    public partial class SeatPlan : DataModel
    {
        public float                                    IsleXScale                              { get; set; }
        public float                                    IsleZScale                              { get; set; }
        public string                                   NYokos                                  { get; set; }
        public string                                   NTates                                  { get; set; }
        public List<int>?                               N_yokoList                              { get; set; }
        public List<int>?                               N_tateList                              { get; set; }
        public int                                      NQuad                                   { get; set; }
        public bool                                     ShowMarkers                             { get; set; }
        public Transform?                               LookAt                                  { get; set; }
        public List<GameObject>?                        Cyabases                                { get; set; }
        public List<SeatQuad>?                          Sqs                                     { get; set; }

        public static SeatPlan? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SeatPlan() { Pointer= p0 };

            value.IsleXScale                                = GetSingle(new IntPtr(p + 0x020)); // 0x20 IsleXScale                  ( ModelPrimitiveType float float float Single )
            value.IsleZScale                                = GetSingle(new IntPtr(p + 0x024)); // 0x24 IsleZScale                  ( ModelPrimitiveType float float float Single )
            value.NYokos                                    = GetString(new IntPtr(p + 0x028)); // 0x28 NYokos                      ( ModelPrimitiveType string string string String )
            value.NTates                                    = GetString(new IntPtr(p + 0x030)); // 0x30 NTates                      ( ModelPrimitiveType string string string String )
            value.N_yokoList                                = GetInt32List(new IntPtr(p + 0x038)); // 0x38 N_yokoList                  ( ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer )
            value.N_tateList                                = GetInt32List(new IntPtr(p + 0x040)); // 0x40 N_tateList                  ( ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer )
            value.NQuad                                     = GetInt32(new IntPtr(p + 0x048)); // 0x48 NQuad                       ( ModelPrimitiveType int int int Int32 )
            value.ShowMarkers                               = GetBool(new IntPtr(p + 0x04C)); // 0x4C ShowMarkers                 ( ModelPrimitiveType bool bool bool Bool )
            value.LookAt                                    = GetObject<Transform>(new IntPtr(p + 0x050), ReversePrism.DataModels.Transform.FromPointer); // 0x50 LookAt                      ( ModelClassType Transform Transform Transform Pointer )
            value.Cyabases                                  = GetObjectList<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 0x58 Cyabases                    ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.Sqs                                       = GetObjectList<SeatQuad>(new IntPtr(p + 0x060), ReversePrism.DataModels.SeatQuad.FromPointer); // 0x60 Sqs                         ( ModelClassListType SeatQuad[] SeatQuad[] List<SeatQuad> Pointer )

            return value;
        }
    }
}
