using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 seatPlans                                SeatPlan[] IL2CPP_TYPE_SZARRAY
    // 020 IsleXScale                               000186666050 ModelPrimitiveType float float float Single
    // 024 IsleZScale                               000186666050 ModelPrimitiveType float float float Single
    // 028 NYokos                                   0001866722E0 ModelPrimitiveType string string string String
    // 030 NTates                                   0001866722E0 ModelPrimitiveType string string string String
    // 038 N_yokoList                               000185CECF28 ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer
    // 040 N_tateList                               000185CECF28 ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer
    // 048 NQuad                                    0001865F59B0 ModelPrimitiveType int int int Int32
    // 04C ShowMarkers                              000186595960 ModelPrimitiveType bool bool bool Bool
    // 050 LookAt                                   0001866AA650 ModelClassType Transform Transform Transform Pointer
    // 058 Cyabases                                 000185B81700 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 060 Sqs                                      000185CA3108 ModelClassListType SeatQuad[] SeatQuad[] List<SeatQuad> Pointer
    // 000 MAXMAN                                   int IL2CPP_TYPE_I4
    public partial class SeatPlan
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
            var value   = new SeatPlan();

            value.IsleXScale                                = GetSingle(new IntPtr(p + 0x020)); // 0270D4E8BDC0 0x20 IsleXScale                  ( 000186666050 ModelPrimitiveType float float float Single )
            value.IsleZScale                                = GetSingle(new IntPtr(p + 0x024)); // 0270D4E8BDE0 0x24 IsleZScale                  ( 000186666050 ModelPrimitiveType float float float Single )
            value.NYokos                                    = GetString(new IntPtr(p + 0x028)); // 0270D4E8BE00 0x28 NYokos                      ( 0001866722E0 ModelPrimitiveType string string string String )
            value.NTates                                    = GetString(new IntPtr(p + 0x030)); // 0270D4E8BE20 0x30 NTates                      ( 0001866722E0 ModelPrimitiveType string string string String )
            value.N_yokoList                                = GetInt32List(new IntPtr(p + 0x038)); // 0270D4E8BE40 0x38 N_yokoList                  ( 000185CECF28 ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer )
            value.N_tateList                                = GetInt32List(new IntPtr(p + 0x040)); // 0270D4E8BE60 0x40 N_tateList                  ( 000185CECF28 ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer )
            value.NQuad                                     = GetInt32(new IntPtr(p + 0x048)); // 0270D4E8BE80 0x48 NQuad                       ( 0001865F59B0 ModelPrimitiveType int int int Int32 )
            value.ShowMarkers                               = GetBool(new IntPtr(p + 0x04C)); // 0270D4E8BEA0 0x4C ShowMarkers                 ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.LookAt                                    = GetObject<Transform>(new IntPtr(p + 0x050), ReversePrism.DataModels.Transform.FromPointer); // 0270D4E8BEC0 0x50 LookAt                      ( 0001866AA650 ModelClassType Transform Transform Transform Pointer )
            value.Cyabases                                  = GetObjectList<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 0270D4E8BEE0 0x58 Cyabases                    ( 000185B81700 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.Sqs                                       = GetObjectList<SeatQuad>(new IntPtr(p + 0x060), ReversePrism.DataModels.SeatQuad.FromPointer); // 0270D4E8BF00 0x60 Sqs                         ( 000185CA3108 ModelClassListType SeatQuad[] SeatQuad[] List<SeatQuad> Pointer )

            return value;
        }
    }
}
