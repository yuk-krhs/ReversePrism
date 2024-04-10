using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 LipSyncTable                             000186534210 ModelClassType LipSyncTable LipSyncTable LipSyncTable Pointer
    // 028 Animator                                 0001866B8DE0 ModelClassType Animator Animator Animator Pointer
    // 030 CharaID                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 038 Lips                                     000185CF0268 ModelClassListType List`1<LipData> List`1<LipData> List<LipData> Pointer
    // 040 IsSerious                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 041 IsAlwaysSerious                          000186594D10 ModelPrimitiveType bool bool bool Bool
    // 042 IsSeriousCloseReverse                    000186594D10 ModelPrimitiveType bool bool bool Bool
    // 043 IsOverwrite                              000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class LipSyncController : DataModel
    {
        public LipSyncTable?                            LipSyncTable                            { get; set; }
        public Animator?                                Animator                                { get; set; }
        public int                                      CharaID                                 { get; set; }
        public List<LipData>?                           Lips                                    { get; set; }
        public bool                                     IsSerious                               { get; set; }
        public bool                                     IsAlwaysSerious                         { get; set; }
        public bool                                     IsSeriousCloseReverse                   { get; set; }
        public bool                                     IsOverwrite                             { get; set; }

        public static LipSyncController? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LipSyncController() { Pointer= p0 };

            value.LipSyncTable                              = GetObject<LipSyncTable>(new IntPtr(p + 0x020), ReversePrism.DataModels.LipSyncTable.FromPointer); // 0245A7089250 0x20 LipSyncTable                ( 000186534210 ModelClassType LipSyncTable LipSyncTable LipSyncTable Pointer )
            value.Animator                                  = GetObject<Animator>(new IntPtr(p + 0x028), ReversePrism.DataModels.Animator.FromPointer); // 0245A7089270 0x28 Animator                    ( 0001866B8DE0 ModelClassType Animator Animator Animator Pointer )
            value.CharaID                                   = GetInt32(new IntPtr(p + 0x030)); // 0245A7089290 0x30 CharaID                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Lips                                      = GetObjectList<LipData>(new IntPtr(p + 0x038), ReversePrism.DataModels.LipData.FromPointer); // 0245A70892B0 0x38 Lips                        ( 000185CF0268 ModelClassListType List`1<LipData> List`1<LipData> List<LipData> Pointer )
            value.IsSerious                                 = GetBool(new IntPtr(p + 0x040)); // 0245A70892D0 0x40 IsSerious                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsAlwaysSerious                           = GetBool(new IntPtr(p + 0x041)); // 0245A70892F0 0x41 IsAlwaysSerious             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsSeriousCloseReverse                     = GetBool(new IntPtr(p + 0x042)); // 0245A7089310 0x42 IsSeriousCloseReverse       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsOverwrite                               = GetBool(new IntPtr(p + 0x043)); // 0245A7089330 0x43 IsOverwrite                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
