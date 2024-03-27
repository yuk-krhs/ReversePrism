using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<LiveTechnicalScoreInfoStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 TechnicalScoreFieldNumber                int IL2CPP_TYPE_I4
    // 018 TechnicalScore                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 HighScoreFieldNumber                     int IL2CPP_TYPE_I4
    // 01C HighScore                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 IsNewRecordFieldNumber                   int IL2CPP_TYPE_I4
    // 020 IsNewRecord                              000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class LiveTechnicalScoreInfoStatus
    {
        public int                                      TechnicalScore                          { get; set; }
        public int                                      HighScore                               { get; set; }
        public bool                                     IsNewRecord                             { get; set; }

        public static LiveTechnicalScoreInfoStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveTechnicalScoreInfoStatus();

            value.TechnicalScore                            = GetInt32(new IntPtr(p + 0x018)); // 0270D135D818 0x18 TechnicalScore              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.HighScore                                 = GetInt32(new IntPtr(p + 0x01C)); // 0270D135D858 0x1C HighScore                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IsNewRecord                               = GetBool(new IntPtr(p + 0x020)); // 0270D135D898 0x20 IsNewRecord                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
