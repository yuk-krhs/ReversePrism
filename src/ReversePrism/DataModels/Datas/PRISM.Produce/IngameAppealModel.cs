using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AppealPoint                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 014 MaxAppealPoint                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 IsNotMaxAppeal                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 01C TotalGetAppealPointCount                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 onUpdateAppealPointSubject               Subject`1<ValueTuple`2<int, int>> IL2CPP_TYPE_GENERICINST
    // 028 onAddAppealPointSubject                  Subject`1<ValueTuple`5<int, int, int, int, ProduceParameterType>> IL2CPP_TYPE_GENERICINST
    // 030 InitialMaxAppealPoint                    0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class IngameAppealModel
    {
        public int                                      AppealPoint                             { get; set; }
        public int                                      MaxAppealPoint                          { get; set; }
        public bool                                     IsNotMaxAppeal                          { get; set; }
        public int                                      TotalGetAppealPointCount                { get; set; }
        public int                                      InitialMaxAppealPoint                   { get; set; }

        public static IngameAppealModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IngameAppealModel();

            value.AppealPoint                               = GetInt32(new IntPtr(p + 0x010)); // 0270D5B35CA8 0x10 AppealPoint                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MaxAppealPoint                            = GetInt32(new IntPtr(p + 0x014)); // 0270D5B35CC8 0x14 MaxAppealPoint              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IsNotMaxAppeal                            = GetBool(new IntPtr(p + 0x018)); // 0270D5B35CE8 0x18 IsNotMaxAppeal              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.TotalGetAppealPointCount                  = GetInt32(new IntPtr(p + 0x01C)); // 0270D5B35D08 0x1C TotalGetAppealPointCount    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.InitialMaxAppealPoint                     = GetInt32(new IntPtr(p + 0x030)); // 0270D5B35D68 0x30 InitialMaxAppealPoint       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
