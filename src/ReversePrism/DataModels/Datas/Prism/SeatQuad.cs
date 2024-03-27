using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Sp                                       00018670F6F0 ModelClassType SeatPlan SeatPlan SeatPlan Pointer
    // 018 Name                                     0001866722E0 ModelPrimitiveType string string string String
    // 020 IQuad                                    0001865F36C0 ModelPrimitiveType int int int Int32
    // 028 Wcorner4                                 000185CB0ED8 ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer
    // 030 Rcorner4                                 000185CB0ED8 ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer
    // 038 Ccorner4                                 000185CB0ED8 ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer
    // 040 Ydeg                                     000186666050 ModelPrimitiveType float float float Single
    // 048 Xposis                                   000185B80920 ModelPrimitiveListType float[] float[] List<float> Pointer
    // 050 Yposis                                   000185B80920 ModelPrimitiveListType float[] float[] List<float> Pointer
    // 058 Zposis                                   000185B80920 ModelPrimitiveListType float[] float[] List<float> Pointer
    // 060 LimLs                                    000185B80920 ModelPrimitiveListType float[] float[] List<float> Pointer
    // 068 LimRs                                    000185B80920 ModelPrimitiveListType float[] float[] List<float> Pointer
    // 070 N_yokos                                  000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 078 N_tates                                  000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 080 NYokoTotal                               0001865F36C0 ModelPrimitiveType int int int Int32
    // 084 NTateTotal                               0001865F36C0 ModelPrimitiveType int int int Int32
    // 088 NTrim                                    0001865F36C0 ModelPrimitiveType int int int Int32
    // 090 NTrimSubs                                000185B7D5E0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 098 ITateNear                                0001865F36C0 ModelPrimitiveType int int int Int32
    // 09C ITateFar                                 0001865F36C0 ModelPrimitiveType int int int Int32
    // 0A0 U2l_yoko                                 000186666050 ModelPrimitiveType float float float Single
    // 0A4 U2l_tate                                 000186666050 ModelPrimitiveType float float float Single
    public partial class SeatQuad
    {
        public SeatPlan?                                Sp                                      { get; set; }
        public string                                   Name                                    { get; set; }
        public int                                      IQuad                                   { get; set; }
        public List<Vector3>?                           Wcorner4                                { get; set; }
        public List<Vector3>?                           Rcorner4                                { get; set; }
        public List<Vector3>?                           Ccorner4                                { get; set; }
        public float                                    Ydeg                                    { get; set; }
        public List<float>?                             Xposis                                  { get; set; }
        public List<float>?                             Yposis                                  { get; set; }
        public List<float>?                             Zposis                                  { get; set; }
        public List<float>?                             LimLs                                   { get; set; }
        public List<float>?                             LimRs                                   { get; set; }
        public List<int>?                               N_yokos                                 { get; set; }
        public List<int>?                               N_tates                                 { get; set; }
        public int                                      NYokoTotal                              { get; set; }
        public int                                      NTateTotal                              { get; set; }
        public int                                      NTrim                                   { get; set; }
        public List<int>?                               NTrimSubs                               { get; set; }
        public int                                      ITateNear                               { get; set; }
        public int                                      ITateFar                                { get; set; }
        public float                                    U2l_yoko                                { get; set; }
        public float                                    U2l_tate                                { get; set; }

        public static SeatQuad? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SeatQuad();

            value.Sp                                        = GetObject<SeatPlan>(new IntPtr(p + 0x010), ReversePrism.DataModels.SeatPlan.FromPointer); // 0270D4E46800 0x10 Sp                          ( 00018670F6F0 ModelClassType SeatPlan SeatPlan SeatPlan Pointer )
            value.Name                                      = GetString(new IntPtr(p + 0x018)); // 0270D4E46820 0x18 Name                        ( 0001866722E0 ModelPrimitiveType string string string String )
            value.IQuad                                     = GetInt32(new IntPtr(p + 0x020)); // 0270D4E46840 0x20 IQuad                       ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Wcorner4                                  = GetEnumList<Vector3>(new IntPtr(p + 0x028)); // 0270D4E46860 0x28 Wcorner4                    ( 000185CB0ED8 ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer )
            value.Rcorner4                                  = GetEnumList<Vector3>(new IntPtr(p + 0x030)); // 0270D4E46880 0x30 Rcorner4                    ( 000185CB0ED8 ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer )
            value.Ccorner4                                  = GetEnumList<Vector3>(new IntPtr(p + 0x038)); // 0270D4E468A0 0x38 Ccorner4                    ( 000185CB0ED8 ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer )
            value.Ydeg                                      = GetSingle(new IntPtr(p + 0x040)); // 0270D4E468C0 0x40 Ydeg                        ( 000186666050 ModelPrimitiveType float float float Single )
            value.Xposis                                    = GetSingleList(new IntPtr(p + 0x048)); // 0270D4E468E0 0x48 Xposis                      ( 000185B80920 ModelPrimitiveListType float[] float[] List<float> Pointer )
            value.Yposis                                    = GetSingleList(new IntPtr(p + 0x050)); // 0270D4E46900 0x50 Yposis                      ( 000185B80920 ModelPrimitiveListType float[] float[] List<float> Pointer )
            value.Zposis                                    = GetSingleList(new IntPtr(p + 0x058)); // 0270D4E46920 0x58 Zposis                      ( 000185B80920 ModelPrimitiveListType float[] float[] List<float> Pointer )
            value.LimLs                                     = GetSingleList(new IntPtr(p + 0x060)); // 0270D4E46940 0x60 LimLs                       ( 000185B80920 ModelPrimitiveListType float[] float[] List<float> Pointer )
            value.LimRs                                     = GetSingleList(new IntPtr(p + 0x068)); // 0270D4E46960 0x68 LimRs                       ( 000185B80920 ModelPrimitiveListType float[] float[] List<float> Pointer )
            value.N_yokos                                   = GetInt32List(new IntPtr(p + 0x070)); // 0270D4E46980 0x70 N_yokos                     ( 000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.N_tates                                   = GetInt32List(new IntPtr(p + 0x078)); // 0270D4E469A0 0x78 N_tates                     ( 000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.NYokoTotal                                = GetInt32(new IntPtr(p + 0x080)); // 0270D4E469C0 0x80 NYokoTotal                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.NTateTotal                                = GetInt32(new IntPtr(p + 0x084)); // 0270D4E469E0 0x84 NTateTotal                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.NTrim                                     = GetInt32(new IntPtr(p + 0x088)); // 0270D4E46A00 0x88 NTrim                       ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.NTrimSubs                                 = GetInt32List(new IntPtr(p + 0x090)); // 0270D4E46A20 0x90 NTrimSubs                   ( 000185B7D5E0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.ITateNear                                 = GetInt32(new IntPtr(p + 0x098)); // 0270D4E46A40 0x98 ITateNear                   ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.ITateFar                                  = GetInt32(new IntPtr(p + 0x09C)); // 0270D4E46A60 0x9C ITateFar                    ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.U2l_yoko                                  = GetSingle(new IntPtr(p + 0x0A0)); // 0270D4E46A80 0xA0 U2l_yoko                    ( 000186666050 ModelPrimitiveType float float float Single )
            value.U2l_tate                                  = GetSingle(new IntPtr(p + 0x0A4)); // 0270D4E46AA0 0xA4 U2l_tate                    ( 000186666050 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
